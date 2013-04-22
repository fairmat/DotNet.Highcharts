using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// Options for the export related buttons, print and export.
	/// </summary>
	public class ExportingButtons
	{
		/// <summary>
		/// Options for the export button.
		/// </summary>
		public ExportingButtonsExportButton ExportButton { get; set; }

		/// <summary>
		/// Options for the print button.
		/// </summary>
		public ExportingButtonsPrintButton PrintButton { get; set; }

	}

}