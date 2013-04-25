using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Mvc;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using DotNet.Highcharts.Samples.Models;
using Point = DotNet.Highcharts.Options.Point;

namespace DotNet.Highcharts.Samples.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult BasicLine()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart
                           {
                               DefaultSeriesType = ChartTypes.Line,
                               MarginRight = 130,
                               MarginBottom = 25,
                               ClassName = "chart"
                           })
                .SetTitle(new Title
                          {
                              Text = "Monthly Average Temperature",
                              X = -20
                          })
                .SetSubtitle(new Subtitle
                             {
                                 Text = "Source: WorldClimate.com",
                                 X = -20
                             })
                .SetXAxis(new XAxis { Categories = ChartsData.Categories })
                .SetYAxis(new YAxis
                          {
                              Title = new XAxisTitle { Text = "Temperature (°C)" },
                              PlotLines = new[]
                                          {
                                              new XAxisPlotLines
                                              {
                                                  Value = 0,
                                                  Width = 1,
                                                  Color = ColorTranslator.FromHtml("#808080")
                                              }
                                          }
                          })
                .SetTooltip(new Tooltip
                            {
                                Formatter = @"function() {
                                        return '<b>'+ this.series.name +'</b><br/>'+
                                    this.x +': '+ this.y +'°C';
                                }"
                            })
                .SetLegend(new Legend
                           {
                               Layout = Layouts.Vertical,
                               Align = HorizontalAligns.Right,
                               VerticalAlign = VerticalAligns.Top,
                               X = -10,
                               Y = 100,
                               BorderWidth = 0
                           })
                .SetSeries(new[]
                           {
                               new Series { Name = "Tokyo", Data = new Data(ChartsData.TokioData) },
                               new Series { Name = "New York", Data = new Data(ChartsData.NewYorkData) },
                               new Series { Name = "Berlin", Data = new Data(ChartsData.BerlinData) },
                               new Series { Name = "London", Data = new Data(ChartsData.LondonData) }
                           }
                );

            return View(chart);
        }

        public ActionResult AjaxLoad()
        {
            Highcharts chart = new Highcharts("chart")
                .SetTitle(new Title { Text = "Daily visits at www.highcharts.com" })
                .SetSubtitle(new Subtitle { Text = "Source: Google Analytics" })
                .SetXAxis(new XAxis
                          {
                              Type = AxisTypes.Datetime,
                              TickInterval = 7 * 24 * 3600 * 1000, // one week
                              TickWidth = 0,
                              GridLineWidth = 1,
                              Labels = new XAxisLabels
                                       {
                                           Align = HorizontalAligns.Left,
                                           X = 3,
                                           Y = -3
                                       }
                          })
                .SetYAxis(new[]
                          {
                              new YAxis
                              {
                                  Title = new YAxisTitle { Text = "" },
                                  Labels = new YAxisLabels
                                           {
                                               Align = HorizontalAligns.Left,
                                               X = 3,
                                               Y = 16,
                                               Formatter = "function() { return Highcharts.numberFormat(this.value, 0); }",
                                           },
                                  ShowFirstLabel = false
                              },
                              new YAxis
                              {
                                  LinkedTo = 0,
                                  GridLineWidth = 0,
                                  Opposite = true,
                                  Title = new YAxisTitle { Text = "" },
                                  Labels = new YAxisLabels
                                           {
                                               Align = HorizontalAligns.Right,
                                               X = -3,
                                               Y = 16,
                                               Formatter = "function() { return Highcharts.numberFormat(this.value, 0); }"
                                           },
                                  ShowFirstLabel = false
                              }
                          })
                .SetLegend(new Legend
                           {
                               Align = HorizontalAligns.Left,
                               VerticalAlign = VerticalAligns.Top,
                               Y = 20,
                               Floating = true,
                               BorderWidth = 0
                           })
                .SetTooltip(new Tooltip
                            {
                                Shared = true,
                                Crosshairs = new Crosshairs(true)
                            })
                .SetPlotOptions(new PlotOptions
                                {
                                    Series = new PlotOptionsSeries
                                             {
                                                 Cursor = Cursors.Pointer,
                                                 Point = new PlotOptionsSeriesPoint
                                                         {
                                                             Events = new PlotOptionsSeriesPointEvents
                                                                      {
                                                                          Click = @"function() {
                                                                                        alert(Highcharts.dateFormat('%A, %b %e, %Y', this.x) +': '+ this.y +' visits');
                                                                                    }"
                                                                      }
                                                         },
                                                 Marker = new PlotOptionsSeriesMarker { LineWidth = 1 }
                                             }
                                })
                .SetSeries(new[]
                           {
                               new Series { Name = "All visits" },
                               new Series { Name = "New visitors" }
                           });

            return View(chart);
        }

        public ActionResult DataLabels()
        {
            string[] categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            object[] tokioData = new object[] { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };
            object[] londonData = new object[] { 3.9, 4.2, 5.7, 8.5, 11.9, 15.2, 17.0, 16.6, 14.2, 10.3, 6.6, 4.8 };

            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Line })
                .SetTitle(new Title { Text = "Monthly Average Temperature" })
                .SetSubtitle(new Subtitle { Text = "Source: WorldClimate.com" })
                .SetXAxis(new XAxis { Categories = categories })
                .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Temperature (°C)" } })
                .SetTooltip(new Tooltip { Enabled = true, Formatter = @"function() { return '<b>'+ this.series.name +'</b><br/>'+ this.x +': '+ this.y +'°C'; }" })
                .SetPlotOptions(new PlotOptions
                                {
                                    Line = new PlotOptionsLine
                                           {
                                               DataLabels = new PlotOptionsLineDataLabels
                                                            {
                                                                Enabled = true
                                                            },
                                               EnableMouseTracking = false
                                           }
                                })
                .SetSeries(new[]
                           {
                               new Series { Name = "Tokyo", Data = new Data(tokioData) },
                               new Series { Name = "London", Data = new Data(londonData) }
                           });

            return View(chart);
        }

        public ActionResult TimeSeriesZoomable()
        {
            Highcharts chart = new Highcharts("chart")
                .SetOptions(new GlobalOptions { Global = new Global { UseUTC = false } })
                .InitChart(new Chart { ZoomType = ZoomTypes.X, SpacingRight = 20 })
                .SetTitle(new Title { Text = "USD to EUR exchange rate from 2006 through 2008" })
                .SetSubtitle(new Subtitle { Text = "Click and drag in the plot area to zoom in" })
                .SetXAxis(new XAxis
                          {
                              Type = AxisTypes.Datetime,
                              MinRange = 14 * 24 * 3600000,
                              Title = new XAxisTitle { Text = "" }
                          })
                .SetYAxis(new YAxis
                          {
                              Title = new YAxisTitle { Text = "Exchange rate" },
                              Min = 0.6,
                              StartOnTick = false,
                              EndOnTick = false
                          })
                .SetTooltip(new Tooltip { Shared = true })
                .SetLegend(new Legend { Enabled = false })
                .SetPlotOptions(new PlotOptions
                                {
                                    Area = new PlotOptionsArea
                                           {
                                               FillColor = new BackColorOrGradient(new Gradient
                                                                                   {
                                                                                       LinearGradient = new[] { 0, 0, 0, 300 },
                                                                                       Stops = new object[,] { { 0, "rgb(116, 116, 116)" }, { 1, Color.Gold } }
                                                                                   }),
                                               LineWidth = 1,
                                               Marker = new PlotOptionsAreaMarker
                                                        {
                                                            Enabled = false,
                                                            States = new PlotOptionsAreaMarkerStates
                                                                     {
                                                                         Hover = new PlotOptionsAreaMarkerStatesHover
                                                                                 {
                                                                                     Enabled = true,
                                                                                     Radius = 5
                                                                                 }
                                                                     }
                                                        },
                                               Shadow = false,
                                               States = new PlotOptionsAreaStates { Hover = new PlotOptionsAreaStatesHover { LineWidth = 1 } },
                                               PointInterval = 24 * 3600 * 1000,
                                               PointStart = new PointStart(new DateTime(2006, 1, 1))
                                           }
                                })
                .SetSeries(new Series
                           {
                               Type = ChartTypes.Area,
                               Name = "USD to EUR",
                               Data = new Data(ChartsData.StockData)
                           });
            return View(chart);
        }

        public ActionResult SplineInvertedAxes()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart
                           {
                               DefaultSeriesType = ChartTypes.Spline,
                               Inverted = true,
                               Width = 500,
                               Style = "margin: '0 auto'"
                           })
                .SetTitle(new Title { Text = "Atmosphere Temperature by Altitude" })
                .SetSubtitle(new Subtitle { Text = "According to the Standard Atmosphere Model" })
                .SetXAxis(new XAxis
                          {
                              Reversed = false,
                              Title = new XAxisTitle { Text = "Altitude" },
                              Labels = new XAxisLabels { Formatter = "function() { return this.value +'km'; }" },
                              MaxPadding = 0.05,
                              ShowLastLabel = true
                          })
                .SetYAxis(new YAxis
                          {
                              Title = new YAxisTitle { Text = "Temperature" },
                              Labels = new XAxisLabels { Formatter = "function() { return this.value + '°C'; }" },
                              LineWidth = 2
                          })
                .SetLegend(new Legend { Enabled = false })
                .SetTooltip(new Tooltip { Formatter = "function() { return ''+ this.x +' km: '+ this.y +'°C'; }" })
                .SetPlotOptions(new PlotOptions { Spline = new PlotOptionsSpline { Marker = new PlotOptionsSeriesMarker { Enabled = true } } })
                .SetSeries(new Series
                           {
                               Name = "Temperature",
                               Data = new Data(new object[,]
                                               {
                                                   { 0, 15 }, { 10, -50 }, { 20, -56.5 }, { 30, -46.5 }, { 40, -22.1 },
                                                   { 50, -2.5 }, { 60, -27.7 }, { 70, -55.7 }, { 80, -76.5 }
                                               })
                           });

            return View(chart);
        }

        public ActionResult SplineWithSymbols()
        {
            Highcharts charts = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Spline })
                .SetTitle(new Title { Text = "Monthly Average Temperature" })
                .SetSubtitle(new Subtitle { Text = "Source: WorldClimate.com" })
                .SetXAxis(new XAxis { Categories = ChartsData.Categories })
                .SetYAxis(new YAxis
                          {
                              Title = new YAxisTitle { Text = "Temperature" },
                              Labels = new YAxisLabels { Formatter = "function() { return this.value +'C°' }" }
                          })
                .SetTooltip(new Tooltip
                            {
                                Crosshairs = new Crosshairs(true),
                                Shared = true
                            })
                .SetPlotOptions(new PlotOptions
                                {
                                    Spline = new PlotOptionsSpline
                                             {
                                                 Marker = new PlotOptionsSeriesMarker
                                                          {
                                                              Radius = 4,
                                                              LineColor = ColorTranslator.FromHtml("#666666"),
                                                              LineWidth = 1
                                                          }
                                             }
                                })
                .SetSeries(new[] { ChartsData.TokyoSeries, ChartsData.LondonSeries });
            return View(charts);
        }

        public ActionResult SplineWithPlotBands()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Spline })
                .SetTitle(new Title { Text = "Wind speed during two days" })
                .SetSubtitle(new Subtitle { Text = "October 6th and 7th 2009 at two locations in Vik i Sogn, Norway" })
                .SetXAxis(new XAxis { Type = AxisTypes.Datetime })
                .SetYAxis(new YAxis
                          {
                              Title = new XAxisTitle { Text = "Wind speed (m/s)" },
                              Min = 0,
                              MinorGridLineWidth = 0,
                              GridLineWidth = 0,
                              PlotBands = new[]
                                          {
                                              new YAxisPlotBands
                                              {
                                                  From = 0.3,
                                                  To = 3.3,
                                                  Color = ColorTranslator.FromHtml("#ECF7FB"),
                                                  Label = new XAxisPlotBandsLabel
                                                          {
                                                              Text = "Gentle breeze",
                                                              Style = "color:'#606060'"
                                                          }
                                              },
                                              new YAxisPlotBands
                                              {
                                                  From = 3.3,
                                                  To = 5.5,
                                                  Color = Color.White,
                                                  Label = new XAxisPlotBandsLabel
                                                          {
                                                              Text = "Light breeze",
                                                              Style = "color:'#606060'"
                                                          }
                                              },
                                              new YAxisPlotBands
                                              {
                                                  From = 5.5,
                                                  To = 8,
                                                  Color = ColorTranslator.FromHtml("#ECF7FB"),
                                                  Label = new XAxisPlotBandsLabel
                                                          {
                                                              Text = "Moderate breeze",
                                                              Style = "color:'#606060'"
                                                          }
                                              },
                                              new YAxisPlotBands
                                              {
                                                  From = 8,
                                                  To = 11,
                                                  Color = Color.White,
                                                  Label = new XAxisPlotBandsLabel
                                                          {
                                                              Text = "Fresh breeze",
                                                              Style = "color:'#606060'"
                                                          }
                                              },
                                              new YAxisPlotBands
                                              {
                                                  From = 11,
                                                  To = 14,
                                                  Color = ColorTranslator.FromHtml("#ECF7FB"),
                                                  Label = new XAxisPlotBandsLabel
                                                          {
                                                              Text = "Strong breeze",
                                                              Style = "color:'#606060'"
                                                          }
                                              },
                                              new YAxisPlotBands
                                              {
                                                  From = 14,
                                                  To = 15,
                                                  Color = Color.White,
                                                  Label = new XAxisPlotBandsLabel
                                                          {
                                                              Text = "High wind",
                                                              Style = "color:'#606060'"
                                                          }
                                              }
                                          }
                          })
                .SetTooltip(new Tooltip { Formatter = "function() { return ''+ Highcharts.dateFormat('%e. %b %Y, %H:00', this.x) +': '+ this.y +' m/s'; }" })
                .SetPlotOptions(new PlotOptions
                                {
                                    Spline = new PlotOptionsSpline
                                             {
                                                 LineWidth = 4,
                                                 PointInterval = 3600000,
                                                 PointStart = new PointStart(new DateTime(2009, 9, 6, 0, 0, 0)),
                                                 States = new PlotOptionsSplineStates { Hover = new PlotOptionsSplineStatesHover { LineWidth = 5 } },
                                                 Marker = new PlotOptionsSplineMarker
                                                          {
                                                              Enabled = false,
                                                              States = new PlotOptionsSplineMarkerStates
                                                                       {
                                                                           Hover = new PlotOptionsSplineMarkerStatesHover
                                                                                   {
                                                                                       Enabled = true,
                                                                                       Radius = 5,
                                                                                       LineWidth = 1
                                                                                   }
                                                                       }
                                                          }
                                             }
                                })
                .SetSeries(new[] { ChartsData.Hestavollane, ChartsData.Voll })
                .SetNavigation(new Navigation { MenuItemStyle = "fontSize: '10px'" });

            return View(chart);
        }

        public ActionResult TimeDataWithInrregularIntervals()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Spline })
                .SetOptions(new GlobalOptions { Global = new Global { UseUTC = false } })
                .SetTitle(new Title { Text = "Snow depth in the Vikjafjellet mountain, Norway" })
                .SetSubtitle(new Subtitle { Text = "An example of irregular time data in Highcharts JS" })
                .SetXAxis(new XAxis
                          {
                              Type = AxisTypes.Datetime,
                              DateTimeLabelFormats = new DateTimeLabel { Month = "%e. %b", Year = "%b" }
                          })
                .SetYAxis(new YAxis
                          {
                              Title = new XAxisTitle { Text = "Snow depth (m)" },
                              Min = 0
                          })
                .SetTooltip(new Tooltip { Formatter = "function() { return '<b>'+ this.series.name +'</b><br/>'+ Highcharts.dateFormat('%e. %b', this.x) +': '+ this.y +' m'; }" })
                .SetSeries(new[] { ChartsData.Winter20072008, ChartsData.Winter20082009, ChartsData.Winter20092010 });

            return View(chart);
        }

        public ActionResult ScatterPlot()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Scatter, ZoomType = ZoomTypes.Xy })
                .SetTitle(new Title { Text = "Height Versus Weight of 507 Individuals by Gender" })
                .SetSubtitle(new Subtitle { Text = "Source: Heinz  2003" })
                .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Weight (kg)" } })
                .SetXAxis(new XAxis
                          {
                              Title = new XAxisTitle { Text = "Height (cm)" },
                              StartOnTick = true,
                              EndOnTick = true,
                              ShowLastLabel = true
                          })
                .SetTooltip(new Tooltip { Formatter = "function() {return ''+ this.x +' cm, '+ this.y +' kg'; }" })
                .SetLegend(new Legend
                           {
                               Layout = Layouts.Vertical,
                               Align = HorizontalAligns.Left,
                               VerticalAlign = VerticalAligns.Top,
                               X = 100,
                               Y = 50,
                               Floating = true,
                               BackgroundColor = ColorTranslator.FromHtml("#FFF"),
                               BorderWidth = 1
                           })
                .SetPlotOptions(new PlotOptions
                                {
                                    Scatter = new PlotOptionsScatter
                                              {
                                                  Marker = new PlotOptionsScatterMarker
                                                           {
                                                               Radius = 5,
                                                               States = new PlotOptionsScatterMarkerStates
                                                                        {
                                                                            Hover = new PlotOptionsScatterMarkerStatesHover
                                                                                    {
                                                                                        Enabled = true,
                                                                                        LineColor = ColorTranslator.FromHtml("#646464")
                                                                                    }
                                                                        }
                                                           },
                                                  States = new PlotOptionsScatterStates { Hover = new PlotOptionsScatterStatesHover { Enabled = false } }
                                              }
                                })
                .SetSeries(new[] { ChartsData.Female, ChartsData.Male });

            return View(chart);
        }

        public ActionResult BasicArea()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Area })
                .SetTitle(new Title { Text = "US and USSR nuclear stockpiles" })
                .SetSubtitle(new Subtitle { Text = "Source: thebulletin.metapress.com" })
                .SetXAxis(new XAxis { Labels = new XAxisLabels { Formatter = "function() { return this.value;  }" } })
                .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Nuclear weapon states" }, Labels = new YAxisLabels { Formatter = "function() { return this.value / 1000 +'k'; }" } })
                .SetPlotOptions(new PlotOptions
                                {
                                    Area = new PlotOptionsArea
                                           {
                                               PointStart = new PointStart(1940),
                                               Marker = new PlotOptionsAreaMarker
                                                        {
                                                            Enabled = false,
                                                            Symbol = "circle",
                                                            Radius = 2,
                                                            States = new PlotOptionsAreaMarkerStates
                                                                     {
                                                                         Hover = new PlotOptionsAreaMarkerStatesHover { Enabled = true }
                                                                     }
                                                        }
                                           }
                                })
                .SetSeries(new[] { ChartsData.Usa, ChartsData.Ussr });

            return View(chart);
        }

        public ActionResult AreaWithNegativeValues()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Area })
                .SetTitle(new Title { Text = "Area chart with negative values" })
                .SetXAxis(new XAxis { Categories = new[] { "Apples", "Oranges", "Pears", "Grapes", "Bananas" } })
                .SetTooltip(new Tooltip { Formatter = "TooltipFormatter" })
                .SetCredits(new Credits { Enabled = false })
                .SetSeries(new[]
                           {
                               new Series { Name = "John", Data = new Data(new object[] { 5, 3, 4, 7, 2 }) },
                               new Series { Name = "Jane", Data = new Data(new object[] { 2, -2, -3, 2, 1 }) },
                               new Series { Name = "Joe", Data = new Data(new object[] { 3, 4, 4, -2, 5 }) }
                           });

            return View(chart);
        }

        public ActionResult StackedArea()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Area })
                .SetTitle(new Title { Text = "Historic and Estimated Worldwide Population Growth by Region" })
                .SetSubtitle(new Subtitle { Text = "Source: Wikipedia.org" })
                .SetXAxis(new XAxis
                          {
                              Categories = new[] { "1750", "1800", "1850", "1900", "1950", "1999", "2050" },
                              TickmarkPlacement = Tickmarks.On,
                          })
                .SetYAxis(new YAxis
                          {
                              Title = new YAxisTitle { Text = "Billions" },
                              Labels = new YAxisLabels { Formatter = "function() { return this.value / 1000; }" }
                          })
                .SetTooltip(new Tooltip { Formatter = "function() { return ''+ this.x +': '+ Highcharts.numberFormat(this.y, 0, ',') +' millions'; }" })
                .SetPlotOptions(new PlotOptions
                                {
                                    Area = new PlotOptionsArea
                                           {
                                               Stacking = Stackings.Normal,
                                               LineColor = ColorTranslator.FromHtml("#666666"),
                                               LineWidth = 1,
                                               Marker = new PlotOptionsAreaMarker
                                                        {
                                                            LineWidth = 1,
                                                            LineColor = ColorTranslator.FromHtml("#666666")
                                                        }
                                           }
                                })
                .SetSeries(new[]
                           {
                               new Series { Name = "Asia", Data = new Data(new object[] { 502, 635, 809, 947, 1402, 3634, 5268 }) },
                               new Series { Name = "Africa", Data = new Data(new object[] { 106, 107, 111, 133, 221, 767, 1766 }) },
                               new Series { Name = "Europe", Data = new Data(new object[] { 163, 203, 276, 408, 547, 729, 628 }) },
                               new Series { Name = "America", Data = new Data(new object[] { 18, 31, 54, 156, 339, 818, 1201 }) },
                               new Series { Name = "Oceania", Data = new Data(new object[] { 2, 2, 2, 6, 13, 30, 46 }) }
                           });

            return View(chart);
        }

        public ActionResult PercentageArea()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Area })
                .SetTitle(new Title { Text = "Historic and Estimated Worldwide Population Growth by Region" })
                .SetSubtitle(new Subtitle { Text = "Source: Wikipedia.org" })
                .SetXAxis(new XAxis
                          {
                              Categories = new[] { "1750", "1800", "1850", "1900", "1950", "1999", "2050" },
                              TickmarkPlacement = Tickmarks.On,
                          })
                .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Percent" } })
                .SetTooltip(new Tooltip { Formatter = "function() { return this.x +': '+ Highcharts.numberFormat(this.percentage, 1) +'% ('+ Highcharts.numberFormat(this.y, 0, ',') +' millions)'; }" })
                .SetPlotOptions(new PlotOptions
                                {
                                    Area = new PlotOptionsArea
                                           {
                                               Stacking = Stackings.Percent,
                                               LineColor = ColorTranslator.FromHtml("#ffffff"),
                                               LineWidth = 1,
                                               Marker = new PlotOptionsAreaMarker
                                                        {
                                                            LineWidth = 1,
                                                            LineColor = ColorTranslator.FromHtml("#ffffff")
                                                        }
                                           }
                                })
                .SetSeries(new[]
                           {
                               new Series { Name = "Asia", Data = new Data(new object[] { 502, 635, 809, 947, 1402, 3634, 5268 }) },
                               new Series { Name = "Africa", Data = new Data(new object[] { 106, 107, 111, 133, 221, 767, 1766 }) },
                               new Series { Name = "Europe", Data = new Data(new object[] { 163, 203, 276, 408, 547, 729, 628 }) },
                               new Series { Name = "America", Data = new Data(new object[] { 18, 31, 54, 156, 339, 818, 1201 }) },
                               new Series { Name = "Oceania", Data = new Data(new object[] { 2, 2, 2, 6, 13, 30, 46 }) }
                           });

            return View(chart);
        }

        public ActionResult AreaWithMissingPoints()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Area, SpacingBottom = 30 })
                .SetTitle(new Title { Text = "Fruit consumption *" })
                .SetSubtitle(new Subtitle
                             {
                                 Text = @"* Jane\'s banana consumption is unknown",
                                 Floating = false,
                                 Align = HorizontalAligns.Right,
                                 VerticalAlign = VerticalAligns.Bottom,
                                 Y = 15
                             })
                .SetLegend(new Legend
                           {
                               Layout = Layouts.Vertical,
                               Align = HorizontalAligns.Left,
                               VerticalAlign = VerticalAligns.Top,
                               X = 150,
                               Y = 100,
                               Floating = true,
                               BorderWidth = 1,
                               BackgroundColor = ColorTranslator.FromHtml("#FFFFFF")
                           })
                .SetXAxis(new XAxis { Categories = new[] { "Apples", "Pears", "Oranges", "Bananas", "Grapes", "Plums", "Strawberries", "Raspberries" } })
                .SetYAxis(new YAxis
                          {
                              Title = new YAxisTitle { Text = "Y-Axis" },
                              Labels = new YAxisLabels { Formatter = "function() { return this.value; }" }
                          })
                .SetTooltip(new Tooltip { Formatter = "function() { return '<b>'+ this.series.name +'</b><br/>'+ this.x +': '+ this.y; }" })
                .SetPlotOptions(new PlotOptions { Area = new PlotOptionsArea { FillOpacity = 0 } })
                .SetCredits(new Credits { Enabled = false })
                .SetSeries(new[]
                           {
                               new Series { Name = "John", Data = new Data(new object[] { 0, 1, 4, 4, 5, 2, 3, 7 }) },
                               new Series { Name = "Jane", Data = new Data(new object[] { 1, 0, 3, null, 3, 1, 2, 1 }) }
                           });

            return View(chart);
        }

        public ActionResult InvertedAxes()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Area, Inverted = true })
                .SetTitle(new Title { Text = "Average fruit consumption during one week" })
                .SetSubtitle(new Subtitle { Style = "position: 'absolute', right: '0px', bottom: '10px'" })
                .SetLegend(new Legend
                           {
                               Layout = Layouts.Vertical,
                               Align = HorizontalAligns.Right,
                               VerticalAlign = VerticalAligns.Top,
                               X = -150,
                               Y = 100,
                               Floating = true,
                               BorderWidth = 1,
                               BackgroundColor = ColorTranslator.FromHtml("#FFFFFF")
                           })
                .SetXAxis(new XAxis { Categories = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" } })
                .SetYAxis(new YAxis
                          {
                              Title = new YAxisTitle { Text = "Number of units" },
                              Labels = new YAxisLabels { Formatter = "function() { return this.value; }" }
                          })
                .SetTooltip(new Tooltip { Formatter = "function() { return '<b>'+ this.series.name +'</b><br/>'+ this.x +': '+ this.y; }" })
                .SetPlotOptions(new PlotOptions { Area = new PlotOptionsArea { FillOpacity = 0.8 } })
                .SetSeries(new[]
                           {
                               new Series { Name = "John", Data = new Data(new object[] { 3, 4, 3, 5, 4, 10, 12 }) },
                               new Series { Name = "Jane", Data = new Data(new object[] { 1, 3, 4, 3, 3, 5, 4 }) }
                           });

            return View(chart);
        }

        public ActionResult AreaSpline()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Areaspline })
                .SetTitle(new Title { Text = "Average fruit consumption during one week" })
                .SetLegend(new Legend
                           {
                               Layout = Layouts.Vertical,
                               Align = HorizontalAligns.Left,
                               VerticalAlign = VerticalAligns.Top,
                               X = 150,
                               Y = 100,
                               Floating = true,
                               BorderWidth = 1,
                               BackgroundColor = ColorTranslator.FromHtml("#FFFFFF")
                           })
                .SetXAxis(new XAxis
                          {
                              Categories = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" },
                              PlotBands = new[]
                                          {
                                              new XAxisPlotBands
                                              {
                                                  From = 4.5,
                                                  To = 6.5,
                                                  Color = Color.FromArgb(50, 68, 179, 213)
                                              }
                                          }
                          })
                .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Fruit units" } })
                .SetTooltip(new Tooltip { Formatter = "function() { return ''+ this.x +': '+ this.y +' units'; }" })
                .SetCredits(new Credits { Enabled = false })
                .SetPlotOptions(new PlotOptions { Areaspline = new PlotOptionsAreaspline { FillOpacity = 0.5 } })
                .SetSeries(new[]
                           {
                               new Series { Name = "John", Data = new Data(new object[] { 3, 4, 3, 5, 4, 10, 12 }) },
                               new Series { Name = "Jane", Data = new Data(new object[] { 1, 3, 4, 3, 3, 5, 4 }) }
                           });

            return View(chart);
        }

        public ActionResult BasicBar()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Bar })
                .SetTitle(new Title { Text = "Historic World Population by Region" })
                .SetSubtitle(new Subtitle { Text = "Source: Wikipedia.org" })
                .SetXAxis(new XAxis
                          {
                              Categories = new[] { "Africa", "America", "Asia", "Europe", "Oceania" },
                              Title = new XAxisTitle { Text = string.Empty }
                          })
                .SetYAxis(new YAxis
                          {
                              Min = 0,
                              Title = new YAxisTitle
                                      {
                                          Text = "Population (millions)",
                                          Align = AxisTitleAligns.High
                                      }
                          })
                .SetTooltip(new Tooltip { Formatter = "function() { return ''+ this.series.name +': '+ this.y +' millions'; }" })
                .SetPlotOptions(new PlotOptions
                                {
                                    Bar = new PlotOptionsBar
                                          {
                                              DataLabels = new PlotOptionsBarDataLabels { Enabled = true }
                                          }
                                })
                .SetLegend(new Legend
                           {
                               Layout = Layouts.Vertical,
                               Align = HorizontalAligns.Right,
                               VerticalAlign = VerticalAligns.Top,
                               X = -100,
                               Y = 100,
                               Floating = true,
                               BorderWidth = 1,
                               BackgroundColor = ColorTranslator.FromHtml("#FFFFFF"),
                               Shadow = true
                           })
                .SetCredits(new Credits { Enabled = false })
                .SetSeries(new[]
                           {
                               new Series { Name = "Year 1800", Data = new Data(new object[] { 107, 31, 635, 203, 2 }) },
                               new Series { Name = "Year 1900", Data = new Data(new object[] { 133, 156, 947, 408, 6 }) },
                               new Series { Name = "Year 2008", Data = new Data(new object[] { 973, 914, 4054, 732, 34 }) }
                           });

            return View(chart);
        }

        public ActionResult StackedBar()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Bar })
                .SetTitle(new Title { Text = "Stacked bar chart" })
                .SetXAxis(new XAxis { Categories = new[] { "Apples", "Oranges", "Pears", "Grapes", "Bananas" } })
                .SetYAxis(new YAxis
                          {
                              Min = 0,
                              Title = new YAxisTitle { Text = "Total fruit consumption" }
                          })
                .SetTooltip(new Tooltip { Formatter = "function() { return ''+ this.series.name +': '+ this.y +''; }" })
                .SetPlotOptions(new PlotOptions { Bar = new PlotOptionsBar { Stacking = Stackings.Normal } })
                .SetSeries(new[]
                           {
                               new Series { Name = "John", Data = new Data(new object[] { 5, 3, 4, 7, 2 }) },
                               new Series { Name = "Jane", Data = new Data(new object[] { 2, 2, 3, 2, 1 }) },
                               new Series { Name = "Joe", Data = new Data(new object[] { 3, 4, 4, 2, 5 }) }
                           });

            return View(chart);
        }

        public ActionResult BarWithNegotiveStack()
        {
            string[] categories = new[]
                                  {
                                      "0-4", "5-9", "10-14", "15-19",
                                      "20-24", "25-29", "30-34", "35-39", "40-44",
                                      "45-49", "50-54", "55-59", "60-64", "65-69",
                                      "70-74", "75-79", "80-84", "85-89", "90-94",
                                      "95-99", "over 100"
                                  };

            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Bar })
                .SetTitle(new Title { Text = "Population pyramid for Germany, midyear 2010" })
                .SetSubtitle(new Subtitle { Text = "Source: www.census.gov" })
                .SetXAxis(new[]
                          {
                              new XAxis
                              {
                                  Categories = categories,
                                  Reversed = false
                              },
                              new XAxis
                              {
                                  Opposite = true,
                                  Reversed = false,
                                  Categories = categories,
                                  LinkedTo = 0
                              }
                          })
                .SetYAxis(new YAxis
                          {
                              Labels = new YAxisLabels { Formatter = "function(){ return (Math.abs(this.value) / 1000000) + 'M'; }" },
                              Title = new YAxisTitle { Text = "" },
                              Min = -4000000,
                              Max = 4000000
                          })
                .SetTooltip(new Tooltip { Formatter = "TooltipFormatter" })
                .SetPlotOptions(new PlotOptions { Bar = new PlotOptionsBar { Stacking = Stackings.Normal } })
                .SetSeries(new[]
                           {
                               new Series
                               {
                                   Name = "Male",
                                   Data = new Data(new object[]
                                                   {
                                                       -1746181, -1884428, -2089758, -2222362, -2537431, -2507081, -2443179,
                                                       -2664537, -3556505, -3680231, -3143062, -2721122, -2229181, -2227768,
                                                       -2176300, -1329968, -836804, -354784, -90569, -28367, -3878
                                                   })
                               },
                               new Series
                               {
                                   Name = "Female",
                                   Data = new Data(new object[]
                                                   {
                                                       1656154, 1787564, 1981671, 2108575, 2403438, 2366003, 2301402, 2519874,
                                                       3360596, 3493473, 3050775, 2759560, 2304444, 2426504, 2568938, 1785638,
                                                       1447162, 1005011, 330870, 130632, 21208
                                                   })
                               }
                           });

            return View(chart);
        }

        public ActionResult BasicColumn()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
                .SetTitle(new Title { Text = "Monthly Average Rainfall" })
                .SetSubtitle(new Subtitle { Text = "Source: WorldClimate.com" })
                .SetXAxis(new XAxis { Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" } })
                .SetYAxis(new YAxis
                          {
                              Min = 0,
                              Title = new YAxisTitle { Text = "Rainfall (mm)" }
                          })
                .SetLegend(new Legend
                           {
                               Layout = Layouts.Vertical,
                               Align = HorizontalAligns.Left,
                               VerticalAlign = VerticalAligns.Top,
                               X = 100,
                               Y = 70,
                               Floating = true,
                               BackgroundColor = ColorTranslator.FromHtml("#FFFFFF"),
                               Shadow = true
                           })
                .SetTooltip(new Tooltip { Formatter = @"function() { return ''+ this.x +': '+ this.y +' mm'; }" })
                .SetPlotOptions(new PlotOptions
                                {
                                    Column = new PlotOptionsColumn
                                             {
                                                 PointPadding = 0.2,
                                                 BorderWidth = 0
                                             }
                                })
                .SetSeries(new[]
                           {
                               new Series { Name = "Tokyo", Data = new Data(new object[] { 49.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 }) },
                               new Series { Name = "London", Data = new Data(new object[] { 48.9, 38.8, 39.3, 41.4, 47.0, 48.3, 59.0, 59.6, 52.4, 65.2, 59.3, 51.2 }) },
                               new Series { Name = "New York", Data = new Data(new object[] { 83.6, 78.8, 98.5, 93.4, 106.0, 84.5, 105.0, 104.3, 91.2, 83.5, 106.6, 92.3 }) },
                               new Series { Name = "Berlin", Data = new Data(new object[] { 42.4, 33.2, 34.5, 39.7, 52.6, 75.5, 57.4, 60.4, 47.6, 39.1, 46.8, 51.1 }) }
                           });

            return View(chart);
        }

        public ActionResult ColumnWithNegativeValues()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
                .SetTitle(new Title { Text = "Column chart with negative values" })
                .SetXAxis(new XAxis { Categories = new[] { "Apples", "Oranges", "Pears", "Grapes", "Bananas" } })
                .SetTooltip(new Tooltip { Formatter = "function() { return ''+ this.series.name +': '+ this.y +''; }" })
                .SetCredits(new Credits { Enabled = false })
                .SetSeries(new[]
                           {
                               new Series { Name = "John", Data = new Data(new object[] { 5, 3, 4, 7, 2 }) },
                               new Series { Name = "Jane", Data = new Data(new object[] { 2, -2, -3, 2, 1 }) },
                               new Series { Name = "Joe", Data = new Data(new object[] { 3, 4, 4, -2, 5 }) }
                           });

            return View(chart);
        }

        public ActionResult StackedColumn()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
                .SetTitle(new Title { Text = "Stacked column chart" })
                .SetXAxis(new XAxis { Categories = new[] { "Apples", "Oranges", "Pears", "Grapes", "Bananas" } })
                .SetYAxis(new YAxis
                          {
                              Min = 0,
                              Title = new YAxisTitle { Text = "Total fruit consumption" },
                              StackLabels = new YAxisStackLabels
                                            {
                                                Enabled = true,
                                                Style = "fontWeight: 'bold', color: (Highcharts.theme && Highcharts.theme.textColor) || 'gray'"
                                            }
                          })
                .SetLegend(new Legend
                           {
                               Layout = Layouts.Horizontal,
                               Align = HorizontalAligns.Right,
                               VerticalAlign = VerticalAligns.Top,
                               X = -100,
                               Y = 20,
                               Floating = true,
                               BackgroundColor = ColorTranslator.FromHtml("#FFFFFF"),
                               BorderColor = ColorTranslator.FromHtml("#CCC"),
                               BorderWidth = 1,
                               Shadow = false
                           })
                .SetTooltip(new Tooltip { Formatter = "TooltipFormatter" })
                .SetPlotOptions(new PlotOptions
                                {
                                    Column = new PlotOptionsColumn
                                             {
                                                 Stacking = Stackings.Normal,
                                                 DataLabels = new PlotOptionsColumnDataLabels
                                                              {
                                                                  Enabled = true,
                                                                  Color = Color.White
                                                              }
                                             }
                                })
                .SetSeries(new[]
                           {
                               new Series { Name = "John", Data = new Data(new object[] { 5, 3, 4, 7, 2 }) },
                               new Series { Name = "Jane", Data = new Data(new object[] { 2, 2, 3, 2, 1 }) },
                               new Series { Name = "Joe", Data = new Data(new object[] { 3, 4, 4, 2, 5 }) }
                           });

            return View(chart);
        }

        public ActionResult StackedAndGroupedColumn()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
                .SetTitle(new Title { Text = "Total fruit consumtion, grouped by gender" })
                .SetXAxis(new XAxis { Categories = new[] { "Apples", "Oranges", "Pears", "Grapes", "Bananas" } })
                .SetYAxis(new YAxis
                          {
                              AllowDecimals = false,
                              Min = 0,
                              Title = new YAxisTitle { Text = "Number of fruits" }
                          })
                .SetTooltip(new Tooltip { Formatter = "TooltipFormatter" })
                .SetPlotOptions(new PlotOptions { Column = new PlotOptionsColumn { Stacking = Stackings.Normal } })
                .SetSeries(new[]
                           {
                               new Series
                               {
                                   Name = "John",
                                   Data = new Data(new object[] { 5, 3, 4, 7, 2 }),
                                   Stack = "male"
                               },
                               new Series
                               {
                                   Name = "Joe",
                                   Data = new Data(new object[] { 3, 4, 4, 2, 5 }),
                                   Stack = "male"
                               },
                               new Series
                               {
                                   Name = "Jane",
                                   Data = new Data(new object[] { 2, 5, 6, 2, 1 }),
                                   Stack = "female"
                               },
                               new Series
                               {
                                   Name = "Janet",
                                   Data = new Data(new object[] { 3, 0, 4, 4, 3 }),
                                   Stack = "female"
                               }
                           });

            return View(chart);
        }

        public ActionResult StackedPercentageColumn()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
                .SetTitle(new Title { Text = "Stacked column chart" })
                .SetXAxis(new XAxis { Categories = new[] { "Apples", "Oranges", "Pears", "Grapes", "Bananas" } })
                .SetYAxis(new YAxis { Min = 0, Title = new YAxisTitle { Text = "Total fruit consumption" } })
                .SetTooltip(new Tooltip { Formatter = "function() { return ''+ this.series.name +': '+ this.y +' ('+ Math.round(this.percentage) +'%)'; }" })
                .SetPlotOptions(new PlotOptions { Column = new PlotOptionsColumn { Stacking = Stackings.Percent } })
                .SetSeries(new[]
                           {
                               new Series { Name = "John", Data = new Data(new object[] { 5, 3, 4, 7, 2 }) },
                               new Series { Name = "Jane", Data = new Data(new object[] { 2, 2, 3, 2, 1 }) },
                               new Series { Name = "Joe", Data = new Data(new object[] { 3, 4, 4, 2, 5 }) }
                           });

            return View(chart);
        }

        public ActionResult ColumnWithRotatedLabels()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Column, Margin = new[] { 50, 50, 100, 80 } })
                .SetTitle(new Title { Text = "World\\'s largest cities per 2008" })
                .SetXAxis(new XAxis
                          {
                              Categories = new[]
                                           {
                                               "Tokyo", "Jakarta", "New York", "Seoul", "Manila", "Mumbai", "Sao Paulo", "Mexico City",
                                               "Dehli", "Osaka", "Cairo", "Kolkata", "Los Angeles", "Shanghai", "Moscow", "Beijing",
                                               "Buenos Aires", "Guangzhou", "Shenzhen", "Istanbul"
                                           },
                              Labels = new XAxisLabels
                                       {
                                           Rotation = -45,
                                           Align = HorizontalAligns.Right,
                                           Style = "font: 'normal 13px Verdana, sans-serif'"
                                       }
                          })
                .SetYAxis(new YAxis
                          {
                              Min = 0,
                              Title = new YAxisTitle { Text = "Population (millions)" }
                          })
                .SetLegend(new Legend { Enabled = false })
                .SetTooltip(new Tooltip { Formatter = "TooltipFormatter" })
                .SetPlotOptions(new PlotOptions
                                {
                                    Column = new PlotOptionsColumn
                                             {
                                                 DataLabels = new PlotOptionsColumnDataLabels
                                                              {
                                                                  Enabled = true,
                                                                  Rotation = -90,
                                                                  Color = ColorTranslator.FromHtml("#FFFFFF"),
                                                                  Align = HorizontalAligns.Right,
                                                                  X = 4,
                                                                  Y = 10,
                                                                  Formatter = "function() { return this.y; }",
                                                                  Style = "font: 'normal 13px Verdana, sans-serif'"
                                                              }
                                             }
                                })
                .SetSeries(new Series
                           {
                               Name = "Population",
                               Data = new Data(new object[]
                                               {
                                                   34.4, 21.8, 20.1, 20, 19.6, 19.5, 19.1, 18.4, 18, 17.3, 16.8, 15, 14.7, 14.5,
                                                   13.3, 12.8, 12.4, 11.8, 11.7, 11.2
                                               }),
                           });

            return View(chart);
        }

        public ActionResult ColumnWithDrilldown()
        {
            string[] categories = new[] { "MSIE", "Firefox", "Chrome", "Safari", "Opera" };
            const string NAME = "Browser brands";
            Data data = new Data(new[]
                                 {
                                     new Point
                                     {
                                         Y = 55.11,
                                         Color = Color.FromName("colors[0]"),
                                         Drilldown = new Drilldown
                                                     {
                                                         Name = "MSIE versions",
                                                         Categories = new[] { "MSIE 6.0", "MSIE 7.0", "MSIE 8.0", "MSIE 9.0" },
                                                         Data = new Data(new object[] { 10.85, 7.35, 33.06, 2.81 }),
                                                         Color = Color.FromName("colors[0]")
                                                     }
                                     },
                                     new Point
                                     {
                                         Y = 21.63,
                                         Color = Color.FromName("colors[1]"),
                                         Drilldown = new Drilldown
                                                     {
                                                         Name = "Firefox versions",
                                                         Categories = new[] { "Firefox 2.0", "Firefox 3.0", "Firefox 3.5", "Firefox 3.6", "Firefox 4.0" },
                                                         Data = new Data(new object[] { 0.20, 0.83, 1.58, 13.12, 5.43 }),
                                                         Color = Color.FromName("colors[1]")
                                                     }
                                     },
                                     new Point
                                     {
                                         Y = 11.94,
                                         Color = Color.FromName("colors[2]"),
                                         Drilldown = new Drilldown
                                                     {
                                                         Name = "Chrome versions",
                                                         Categories = new[] { "Chrome 5.0", "Chrome 6.0", "Chrome 7.0", "Chrome 8.0", "Chrome 9.0", "Chrome 10.0", "Chrome 11.0", "Chrome 12.0" },
                                                         Data = new Data(new object[] { 0.12, 0.19, 0.12, 0.36, 0.32, 9.91, 0.50, 0.22 }),
                                                         Color = Color.FromName("colors[2]")
                                                     }
                                     },
                                     new Point
                                     {
                                         Y = 7.15,
                                         Color = Color.FromName("colors[3]"),
                                         Drilldown = new Drilldown
                                                     {
                                                         Name = "Safari versions",
                                                         Categories = new[] { "Safari 5.0", "Safari 4.0", "Safari Win 5.0", "Safari 4.1", "Safari/Maxthon", "Safari 3.1", "Safari 4.1" },
                                                         Data = new Data(new object[] { 4.55, 1.42, 0.23, 0.21, 0.20, 0.19, 0.14 }),
                                                         Color = Color.FromName("colors[3]")
                                                     }
                                     },
                                     new Point
                                     {
                                         Y = 2.14,
                                         Color = Color.FromName("colors[4]"),
                                         Drilldown = new Drilldown
                                                     {
                                                         Name = "Opera versions",
                                                         Categories = new[] { "Opera 9.x", "Opera 10.x", "Opera 11.x" },
                                                         Data = new Data(new object[] { 0.12, 0.37, 1.65 }),
                                                         Color = Color.FromName("colors[4]")
                                                     }
                                     }
                                 });

            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
                .SetTitle(new Title { Text = "Browser market share, April, 2011" })
                .SetSubtitle(new Subtitle { Text = "Click the columns to view versions. Click again to view brands." })
                .SetXAxis(new XAxis { Categories = categories })
                .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Total percent market share" } })
                .SetLegend(new Legend { Enabled = false })
                .SetTooltip(new Tooltip { Formatter = "TooltipFormatter" })
                .SetPlotOptions(new PlotOptions
                                {
                                    Column = new PlotOptionsColumn
                                             {
                                                 Cursor = Cursors.Pointer,
                                                 Point = new PlotOptionsColumnPoint { Events = new PlotOptionsColumnPointEvents { Click = "ColumnPointClick" } },
                                                 DataLabels = new PlotOptionsColumnDataLabels
                                                              {
                                                                  Enabled = true,
                                                                  Color = Color.FromName("colors[0]"),
                                                                  Formatter = "function() { return this.y +'%'; }",
                                                                  Style = "fontWeight: 'bold'"
                                                              }
                                             }
                                })
                .SetSeries(new Series
                           {
                               Name = "Browser brands",
                               Data = data,
                               Color = Color.White
                           })
                .SetExporting(new Exporting { Enabled = false })
                .AddJavascripFunction(
                    "TooltipFormatter",
                    @"var point = this.point, s = this.x +':<b>'+ this.y +'% market share</b><br/>';
                      if (point.drilldown) {
                        s += 'Click to view '+ point.category +' versions';
                      } else {
                        s += 'Click to return to browser brands';
                      }
                      return s;"
                )
                .AddJavascripFunction(
                    "ColumnPointClick",
                    @"var drilldown = this.drilldown;
                      if (drilldown) { // drill down
                        setChart(drilldown.name, drilldown.categories, drilldown.data.data, drilldown.color);
                      } else { // restore
                        setChart(name, categories, data.data);
                      }"
                )
                .AddJavascripFunction(
                    "setChart",
                    @"chart.xAxis[0].setCategories(categories);
                      chart.series[0].remove();
                      chart.addSeries({
                         name: name,
                         data: data,
                         color: color || 'white'
                      });",
                    "name", "categories", "data", "color"
                )
                .AddJavascripVariable("colors", "Highcharts.getOptions().colors")
                .AddJavascripVariable("name", "'{0}'".FormatWith(NAME))
                .AddJavascripVariable("categories", JsonSerializer.Serialize(categories))
                .AddJavascripVariable("data", JsonSerializer.Serialize(data));

            return View(chart);
        }

        public ActionResult PieChart()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { PlotShadow = false })
                .SetTitle(new Title { Text = "Browser market shares at a specific website, 2010" })
                .SetTooltip(new Tooltip { Formatter = "function() { return '<b>'+ this.point.name +'</b>: '+ this.percentage +' %'; }" })
                .SetPlotOptions(new PlotOptions
                                {
                                    Pie = new PlotOptionsPie
                                          {
                                              AllowPointSelect = true,
                                              Cursor = Cursors.Pointer,
                                              DataLabels = new PlotOptionsPieDataLabels
                                                           {
                                                               Color = ColorTranslator.FromHtml("#000000"),
                                                               ConnectorColor = ColorTranslator.FromHtml("#000000"),
                                                               Formatter = "function() { return '<b>'+ this.point.name +'</b>: '+ this.percentage +' %'; }"
                                                           }
                                          }
                                })
                .SetSeries(new Series
                           {
                               Type = ChartTypes.Pie,
                               Name = "Browser share",
                               Data = new Data(new object[]
                                               {
                                                   new object[] { "Firefox", 45.0 },
                                                   new object[] { "IE", 26.8 },
                                                   new Point
                                                   {
                                                       Name = "Chrome",
                                                       Y = 12.8,
                                                       Sliced = true,
                                                       Selected = true
                                                   },
                                                   new object[] { "Safari", 8.5 },
                                                   new object[] { "Opera", 6.2 },
                                                   new object[] { "Others", 0.7 }
                                               })
                           });

            return View(chart);
        }

        public ActionResult DonutChart()
        {
            string[] categories = new[] { "MSIE", "Firefox", "Chrome", "Safari", "Opera" };
            Data data = new Data(new[]
                                 {
                                     new Point
                                     {
                                         Y = 55.11,
                                         Color = Color.FromName("colors[0]"),
                                         Drilldown = new Drilldown
                                                     {
                                                         Name = "MSIE versions",
                                                         Categories = new[] { "MSIE 6.0", "MSIE 7.0", "MSIE 8.0", "MSIE 9.0" },
                                                         Data = new Data(new object[] { 10.85, 7.35, 33.06, 2.81 }),
                                                         Color = Color.FromName("colors[0]")
                                                     }
                                     },
                                     new Point
                                     {
                                         Y = 21.63,
                                         Color = Color.FromName("colors[1]"),
                                         Drilldown = new Drilldown
                                                     {
                                                         Name = "Firefox versions",
                                                         Categories = new[] { "Firefox 2.0", "Firefox 3.0", "Firefox 3.5", "Firefox 3.6", "Firefox 4.0" },
                                                         Data = new Data(new object[] { 0.20, 0.83, 1.58, 13.12, 5.43 }),
                                                         Color = Color.FromName("colors[1]")
                                                     }
                                     },
                                     new Point
                                     {
                                         Y = 11.94,
                                         Color = Color.FromName("colors[2]"),
                                         Drilldown = new Drilldown
                                                     {
                                                         Name = "Chrome versions",
                                                         Categories = new[] { "Chrome 5.0", "Chrome 6.0", "Chrome 7.0", "Chrome 8.0", "Chrome 9.0", "Chrome 10.0", "Chrome 11.0", "Chrome 12.0" },
                                                         Data = new Data(new object[] { 0.12, 0.19, 0.12, 0.36, 0.32, 9.91, 0.50, 0.22 }),
                                                         Color = Color.FromName("colors[2]")
                                                     }
                                     },
                                     new Point
                                     {
                                         Y = 7.15,
                                         Color = Color.FromName("colors[3]"),
                                         Drilldown = new Drilldown
                                                     {
                                                         Name = "Safari versions",
                                                         Categories = new[] { "Safari 5.0", "Safari 4.0", "Safari Win 5.0", "Safari 4.1", "Safari/Maxthon", "Safari 3.1", "Safari 4.1" },
                                                         Data = new Data(new object[] { 4.55, 1.42, 0.23, 0.21, 0.20, 0.19, 0.14 }),
                                                         Color = Color.FromName("colors[3]")
                                                     }
                                     },
                                     new Point
                                     {
                                         Y = 2.14,
                                         Color = Color.FromName("colors[4]"),
                                         Drilldown = new Drilldown
                                                     {
                                                         Name = "Opera versions",
                                                         Categories = new[] { "Opera 9.x", "Opera 10.x", "Opera 11.x" },
                                                         Data = new Data(new object[] { 0.12, 0.37, 1.65 }),
                                                         Color = Color.FromName("colors[4]")
                                                     }
                                     }
                                 });

            List<Point> browserData = new List<Point>(categories.Length);
            List<Point> versionsData = new List<Point>();
            for (int i = 0; i < categories.Length; i++)
            {
                browserData.Add(new Point { Name = categories[i], Y = data.SeriesData[i].Y, Color = data.SeriesData[i].Color });
                for (int j = 0; j < data.SeriesData[i].Drilldown.Categories.Length; j++)
                {
                    Drilldown drilldown = data.SeriesData[i].Drilldown;
                    versionsData.Add(new Point { Name = drilldown.Categories[j], Y = Number.GetNumber(drilldown.Data.ArrayData[j]), Color = drilldown.Color });
                }
            }

            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Pie })
                .SetTitle(new Title { Text = "Browser market share, April, 2011" })
                .SetSubtitle(new Subtitle { Text = "Total percent market share" })
                .SetPlotOptions(new PlotOptions { Pie = new PlotOptionsPie { Shadow = false } })
                .SetTooltip(new Tooltip { Formatter = @"function() { return '<b>'+ this.point.name +'</b>: '+ this.y +' %';}" })
                .AddJavascripVariable("colors", "Highcharts.getOptions().colors")
                .SetSeries(new[]
                           {
                               new Series
                               {
                                   Name = "Browsers",
                                   Data = new Data(browserData.ToArray()),
                                   PlotOptionsPie = new PlotOptionsPie
                                                    {
                                                        Size = "60%",
                                                        DataLabels = new PlotOptionsPieDataLabels
                                                                     {
                                                                         Formatter = "function() { return this.y > 5 ? this.point.name : null; }",
                                                                         Color = Color.White,
                                                                         Distance = -30
                                                                     }
                                                    }
                               },
                               new Series
                               {
                                   Name = "Versions",
                                   Data = new Data(versionsData.ToArray()),
                                   PlotOptionsPie = new PlotOptionsPie
                                                    {
                                                        InnerSize = "60%",
                                                        DataLabels = new PlotOptionsPieDataLabels
                                                                     {
                                                                         Formatter = "function() { return this.y > 1 ? '<b>'+ this.point.name +':</b> '+ this.y +'%'  : null; }"
                                                                     }
                                                    }
                               }
                           });

            return View(chart);
        }

        public ActionResult PieWithLegend()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { PlotShadow = false, PlotBackgroundColor = null, PlotBorderWidth = null })
                .SetTitle(new Title { Text = "Browser market shares at a specific website, 2010" })
                .SetTooltip(new Tooltip { Formatter = "function() { return '<b>'+ this.point.name +'</b>: '+ this.percentage +' %'; }" })
                .SetPlotOptions(new PlotOptions
                                {
                                    Pie = new PlotOptionsPie
                                          {
                                              AllowPointSelect = true,
                                              Cursor = Cursors.Pointer,
                                              DataLabels = new PlotOptionsPieDataLabels { Enabled = false },
                                              ShowInLegend = true
                                          }
                                })
                .SetSeries(new Series
                           {
                               Type = ChartTypes.Pie,
                               Name = "Browser share",
                               Data = new Data(new object[]
                                               {
                                                   new object[] { "Firefox", 45.0 },
                                                   new object[] { "IE", 26.8 },
                                                   new Point
                                                   {
                                                       Name = "Chrome",
                                                       Y = 12.8,
                                                       Sliced = true,
                                                       Selected = true
                                                   },
                                                   new object[] { "Safari", 8.5 },
                                                   new object[] { "Opera", 6.2 },
                                                   new object[] { "Others", 0.7 }
                                               })
                           });

            return View(chart);
        }

        public ActionResult SplineUpdateEachSecond()
        {
            List<object> points = new List<object>(20);
            DateTime now = DateTime.Now;
            Random rand = new Random();
            for (int i = -19; i <= 0; i++)
                points.Add(new { X = now.AddSeconds(i), Y = rand.NextDouble() });

            Highcharts chart = new Highcharts("chart")
                .SetOptions(new GlobalOptions { Global = new Global { UseUTC = false } })
                .InitChart(new Chart
                           {
                               DefaultSeriesType = ChartTypes.Spline,
                               MarginRight = 10,
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
                                             y = Math.random();
                                          series.addPoint([x, y], true, true);
                                       }, 1000);")
                .SetTitle(new Title { Text = "Live random data" })
                .SetXAxis(new XAxis
                          {
                              Type = AxisTypes.Datetime,
                              TickPixelInterval = 150
                          })
                .SetYAxis(new YAxis
                          {
                              Title = new YAxisTitle { Text = "Value" },
                              PlotLines = new[]
                                          {
                                              new YAxisPlotLines
                                              {
                                                  Value = 0,
                                                  Width = 1,
                                                  Color = ColorTranslator.FromHtml("#808080")
                                              }
                                          }
                          })
                .SetTooltip(new Tooltip { Formatter = "TooltipFormatter" })
                .AddJavascripFunction("TooltipFormatter",
                                      @"return '<b>'+ this.series.name +'</b><br/>'+
                                       Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', this.x) +'<br/>'+ 
                                       Highcharts.numberFormat(this.y, 2);")
                .SetLegend(new Legend { Enabled = false })
                .SetExporting(new Exporting { Enabled = false })
                .SetSeries(new Series
                           {
                               Name = "Random data",
                               Data = new Data(points.ToArray())
                           });

            return View(chart);
        }

        public ActionResult ColumnLineAndPie()
        {
            Highcharts chart = new Highcharts("chart")
                .SetTitle(new Title { Text = "Combination chart" })
                .SetTooltip(new Tooltip { Formatter = "function() { return '<b>'+ this.point.name +'</b>: '+ this.percentage +' %'; }" })
                .SetXAxis(new XAxis { Categories = new[] { "Apples", "Oranges", "Pears", "Bananas", "Plums" } })
                .SetTooltip(new Tooltip { Formatter = "TooltipFormatter" })
                .AddJavascripFunction("TooltipFormatter",
                                      @"var s;
                    if (this.point.name) { // the pie chart
                       s = ''+
                          this.point.name +': '+ this.y +' fruits';
                    } else {
                       s = ''+
                          this.x  +': '+ this.y;
                    }
                    return s;")
                .SetLabels(new Labels
                           {
                               Items = new[]
                                       {
                                           new LabelsItems
                                           {
                                               Html = "Total fruit consumption",
                                               Style = "left: '40px', top: '8px', color: 'black'"
                                           }
                                       }
                           })
                .SetPlotOptions(new PlotOptions
                                {
                                    Pie = new PlotOptionsPie
                                          {
                                              Center = new[] { "100", "80" },
                                              Size = "100",
                                              ShowInLegend = false,
                                              DataLabels = new PlotOptionsPieDataLabels { Enabled = false }
                                          }
                                })
                .SetSeries(new[]
                           {
                               new Series
                               {
                                   Type = ChartTypes.Column,
                                   Name = "Jane",
                                   Data = new Data(new object[] { 3, 2, 1, 3, 4 })
                               },
                               new Series
                               {
                                   Type = ChartTypes.Column,
                                   Name = "John",
                                   Data = new Data(new object[] { 2, 3, 5, 7, 6 })
                               },
                               new Series
                               {
                                   Type = ChartTypes.Column,
                                   Name = "Joe",
                                   Data = new Data(new object[] { 4, 3, 3, 9, 0 })
                               },
                               new Series
                               {
                                   Type = ChartTypes.Spline,
                                   Name = "Average",
                                   Data = new Data(new object[] { 3, 2.67, 3, 6.33, 3.33 })
                               },
                               new Series
                               {
                                   Type = ChartTypes.Pie,
                                   Name = "Total consumption",
                                   Data = new Data(new[]
                                                   {
                                                       new Point
                                                       {
                                                           Name = "Jane",
                                                           Y = 13,
                                                           Color = Color.FromName("Highcharts.getOptions().colors[0]")
                                                       },
                                                       new Point
                                                       {
                                                           Name = "John",
                                                           Y = 23,
                                                           Color = Color.FromName("Highcharts.getOptions().colors[1]")
                                                       },
                                                       new Point
                                                       {
                                                           Name = "Joe",
                                                           Y = 19,
                                                           Color = Color.FromName("Highcharts.getOptions().colors[2]")
                                                       }
                                                   }
                                       )
                               }
                           });

            return View(chart);
        }

        public ActionResult DualAxesLineAndColumn()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { ZoomType = ZoomTypes.Xy })
                .SetTitle(new Title { Text = "Average Monthly Temperature and Rainfall in Tokyo" })
                .SetSubtitle(new Subtitle { Text = "Source: WorldClimate.com" })
                .SetXAxis(new XAxis { Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" } })
                .SetYAxis(new[]
                          {
                              new YAxis
                              {
                                  Labels = new YAxisLabels
                                           {
                                               Formatter = "function() { return this.value +'°C'; }",
                                               Style = "color: '#89A54E'"
                                           },
                                  Title = new XAxisTitle
                                          {
                                              Text = "Temperature",
                                              Style = "color: '#89A54E'"
                                          }
                              },
                              new YAxis
                              {
                                  Labels = new YAxisLabels
                                           {
                                               Formatter = "function() { return this.value +' mm'; }",
                                               Style = "color: '#4572A7'"
                                           },
                                  Title = new XAxisTitle
                                          {
                                              Text = "Rainfall",
                                              Style = "color: '#4572A7'"
                                          },
                                  Opposite = true
                              }
                          })
                .SetTooltip(new Tooltip
                            {
                                Formatter = "function() { return ''+ this.x +': '+ this.y + (this.series.name == 'Rainfall' ? ' mm' : '°C'); }"
                            })
                .SetLegend(new Legend
                           {
                               Layout = Layouts.Vertical,
                               Align = HorizontalAligns.Left,
                               X = 120,
                               VerticalAlign = VerticalAligns.Top,
                               Y = 100,
                               Floating = true,
                               BackgroundColor = ColorTranslator.FromHtml("#FFFFFF")
                           })
                .SetSeries(new[]
                           {
                               new Series
                               {
                                   Name = "Rainfall",
                                   Color = ColorTranslator.FromHtml("#4572A7"),
                                   Type = ChartTypes.Column,
                                   YAxis = 1,
                                   Data = new Data(new object[] { 49.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 })
                               },
                               new Series
                               {
                                   Name = "Temperature",
                                   Color = ColorTranslator.FromHtml("#89A54E"),
                                   Type = ChartTypes.Spline,
                                   Data = new Data(new object[] { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 })
                               }
                           });

            return View(chart);
        }

        public ActionResult MultipleAxes()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { ZoomType = ZoomTypes.Xy })
                .SetTitle(new Title { Text = "Average Monthly Weather Data for Tokyo" })
                .SetSubtitle(new Subtitle { Text = "Source: WorldClimate.com" })
                .SetXAxis(new XAxis { Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" } })
                .SetYAxis(new[]
                          {
                              new YAxis
                              {
                                  Labels = new YAxisLabels
                                           {
                                               Formatter = "function() { return this.value +'°C'; }",
                                               Style = "color: '#89A54E'"
                                           },
                                  Title = new XAxisTitle
                                          {
                                              Text = "Temperature",
                                              Style = "color: '#89A54E'"
                                          },
                                  Opposite = true
                              },
                              new YAxis
                              {
                                  Labels = new YAxisLabels
                                           {
                                               Formatter = "function() { return this.value +' mm'; }",
                                               Style = "color: '#4572A7'"
                                           },
                                  Title = new XAxisTitle { Style = "color: '#4572A7'" },
                                  GridLineWidth = 0
                              },
                              new YAxis
                              {
                                  Labels = new YAxisLabels
                                           {
                                               Formatter = "function() { return this.value +' mb'; }",
                                               Style = "color: '#AA4643'"
                                           },
                                  Title = new XAxisTitle
                                          {
                                              Text = "Sea-Level Pressure",
                                              Style = "color: '#AA4643'"
                                          },
                                  GridLineWidth = 0,
                                  Opposite = true
                              }
                          })
                .SetTooltip(new Tooltip { Formatter = "TooltipFormatter" })
                .AddJavascripFunction("TooltipFormatter",
                                      @"var unit = {
                   'Rainfall': 'mm',
                   'Temperature': '°C',
                   'Sea-Level Pressure': 'mb'
                 }[this.series.name];
            
                return ''+
                   this.x +': '+ this.y +' '+ unit;")
                .SetLegend(new Legend
                           {
                               Layout = Layouts.Vertical,
                               Align = HorizontalAligns.Left,
                               X = 120,
                               VerticalAlign = VerticalAligns.Top,
                               Y = 80,
                               Floating = true,
                               BackgroundColor = ColorTranslator.FromHtml("#FFFFFF")
                           })
                .SetPlotOptions(new PlotOptions
                                {
                                    Line = new PlotOptionsLine
                                           {
                                               Marker = new PlotOptionsLineMarker { Enabled = false },
                                               DashStyle = DashStyles.ShortDot
                                           }
                                })
                .SetSeries(new[]
                           {
                               new Series
                               {
                                   Name = "Rainfall",
                                   Color = ColorTranslator.FromHtml("#4572A7"),
                                   Type = ChartTypes.Column,
                                   YAxis = 1,
                                   Data = new Data(new object[] { 49.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 })
                               },
                               new Series
                               {
                                   Name = "Sea-Level Pressure",
                                   Color = ColorTranslator.FromHtml("#AA4643"),
                                   Type = ChartTypes.Spline,
                                   YAxis = 2,
                                   Data = new Data(new object[] { 1016, 1016, 1015.9, 1015.5, 1012.3, 1009.5, 1009.6, 1010.2, 1013.1, 1016.9, 1018.2, 1016.7 }),
                                   PlotOptionsSpline = new PlotOptionsSpline
                                                       {
                                                           Marker = new PlotOptionsSplineMarker { Enabled = false },
                                                           DashStyle = DashStyles.ShortDot
                                                       }
                               },
                               new Series
                               {
                                   Name = "Temperature",
                                   Color = ColorTranslator.FromHtml("#89A54E"),
                                   Type = ChartTypes.Spline,
                                   Data = new Data(new object[] { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 })
                               }
                           });

            return View(chart);
        }

        public ActionResult ScatterPlotWithRegressionLine()
        {
            Highcharts chart = new Highcharts("chart")
                .SetXAxis(new XAxis { Min = -0.5, Max = 5.5 })
                .SetYAxis(new YAxis { Min = 0 })
                .SetTitle(new Title { Text = "Scatter plot with regression line" })
                .SetSeries(new[]
                           {
                               new Series
                               {
                                   Type = ChartTypes.Line,
                                   Name = "Regression Line",
                                   Data = new Data(new object[,] { { 0, 1.11 }, { 5, 4.51 } }),
                                   PlotOptionsLine = new PlotOptionsLine
                                                     {
                                                         Marker = new PlotOptionsSeriesMarker { Enabled = false },
                                                         States = new PlotOptionsLineStates { Hover = new PlotOptionsSeriesStatesHover { LineWidth = 0 } },
                                                         EnableMouseTracking = false
                                                     },
                               },
                               new Series
                               {
                                   Type = ChartTypes.Scatter,
                                   Name = "Observations",
                                   Data = new Data(new object[] { 1, 1.5, 2.8, 3.5, 3.9, 4.2 }),
                                   PlotOptionsScatter = new PlotOptionsScatter { Marker = new PlotOptionsSeriesMarker { Radius = 4 } }
                               }
                           });

            return View(chart);
        }

        public ActionResult ClickToAddPoint()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart
                           {
                               DefaultSeriesType = ChartTypes.Scatter,
                               Margin = new[] { 70, 50, 60, 80 },
                               Events = new ChartEvents { Click = "ChartClickEvent" }
                           })
                .AddJavascripFunction("ChartClickEvent", @"var x = e.xAxis[0].value,
                    y = e.yAxis[0].value,
                    series = this.series[0];
                    series.addPoint([x, y]);", "e")
                .SetTitle(new Title { Text = "User supplied data" })
                .SetSubtitle(new Subtitle { Text = "Click the plot area to add a point. Click a point to remove it." })
                .SetXAxis(new XAxis
                          {
                              MinPadding = 0.2,
                              MaxPadding = 0.2,
                              MinRange = 60
                          })
                .SetYAxis(new YAxis
                          {
                              Title = new YAxisTitle { Text = "Value" },
                              MinPadding = 0.2,
                              MaxPadding = 0.2,
                              MinRange = 60,
                              PlotLines = new[]
                                          {
                                              new YAxisPlotLines
                                              {
                                                  Value = 0,
                                                  Width = 1,
                                                  Color = ColorTranslator.FromHtml("#808080")
                                              }
                                          }
                          })
                .SetLegend(new Legend { Enabled = false })
                .SetExporting(new Exporting { Enabled = false })
                .SetPlotOptions(new PlotOptions
                                {
                                    Series = new PlotOptionsSeries
                                             {
                                                 LineWidth = 1,
                                                 Point = new PlotOptionsSeriesPoint
                                                         {
                                                             Events = new PlotOptionsSeriesPointEvents
                                                                      {
                                                                          Click = "function() { if (this.series.data.length > 1) this.remove(); }"
                                                                      }
                                                         }
                                             }
                                })
                .SetSeries(new Series { Data = new Data(new object[,] { { 20, 20 }, { 80, 80 } }) });

            return View(chart);
        }


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
                    Line = new PlotOptionsLine { Step = true }
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
                        Label = new YAxisPlotBandsLabel { Text = "Last quarter\\'s value range" }
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
                .SetSeries(new[]
                {
                    new Series 
                    { 
                        Name = "AAPL",
                        Type = ChartTypes.Candlestick,
                        // data grouping?
                    },
                    new Series
                    {
                        Name="Volume",
                        Type = ChartTypes.Column,
                        YAxis = 1
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
    }
}
