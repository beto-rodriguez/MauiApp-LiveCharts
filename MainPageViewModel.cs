﻿using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;

namespace MauiApp4;

public class MainPageViewModel
{
    public ISeries[] Series { get; set; }
        = new ISeries[]
        {
                new LineSeries<double>
                {
                    Values = new double[] { 2, 1, 3, 5, 3, 4, 6 },
                    Fill = null
                }
        };
}
