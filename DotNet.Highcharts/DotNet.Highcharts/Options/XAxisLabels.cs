using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// The axis labels show the number or category for each tick.
	/// </summary>
	public class XAxisLabels
	{
		/// <summary>
		/// What part of the string the given position is anchored to.  Can be one of <code>'left'</code>, <code>'center'</code> or <code>'right'</code>. In inverted charts, x axis label alignment and y axis alignment are swapped.
		/// Default: center
		/// </summary>
		public HorizontalAligns? Align { get; set; }

		/// <summary>
		/// Enable or disable the axis labels.
		/// Default: true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// A <a href='http://docs.highcharts.com#formatting'>format string</a> for the axis label. 
		/// </summary>
		public string Format { get; set; }

		/// <summary>
		/// Callback JavaScript function to format the label. The value is  given by <code>this.value</code>. Additional properties for <code>this</code> are <code>axis</code>, <code>chart</code>, <code>isFirst</code> and <code>isLast</code>. Defaults to: <pre>function() { return this.value;}</pre>
		/// </summary>
		[JsonFormatter("{0}")]
		public string Formatter { get; set; }

		/// <summary>
		/// How to handle overflowing labels on horizontal axis. Can be undefined or 'justify'. If 'justify', labels will not render outside the plot area. If there is room to move it, it will be aligned to the edge, else it will be removed.
		/// </summary>
		public string Overflow { get; set; }

		/// <summary>
		/// Rotation of the labels in degrees.
		/// Default: 0
		/// </summary>
		public Number? Rotation { get; set; }

		/// <summary>
		/// Horizontal axes only. The number of lines to spread the labels over to make room or tighter labels.  .
		/// </summary>
		public Number? StaggerLines { get; set; }

		/// <summary>
		/// To show only every <em>n</em>'th label on the axis, set the step to <em>n</em>. Setting the step to 2 shows every other label.
		/// </summary>
		public Number? Step { get; set; }

		/// <summary>
		/// CSS styles for the label. Defaults to:<pre>style: { color: '#6D869F', fontWeight: 'bold'}</pre>
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// Whether to use HTML to render the labels. Using HTML allows advanced formatting, images and reliable bi-directional text rendering. Note that exported images won't respect the HTML, and that HTML won't respect Z-index settings.
		/// Default: false
		/// </summary>
		public bool? UseHTML { get; set; }

		/// <summary>
		/// The x position offset of the label relative to the tick position on the axis.
		/// Default: 0
		/// </summary>
		public Number? X { get; set; }

		/// <summary>
		/// The y position offset of the label relative to the tick position on the axis.
		/// Default: 0
		/// </summary>
		public Number? Y { get; set; }

		/// <summary>
		/// The Z index for the axis labels.
		/// Default: 7
		/// </summary>
		public Number? ZIndex { get; set; }

	}

}