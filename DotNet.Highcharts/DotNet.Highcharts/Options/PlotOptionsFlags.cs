using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsFlags : PlotOptionsSeries
	{

        /// <summary>
        /// An id for the series. This can be used after render time to get a pointer
        /// to the series object through chart.get(). Defaults to null.
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// The id of the series that the flags should be drawn on. 
        /// If no id is given, the flags are drawn on the x axis. 
        /// Defaults to undefined.
        /// </summary>
        string OnSeries { get; set; }
	}
}