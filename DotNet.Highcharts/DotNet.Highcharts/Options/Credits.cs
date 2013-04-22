using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// Highchart by default puts a credits label in the lower right corner of the chart.
	/// This can be changed using these options.
	/// </summary>
	public class Credits
	{
		/// <summary>
		/// Whether to show the credits text. Defaults to true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// Position configuration for the credtis label. Supported properties are 
		/// align, verticalAlign, x and y.
		/// Defaults to 
		/// position: {
		/// align: 'right',
		/// x: -10,
		/// verticalAlign: 'bottom',
		/// y: -5
		/// }
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// The URL for the credits label. Defaults to "http://www.highcharts.com"
		/// </summary>
		public string Href { get; set; }

		/// <summary>
		/// CSS styles for the credits label. Defaults to:
		/// itemStyle: {
		/// cursor: 'pointer',
		/// color: '#909090',
		/// fontSize: '10px'
		/// 
		/// }
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// The text for the credits label. Defaults to "Highcharts.com"
		/// </summary>
		public string Text { get; set; }

	}

}