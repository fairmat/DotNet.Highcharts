using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// A collection of options for buttons and menus appearing in the exporting module.
	/// </summary>
	public class Navigation
	{
		/// <summary>
		/// CSS styles for the popup menu appearing by default when the export icon is
		/// clicked. This menu is rendered in HTML. Defaults to 
		/// menuStyle: {
		/// border: '1px solid #A0A0A0',
		/// background: '#FFFFFF'
		/// }
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string MenuStyle { get; set; }

		/// <summary>
		/// CSS styles for the individual items within the popup menu appearing by 
		/// default when the export icon is
		/// clicked. The menu items are rendered in HTML. Defaults to 
		/// menuItemStyle: {
		/// padding: '0 5px',
		/// background: NONE,
		/// color: '#303030'
		/// }
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string MenuItemStyle { get; set; }

		/// <summary>
		/// CSS styles for the hover state of the individual items within the popup menu appearing by 
		/// default when the export icon is
		/// clicked. The menu items are rendered in HTML. Defaults to 
		/// menuItemHoverStyle: {
		/// background: '#4572A5',
		/// color: '#FFFFFF'
		/// }
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string MenuItemHoverStyle { get; set; }

		/// <summary>
		/// General options for buttons like the Print and Export buttons.
		/// </summary>
		public NavigationButtonOptions ButtonOptions { get; set; }

	}

}