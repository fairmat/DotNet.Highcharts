using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// Options for the exporting module.
	/// </summary>
	public class Exporting
	{
		/// <summary>
		/// Configuration options for the buttons associated with the exporting module.
		/// </summary>
		public ExportingButtons Buttons { get; set; }

		/// <summary>
		/// Whether to enable the exporting module. Defaults to true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// Whether to enable images in the export. Including image point markers, background 
		/// images etc. Defaults to false
		/// </summary>
		public bool? EnableImages { get; set; }

		/// <summary>
		/// The filename, without extension, to use for the exported chart. Defaults to "chart"
		/// </summary>
		public string Filename { get; set; }

		/// <summary>
		/// Default MIME type for exporting if chart.exportChart() is called
		/// without specifying a type option. Possible values are image/png,
		/// image/jpeg, application/pdf and image/svg+xml. Defaults to "image/png"
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// The URL for the server module converting the SVG string to an image format. By
		/// default this points to Highslide Software's free web service. Defaults to http://export.highcharts.com
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// The pixel width of charts exported to PNG or JPG. Defaults to 800
		/// </summary>
		public Number? Width { get; set; }

	}

}