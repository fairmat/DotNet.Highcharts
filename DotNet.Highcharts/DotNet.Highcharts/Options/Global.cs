using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// Global options that don't apply to each chart. These options, like the lang
	/// options, must be set using the Highcharts.setOptions method.
	/// Highcharts.setOptions({
	/// global: {
	/// useUTC: false
	/// }
	/// });
	/// </summary>
	public class Global
	{
		/// <summary>
		/// The URL to the additional file to lazy load for Android 2.x devices. These devices don't 
		/// support SVG, so we download a helper file that contains canvg,
		/// its dependecy rbcolor, and our own CanVG Renderer class. To avoid hotlinking to our site,
		/// you can install canvas-tools.js on your own server and change this option accordingly. Defaults to "http://www.highcharts.com/js/canvas-tools.js"
		/// </summary>
		public string CanvasToolsURL { get; set; }

		/// <summary>
		/// Whether to use UTC time for axis scaling, tickmark placement and time display in 
		/// Highcharts.dateFormat. Advantages of using UTC is that the time
		/// displays equally regardless of the user agent's time zone settings. Local time
		/// can be used when the data is loaded in real time or when correct Daylight Saving Time
		/// transitions are required. Defaults to true
		/// </summary>
		public bool? UseUTC { get; set; }

	}

}