using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class YAxisTitle : XAxisTitle
	{
		/// <summary>
		/// The pixel distance between the axis labels and the title. Positive
		/// values are outside the axis line, negative are inside. Defaults to 40
		/// </summary>
		public Number? Margin { get; set; }

		/// <summary>
		/// The rotation of the text in degrees. 0 is horizontal, 270 is 
		/// vertical reading from bottom to top. Defaults to 270
		/// </summary>
		public Number? Rotation { get; set; }

		/// <summary>
		/// The actual text of the axis title. Horizontal texts can contain HTML, 
		/// but rotated texts are painted using vector techniques and must be 
		/// clean text. The Y axis title is disabled by setting the text
		/// option to null. Defaults to "Y-values"
		/// </summary>
		public string Text { get; set; }

	}

}