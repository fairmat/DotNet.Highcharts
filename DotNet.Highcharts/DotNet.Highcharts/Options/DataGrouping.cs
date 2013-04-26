using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// Options regarding the grouping of data for the plotting.
	/// </summary>
	public class DataGrouping
	{
        /// <summary>
        /// Enable or disable data grouping. Defaults to true.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// When data grouping is forced, it runs no matter how small the intervals are.
        /// This can be handy for example when the sum should be calculated for
        /// values appearing at random times within each hour. Defaults to false.
        /// </summary>
        public bool? Forced { get; set; }

        /// <summary>
        /// The approximate pixel width of each group. If for example a series with
        /// 30 points is displayed over a 600 pixel wide plot area,
        /// no grouping is performed. If however the series contains so many points
        /// that the spacing is less than the groupPixelWidth, Highcharts will try
        /// to group it into appropriate groups so that each is more or less two
        /// pixels wide. If multiple series with different group pixel widths are
        /// drawn on the same x axis, all series will take the greatest width.
        /// For example, line series have 2px default group width, while column
        /// series have 10px. If combined, both the line and the column will have
        /// 10px by default. Defaults to 2.
        /// </summary>
        public Number? GroupPixelWidth { get; set; }

        /// <summary>
        /// Normally, a group is indexed by the start of that group, so for
        /// example when 30 daily values are grouped into one month, that
        /// month's x value will be the 1st of the month. This apparently
        /// shifts the data to the left. When the smoothed option is true,
        /// this is compensated for. The data is shifted to the middle of the
        /// group, and min and max values are preserved. Internally, this is
        /// used in the Navigator series. Defaults to false. Defaults to false.
        /// </summary>
        public bool? Smoothed { get; set; }
	}
}