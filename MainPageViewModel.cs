using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
using LinearGradientPaint = LiveChartsCore.SkiaSharpView.Painting.LinearGradientPaint;

namespace MauiApp4;

public class MainPageViewModel
{
    public ISeries[] Series { get; set; } = new ISeries[]
    {
        new ColumnSeries<int>
        {
            Values = new []{ 3, 7, 2, 9, 4 },
            Stroke = null,
            Fill = new LinearGradientPaint(
                new [] { new SKColor(255, 140, 148), new SKColor(220, 237, 194) },
                new SKPoint(0.5f, 0),
                new SKPoint(0.5f, 1))
        },
        new LineSeries<int>
        {
            Values = new []{ 4, 2, 8, 5, 3 },
            GeometrySize = 22,
            Stroke = new LinearGradientPaint(new[]{ new SKColor(45, 64, 89), new SKColor(255, 212, 96)}) { StrokeThickness = 10 },
            GeometryStroke = new LinearGradientPaint(new[]{ new SKColor(45, 64, 89), new SKColor(255, 212, 96)}) { StrokeThickness = 10 },
            Fill = null
        }
    };
}
