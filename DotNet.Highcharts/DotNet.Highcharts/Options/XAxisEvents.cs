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
		/// Fires when the minimum and maximum is set for the axis, either by calling the
		/// .setExtremes() method or by selecting an area in the chart. The this 
		/// keyword refers to the axis object itself. One parameter, event, is passed to the function. 
		/// This contains common event information based on jQuery or MooTools depending on which 
		/// library is used as the base for Highcharts. The new user set minimum and maximum values
		/// can be found by event.min and event.max.
		/// </summary>
		[JsonFormatter("{0}")]
		public string SetExtremes { get; set; }

	}

}