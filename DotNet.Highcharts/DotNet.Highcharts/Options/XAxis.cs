using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// The X axis or category axis. Normally this is the horizontal axis, though if the 
	/// chart is inverted this is the vertical axis. In case of multiple axes, the xAxis
	/// node is an array of configuration objects.
	/// See the Axis object for programmatic
	/// access to the axis.
	/// </summary>
	public class XAxis
	{
		/// <summary>
		/// Whether to allow decimals in this axis' ticks. When counting integers, like
		/// persons or hits on a web page, decimals must be avoided in the axis tick
		/// labels. Defaults to true
		/// </summary>
		public bool? AllowDecimals { get; set; }

		/// <summary>
		/// When using an alternate grid color, a band is painted across the plot area
		/// between every other grid line. Defaults to null
		/// </summary>
		public Color? AlternateGridColor { get; set; }

		/// <summary>
		/// If categories are present for the xAxis, names are used instead of numbers for that
		/// axis. Example:
		/// categories: ['Apples', 'Bananas', 'Oranges'] Defaults to []
		/// </summary>
		public string[] Categories { get; set; }

		/// <summary>
		/// For a datetime axis, the scale will automatically adjust to the appropriate unit.
		/// This member gives the default string representations used for each unit. For an
		/// overview of the replacement codes, see dateFormat.
		/// Defaults to:
		/// {
		/// second: '%H:%M:%S',
		/// minute: '%H:%M',
		/// hour: '%H:%M',
		/// day: '%e. %b',
		/// week: '%e. %b',
		/// month: '%b \'%y',
		/// year: '%Y'
		/// }
		/// </summary>
		public DateTimeLabel DateTimeLabelFormats { get; set; }

		/// <summary>
		/// Whether to force the axis to end on a tick. Use this option with the maxPadding
		/// option to control the axis end. Defaults to false
		/// </summary>
		public bool? EndOnTick { get; set; }

		/// <summary>
		/// A collection of event handlers.
		/// </summary>
		public XAxisEvents Events { get; set; }

		/// <summary>
		/// Color of the grid lines extending the ticks across the plot area. Defaults to "#C0C0C0"
		/// </summary>
		public Color? GridLineColor { get; set; }

		/// <summary>
		/// The dash or dot style of the grid lines. For possible values, see 
		/// this demonstration. Defaults to Solid
		/// </summary>
		public DashStyles? GridLineDashStyle { get; set; }

		/// <summary>
		/// The width of the grid lines extending the ticks across the plot area. Defaults to 0
		/// </summary>
		public Number? GridLineWidth { get; set; }

		/// <summary>
		/// An id for the axis. This can be used after render time to get a pointer
		/// to the axis object through chart.get(). Defaults to null
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Configuration object for the axis labels, usually displaying the number
		/// for each tick.
		/// </summary>
		public XAxisLabels Labels { get; set; }

		/// <summary>
		/// The color of the line marking the axis itself. Defaults to "#C0D0E0"
		/// </summary>
		public Color? LineColor { get; set; }

		/// <summary>
		/// The width of the line marking the axis itself. Defaults to 1
		/// </summary>
		public Number? LineWidth { get; set; }

		/// <summary>
		/// Index of another axis that this axis is linked to. When an axis is linked to
		/// a master axis, it will take the same extremes as the master, but as assigned by
		/// min or max or by setExtremes. It can be used to show additional info, or to ease
		/// reading the chart by duplicating the scales. Defaults to null
		/// </summary>
		public Number? LinkedTo { get; set; }

		/// <summary>
		/// The maximum value of the axis. If null, the max value is
		/// automatically calculated. If the endOnTick option is
		/// true, the max value might be rounded up.
		/// The actual maximum value is also influenced by 
		/// chart.alignTicks. Defaults to null
		/// </summary>
		public Number? Max { get; set; }

		/// <summary>
		/// Padding of the max value relative to the length of the axis. A padding of 0.05 will make
		/// a 100px axis 5px longer. This is useful when you don't want the highest data
		/// value to appear on the edge of the plot area. When the axis' max
		/// option is set or a max extreme is set using axis.setExtremes(),
		/// the maxPadding will be ignored. Defaults to 0.01
		/// </summary>
		public Number? MaxPadding { get; set; }

		[Obsolete("Deprecated. Renamed to minRange as of Highcharts 2.2.")]
		public Number? MaxZoom { get; set; }

		/// <summary>
		/// The minimum value of the axis. If null the min value is
		/// automatically calculated. If the startOnTick option is
		/// true, the min value might be rounded down. Defaults to null
		/// </summary>
		public Number? Min { get; set; }

		/// <summary>
		/// Color of the minor, secondary grid lines. Defaults to #E0E0E0
		/// </summary>
		public Color? MinorGridLineColor { get; set; }

		/// <summary>
		/// The dash or dot style of the minor grid lines. For possible values, see 
		/// this demonstration. Defaults to Solid
		/// </summary>
		public DashStyles? MinorGridLineDashStyle { get; set; }

		/// <summary>
		/// Width of the minor, secondary grid lines. Defaults to 1
		/// </summary>
		public Number? MinorGridLineWidth { get; set; }

		/// <summary>
		/// Color for the minor tick marks. Defaults to #A0A0A0
		/// </summary>
		public Color? MinorTickColor { get; set; }

		/// <summary>
		/// Tick interval in scale units for the minor ticks. On a linear axis, if "auto", 
		/// the minor tick interval is calculated as a fifth of the tickInterval. If
		/// null, minor ticks are not shown.
		/// On logarithmic axes, the unit is the power of the value. For example, setting
		/// 	the minorTickInterval to 1 puts one tick on each of 0.1, 1, 10, 100 etc. Setting
		/// 	the minorTickInterval to 0.1 produces 9 ticks between 1 and 10, 
		/// 	10 and 100 etc. A minorTickInterval of "auto" on a log axis results in a best guess,
		/// 	attempting to enter approximately 5 minor ticks between each major tick. Defaults to null
		/// </summary>
		public Number? MinorTickInterval { get; set; }

		/// <summary>
		/// The pixel length of the minor tick marks. Defaults to 2
		/// </summary>
		public Number? MinorTickLength { get; set; }

		/// <summary>
		/// The position of the minor tick marks relative to the axis line. Can be
		/// one of inside and outside. Defaults to outside
		/// </summary>
		public TickPositions? MinorTickPosition { get; set; }

		/// <summary>
		/// The pixel width of the minor tick mark. Defaults to 0
		/// </summary>
		public Number? MinorTickWidth { get; set; }

		/// <summary>
		/// Padding of the min value relative to the length of the axis. A padding of 0.05 will make
		/// a 100px axis 5px longer. This is useful when you don't want the lowest data
		/// value to appear on the edge of the plot area. When the axis' min
		/// option is set or a min extreme is set using axis.setExtremes(),
		/// the minPadding will be ignored. Defaults to 0.01
		/// </summary>
		public Number? MinPadding { get; set; }

		/// <summary>
		/// The minimum range to display on this axis. The entire axis will not be allowed
		/// to span over a smaller interval than this. For example, for a datetime axis
		/// the main unit is milliseconds. If minRange is set to 3600000, you can't zoom
		/// in more than to one hour.
		/// The default minRange for the x axis is five times the smallest
		/// interval between any of the data points.
		/// On a logarithmic axis, the unit for the minimum range is the power. So a minRange of
		/// 	1 means that the axis can be zoomed to 10-100, 100-1000, 1000-10000 etc.
		/// </summary>
		public Number? MinRange { get; set; }

		/// <summary>
		/// The distance in pixels from the plot area to the axis line. A positive offset
		/// moves the axis with it's line, labels and ticks away from the plot area. This
		/// is typically used when two or more axes are displayed on the same side of the
		/// plot. Defaults to 0
		/// </summary>
		public Number? Offset { get; set; }

		/// <summary>
		/// Whether to display the axis on the opposite side of the normal. The normal
		/// is on the left side for vertical axes and bottom for horizontal, so the opposite
		/// sides will be right and top respectively. This is typically used with dual or
		/// multiple axes. Defaults to false
		/// </summary>
		public bool? Opposite { get; set; }

		/// <summary>
		/// An array of configuration objects for plot bands colouring parts of the 
		/// plot area background. Defaults to null
		/// </summary>
		public XAxisPlotBands[] PlotBands { get; set; }

		/// <summary>
		/// An array of configuration objects for plot lines marking specific values in 
		/// the plot area. Defaults to null
		/// </summary>
		public XAxisPlotLines[] PlotLines { get; set; }

		/// <summary>
		/// Whether to reverse the axis so that the highest number is closest to origo.
		/// If the chart is inverted, the x axis is reversed by default. Defaults to false
		/// </summary>
		public bool? Reversed { get; set; }

		/// <summary>
		/// Whether to show the first tick label. Defaults to true
		/// </summary>
		public bool? ShowFirstLabel { get; set; }

		/// <summary>
		/// Whether to show the last tick label. Defaults to false
		/// </summary>
		public bool? ShowLastLabel { get; set; }

		/// <summary>
		/// For datetime axes, this decides where to put the tick between
		/// weeks. 0 = Sunday, 1 = Monday. Defaults to 1
		/// </summary>
		public WeekDays? StartOfWeek { get; set; }

		/// <summary>
		/// Whether to force the axis to start on a tick. Use this option with the maxPadding
		/// option to control the axis start. Defaults to false
		/// </summary>
		public bool? StartOnTick { get; set; }

		/// <summary>
		/// Color for the main tick marks. Defaults to #C0D0E0
		/// </summary>
		public Color? TickColor { get; set; }

		/// <summary>
		/// The interval of the tick marks in axis units. When null, the tick interval
		/// is computed to approximately follow the tickPixelInterval on linear and datetime axes.
		/// On categorized axes, a null tickInterval will default to 1, one category. 
		/// Note that datetime axes are based on milliseconds, so for 
		/// example an interval of one day is expressed as 24 * 3600 * 1000.
		/// On logarithmic axes, the tickInterval is based on powers, so a tickInterval of 1 means
		/// 	one tick on each of 0.1, 1, 10, 100 etc. A tickInterval of 2 means a tick of 0.1, 10, 1000 etc.
		/// 	A tickInterval of 0.2 puts a tick on 0.1, 0.2, 0.4, 0.6, 0.8, 1, 2, 4, 6, 8, 10, 20, 40 etc. Defaults to null
		/// </summary>
		public object TickInterval { get; set; }

		/// <summary>
		/// The pixel length of the main tick marks. Defaults to 5
		/// </summary>
		public Number? TickLength { get; set; }

		/// <summary>
		/// For categorized axes only. If "on" the tick mark is placed in the center of 
		/// the category, if "between" the tick mark is placed between categories. Defaults to "between"
		/// </summary>
		public Tickmarks? TickmarkPlacement { get; set; }

		/// <summary>
		/// If tickInterval is null this option sets the approximate pixel interval of the
		/// tick marks. Not applicable to categorized axis. Defaults to 72 
		/// for the Y axis and 100 for	the X axis.
		/// </summary>
		public Number? TickPixelInterval { get; set; }

		/// <summary>
		/// The position of the major tick marks relative to the axis line. Can be
		/// one of inside and outside. Defaults to "outside"
		/// </summary>
		public TickPositions? TickPosition { get; set; }

		/// <summary>
		/// The pixel width of the major tick marks. Defaults to 1
		/// </summary>
		public Number? TickWidth { get; set; }

		/// <summary>
		/// Configuration object for the axis title.
		/// </summary>
		public XAxisTitle Title { get; set; }

		/// <summary>
		/// The type of axis. Can be one of "linear", "logarithmic" or "datetime". In a datetime
		/// axis, the numbers are given in milliseconds, and tick marks are placed 
		/// on appropriate values like full hours or days. Defaults to "linear"
		/// </summary>
		public AxisTypes? Type { get; set; }

	}

}