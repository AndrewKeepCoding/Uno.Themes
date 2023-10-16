using System;
using Windows.UI;
using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using Uno.Extensions.Markup;
using Uno.Extensions.Markup.Internals;

using ResourceKeyDefinitionAttribute = Uno.Themes.WinUI.Markup.ResourceKeyDefinitionAttribute;

namespace Uno.Themes.Markup
{
	public static partial class Theme
	{
		public static partial class Button
		{
			public static partial class Resources
			{
				public static partial class Fab
				{
					public static readonly BackgroundVSG Background = new();
					public partial class BackgroundVSG
					{
						[ResourceKeyDefinition(typeof(Brush), "FabBackground")]
						public ThemeResourceKey<Brush> Default = new("FabBackground");

						[ResourceKeyDefinition(typeof(Brush), "FabBackgroundPointerOver")]
						public ThemeResourceKey<Brush> PointerOver = new("FabBackgroundPointerOver");

						[ResourceKeyDefinition(typeof(Brush), "FabBackgroundPressed")]
						public ThemeResourceKey<Brush> Pressed = new("FabBackgroundPressed");

						[ResourceKeyDefinition(typeof(Brush), "FabBackgroundDisabled")]
						public ThemeResourceKey<Brush> Disabled = new("FabBackgroundDisabled");

						public static implicit operator ThemeResourceKey<Brush>(BackgroundVSG self) => self.Default;
					}

					public static readonly ForegroundVSG Foreground = new();
					public partial class ForegroundVSG
					{
						[ResourceKeyDefinition(typeof(Brush), "FabForeground")]
						public ThemeResourceKey<Brush> Default = new("FabForeground");

						[ResourceKeyDefinition(typeof(Brush), "FabForegroundPointerOver")]
						public ThemeResourceKey<Brush> PointerOver = new("FabForegroundPointerOver");

						[ResourceKeyDefinition(typeof(Brush), "FabForegroundPressed")]
						public ThemeResourceKey<Brush> Pressed = new("FabForegroundPressed");

						[ResourceKeyDefinition(typeof(Brush), "FabForegroundDisabled")]
						public ThemeResourceKey<Brush> Disabled = new("FabForegroundDisabled");

						public static implicit operator ThemeResourceKey<Brush>(ForegroundVSG self) => self.Default;
					}

					public static partial class StateOverlayBackground
					{
						[ResourceKeyDefinition(typeof(Brush), "FabStateOverlayBackgroundPointerOver")]
						public static ThemeResourceKey<Brush> PointerOver => new("FabStateOverlayBackgroundPointerOver");

						[ResourceKeyDefinition(typeof(Brush), "FabStateOverlayBackgroundPressed")]
						public static ThemeResourceKey<Brush> Pressed => new("FabStateOverlayBackgroundPressed");

						[ResourceKeyDefinition(typeof(Brush), "FabStateOverlayBackgroundDisabled")]
						public static ThemeResourceKey<Brush> Disabled => new("FabStateOverlayBackgroundDisabled");

						[ResourceKeyDefinition(typeof(Brush), "FabStateOverlayBackgroundFocused")]
						public static ThemeResourceKey<Brush> Focused => new("FabStateOverlayBackgroundFocused");
					}

					[ResourceKeyDefinition(typeof(double), "MaterialFabContentWidthOrHeight")]
					public static ThemeResourceKey<double> ContentWidthOrHeight => new("MaterialFabContentWidthOrHeight");

					[ResourceKeyDefinition(typeof(CornerRadius), "MaterialFabCornerRadius")]
					public static ThemeResourceKey<CornerRadius> CornerRadius => new("MaterialFabCornerRadius");

					[ResourceKeyDefinition(typeof(double), "MaterialFabIconTextPadding")]
					public static ThemeResourceKey<double> IconTextPadding => new("MaterialFabIconTextPadding");

					[ResourceKeyDefinition(typeof(Thickness), "MaterialFabPadding")]
					public static ThemeResourceKey<Thickness> Padding => new("MaterialFabPadding");
				}

				public static partial class LargeFab
				{
					[ResourceKeyDefinition(typeof(double), "MaterialLargeFabContentWidthOrHeight")]
					public static ThemeResourceKey<double> ContentWidthOrHeight => new("MaterialLargeFabContentWidthOrHeight");

					[ResourceKeyDefinition(typeof(CornerRadius), "MaterialLargeFabCornerRadius")]
					public static ThemeResourceKey<CornerRadius> CornerRadius => new("MaterialLargeFabCornerRadius");

					[ResourceKeyDefinition(typeof(Thickness), "MaterialLargeFabPadding")]
					public static ThemeResourceKey<Thickness> Padding => new("MaterialLargeFabPadding");
				}

				public static partial class SecondaryFab
				{
					public static readonly BackgroundVSG Background = new();
					public partial class BackgroundVSG
					{
						[ResourceKeyDefinition(typeof(Brush), "FabSecondaryBackground")]
						public ThemeResourceKey<Brush> Default = new("FabSecondaryBackground");

						[ResourceKeyDefinition(typeof(Brush), "FabSecondaryBackgroundPointerOver")]
						public ThemeResourceKey<Brush> PointerOver = new("FabSecondaryBackgroundPointerOver");

						[ResourceKeyDefinition(typeof(Brush), "FabSecondaryBackgroundPressed")]
						public ThemeResourceKey<Brush> Pressed = new("FabSecondaryBackgroundPressed");

						[ResourceKeyDefinition(typeof(Brush), "FabSecondaryBackgroundDisabled")]
						public ThemeResourceKey<Brush> Disabled = new("FabSecondaryBackgroundDisabled");

						public static implicit operator ThemeResourceKey<Brush>(BackgroundVSG self) => self.Default;
					}

					public static partial class Fab
					{
						[ResourceKeyDefinition(typeof(CornerRadius), "MaterialFabCornerRadius")]
						public static ThemeResourceKey<CornerRadius> CornerRadius => new("MaterialFabCornerRadius");

						[ResourceKeyDefinition(typeof(Thickness), "MaterialFabPadding")]
						public static ThemeResourceKey<Thickness> Padding => new("MaterialFabPadding");
					}

					public static readonly ForegroundVSG Foreground = new();
					public partial class ForegroundVSG
					{
						[ResourceKeyDefinition(typeof(Brush), "FabSecondaryForeground")]
						public ThemeResourceKey<Brush> Default = new("FabSecondaryForeground");

						[ResourceKeyDefinition(typeof(Brush), "FabSecondaryForegroundPointerOver")]
						public ThemeResourceKey<Brush> PointerOver = new("FabSecondaryForegroundPointerOver");

						[ResourceKeyDefinition(typeof(Brush), "FabSecondaryForegroundPressed")]
						public ThemeResourceKey<Brush> Pressed = new("FabSecondaryForegroundPressed");

						[ResourceKeyDefinition(typeof(Brush), "FabSecondaryForegroundDisabled")]
						public ThemeResourceKey<Brush> Disabled = new("FabSecondaryForegroundDisabled");

						public static implicit operator ThemeResourceKey<Brush>(ForegroundVSG self) => self.Default;
					}

					public static partial class StateOverlayBackground
					{
						[ResourceKeyDefinition(typeof(Brush), "FabSecondaryStateOverlayBackgroundPointerOver")]
						public static ThemeResourceKey<Brush> PointerOver => new("FabSecondaryStateOverlayBackgroundPointerOver");

						[ResourceKeyDefinition(typeof(Brush), "FabSecondaryStateOverlayBackgroundPressed")]
						public static ThemeResourceKey<Brush> Pressed => new("FabSecondaryStateOverlayBackgroundPressed");

						[ResourceKeyDefinition(typeof(Brush), "FabSecondaryStateOverlayBackgroundDisabled")]
						public static ThemeResourceKey<Brush> Disabled => new("FabSecondaryStateOverlayBackgroundDisabled");

						[ResourceKeyDefinition(typeof(Brush), "FabSecondaryStateOverlayBackgroundFocused")]
						public static ThemeResourceKey<Brush> Focused => new("FabSecondaryStateOverlayBackgroundFocused");
					}

					[ResourceKeyDefinition(typeof(double), "MaterialFabContentWidthOrHeight")]
					public static ThemeResourceKey<double> FabContentWidthOrHeight => new("MaterialFabContentWidthOrHeight");

					[ResourceKeyDefinition(typeof(double), "MaterialFabIconTextPadding")]
					public static ThemeResourceKey<double> FabIconTextPadding => new("MaterialFabIconTextPadding");
				}

				public static partial class SecondaryLargeFab
				{
					public static partial class LargeFab
					{
						[ResourceKeyDefinition(typeof(CornerRadius), "MaterialLargeFabCornerRadius")]
						public static ThemeResourceKey<CornerRadius> CornerRadius => new("MaterialLargeFabCornerRadius");

						[ResourceKeyDefinition(typeof(Thickness), "MaterialLargeFabPadding")]
						public static ThemeResourceKey<Thickness> Padding => new("MaterialLargeFabPadding");
					}

					[ResourceKeyDefinition(typeof(double), "MaterialLargeFabContentWidthOrHeight")]
					public static ThemeResourceKey<double> LargeFabContentWidthOrHeight => new("MaterialLargeFabContentWidthOrHeight");
				}

				public static partial class SecondarySmallFab
				{
					public static partial class SmallFab
					{
						[ResourceKeyDefinition(typeof(CornerRadius), "MaterialSmallFabCornerRadius")]
						public static ThemeResourceKey<CornerRadius> CornerRadius => new("MaterialSmallFabCornerRadius");

						[ResourceKeyDefinition(typeof(Thickness), "MaterialSmallFabPadding")]
						public static ThemeResourceKey<Thickness> Padding => new("MaterialSmallFabPadding");
					}

					[ResourceKeyDefinition(typeof(double), "MaterialSmallFabContentWidthOrHeight")]
					public static ThemeResourceKey<double> SmallFabContentWidthOrHeight => new("MaterialSmallFabContentWidthOrHeight");
				}

				public static partial class SmallFab
				{
					[ResourceKeyDefinition(typeof(double), "MaterialSmallFabContentWidthOrHeight")]
					public static ThemeResourceKey<double> ContentWidthOrHeight => new("MaterialSmallFabContentWidthOrHeight");

					[ResourceKeyDefinition(typeof(CornerRadius), "MaterialSmallFabCornerRadius")]
					public static ThemeResourceKey<CornerRadius> CornerRadius => new("MaterialSmallFabCornerRadius");

					[ResourceKeyDefinition(typeof(Thickness), "MaterialSmallFabPadding")]
					public static ThemeResourceKey<Thickness> Padding => new("MaterialSmallFabPadding");
				}

				public static partial class SurfaceFab
				{
					public static readonly BackgroundVSG Background = new();
					public partial class BackgroundVSG
					{
						[ResourceKeyDefinition(typeof(Brush), "FabSurfaceBackground")]
						public ThemeResourceKey<Brush> Default = new("FabSurfaceBackground");

						[ResourceKeyDefinition(typeof(Brush), "FabSurfaceBackgroundPointerOver")]
						public ThemeResourceKey<Brush> PointerOver = new("FabSurfaceBackgroundPointerOver");

						[ResourceKeyDefinition(typeof(Brush), "FabSurfaceBackgroundPressed")]
						public ThemeResourceKey<Brush> Pressed = new("FabSurfaceBackgroundPressed");

						[ResourceKeyDefinition(typeof(Brush), "FabSurfaceBackgroundDisabled")]
						public ThemeResourceKey<Brush> Disabled = new("FabSurfaceBackgroundDisabled");

						public static implicit operator ThemeResourceKey<Brush>(BackgroundVSG self) => self.Default;
					}

					public static partial class Fab
					{
						[ResourceKeyDefinition(typeof(CornerRadius), "MaterialFabCornerRadius")]
						public static ThemeResourceKey<CornerRadius> CornerRadius => new("MaterialFabCornerRadius");

						[ResourceKeyDefinition(typeof(Thickness), "MaterialFabPadding")]
						public static ThemeResourceKey<Thickness> Padding => new("MaterialFabPadding");
					}

					public static readonly ForegroundVSG Foreground = new();
					public partial class ForegroundVSG
					{
						[ResourceKeyDefinition(typeof(Brush), "FabSurfaceForeground")]
						public ThemeResourceKey<Brush> Default = new("FabSurfaceForeground");

						[ResourceKeyDefinition(typeof(Brush), "FabSurfaceForegroundPointerOver")]
						public ThemeResourceKey<Brush> PointerOver = new("FabSurfaceForegroundPointerOver");

						[ResourceKeyDefinition(typeof(Brush), "FabSurfaceForegroundPressed")]
						public ThemeResourceKey<Brush> Pressed = new("FabSurfaceForegroundPressed");

						[ResourceKeyDefinition(typeof(Brush), "FabSurfaceForegroundDisabled")]
						public ThemeResourceKey<Brush> Disabled = new("FabSurfaceForegroundDisabled");

						public static implicit operator ThemeResourceKey<Brush>(ForegroundVSG self) => self.Default;
					}

					public static partial class StateOverlayBackground
					{
						[ResourceKeyDefinition(typeof(Brush), "FabSurfaceStateOverlayBackgroundPointerOver")]
						public static ThemeResourceKey<Brush> PointerOver => new("FabSurfaceStateOverlayBackgroundPointerOver");

						[ResourceKeyDefinition(typeof(Brush), "FabSurfaceStateOverlayBackgroundPressed")]
						public static ThemeResourceKey<Brush> Pressed => new("FabSurfaceStateOverlayBackgroundPressed");

						[ResourceKeyDefinition(typeof(Brush), "FabSurfaceStateOverlayBackgroundDisabled")]
						public static ThemeResourceKey<Brush> Disabled => new("FabSurfaceStateOverlayBackgroundDisabled");

						[ResourceKeyDefinition(typeof(Brush), "FabSurfaceStateOverlayBackgroundFocused")]
						public static ThemeResourceKey<Brush> Focused => new("FabSurfaceStateOverlayBackgroundFocused");
					}

					[ResourceKeyDefinition(typeof(double), "MaterialFabContentWidthOrHeight")]
					public static ThemeResourceKey<double> FabContentWidthOrHeight => new("MaterialFabContentWidthOrHeight");

					[ResourceKeyDefinition(typeof(double), "MaterialFabIconTextPadding")]
					public static ThemeResourceKey<double> FabIconTextPadding => new("MaterialFabIconTextPadding");
				}

				public static partial class SurfaceLargeFab
				{
					public static partial class LargeFab
					{
						[ResourceKeyDefinition(typeof(CornerRadius), "MaterialLargeFabCornerRadius")]
						public static ThemeResourceKey<CornerRadius> CornerRadius => new("MaterialLargeFabCornerRadius");

						[ResourceKeyDefinition(typeof(Thickness), "MaterialLargeFabPadding")]
						public static ThemeResourceKey<Thickness> Padding => new("MaterialLargeFabPadding");
					}

					[ResourceKeyDefinition(typeof(double), "MaterialLargeFabContentWidthOrHeight")]
					public static ThemeResourceKey<double> LargeFabContentWidthOrHeight => new("MaterialLargeFabContentWidthOrHeight");
				}

				public static partial class SurfaceSmallFab
				{
					public static partial class SmallFab
					{
						[ResourceKeyDefinition(typeof(CornerRadius), "MaterialSmallFabCornerRadius")]
						public static ThemeResourceKey<CornerRadius> CornerRadius => new("MaterialSmallFabCornerRadius");

						[ResourceKeyDefinition(typeof(Thickness), "MaterialSmallFabPadding")]
						public static ThemeResourceKey<Thickness> Padding => new("MaterialSmallFabPadding");
					}

					[ResourceKeyDefinition(typeof(double), "MaterialSmallFabContentWidthOrHeight")]
					public static ThemeResourceKey<double> SmallFabContentWidthOrHeight => new("MaterialSmallFabContentWidthOrHeight");
				}

				public static partial class TertiaryFab
				{
					public static readonly BackgroundVSG Background = new();
					public partial class BackgroundVSG
					{
						[ResourceKeyDefinition(typeof(Brush), "FabTertiaryBackground")]
						public ThemeResourceKey<Brush> Default = new("FabTertiaryBackground");

						[ResourceKeyDefinition(typeof(Brush), "FabTertiaryBackgroundPointerOver")]
						public ThemeResourceKey<Brush> PointerOver = new("FabTertiaryBackgroundPointerOver");

						[ResourceKeyDefinition(typeof(Brush), "FabTertiaryBackgroundPressed")]
						public ThemeResourceKey<Brush> Pressed = new("FabTertiaryBackgroundPressed");

						[ResourceKeyDefinition(typeof(Brush), "FabTertiaryBackgroundDisabled")]
						public ThemeResourceKey<Brush> Disabled = new("FabTertiaryBackgroundDisabled");

						public static implicit operator ThemeResourceKey<Brush>(BackgroundVSG self) => self.Default;
					}

					public static partial class Fab
					{
						[ResourceKeyDefinition(typeof(CornerRadius), "MaterialFabCornerRadius")]
						public static ThemeResourceKey<CornerRadius> CornerRadius => new("MaterialFabCornerRadius");

						[ResourceKeyDefinition(typeof(Thickness), "MaterialFabPadding")]
						public static ThemeResourceKey<Thickness> Padding => new("MaterialFabPadding");
					}

					public static readonly ForegroundVSG Foreground = new();
					public partial class ForegroundVSG
					{
						[ResourceKeyDefinition(typeof(Brush), "FabTertiaryForeground")]
						public ThemeResourceKey<Brush> Default = new("FabTertiaryForeground");

						[ResourceKeyDefinition(typeof(Brush), "FabTertiaryForegroundPointerOver")]
						public ThemeResourceKey<Brush> PointerOver = new("FabTertiaryForegroundPointerOver");

						[ResourceKeyDefinition(typeof(Brush), "FabTertiaryForegroundPressed")]
						public ThemeResourceKey<Brush> Pressed = new("FabTertiaryForegroundPressed");

						[ResourceKeyDefinition(typeof(Brush), "FabTertiaryForegroundDisabled")]
						public ThemeResourceKey<Brush> Disabled = new("FabTertiaryForegroundDisabled");

						public static implicit operator ThemeResourceKey<Brush>(ForegroundVSG self) => self.Default;
					}

					public static partial class StateOverlayBackground
					{
						[ResourceKeyDefinition(typeof(Brush), "FabTertiaryStateOverlayBackgroundPointerOver")]
						public static ThemeResourceKey<Brush> PointerOver => new("FabTertiaryStateOverlayBackgroundPointerOver");

						[ResourceKeyDefinition(typeof(Brush), "FabTertiaryStateOverlayBackgroundPressed")]
						public static ThemeResourceKey<Brush> Pressed => new("FabTertiaryStateOverlayBackgroundPressed");

						[ResourceKeyDefinition(typeof(Brush), "FabTertiaryStateOverlayBackgroundDisabled")]
						public static ThemeResourceKey<Brush> Disabled => new("FabTertiaryStateOverlayBackgroundDisabled");

						[ResourceKeyDefinition(typeof(Brush), "FabTertiaryStateOverlayBackgroundFocused")]
						public static ThemeResourceKey<Brush> Focused => new("FabTertiaryStateOverlayBackgroundFocused");
					}

					[ResourceKeyDefinition(typeof(double), "MaterialFabContentWidthOrHeight")]
					public static ThemeResourceKey<double> FabContentWidthOrHeight => new("MaterialFabContentWidthOrHeight");

					[ResourceKeyDefinition(typeof(double), "MaterialFabIconTextPadding")]
					public static ThemeResourceKey<double> FabIconTextPadding => new("MaterialFabIconTextPadding");
				}

				public static partial class TertiaryLargeFab
				{
					public static partial class LargeFab
					{
						[ResourceKeyDefinition(typeof(CornerRadius), "MaterialLargeFabCornerRadius")]
						public static ThemeResourceKey<CornerRadius> CornerRadius => new("MaterialLargeFabCornerRadius");

						[ResourceKeyDefinition(typeof(Thickness), "MaterialLargeFabPadding")]
						public static ThemeResourceKey<Thickness> Padding => new("MaterialLargeFabPadding");
					}

					[ResourceKeyDefinition(typeof(double), "MaterialLargeFabContentWidthOrHeight")]
					public static ThemeResourceKey<double> LargeFabContentWidthOrHeight => new("MaterialLargeFabContentWidthOrHeight");
				}

				public static partial class TertiarySmallFab
				{
					public static partial class SmallFab
					{
						[ResourceKeyDefinition(typeof(CornerRadius), "MaterialSmallFabCornerRadius")]
						public static ThemeResourceKey<CornerRadius> CornerRadius => new("MaterialSmallFabCornerRadius");

						[ResourceKeyDefinition(typeof(Thickness), "MaterialSmallFabPadding")]
						public static ThemeResourceKey<Thickness> Padding => new("MaterialSmallFabPadding");
					}

					[ResourceKeyDefinition(typeof(double), "MaterialSmallFabContentWidthOrHeight")]
					public static ThemeResourceKey<double> SmallFabContentWidthOrHeight => new("MaterialSmallFabContentWidthOrHeight");
				}
			}

			public static partial class Styles
			{
				[ResourceKeyDefinition(typeof(Style), "MaterialFabStyle", TargetType = typeof(global::Microsoft.UI.Xaml.Controls.Button))]
				public static StaticResourceKey<Style> Fab => new("MaterialFabStyle");

				[ResourceKeyDefinition(typeof(Style), "MaterialSurfaceFabStyle", TargetType = typeof(global::Microsoft.UI.Xaml.Controls.Button))]
				public static StaticResourceKey<Style> SurfaceFab => new("MaterialSurfaceFabStyle");

				[ResourceKeyDefinition(typeof(Style), "MaterialSecondaryFabStyle", TargetType = typeof(global::Microsoft.UI.Xaml.Controls.Button))]
				public static StaticResourceKey<Style> SecondaryFab => new("MaterialSecondaryFabStyle");

				[ResourceKeyDefinition(typeof(Style), "MaterialTertiaryFabStyle", TargetType = typeof(global::Microsoft.UI.Xaml.Controls.Button))]
				public static StaticResourceKey<Style> TertiaryFab => new("MaterialTertiaryFabStyle");

				[ResourceKeyDefinition(typeof(Style), "MaterialSmallFabStyle", TargetType = typeof(global::Microsoft.UI.Xaml.Controls.Button))]
				public static StaticResourceKey<Style> SmallFab => new("MaterialSmallFabStyle");

				[ResourceKeyDefinition(typeof(Style), "MaterialSurfaceSmallFabStyle", TargetType = typeof(global::Microsoft.UI.Xaml.Controls.Button))]
				public static StaticResourceKey<Style> SurfaceSmallFab => new("MaterialSurfaceSmallFabStyle");

				[ResourceKeyDefinition(typeof(Style), "MaterialSecondarySmallFabStyle", TargetType = typeof(global::Microsoft.UI.Xaml.Controls.Button))]
				public static StaticResourceKey<Style> SecondarySmallFab => new("MaterialSecondarySmallFabStyle");

				[ResourceKeyDefinition(typeof(Style), "MaterialTertiarySmallFabStyle", TargetType = typeof(global::Microsoft.UI.Xaml.Controls.Button))]
				public static StaticResourceKey<Style> TertiarySmallFab => new("MaterialTertiarySmallFabStyle");

				[ResourceKeyDefinition(typeof(Style), "MaterialLargeFabStyle", TargetType = typeof(global::Microsoft.UI.Xaml.Controls.Button))]
				public static StaticResourceKey<Style> LargeFab => new("MaterialLargeFabStyle");

				[ResourceKeyDefinition(typeof(Style), "MaterialSurfaceLargeFabStyle", TargetType = typeof(global::Microsoft.UI.Xaml.Controls.Button))]
				public static StaticResourceKey<Style> SurfaceLargeFab => new("MaterialSurfaceLargeFabStyle");

				[ResourceKeyDefinition(typeof(Style), "MaterialSecondaryLargeFabStyle", TargetType = typeof(global::Microsoft.UI.Xaml.Controls.Button))]
				public static StaticResourceKey<Style> SecondaryLargeFab => new("MaterialSecondaryLargeFabStyle");

				[ResourceKeyDefinition(typeof(Style), "MaterialTertiaryLargeFabStyle", TargetType = typeof(global::Microsoft.UI.Xaml.Controls.Button))]
				public static StaticResourceKey<Style> TertiaryLargeFab => new("MaterialTertiaryLargeFabStyle");
			}
		}
	}
}
