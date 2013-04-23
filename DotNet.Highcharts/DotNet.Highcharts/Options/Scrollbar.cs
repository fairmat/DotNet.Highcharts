using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

/// TODO: barBackgroundColor, barBorderColor, buttonArrowColor, buttonBackgroundColor,
///       buttonBorderColor, rifleColor, trackBackgroundColor, trackBorderColor, trackBorderWidth.
namespace DotNet.Highcharts.Options
{
	/// <summary>
    /// The scrollbar is a means of panning over the X axis of a chart.
	/// </summary>
	public class Scrollbar
	{
        /// <summary>
        /// The border rounding radius of the bar. Defaults to 2.
        /// </summary>
        public Number? BarBorderRadius { get; set; }

        /// <summary>
        /// The width of the bar's border. Defaults to 1.
        /// </summary>
        public Number? BarBorderWidth { get; set; }

        /// <summary>
        /// The corner radius of the scrollbar buttons. Defaults to 2.
        /// </summary>
        public Number? ButtonBorderRadius { get; set; }

        /// <summary>
        /// The border width of the scrollbar buttons. Defaults to 1.
        /// </summary>
        public Number? ButtonBorderWidth { get; set; }

        /// <summary>
        /// Enable or disable the scrollbar. Defaults to true.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// The height of the scrollbar. The height also applies to the width of the
        /// scroll arrows so that they are always squares.
        /// Defaults to 20 for touch devices and 14 for mouse devices.
        /// </summary>
        public Number? Height { get; set; }

        /// <summary>
        /// Whether to redraw the main chart as the scrollbar or the navigator 
        /// zoomed window is moved.
        /// Defaults to true for modern browsers and false for legacy IE browsers.
        /// </summary>
        public bool? LiveRedraw { get; set; }

        /// <summary>
        /// The minimum width of the scrollbar. Defaults to 6.
        /// </summary>
        public Number? MinWidth { get; set; }

        /// <summary>
        /// The corner radius of the border of the scrollbar track. Defaults to 0.
        /// </summary>
        public Number? TrackBorderRadius { get; set; }
	}
}