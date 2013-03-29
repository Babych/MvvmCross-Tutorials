﻿using Cirrious.CrossCore.UI;
using FractalGen.Core.Services.PlatformSpecific;

namespace FractalGen.UI.Store.UIServices
{
    public class ColorToIntService : IMvxColorToIntService
    {
        public int Convert(MvxColor color)
        {
            return color.R << 16 | color.G << 8 | color.B | color.A << 24;
        }
    }
}