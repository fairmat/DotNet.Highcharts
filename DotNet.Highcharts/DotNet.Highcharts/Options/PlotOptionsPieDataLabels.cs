using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsPieDataLabels : PlotOptionsSeriesDataLabels
	{
		/// <summary>
		/// N/A for pies. Defaults to null
		/// </summary>
		public HorizontalAligns? Align { get; set; }

		/// <summary>
		/// The width of the line connecting the data label to the pie slice Defaults to 1
		/// </summary>
		public Number? ConnectorWidth { get; set; }

		/// <summary>
		/// The color of the line connecting the data label to the pie slice. The default color
		/// is the same as the point's color. Defaults to {point.color}
		/// </summary>
		public Color? ConnectorColor { get; set; }

		/// <summary>
		/// The distance from the data label to the connector Defaults to 5
		/// </summary>
		public Number? ConnectorPadding { get; set; }

		/// <summary>
		/// The distance of the data label from the pie's edge. Negative numbers put the data
		/// label on top of the pie slices. Connectors are only shown for data labels outside
		/// the pie. Defaults to 30
		/// </summary>
		public Number? Distance { get; set; }

		/// <summary>
		/// Enable or disable the data labels. Defaults to true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// Whether to render the connector as a soft arc or a line with sharp break. Defaults to true
		/// </summary>
		public bool? SoftConnector { get; set; }

	}

}