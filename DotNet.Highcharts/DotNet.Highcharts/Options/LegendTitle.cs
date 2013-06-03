using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// A title to be added on top of the legend.
	/// </summary>
	public class LegendTitle
	{
		/// <summary>
		/// Generic CSS styles for the legend title. Defaults to:<pre>style: {   fontWeight: 'bold'}</pre>
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// A text or HTML string for the title. 
		/// Default: null
		/// </summary>
		public string Text { get; set; }

	}

}