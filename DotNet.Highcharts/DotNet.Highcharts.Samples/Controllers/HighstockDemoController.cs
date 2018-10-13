using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Mvc;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using DotNet.Highcharts.Options.Exporting;
using DotNet.Highcharts.Options.PlotOptions;
using DotNet.Highcharts.Options.Series;
using DotNet.Highcharts.Options.YAxis;
using DotNet.Highcharts.Samples.Models;
using Point = DotNet.Highcharts.Options.Point;

namespace DotNet.Highcharts.Samples.Controllers
{
    public class HighstockDemoController : Controller
    {
        public ActionResult HighstockBasicLine()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Line,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "AAPL Stock Price",
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 2,
                })
                .SetSeries(new[]
                {
                    new Series { Name = "AAPL" },
                });

            return View(chart);
        }

        public ActionResult HighstockDynamicUpdate()
        {
            List<object> points = new List<object>(1000);
            DateTime now = DateTime.Now;
            Random rand = new Random();
            for (int i = -999; i <= 0; i++)
                points.Add(new { X = now.AddSeconds(i), Y = rand.NextDouble() });

            Highstock chart = new Highstock("chart")
                .SetOptions(new GlobalOptions { Global = new Global { UseUTC = false } })
                .InitChart(new Chart
                {
                    Events = new ChartEvents
                    {
                        Load = "ChartEventsLoad"
                    }
                })
                .AddJavascripFunction("ChartEventsLoad",
                                      @"// set up the updating of the chart each second
                                       var series = this.series[0];
                                       setInterval(function() {
                                          var x = (new Date()).getTime(), // current time
                                             y = Math.round(Math.random()*100);
                                          series.addPoint([x, y], true, true);
                                       }, 1000);")
                /*.SetRangeSelector(new RangeSelector
                {
                    // buttons?
                    InputEnabled = false,
                    Selected = 0,
                })*/
                .SetTitle(new Title { Text = "Live random data" })
                .SetExporting(new Exporting { Enabled = false })
                .SetSeries(new Series
                {
                    Name = "Random data",
                    Data = new Data(points.ToArray())
                });

            return View(chart);
        }

        public ActionResult HighstockLineMarkers()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Line,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "AAPL Stock Price",
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 2,
                })
                .SetPlotOptions(new PlotOptions
                {
                    Series = new PlotOptionsSeries
                    {
                        Marker = new PlotOptionsSeriesMarker
                        {
                            Enabled = true,
                            Radius = 3
                        },
                        Shadow = true
                    }
                })
                .SetSeries(new[]
                {
                    new Series { Name = "AAPL" }
                });

            return View(chart);
        }

        public ActionResult HighstockSpline()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "AAPL Stock Price",
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 2,
                })
                .SetSeries(new[]
                {
                    new Series 
                    {
                        Name = "AAPL",
                        Type = ChartTypes.Spline
                    },
                });

            return View(chart);
        }

        public ActionResult HighstockStepLine()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Line,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "AAPL Stock Price",
                })
                .SetPlotOptions(new PlotOptions
                {
                    Line = new PlotOptionsLine { Step = "true" }
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 2,
                })
                .SetSeries(new[]
                {
                    new Series { Name = "AAPL" },
                });

            return View(chart);
        }

        public ActionResult HighstockArea()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "AAPL Stock Price",
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 2,
                })
                .SetPlotOptions(new PlotOptions
                {
                    Area = new PlotOptionsArea
                    {
                        FillColor = new Gradient
                        {
                            LinearGradient = new[] { 0, 0, 0, 200 },
                            Stops = new object[,] { { 0, Color.LightBlue }, { 1, Color.Transparent } }
                        }
                    }
                })
                .SetSeries(new[]
                {
                    new Series 
                    {
                        Name = "AAPL",
                        Type = ChartTypes.Area,
                    },
                });

            return View(chart);
        }

        public ActionResult HighstockAreaSpline()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "AAPL Stock Price",
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 2,
                })
                .SetPlotOptions(new PlotOptions
                {
                    Area = new PlotOptionsArea//missing spline
                    {
                        FillColor = new Gradient
                        {
                            LinearGradient = new[] { 0, 0, 0, 200 },
                            Stops = new object[,] { { 0, Color.LightBlue }, { 1, Color.Transparent } }
                        }
                    }
                })
                .SetSeries(new[]
                {
                    new Series 
                    {
                        Name = "AAPL",
                        Type = ChartTypes.Areaspline
                    },
                });

            return View(chart);
        }

        public ActionResult HighstockAreaRange()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Arearange,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 2,
                })*/
                .SetTitle(new Title
                {
                    Text = "Temperature variation by day",
                })
                .SetTooltip(new Tooltip
                {
                    ValueSuffix = "°C"
                })
                .SetSeries(new[]
                {
                    new Series { Name = "Temperatures" },
                });

            return View(chart);
        }

        public ActionResult HighstockAreaSplineRange()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Areasplinerange,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 2,
                })*/
                .SetTitle(new Title
                {
                    Text = "Temperature variation by day",
                })
                .SetTooltip(new Tooltip
                {
                    ValueSuffix = "°C"
                })
                .SetSeries(new[]
                {
                    new Series { Name = "Temperatures" },
                });

            return View(chart);
        }

        public ActionResult HighstockCandlestick()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Candlestick,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "AAPL Stock Price",
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 2,
                })
                .SetPlotOptions(new PlotOptions
                {
                    Series = new PlotOptionsSeries
                    {
                        DataGrouping = new DataGrouping
                        {
                            Units = new object[] 
                            { 
                                new object[]{"week", new[] {1}},
                                new object[]{"month", new[] {1,2,3,4,5,6}}
                            }
                        }
                    }
                })
                .SetSeries(new[]
                {
                    new Series { Name = "AAPL Stock Price" },
                    // Lacks datagrouping
                });

            return View(chart);
        }

        public ActionResult HighstockOHLC()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Ohlc,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 2,
                })*/
                .SetTitle(new Title
                {
                    Text = "AAPL Stock Price",
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 2,
                })
                .SetPlotOptions(new PlotOptions
                {
                    Series = new PlotOptionsSeries
                    {
                        DataGrouping = new DataGrouping
                        {
                            Units = new object[] 
                            { 
                                new object[]{"week", new[] {1}},
                                new object[]{"month", new[] {1,2,3,4,5,6}}
                            }
                        }
                    }
                })
                .SetSeries(new[]
                {
                    new Series { Name = "AAPL Stock Price" },
                    // Lacks datagrouping
                });

            return View(chart);
        }

        public ActionResult HighstockColumn()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Column,
                    AlignTicks = false,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "AAPL Stock Volume",
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 2,
                })
                .SetPlotOptions(new PlotOptions
                {
                    Series = new PlotOptionsSeries
                    {
                        DataGrouping = new DataGrouping
                        {
                            Units = new object[] 
                            { 
                                new object[]{"week", new[] {1}},
                                new object[]{"month", new[] {1,2,3,4,5,6}}
                            }
                        }
                    }
                })
                .SetSeries(new[]
                {
                    new Series { Name = "AAPL Stock Volume" },
                    // Lacks datagrouping
                });

            return View(chart);
        }

        public ActionResult HighstockColumnRange()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Columnrange,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 2,
                })*/
                .SetTitle(new Title
                {
                    Text = "Temperature variation by day",
                })
                .SetTooltip(new Tooltip
                {
                    ValueSuffix = "°C"
                })
                .SetSeries(new[]
                {
                    new Series { Name = "Temperatures" },
                });

            return View(chart);
        }

        public ActionResult HighstockMarkersOnly()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Line,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "AAPL Stock Price",
                })
                .SetPlotOptions(new PlotOptions
                {
                    Line = new PlotOptionsLine
                    {
                        Step = "true",
                        LineWidth = 0,
                        Marker = new PlotOptionsLineMarker { Enabled = true, Radius = 2 }
                    }
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 2,
                })
                .SetSeries(new[]
                {
                    new Series { Name = "AAPL" },
                });

            return View(chart);
        }

        public ActionResult HighstockScrollbarDisabled()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Line,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "AAPL Stock Price",
                })
                .SetScrollbar(new Scrollbar
                {
                    Enabled = false,
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 2,
                })
                .SetSeries(new[]
                {
                    new Series { Name = "AAPL" },
                });

            return View(chart);
        }

        public ActionResult HighstockNavigatorDisabled()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Line,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "AAPL Stock Price",
                })
                .SetNavigator(new Navigator
                {
                    Enabled = false,
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 2,
                })
                .SetSeries(new[]
                {
                    new Series { Name = "AAPL" },
                });

            return View(chart);
        }

        public ActionResult HighstockStyledScrollbar()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Line,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "AAPL Stock Price",
                })
                .SetScrollbar(new Scrollbar
                {
                    BarBackgroundColor = Color.Gray,
                    BarBorderRadius = 7,
                    BarBorderWidth = 0,
                    ButtonBackgroundColor = Color.Gray,
                    ButtonBorderWidth = 0,
                    ButtonBorderRadius = 7,
                    TrackBackgroundColor = Color.Transparent,
                    TrackBorderWidth = 1,
                    TrackBorderRadius = 8,
                    TrackBorderColor = Color.Gray,
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 2,
                })
                .SetSeries(new[]
                {
                    new Series { Name = "AAPL" },
                });

            return View(chart);
        }

        public ActionResult HighstockYAxisPlotLines()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Line,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "USD to EUR exchange rate",
                })
                .SetYAxis(new YAxis
                {
                    Title = new YAxisTitle { Text = "Exchange rate" },
                    PlotLines = new []
                    {
                        new YAxisPlotLines
                        {
                            Value = 0.6738,
                            Color = Color.Green,
                            DashStyle = DashStyles.ShortDash,
                            Width = 2,
                            Label = new YAxisPlotLinesLabel { Text = "Last quarter minimum" }
                        },
                        new YAxisPlotLines
                        {
                            Value=0.7419,
                            Color = Color.Red,
                            DashStyle = DashStyles.ShortDash,
                            Width = 2,
                            Label = new YAxisPlotLinesLabel { Text = "Last quarter maximum" }
                        }
                    }
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 4,
                })
                .SetSeries(new[]
                {
                    new Series { Name = "USD to EUR" },
                });

            return View(chart);
        }

        public ActionResult HighstockYAxisPlotBands()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Line,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "USD to EUR exchange rate",
                })
                .SetYAxis(new YAxis
                {
                    Title = new YAxisTitle { Text = "Exchange rate" },
                    PlotBands = new[] { new YAxisPlotBands
                    {
                        From = 0.6738,
                        To = 0.7419,
                        Color = Color.FromArgb(51,68,170,213),
                        Label = new YAxisPlotBandsLabel { Text = "Last quarter's value range" }
                    }}
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 4,
                })
                .SetSeries(new[]
                {
                    new Series { Name = "USD to EUR" },
                });

            return View(chart);
        }

        public ActionResult HighstockYAxisReversed()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Area,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetYAxis(new YAxis
                {
                    Reversed = true,
                    ShowFirstLabel = false,
                    ShowLastLabel = true
                })
                .SetTitle(new Title
                {
                    Text = "AAPL Stock Price",
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 2,
                })
                .SetPlotOptions(new PlotOptions
                {
                    Area = new PlotOptionsArea
                    {
                        FillColor = new Gradient 
                        {
                            LinearGradient = new[] { 0, 300, 0, 0 },
                            Stops = new object[,] { { 0, Color.Blue }, { 1, Color.White } }
                        }
                    }
                })
                .SetSeries(new[]
                {
                    new Series { Name = "AAPL Stock Price" },
                });

            return View(chart);
        }

        public ActionResult HighstockCandlestickVolume()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    ClassName = "chart",
                    AlignTicks = false
                })
                .SetTitle(new Title
                {
                    Text = "AAPL Historical",
                })
                .SetYAxis(new []{ new YAxis
                {
                    Title = new YAxisTitle { Text = "OHLC" },
                    LineWidth = 2,
                    Height = 200,
                }, new YAxis
                {
                    Title = new YAxisTitle { Text = "Volume" },
                    Offset = 0,
                    LineWidth = 2,
                    Height = 100,
                    Top = 300,
                }})
                .SetPlotOptions(new PlotOptions
                {
                    Series = new PlotOptionsSeries
                    {
                        DataGrouping = new DataGrouping
                        {
                            Units = new object[] 
                            { 
                                new object[]{"week", new[] {1}},
                                new object[]{"month", new[] {1,2,3,4,5,6}}
                            }
                        }
                    }
                })
                .SetSeries(new[]
                {
                    new Series 
                    { 
                        Name = "AAPL",
                        Type = ChartTypes.Candlestick,
                    },
                    new Series
                    {
                        Name="Volume",
                        Type = ChartTypes.Column,
                        YAxis = "1"
                    }
                });

            return View(chart);
        }

        public ActionResult HighstockCompare()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    ClassName = "chart",
                })
                .SetYAxis(new YAxis
                {
                        //labels, plotlines?
                })
                //plot options => series => compare?
                .SetTooltip(new Tooltip
                {
                    PointFormat = "<span style=\"color:{series.color}\">{series.name}</span>: <b>{point.y}</b> ({point.change}%)<br/>",
                    ValueDecimals = 2,
                })
                .SetSeries(new[]
                {
                    new Series 
                    { 
                        Name = "MSFT",
                    },
                    new Series
                    {
                        Name="AAPL",
                    },
                    new Series
                    {
                        Name="GOOG",
                    }
                });

            return View(chart);
        }

        public ActionResult HighstockFlagsPlacement()
        {
            Highstock chart = new Highstock("chart")
                .InitChart(new Chart
                {
                    DefaultSeriesType = ChartTypes.Line,
                    ClassName = "chart"
                })
                // range selector seems to have problems in highstock.
                /*.SetRangeSelector(new RangeSelector
                {
                    Selected = 1,
                })*/
                .SetTitle(new Title
                {
                    Text = "USD to EUR exchange rate",
                })
                .SetYAxis(new YAxis
                {
                    Title = new YAxisTitle { Text = "Exchange rate" },
                })
                .SetTooltip(new Tooltip
                {
                    ValueDecimals = 4,
                })
                .SetSeries(new[]
                {
                    new Series { Name = "USD to EUR", PlotOptionsFlags = new PlotOptionsFlags { Id = "dataseries"} },
                    new Series
                    { 
                        Type = ChartTypes.Flags, 
                        Name = "Flags on series",
                        PlotOptionsFlags = new PlotOptionsFlags { OnSeries = "dataseries"},
                        Data = new Data(new Flag[] 
                                        { 
                                            new Flag
                                            {
                                                X = new DateTime(2011,1,14).Ticks,
                                                Title = "On series",
                                            },
                                            new Flag
                                            {
                                                X =  new DateTime(2011,3,28).Ticks,
                                                Title = "On series",
                                            }
                                        }),
                    },
                    new Series
                    { 
                        Type = ChartTypes.Flags, 
                        Name = "Flags on axis",
                        PlotOptionsFlags = new PlotOptionsFlags { OnSeries = "dataseries"},
                        Data = new Data(new Flag[] 
                                        { 
                                            new Flag
                                            {
                                                X = new DateTime(2011,2,1).Ticks,
                                                Title = "On axis",
                                            },
                                            new Flag
                                            {
                                                X =  new DateTime(2011,3,1).Ticks,
                                                Title = "On axis",
                                            }
                                        }),
                    }});

            return View(chart);
        }
    }
}
