using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

/// TODO: baseSeries, handles, maskFill, outlineColor, series, xAxis, yAxis.
namespace DotNet.Highcharts.Options
{
	/// <summary>
    /// The navigator is a small series below the main series, displaying a view of
    /// the entire data set. It provides tools to zoom in and out on parts of the
    /// data as well as panning across the dataset.
	/// </summary>
	public class Navigator
	{
        /// <summary>
        /// Whether the navigator and scrollbar should adapt to updated data in the base X axis.
        /// This should be false when loading data asynchronously, to prevent circular loading.
        /// Defaults to true.
        /// </summary>
        public bool? AdaptToUpdatedData { get; set; }

        /// <summary>
        /// Enable or disable the navigator. Defaults to true.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// The height of the navigator. Defaults to 40.
        /// </summary>
        public Number? Height { get; set; }

        /// <summary>
        /// The distance from the nearest element, the X axis or X axis labels. Defaults to 10.
        /// </summary>
        public Number? Margin { get; set; }

        /// <summary>
        /// The width of the line marking the currently zoomed area in the navigator.
        /// Defaults to 2.
        /// </summary>
        public Number? OutlineWidth { get; set; }
	}
}