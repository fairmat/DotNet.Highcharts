using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsSeriesEvents
	{
		/// <summary>
		/// Fires when the series is clicked. The this keyword refers to the 
		/// series object itself. One parameter, event, is passed to the function.
		/// This contains common event information based on jQuery or MooTools depending on 
		/// which library is used as the base for Highcharts. Additionally, event.point
		/// holds a pointer to the nearest point on the graph.
		/// </summary>
		[JsonFormatter("{0}")]
		public string Click { get; set; }

		/// <summary>
		/// Fires when the checkbox next to the series' name in the legend is clicked.. The this keyword refers to the 
		/// series object itself. One parameter, event, is passed to the function.
		/// The state of the checkbox is found by event.checked. Return false
		/// to prevent the default action which is to toggle the select state of the series.
		/// </summary>
		[JsonFormatter("{0}")]
		public string CheckboxClick { get; set; }

		/// <summary>
		/// Fires when the series is hidden after chart generation time, either by clicking
		/// the legend item or by calling .hide().
		/// </summary>
		[JsonFormatter("{0}")]
		public string Hide { get; set; }

		/// <summary>
		/// Fires when the legend item belonging to the series is clicked. 
		/// The this keyword refers to the 
		/// series object itself. One parameter, event, is passed to the function.
		/// This contains common event information based on jQuery or MooTools depending on 
		/// which library is used as the base for Highcharts. The default action is to toggle
		/// the visibility of the series. This can be prevented by returning false
		/// or calling event.preventDefault().
		/// </summary>
		[JsonFormatter("{0}")]
		public string LegendItemClick { get; set; }

		/// <summary>
		/// Fires when the mouse enters the graph. The this keyword refers to the 
		/// series object itself. One parameter, event, is passed to the function.
		/// This contains common event information based on jQuery or MooTools depending on 
		/// which library is used as the base for Highcharts.
		/// </summary>
		[JsonFormatter("{0}")]
		public string MouseOver { get; set; }

		/// <summary>
		/// Fires when the mouse leaves the graph. The this keyword refers to the 
		/// series object itself. One parameter, event, is passed to the function.
		/// This contains common event information based on jQuery or MooTools depending on 
		/// which library is used as the base for Highcharts. If the 
		/// stickyTracking option is true,
		/// mouseOut doesn't happen before the mouse enters another graph or leaves
		/// the plot area.
		/// </summary>
		[JsonFormatter("{0}")]
		public string MouseOut { get; set; }

		/// <summary>
		/// Fires when the series is shown after chart generation time, either by clicking
		/// the legend item or by calling .show().
		/// </summary>
		[JsonFormatter("{0}")]
		public string Show { get; set; }

	}

}