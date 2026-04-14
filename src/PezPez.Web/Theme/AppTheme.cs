using MudBlazor;

namespace PezPez.Web.Theme;

public static class AppTheme
{
    public static MudTheme PezPezTheme => new()
    {
        PaletteLight = new PaletteLight
        {
            Primary = "#5B5FEF",
            Secondary = "#10B981",
            Tertiary = "#0F172A",
            Info = "#3B82F6",
            Success = "#22C55E",
            Warning = "#F59E0B",
            Error = "#EF4444",
            Background = "#F4F7FB",
            Surface = "#FFFFFF",
            AppbarBackground = "#FFFFFF",
            AppbarText = "#111827",
            DrawerBackground = "#081225",
            DrawerText = "#E5E7EB",
            DrawerIcon = "#94A3B8",
            TextPrimary = "#111827",
            TextSecondary = "#6B7280",
            LinesDefault = "#E5E7EB",
            TableLines = "#EEF2F7",
            Divider = "#E5E7EB"
        },
        LayoutProperties = new LayoutProperties
        {
            DefaultBorderRadius = "16px"
        },
        Typography = new Typography
        {
            Default = new DefaultTypography
            {
                FontFamily = new[] { "Inter", "Segoe UI", "sans-serif" }
            },
            H4 = new H4Typography
            {
                FontWeight = "700",
                LetterSpacing = "-0.03em"
            },
            H5 = new H5Typography
            {
                FontWeight = "700",
                LetterSpacing = "-0.02em"
            },
            H6 = new H6Typography
            {
                FontWeight = "600"
            },
            Subtitle1 = new Subtitle1Typography
            {
                FontWeight = "600"
            },
            Button = new ButtonTypography
            {
                FontWeight = "600",
                TextTransform = "none"
            }
        }
    };
}