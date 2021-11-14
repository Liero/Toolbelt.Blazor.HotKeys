﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Toolbelt.Blazor.HotKeys;

namespace SampleSite.Components.Pages
{
    public partial class SaveText : IDisposable
    {
        [Inject] public HotKeys HotKeys { get; set; }

        [Inject] public IJSRuntime JS { get; set; }

        private HotKeysContext HotKeysContext;

        private ElementReference InputElement;

        private string InpuText = "";

        private readonly List<string> SavedTexts = new List<string>();

        protected override void OnInitialized()
        {
            this.HotKeysContext = this.HotKeys.CreateContext()
                .Add(ModKeys.Ctrl, Keys.S, () => this.OnSaveText(), exclude: Exclude.TextArea);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
#if ENABLE_FOCUS
                await this.InputElement.FocusAsync();
#endif
            }
        }

        private async Task OnSaveText()
        {
            await this.JS.InvokeVoidAsync("Toolbelt.Blazor.fireOnChange", this.InputElement);

            this.SavedTexts.Add(this.InpuText);
            this.StateHasChanged();
        }

        public void Dispose()
        {
            this.HotKeysContext?.Dispose();
        }
    }
}
