﻿using System;
using System.ComponentModel;

namespace Toolbelt.Blazor.HotKeys
{
    /// <summary>
    /// The identifier of the key code.
    /// </summary>
    public enum Keys
    {
        Backspace = 0x08,
        Tab = 0x09,
        Shift = 0x10,
        Ctrl = 0x11,
        Alt = 0x12,
        Pause = 0x13,
        CapsLock = 0x14,
        Enter = 0x0d,
        ESC = 0x1b,
        Space = 0x20,
        PgUp = 0x21,
        PgDown = 0x22,
        End = 0x23,
        Home = 0x24,
        Left = 0x25,
        Up = 0x26,
        Right = 0x27,
        Down = 0x28,
        Insert = 0x2D,
        Delete = 0x2E,
        Num0 = 0x30,
        Num1 = 0x31,
        Num2 = 0x32,
        Num3 = 0x33,
        Num4 = 0x34,
        Num5 = 0x35,
        Num6 = 0x36,
        Num7 = 0x37,
        Num8 = 0x38,
        Num9 = 0x39,
        SemiColon = 0x3B,
        Equal = 0x3D,
        A = 0x41,
        B = 0x42,
        C = 0x43,
        D = 0x44,
        E = 0x45,
        F = 0x46,
        G = 0x47,
        H = 0x48,
        I = 0x49,
        J = 0x4A,
        K = 0x4B,
        L = 0x4C,
        M = 0x4D,
        N = 0x4E,
        O = 0x4F,
        P = 0x50,
        Q = 0x51,
        R = 0x52,
        S = 0x53,
        T = 0x54,
        U = 0x55,
        V = 0x56,
        W = 0x57,
        X = 0x58,
        Y = 0x59,
        Z = 0x5A,

        ContextMenu = 0x5D,

        Multiply = 0x6A,
        Add = 0x6B,
        Subtract = 0x6D,
        Divide = 0x6F,

        F1 = 0x70,
        F2 = 0x71,
        F3 = 0x72,
        F4 = 0x73,
        F5 = 0x74,
        F6 = 0x75,
        F7 = 0x76,
        F8 = 0x77,
        F9 = 0x78,
        F10 = 0x79,
        F11 = 0x7A,
        F12 = 0x7B,

        NumLock = 0x90,
        ScrollLock = 0x91,

        Hyphen = 0xBD,
        Comma = 0xBC,
        Period = 0xBE,
        Slash = 0xBF,

        [EditorBrowsable(EditorBrowsableState.Never), Obsolete("use BackQuote instead.")]
        BackQuart = 0xC0,

        BackQuote = 0xC0,

        BlaceLeft = 0xDB,
        BackSlash = 0xDC,
        BlaceRight = 0xDD,

        [EditorBrowsable(EditorBrowsableState.Never), Obsolete("use SingleQuote instead.")]
        SingleQuart = 0xDE,

        SingleQuote = 0xDE,

        AudioVolumeMute = 0xAD,
        AudioVolumeDown = 0xAE,
        AudioVolumeUp = 0xAF,
        MediaTrackNext = 0xB0,
        MediaTrackPrevious = 0xB1,
        MediaPlayPause = 0xB3,
        LaunchMediaPlayer = 0xB5,
    }
}
