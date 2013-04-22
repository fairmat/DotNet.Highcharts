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
		/// What part of the string the given position is anchored to. 
		/// Can be one of "left",
		/// "center" or "right". In inverted charts,
		/// x axis label alignment and y axis alignment are swapped. Defaults to "center"
		/// </summary>
		public HorizontalAligns? Align { get; set; }

		/// <summary>
		/// Enable or disable the axis labels. Defaults to true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// Callback JavaScript function to format the label. The value is 
		/// given by this.value. Additional properties for this are
		/// axis, chart, isFirst and isLast.
		/// Defaults to: 
		/// function() {
		/// return this.value;
		/// }
		/// </summary>
		[JsonFormatter("{0}")]
		public string Formatter { get; set; }

		/// <summary>
		/// Rotation of the labels in degrees. Defaults to 0
		/// </summary>
		public Number? Rotation { get; set; }

		/// <summary>
		/// Horizontal axes only. The number of lines to spread the labels over to make room
		/// or tighter labels. Defaults to null
		/// </summary>
		public Number? StaggerLines { get; set; }

		/// <summary>
		/// To show only every n'th label on the axis, set the step to n. Setting the step to 2 shows every other label. Defaults to null
		/// </summary>
		public Number? Step { get; set; }

		/// <summary>
		/// CSS styles for the label. Defaults to:
		/// style: {
		/// color: '#6D869F',
		/// fontWeight: 'bold'
		/// }
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// The x position offset of the label relative to the tick position
		/// on the axis. Defaults to 0
		/// </summary>
		public Number? X { get; set; }

		/// <summary>
		/// The y position offset of the label relative to the tick position
		/// on the axis. Defaults to 0
		/// </summary>
		public Number? Y { get; set; }

	}

}