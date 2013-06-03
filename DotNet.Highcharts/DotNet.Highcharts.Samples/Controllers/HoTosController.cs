using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web.Mvc;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using DotNet.Highcharts.Samples.Models;
using Point = DotNet.Highcharts.Options.Point;

namespace DotNet.Highcharts.Samples.Controllers
{
    public class HoTosController : Controller
    {
        public ActionResult MultipleXAxes()
        {
            // Example from JSFIDDLE: http://jsfiddle.net/kSkYN/4502/

            Highcharts chart = new Highcharts("chart")
                .SetTitle(new Title { Text = "Multiple X-Axes" })
                .SetXAxis(new[]
                          {
                              new XAxis { Type = AxisTypes.Datetime },
                              new XAxis { Type = AxisTypes.Datetime, Opposite = true }
                          })
                .SetSeries(new[]
                           {
                               new Series
                               {
                                   Data = new Data(new object[] { 29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 }),
                                   PlotOptionsSeries = new PlotOptionsSeries
                                                       {
                                                           PointStart = new PointStart(new DateTime(2010, 1, 1)),
                                                           PointInterval = 24 * 3600 * 1000 // one day
                                                       }
                               },
                               new Series
                               {
                                   Data = new Data(new object[] { 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4, 29.9, 71.5, 106.4, 129.2, 144.0 }),
                                   PlotOptionsSeries = new PlotOptionsSeries
                                                       {
                                                           PointStart = new PointStart(new DateTime(2010, 1, 10)),
                                                           PointInterval = 24 * 3600 * 1000, // one day
                                                       },
                                   XAxis = "1"
                               }
                           });

            return View(chart);
        }

        public ActionResult ChartInFunction()
        {
            Highcharts chart = new Highcharts("newChart")
                .SetTitle(new Title { Text = "Chart inside JavaScript function" })
                .SetTooltip(new Tooltip { Formatter = "function() { return '<b>'+ this.point.name +'</b>: '+ this.percentage +' %'; }" })
                .SetXAxis(new XAxis { Categories = new[] { "Apples", "Oranges", "Pears", "Bananas", "Plums" } })
                .SetTooltip(new Tooltip { Formatter = "TooltipFormatter" })
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
                                              Center = new[] { new PercentageOrPixel(100), new PercentageOrPixel(80) },
                                              Size = new PercentageOrPixel(100),
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
                                                           Color = Color.FromName("colors[5]")
                                                       },
                                                       new Point
                                                       {
                                                           Name = "John",
                                                           Y = 23,
                                                           Color = Color.FromName("colors[6]")
                                                       },
                                                       new Point
                                                       {
                                                           Name = "Joe",
                                                           Y = 19,
                                                           Color = Color.FromName("colors[7]")
                                                       }
                                                   }
                                       )
                               }
                           })
                .InFunction("DrawChart")
                .AddJavascripVariable("colors", "Highcharts.getOptions().colors")
                .AddJavascripFunction("TooltipFormatter",
                                      @"var s;
                    if (this.point.name) { // the pie chart
                       s = ''+
                          this.point.name +': '+ this.y +' fruits';
                    } else {
                       s = ''+
                          this.x  +': '+ this.y;
                    }
                    return s;");

            return View(chart);
        }

        public ActionResult MultipleCharts()
        {
            Highcharts chart1 = new Highcharts("chart1")
                .InitChart(new Chart { Type = ChartTypes.Column })
                .SetTitle(new Title { Text = "Chart 1" })
                .SetXAxis(new XAxis
                          {
                              Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                          })
                .SetSeries(new Series
                           {
                               Data = new Data(new object[] { 29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 })
                           });

            Highcharts chart2 = new Highcharts("chart2")
                .InitChart(new Chart { Type = ChartTypes.Bar })
                .SetTitle(new Title { Text = "Chart 2" })
                .SetXAxis(new XAxis
                          {
                              Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                          })
                .SetSeries(new Series
                           {
                               Data = new Data(new object[] { 29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 })
                           })
                .InFunction("DrawChart2");

            Highcharts chart3 = new Highcharts("chart3")
                .InitChart(new Chart { Type = ChartTypes.Spline })
                .SetTitle(new Title { Text = "Chart 3" })
                .SetXAxis(new XAxis
                          {
                              Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                          })
                .SetSeries(new Series
                           {
                               Data = new Data(new object[] { 29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 })
                           })
                .InFunction("DrawChart3");

            Highcharts chart4 = new Highcharts("chart4")
                .SetTitle(new Title { Text = "Chart 4" })
                .SetXAxis(new XAxis
                          {
                              Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                          })
                .SetSeries(new Series
                           {
                               Data = new Data(new object[] { 29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 })
                           });

            return View(new Container(new[] { chart1, chart2, chart3, chart4 }));
        }

        public ActionResult DisableAnimation()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { Type = ChartTypes.Column })
                .SetTitle(new Title { Text = "Disabled animation" })
                .SetPlotOptions(new PlotOptions { Column = new PlotOptionsColumn { Animation = new Animation(false) } })
                .SetXAxis(new XAxis
                          {
                              Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                          })
                .SetSeries(new Series
                           {
                               Data = new Data(new object[] { 29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 })
                           });
            return View(chart);
        }

        public ActionResult EaseOutBounceEffect()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { Type = ChartTypes.Column })
                .SetTitle(new Title { Text = "EaseOutBounce Effect" })
                .SetPlotOptions(new PlotOptions { Column = new PlotOptionsColumn { Animation = new Animation(new AnimationConfig { Duration = 2000, Easing = EasingTypes.EaseOutBounce }) } })
                .SetXAxis(new XAxis
                          {
                              Categories = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }
                          })
                .SetSeries(new Series
                           {
                               Data = new Data(new object[] { 29.9, 71.5, 106.4, 129.2, 111 })
                           });
            return View(chart);
        }

        public ActionResult BindDecimalValues()
        {
            List<decimal> values = new List<decimal> { (decimal)29.9, (decimal)71.5, (decimal)106.4, (decimal)129.2, 111 };
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { Type = ChartTypes.Spline })
                .SetTitle(new Title { Text = "Chart with decimal values" })
                .SetXAxis(new XAxis
                          {
                              Categories = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }
                          })
                .SetSeries(new Series
                           {
                               Data = new Data(values.Select(x => (object)x).ToArray())
                           });
            return View(chart);
        }

        public ActionResult UseDotNetGlobalization()
        {
            Highcharts chart = new Highcharts("chart")
                .SetXAxis(new XAxis { Type = AxisTypes.Datetime })
                .SetTitle(new Title { Text = "Using .NET Globalization (German)" })
                .SetOptions(new GlobalOptions { Lang = new Helpers.Lang().SetAndUseCulture("de-DE"), Global = new Global { UseUTC = false } })
                .SetSeries(new Series
                           {
                               PlotOptionsSeries = new PlotOptionsSeries
                                                   {
                                                       PointStart = new PointStart(new DateTime(2012, 1, 1)),
                                                       PointInterval = 3600 * 1000 * 24 * 10 // one day
                                                   },
                               Data = new Data(new object[] { 8929.9, 9071.5, 7106.4, 10129.2, 8144.0, 8176.9, 7135.6, 9148.5, 10216.4, 8194.1, 8995.6, 7754.4 })
                           });
            return View(chart);
        }

        public ActionResult BindDataFromDictionary()
        {
            Dictionary<DateTime, int> data = new Dictionary<DateTime, int>
                                             {
                                                 { DateTime.Now.AddDays(-10).Date, 123 },
                                                 { DateTime.Now.AddDays(-9).Date, 223 },
                                                 { DateTime.Now.AddDays(-8).Date, 103 },
                                                 { DateTime.Now.AddDays(-7).Date, 23 },
                                                 { DateTime.Now.AddDays(-6).Date, 183 },
                                                 { DateTime.Now.AddDays(-5).Date, 143 },
                                                 { DateTime.Now.AddDays(-4).Date, 153 },
                                                 { DateTime.Now.AddDays(-3).Date, 173 },
                                                 { DateTime.Now.AddDays(-2).Date, 133 },
                                                 { DateTime.Now.AddDays(-1).Date, 113 },
                                                 { DateTime.Now.Date, 123 }
                                             };

            object[,] chartData = new object[data.Count, 2];
            int i = 0;
            foreach (KeyValuePair<DateTime, int> pair in data)
            {
                chartData.SetValue(pair.Key, i, 0);
                chartData.SetValue(pair.Value, i, 1);
                i++;
            }

            Highcharts chart1 = new Highcharts("chart1")
                .InitChart(new Chart { Type = ChartTypes.Area })
                .SetTitle(new Title { Text = "Chart 1" })
                .SetXAxis(new XAxis { Type = AxisTypes.Datetime })
                .SetSeries(new Series { Data = new Data(chartData) });

            return View(chart1);
        }

        public ActionResult BindDataFromObjectList()
        {
            List<DataClass> data = new List<DataClass>
                                   {
                                       new DataClass { ExecutionDate = DateTime.Now.AddDays(-10).Date, ExecutionValue = 20.21 },
                                       new DataClass { ExecutionDate = DateTime.Now.AddDays(-9).Date, ExecutionValue = 23.13 },
                                       new DataClass { ExecutionDate = DateTime.Now.AddDays(-8).Date, ExecutionValue = 27.41 },
                                       new DataClass { ExecutionDate = DateTime.Now.AddDays(-7).Date, ExecutionValue = 30.51 },
                                       new DataClass { ExecutionDate = DateTime.Now.AddDays(-6).Date, ExecutionValue = 21.16 },
                                       new DataClass { ExecutionDate = DateTime.Now.AddDays(-5).Date, ExecutionValue = 22.17 },
                                       new DataClass { ExecutionDate = DateTime.Now.AddDays(-4).Date, ExecutionValue = 33.18 },
                                       new DataClass { ExecutionDate = DateTime.Now.AddDays(-3).Date, ExecutionValue = 34.91 },
                                       new DataClass { ExecutionDate = DateTime.Now.AddDays(-2).Date, ExecutionValue = 40.10 },
                                       new DataClass { ExecutionDate = DateTime.Now.AddDays(-1).Date, ExecutionValue = 50.11 },
                                       new DataClass { ExecutionDate = DateTime.Now.Date, ExecutionValue = 20.1 },
                                   };
            object[,] chartData = new object[data.Count, 2];
            int i = 0;
            foreach (DataClass item in data)
            {
                chartData.SetValue(item.ExecutionDate, i, 0);
                chartData.SetValue(item.ExecutionValue, i, 1);
                i++;
            }

            Highcharts chart1 = new Highcharts("chart1")
                .InitChart(new Chart { Type = ChartTypes.Column })
                .SetTitle(new Title { Text = "Chart 1" })
                .SetXAxis(new XAxis { Type = AxisTypes.Datetime })
                .SetSeries(new Series { Data = new Data(chartData) });

            return View(chart1);
        }

        public ActionResult CustomTheme()
        {
            Highcharts chart = new Highcharts("chart")
                .SetOptions(new GlobalOptions
                            {
                                Colors = new[]
                                         {
                                             ColorTranslator.FromHtml("#DDDF0D"),
                                             ColorTranslator.FromHtml("#7798BF"),
                                             ColorTranslator.FromHtml("#55BF3B"),
                                             ColorTranslator.FromHtml("#DF5353"),
                                             ColorTranslator.FromHtml("#DDDF0D"),
                                             ColorTranslator.FromHtml("#aaeeee"),
                                             ColorTranslator.FromHtml("#ff0066"),
                                             ColorTranslator.FromHtml("#eeaaee")
                                         }
                            })
                .InitChart(new Chart
                           {
                               BorderWidth = 0,
                               BorderRadius = 15,
                               PlotBackgroundColor = null,
                               PlotShadow = false,
                               PlotBorderWidth = 0,
                               BackgroundColor = new BackColorOrGradient(new Gradient
                                                                         {
                                                                             LinearGradient = new[] { 0, 0, 0, 400 },
                                                                             Stops = new object[,]
                                                                                     {
                                                                                         { 0, Color.FromArgb(255, 96, 96, 96) },
                                                                                         { 1, Color.FromArgb(255, 16, 16, 16) }
                                                                                     }
                                                                         })
                           })
                .SetTitle(new Title
                          {
                              Text = "Gray Theme",
                              Style = "color: '#FFF', font: '16px Lucida Grande, Lucida Sans Unicode, Verdana, Arial, Helvetica, sans-serif'"
                          })
                .SetSubtitle(new Subtitle { Style = "color: '#DDD', font: '12px Lucida Grande, Lucida Sans Unicode, Verdana, Arial, Helvetica, sans-serif'" })
                .SetXAxis(new XAxis
                          {
                              GridLineWidth = 0,
                              LineColor = ColorTranslator.FromHtml("#999"),
                              TickColor = ColorTranslator.FromHtml("#999"),
                              Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" },
                              Labels = new XAxisLabels { Style = "color: '#999', fontWeight: 'bold'" },
                              Title = new XAxisTitle { Style = "color: '#AAA', font: 'bold 12px Lucida Grande, Lucida Sans Unicode, Verdana, Arial, Helvetica, sans-serif'" }
                          })
                .SetYAxis(new YAxis
                          {
                              AlternateGridColor = null,
                              MinorTickInterval = null,
                              GridLineColor = Color.FromArgb(255, 255, 255, 255),
                              LineWidth = 0,
                              TickWidth = 0,
                              Labels = new YAxisLabels { Style = "color: '#999',fontWeight: 'bold'" },
                              Title = new YAxisTitle { Style = "color: '#AAA',font: 'bold 12px Lucida Grande, Lucida Sans Unicode, Verdana, Arial, Helvetica, sans-serif'" }
                          })
                .SetLegend(new Legend
                           {
                               ItemStyle = "color: '#CCC'",
                               ItemHoverStyle = "color: '#FFF'",
                               ItemHiddenStyle = "color: '#333'"
                           })
                .SetLabels(new Labels { Style = "color: '#CCC'" })
                .SetTooltip(new Tooltip
                            {
                                BorderWidth = 0,
                                Style = "color: '#FFF'",
                                BackgroundColor = new BackColorOrGradient(new Gradient
                                                                          {
                                                                              LinearGradient = new[] { 0, 0, 0, 50 },
                                                                              Stops = new object[,]
                                                                                      {
                                                                                          { 0, Color.FromArgb(200, 96, 96, 96) },
                                                                                          { 1, Color.FromArgb(200, 16, 16, 16) }
                                                                                      }
                                                                          })
                            })
                .SetPlotOptions(new PlotOptions
                                {
                                    Line = new PlotOptionsLine
                                           {
                                               DataLabels = new PlotOptionsLineDataLabels { Color = ColorTranslator.FromHtml("#CCC") },
                                               Marker = new PlotOptionsLineMarker { LineColor = ColorTranslator.FromHtml("#333") }
                                           },
                                    Spline = new PlotOptionsSpline { Marker = new PlotOptionsSplineMarker { LineColor = ColorTranslator.FromHtml("#333") } },
                                    Scatter = new PlotOptionsScatter { Marker = new PlotOptionsScatterMarker { LineColor = ColorTranslator.FromHtml("#333") } }
                                })
                .SetNavigation(new Navigation { ButtonOptions = new NavigationButtonOptions { SymbolStroke = ColorTranslator.FromHtml("#C0C0C0") } })
                .SetSeries(new Series
                           {
                               Data = new Data(new object[] { 29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 })
                           });

            return View(chart);
        }

        public ActionResult TooltipCrosshairs()
        {
            Highcharts chart = new Highcharts("chart")
                .SetTitle(new Title { Text = "Tooltip Crosshairs" })
                .SetTooltip(new Tooltip
                            {
                                Crosshairs = new Crosshairs(
                                    new CrosshairsForamt
                                    {
                                        Width = 3,
                                        Color = Color.Red
                                    },
                                    new CrosshairsForamt
                                    {
                                        Width = 3,
                                        Color = Color.Aqua
                                    }
                                    )
                            })
                .SetXAxis(new XAxis
                          {
                              Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                          })
                .SetSeries(new Series
                           {
                               Data = new Data(new object[] { 29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 })
                           });

            return View(chart);
        }

        public ActionResult CrosshairsWithBooleanValues()
        {
            Highcharts chart = new Highcharts("chart")
                .SetXAxis(new XAxis
                    {
                        Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                    })
                .SetSeries(new Series
                    {
                        Data = new Data(new object[] { 29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 })
                    }).SetTooltip(new Tooltip { Shared = true, Crosshairs = new Crosshairs(true, true), Enabled = true });
            return View(chart);
        }

        public ActionResult ThemingTheResetButton()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart
                           {
                               ZoomType = ZoomTypes.X,
                               ResetZoomButton = new ChartResetZoomButton
                                                 {
                                                     Theme = new Theme
                                                             {
                                                                 Fill = Color.White,
                                                                 Stroke = Color.Silver,
                                                                 R = 0,
                                                                 States = new ThemeStates
                                                                          {
                                                                              Hover = new ThemeStatesHover
                                                                                      {
                                                                                          Fill = ColorTranslator.FromHtml("#41739D"),
                                                                                          Style = "color: 'white'"
                                                                                      }
                                                                          }
                                                             }
                                                 }
                           })
                .SetTitle(new Title { Text = "Theming the reset button" })
                .SetXAxis(new XAxis
                          {
                              Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                          })
                .SetSeries(new Series
                           {
                               Data = new Data(new object[] { 29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 })
                           });

            return View(chart);
        }

        public ActionResult PlotBandEvents()
        {
            Highcharts chart = new Highcharts("chart")
                .SetTitle(new Title { Text = "Plot band events" })
                .SetXAxis(new XAxis
                          {
                              TickInterval = 24 * 3600 * 1000, // one day
                              Type = AxisTypes.Datetime,
                              PlotBands = new[]
                                          {
                                              new XAxisPlotBands
                                              {
                                                  Color = ColorTranslator.FromHtml("#FCFFC5"),
                                                  From = Tools.GetTotalMilliseconds(new DateTime(2010, 1, 2)),
                                                  To = Tools.GetTotalMilliseconds(new DateTime(2010, 1, 4)),
                                                  Events = new Events
                                                           {
                                                               Click = "function(e) { $('#report').html(e.type); }",
                                                               Mouseover = "function(e) { $('#report').html(e.type); }",
                                                               Mouseout = "function(e) { $('#report').html(e.type); }",
                                                           }
                                              }
                                          }
                          })
                .SetPlotOptions(new PlotOptions
                                {
                                    Series = new PlotOptionsSeries
                                             {
                                                 PointStart = new PointStart(new DateTime(2010, 1, 1)),
                                                 PointInterval = 24 * 3600 * 1000
                                             }
                                })
                .SetSeries(new Series
                           {
                               Data = new Data(new object[] { 29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4 })
                           });

            return View(chart);
        }

        public ActionResult TransparentBackground()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart
                           {
                               BackgroundColor = new BackColorOrGradient(new Gradient
                               {
                                   LinearGradient = new[] { 0, 0, 0, 400 },
                                   Stops = new object[,]
            {
                { 0, Color.FromArgb(13, 255, 255, 255) },
                { 1, Color.FromArgb(13, 255, 255, 255) }
            }
                               })
                           })
                .SetTitle(new Title { Text = "Disabled background" })
                .SetPlotOptions(new PlotOptions { Column = new PlotOptionsColumn { Animation = new Animation(false) } })
                .SetXAxis(new XAxis
                          {
                              Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                          })
                .SetSeries(new Series
                           {
                               Data = new Data(new object[] { 29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 })
                           });
            return View(chart);
        }

        public ActionResult PieChartWithEvents()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart())
                .SetPlotOptions(new PlotOptions
                {
                    Pie = new PlotOptionsPie
                    {
                        AllowPointSelect = true,
                        Cursor = Cursors.Pointer,
                        ShowInLegend = true,
                        Events = new PlotOptionsPieEvents { Click = "function(event) { alert('The slice was clicked!'); }" },
                        Point = new PlotOptionsPiePoint { Events = new PlotOptionsPiePointEvents { LegendItemClick = "function(event) { if (!confirm('Do you want to toggle the visibility of this slice?')) { return false; } }" } }
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
                                        new object[] { "Chrome", 12.8},
                                        new object[] { "Safari", 8.5 },
                                        new object[] { "Opera", 6.2 },
                                        new object[] { "Other\\'s", 0.7 }
                                    })
                });

            return View(chart);
        }
    }
}