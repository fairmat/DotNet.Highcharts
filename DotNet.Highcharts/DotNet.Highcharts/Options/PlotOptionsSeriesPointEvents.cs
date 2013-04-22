using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// Events for each single point
	/// </summary>
	public class PlotOptionsSeriesPointEvents
	{
		/// <summary>
		/// Fires when a point is clicked. The this keyword refers to the 
		/// point object itself. One parameter, event, is passed to the function.
		/// This contains common event information based on jQuery or MooTools depending on 
		/// which library is used as the base for Highcharts.
		/// If the series.allowPointSelect
		/// option is true, the default action for the point's click event is to toggle the
		/// point's select state. Returning false cansels this action.
		/// </summary>
		[JsonFormatter("{0}")]
		public string Click { get; set; }

		/// <summary>
		/// Fires when the mouse enters the area close to the point. The this keyword refers to the 
		/// point object itself. One parameter, event, is passed to the function.
		/// This contains common event information based on jQuery or MooTools depending on 
		/// which library is used as the base for Highcharts.
		/// </summary>
		[JsonFormatter("{0}")]
		public string MouseOver { get; set; }

		/// <summary>
		/// Fires when the mouse leaves the area close to the point. The this keyword refers to the 
		/// point object itself. One parameter, event, is passed to the function.
		/// This contains common event information based on jQuery or MooTools depending on 
		/// which library is used as the base for Highcharts.
		/// </summary>
		[JsonFormatter("{0}")]
		public string MouseOut { get; set; }

		/// <summary>
		/// Fires when the point is removed using the .remove() method. The this keyword refers to the 
		/// point object itself. One parameter, event, is passed to the function.
		/// Returning false cancels the operation.
		/// </summary>
		[JsonFormatter("{0}")]
		public string Remove { get; set; }

		/// <summary>
		/// Fires when the point is selected either programatically or following a click
		/// on the point. The this keyword refers to the 
		/// point object itself. One parameter, event, is passed to the function.
		/// Returning false cancels the operation.
		/// </summary>
		[JsonFormatter("{0}")]
		public string Select { get; set; }

		/// <summary>
		/// Fires when the point is unselected either programatically or following a click
		/// on the point. The this keyword refers to the 
		/// point object itself. One parameter, event, is passed to the function.
		/// Returning false cancels the operation.
		/// </summary>
		[JsonFormatter("{0}")]
		public string Unselect { get; set; }

		/// <summary>
		/// Fires when the point is updated programmatically through the .update()
		/// method. The this keyword refers to the 
		/// point object itself. One parameter, event, is passed to the function. The 
		/// new point options can be accessed through event.options.
		/// Returning false cancels the operation.
		/// </summary>
		[JsonFormatter("{0}")]
		public string Update { get; set; }

	}

}