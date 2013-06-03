using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class YAxisTitle
	{
		/// <summary>
		/// Alignment of the title relative to the axis values. Possible values are 'low', 'middle' or 'high'.
		/// Default: middle
		/// </summary>
		public AxisTitleAligns? Align { get; set; }

		[Obsolete("Deprecated. Set the <code>text</code> to <code>null</code> to disable the title.")]
		public string Enabled { get; set; }

		/// <summary>
		/// The pixel distance between the axis labels and the title. Positive values are outside the axis line, negative are inside.
		/// Default: 40
		/// </summary>
		public Number? Margin { get; set; }

		/// <summary>
		/// The distance of the axis title from the axis line. By default, this distance is  computed from the offset width of the labels, the labels' distance from  the axis and the title's margin. However when the offset option is set, it overrides all this.
		/// </summary>
		public Number? Offset { get; set; }

		/// <summary>
		/// The rotation of the text in degrees. 0 is horizontal, 270 is  vertical reading from bottom to top.
		/// Default: 270
		/// </summary>
		public Number? Rotation { get; set; }

		/// <summary>
		/// CSS styles for the title. When titles are rotated they are rendered using vector graphic techniques and not all styles are applicable. Defaults to: <pre>style: { color: '#6D869F', fontWeight: 'bold'}</pre>
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// The actual text of the axis title. Horizontal texts can contain HTML,  but rotated texts are painted using vector techniques and must be  clean text. The Y axis title is disabled by setting the <code>text</code> option to <code>null</code>.
		/// Default: Values
		/// </summary>
		public string Text { get; set; }

	}

}