# MauiApp

Example to test https://github.com/beto-rodriguez/LiveCharts2/issues/800.

This is a working application for maui that uses:

- [LiveCharts beta.810](https://www.nuget.org/packages/LiveChartsCore/2.0.0-beta.810)
- Net 7.0, to ensure your dotnet/maui versions are updated, please ensure that your csproj file looks something [like this](https://github.com/beto-rodriguez/MauiApp-LiveCharts/blob/master/MauiApp4.csproj), if you update VisualStudio 2022 to the latest version this might be fixed for you when you create a new Maui project that targets dotnet 7
- VisualStudio 2022 17.6.5
- Even if you use Windows (Remote devices), a Mac with at least MacOs Ventura 13.4 is necessary to compile the iOs/MacCatalyst versions.
