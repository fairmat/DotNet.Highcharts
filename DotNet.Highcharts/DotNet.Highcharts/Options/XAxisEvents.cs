using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// Event handlers for the axis.
	/// </summary>
	public class XAxisEvents
	{
		/// <summary>
		/// As opposed to the <code>setExtremes</code> event, this event fires after the final min and max values are computed and corrected for <code>minRange</code>.
		/// </summary>
		[JsonFormatter("{0}")]
		public string AfterSetExtremes { get; set; }

		/// <summary>
		/// Fires when the minimum and maximum is set for the axis, either by calling the <code>.setExtremes()</code> method or by selecting an area in the chart. The <code>this</code>  keyword refers to the axis object itself. One parameter, <code>event</code>, is passed to the function.  This contains common event information based on jQuery or MooTools depending on which  library is used as the base for Highcharts. The new user set minimum and maximum values can be found by <code>event.min</code> and <code>event.max</code>.
		/// </summary>
		[JsonFormatter("{0}")]
		public string SetExtremes { get; set; }

	}

}