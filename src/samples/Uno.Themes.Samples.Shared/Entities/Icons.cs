﻿using System;
using System.Collections.Generic;
using System.Text;
#if IS_WINUI
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
#else
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#endif
namespace Uno.Themes.Samples.Entities
{
	public static class Icons
	{
		// sourced from: https://materialdesignicons.com/
		// note: the path data should be zero'd, else they will off-centered

		public const string Overview = /* format-list-bulleted-type */ "M2 5.5 4.5 10H-.5L2 5.5M0 0H4V4H0V0M2 16A2 2 0 004 14 2 2 0 002 12 2 2 0 000 14 2 2 0 002 16M6 1V3H18V1H6M6 15H18V13H6V15M6 9H18V7H6V9Z";

		public static class Styles
		{
			public const string CategoryHeader = /* palette-swatch-outline */ "M1.5 17.6 2.8 18.2V9.2L.4 15C0 16.1.5 17.2 1.5 17.6M14.2 2.8 19.2 14.8 11.9 17.8 6.9 5.9V5.8L14.2 2.8M14.3.8C14 .8 13.8.8 13.5.9L6.1 4C5.4 4.3 4.9 5 4.9 5.8 4.9 6 4.9 6.3 5 6.6L10 18.5C10.3 19.3 11 19.7 11.8 19.7 12.1 19.7 12.3 19.7 12.6 19.6L20 16.5C21 16.1 21.5 14.9 21.1 13.9L16.1 2C15.8 1.2 15 .8 14.3.8M9.5 7.9C8.9 7.9 8.5 7.5 8.5 6.9S8.9 5.9 9.5 5.9C10.1 5.9 10.5 6.4 10.5 6.9S10.1 7.9 9.5 7.9M4.9 17.8C4.9 18.9 5.8 19.8 6.9 19.8H8.3L4.9 11.5V17.8Z";
			public const string Colors = /* palette-outline */ "M10 20A10 10 0 010 10 10 10 0 0110 0C15.5 0 20 4 20 9A6 6 0 0114 15H12.2C11.9 15 11.7 15.2 11.7 15.5 11.7 15.6 11.8 15.7 11.8 15.8 12.2 16.3 12.4 16.9 12.4 17.5 12.5 18.9 11.4 20 10 20M10 2A8 8 0 002 10 8 8 0 0010 18C10.3 18 10.5 17.8 10.5 17.5 10.5 17.3 10.4 17.2 10.4 17.1 10 16.6 9.8 16.1 9.8 15.5 9.8 14.1 10.9 13 12.3 13H14A4 4 0 0018 9C18 5.1 14.4 2 10 2M4.5 8C5.3 8 6 8.7 6 9.5 6 10.3 5.3 11 4.5 11 3.7 11 3 10.3 3 9.5 3 8.7 3.7 8 4.5 8M7.5 4C8.3 4 9 4.7 9 5.5 9 6.3 8.3 7 7.5 7 6.7 7 6 6.3 6 5.5 6 4.7 6.7 4 7.5 4M12.5 4C13.3 4 14 4.7 14 5.5 14 6.3 13.3 7 12.5 7 11.7 7 11 6.3 11 5.5 11 4.7 11.7 4 12.5 4M15.5 8C16.3 8 17 8.7 17 9.5 17 10.3 16.3 11 15.5 11 14.7 11 14 10.3 14 9.5 14 8.7 14.7 8 15.5 8Z";
		}

		public static class Controls
		{
			public const string CategoryHeader = /* rhombus-split */ "M10 0C9.5 0 9 .19 8.59.59L5.29 3.88 10 8.58 14.71 3.88 11.41.59C11 .19 10.5 0 10 0M3.88 5.29.59 8.59C-.2 9.37-.2 10.63.59 11.41L3.88 14.71 8.58 10 3.88 5.29M16.12 5.29 11.42 10 16.12 14.71 19.41 11.41C20.2 10.63 20.2 9.37 19.41 8.59L16.12 5.29M10 11.42 5.29 16.12 8.59 19.41C9.37 20.2 10.63 20.2 11.41 19.41L14.71 16.12 10 11.42Z";
			public const string Control = Shared.Placeholder;
		}

		public static class Helpers
		{
			public const string CategoryHeader = /* toolbox-outline */ "M18 4H15V2C15 .9 14.1 0 13 0H7C5.9 0 5 .9 5 2V4H2C.9 4 0 4.9 0 6V16H20V6C20 4.9 19.1 4 18 4M7 2H13V4H7V2M18 14H2V11H4V12H6V11H14V12H16V11H18V14M16 9V8H14V9H6V8H4V9H2V6H18V9H16Z";
			public const string ControlExtensions = /* wrench-cog-outline */ "M7 .09V5H5V.09C2.16.57 0 3.03 0 6 0 8.22 1.21 10.15 3 11.19V20C3 20.55 3.45 21 4 21H8C8.55 21 9 20.55 9 20V11.19C10.79 10.15 12 8.22 12 6 12 3.03 9.84.57 7 .09M8 9.46 7 10.04V19H5V10.04L4 9.46C2.77 8.74 2 7.42 2 6 2 5 2.37 4.06 3 3.35V7H9V3.35C9.63 4.06 10 5 10 6 10 7.42 9.23 8.74 8 9.46M18.94 16.94C18.96 16.79 18.97 16.65 18.97 16.5S18.96 16.2 18.94 16.05L19.91 15.32C20 15.25 20.03 15.13 19.97 15.03L19.05 13.47C19 13.37 18.87 13.33 18.76 13.37L17.61 13.82C17.37 13.65 17.12 13.5 16.83 13.38L16.66 12.19C16.64 12.08 16.54 12 16.43 12H14.58C14.46 12 14.36 12.08 14.34 12.19L14.17 13.38C13.88 13.5 13.63 13.65 13.39 13.82L12.24 13.37C12.14 13.33 12 13.37 11.96 13.47L11.03 15.03C10.97 15.13 11 15.25 11.09 15.32L12.06 16.05C12.05 16.2 12.03 16.35 12.03 16.5S12.05 16.79 12.06 16.94L11.09 17.68C11 17.75 10.97 17.87 11.03 17.97L11.96 19.53C12 19.63 12.14 19.66 12.24 19.63L13.39 19.17C13.63 19.35 13.88 19.5 14.17 19.62L14.34 20.81C14.36 20.92 14.46 21 14.58 21H16.43C16.54 21 16.64 20.92 16.66 20.81L16.83 19.62C17.12 19.5 17.37 19.35 17.61 19.17L18.76 19.63C18.87 19.66 19 19.63 19.05 19.53L19.97 17.97C20.03 17.87 20 17.75 19.91 17.68L18.94 16.94M15.5 18C14.67 18 14 17.33 14 16.5S14.67 15 15.5 15 17 15.67 17 16.5 16.33 18 15.5 18Z";
		}

		public static class Shared
		{
			// note: Windows.UI.Xaml.Controls.Symbol.Placeholder looks out of place (brush too thin) compared to the ones above, hence why we arnt using it.
			public const string Placeholder = /* alert-rhombus-outline (modified: hollowed) */ "M10 0C9.5 0 9 .19 8.59.59L.59 8.59C-.2 9.37-.2 10.63.59 11.41L8.59 19.41C9.37 20.2 10.63 20.2 11.41 19.41L19.41 11.41C20.2 10.63 20.2 9.37 19.41 8.59L11.41.59C11 .19 10.5 0 10 0M10 2 18 10 10 18 2 10Z";
		}
	}
}
