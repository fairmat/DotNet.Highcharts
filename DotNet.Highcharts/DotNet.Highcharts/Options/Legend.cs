using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// The legend is a box containing a symbol and name for each series item
	/// or point item in the chart.
	/// </summary>
	public class Legend
	{
		/// <summary>
		/// The horizontal alignment of the legend box within the chart area. Defaults to "center"
		/// </summary>
		public HorizontalAligns? Align { get; set; }

		/// <summary>
		/// The background color of the legend, filling the rounded corner border. Defaults to null
		/// </summary>
		public Color? BackgroundColor { get; set; }

		/// <summary>
		/// The color of the drawn border around the legend. Defaults to #909090
		/// </summary>
		public Color? BorderColor { get; set; }

		/// <summary>
		/// The border corner radius of the legend. Defaults to 5
		/// </summary>
		public Number? BorderRadius { get; set; }

		/// <summary>
		/// The width of the drawn border around the legend. Defaults to 1
		/// </summary>
		public Number? BorderWidth { get; set; }

		/// <summary>
		/// Enable or disable the legend. Defaults to true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// When the legend is floating, the plot area ignores it and is allowed
		/// to be placed below it. Defaults to false
		/// </summary>
		public bool? Floating { get; set; }

		/// <summary>
		/// CSS styles for each legend item when the corresponding series or point
		/// is hidden. Properties are inherited
		/// from style unless overridden here. Defaults to:
		/// itemHiddenStyle: {
		/// color: '#CCC'
		/// }
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string ItemHiddenStyle { get; set; }

		/// <summary>
		/// CSS styles for each legend item in hover mode. Properties are inherited
		/// from style unless overridden here. Defaults to:
		/// itemHoverStyle: {
		/// color: '#000'
		/// }
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string ItemHoverStyle { get; set; }

		/// <summary>
		/// CSS styles for each legend item. Defaults to:
		/// itemStyle: {
		/// cursor: 'pointer',
		/// color: '#3E576F'
		/// }
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string ItemStyle { get; set; }

		/// <summary>
		/// The width for each legend item. This is useful in a horizontal layout with
		/// many items when you want the items to align vertically. Defaults to null
		/// </summary>
		public Number? ItemWidth { get; set; }

		/// <summary>
		/// The layout of the legend items. Can be one of "horizontal" or "vertical". Defaults to "horizontal"
		/// </summary>
		public Layouts Layout { get; set; }

		/// <summary>
		/// Callback function to format each of the series' labels. The this
		/// keyword refers to the series object, or the point object in case of pie charts.
		/// Defaults to:
		/// labelFormatter: function() {
		/// return this.name
		/// }
		/// </summary>
		[JsonFormatter("{0}")]
		public string LabelFormatter { get; set; }

		/// <summary>
		///  Defaults to 16
		/// </summary>
		public Number? LineHeight { get; set; }

		/// <summary>
		/// If the plot area sized is calculated automatically and the legend
		/// is not floating, the legend margin is the 
		/// space between the legend and the axis labels or plot area. Defaults to 15
		/// </summary>
		public Number? Margin { get; set; }

		/// <summary>
		/// Whether to reverse the order of the legend items compared to the order
		/// of the series or points as defined in the configuration object. Defaults to false
		/// </summary>
		public bool? Reversed { get; set; }

		/// <summary>
		/// Whether to show the symbol on the right side of the text rather than the left side. 
		/// This is common in Arabic and Hebraic. Defaults to false
		/// </summary>
		public bool? Rtl { get; set; }

		/// <summary>
		/// Whether to apply a drop shadow to the legend. A backgroundColor
		/// also needs to be applied for this to take effect. Defaults to false
		/// </summary>
		public bool? Shadow { get; set; }

		/// <summary>
		/// CSS styles for the legend area. In the 1.x versions the position of the legend area
		/// was determined by CSS. In 2.x, the position is determined by properties like 
		/// align, verticalAlign, x and y,
		/// but the styles are still parsed for backwards compatibility.
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// The pixel padding between the legend item symbol and the legend item text. Defaults to 5
		/// </summary>
		public Number? SymbolPadding { get; set; }

		/// <summary>
		/// The pixel width of the legend item symbol. Defaults to 30
		/// </summary>
		public Number? SymbolWidth { get; set; }

		/// <summary>
		/// The vertical alignment of the legend box. Can be one of "top", "middle" or 
		/// "bottom". Vertical position can be further determined by the y
		/// option. Defaults to "bottom"
		/// </summary>
		public VerticalAligns? VerticalAlign { get; set; }

		/// <summary>
		/// The width of the legend box, not including style.padding. Defaults to null
		/// </summary>
		public Number? Width { get; set; }

		/// <summary>
		/// The x offset of the legend relative to it's horizontal alignment align
		/// within chart.spacingLeft and chart.spacingRight. Negative
		/// x moves it to the left, positive x moves it to the right. The default value of 
		/// 15 together with align: "center" puts it in the center of the 
		/// plot area. Defaults to 0
		/// </summary>
		public Number? X { get; set; }

		/// <summary>
		/// The vertical offset of the legend relative to it's vertical alignment
		/// verticalAlign within chart.spacingTop and chart.spacingBottom. Negative
		/// y moves it up, positive y moves it down. Defaults to 0
		/// </summary>
		public Number? Y { get; set; }

	}

}