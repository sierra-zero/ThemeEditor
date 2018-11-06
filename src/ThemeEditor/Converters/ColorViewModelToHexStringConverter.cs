﻿using System;
using System.Globalization;
using Avalonia;
using Avalonia.Data.Converters;
using ThemeEditor.ViewModels;

namespace ThemeEditor.Converters
{
    public class ColorViewModelToHexStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ArgbColorViewModel color && targetType == typeof(string))
            {
                return color.ToHexString();
            }
            return AvaloniaProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string s && targetType == typeof(ArgbColorViewModel))
            {
                return s.ArgbFromHexString();
            }
            return AvaloniaProperty.UnsetValue;
        }
    }
}
