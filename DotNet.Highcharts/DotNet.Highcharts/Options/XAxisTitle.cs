using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// The axis title, showing next to the axis line.
	/// </summary>
	public class XAxisTitle
	{
		/// <summary>
		/// Alignment of the title relative to the axis values. Possible values are 'low', 'middle' or 'high'.
		/// Default: middle
		/// </summary>
		public AxisTitleAligns? Align { get; set; }

		[Obsolete("Deprecated. Set the <code>text</code> to <code>null</code> to disable the title.")]
		public string Enabled { get; set; }

		/// <summary>
		/// The pixel distance between the axis labels or line and the title. Defaults to 0 for horizontal axes, 10 for vertical
		/// </summary>
		public Number? Margin { get; set; }

		/// <summary>
		/// The distance of the axis title from the axis line. By default, this distance is  computed from the offset width of the labels, the labels' distance from  the axis and the title's margin. However when the offset option is set, it overrides all this.
		/// </summary>
		public Number? Offset { get; set; }

		/// <summary>
		/// The rotation of the text in degrees. 0 is horizontal, 270 is vertical reading from bottom to top.
		/// Default: 0
		/// </summary>
		public Number? Rotation { get; set; }

		/// <summary>
		/// CSS styles for the title. When titles are rotated they are rendered using vector graphic techniques and not all styles are applicable. Defaults to: <pre>style: { color: '#6D869F', fontWeight: 'bold'}</pre>
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// The actual text of the axis title. It can contain basic HTML text markup like &lt;b&gt;, &lt;i&gt; and spans with style.
		/// </summary>
		public string Text { get; set; }

	}

}