﻿using System;
using System.Globalization;
using System.Windows.Data;
using Sheas_Cealer.Consts;

namespace Sheas_Cealer.Convs;

internal class MainUpdateHostButtonIsEnabledConv : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        string? upstreamUrl = value as string;

        return MainConst.UpstreamUrlRegex().IsMatch(upstreamUrl!);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
}