using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using static MVVMFramework.Controls.ControlUtilities;
using static MVVMFramework.Controls.ButtonUtilities;

namespace MVVMFramework.Controls
{
    public static class ButtonUtilities
    {
        internal static Trigger[] CreateButtonTriggers() =>
            new[]
            {
                CreateTrigger(UIElement.IsMouseOverProperty, true, new[] { CreateSetter(Control.BackgroundProperty, Brushes.CadetBlue) }),
                CreateTrigger(UIElement.IsMouseOverProperty, false, new[] { CreateSetter(Control.BorderBrushProperty, Brushes.Transparent), CreateSetter(Control.BackgroundProperty, Brushes.DarkGray) }),
                CreateTrigger(ButtonBase.IsPressedProperty, true, new [] { CreateSetter(Control.BorderBrushProperty, Brushes.Transparent), CreateSetter(UIElement.OpacityProperty, 0.8) })
            };

        internal static Setter[] CreateButtonSetters() =>
            new[]
            {
                CreateSetter(Border.CornerRadiusProperty, new CornerRadius(8))
            };
    }

    public abstract class DefaultButton : Button
    {
        protected DefaultButton()
        {
            Style = SetStyle(CreateButtonSetters(), CreateButtonTriggers());
            HorizontalAlignment = HorizontalAlignment.Center;
            VerticalAlignment = VerticalAlignment.Center;
            Margin = new Thickness(5, 0, 5, 5);
            Padding = new Thickness(5, 5, 5, 5);
        }
    }

    public class ExtraSmallButton : DefaultButton
    {
        public ExtraSmallButton()
        {
            Template = SetTemplateContent<ExtraSmallButton>();
            Width = 50;
            Height = 25;
        }

        static ExtraSmallButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExtraSmallButton), new FrameworkPropertyMetadata(typeof(ExtraSmallButton)));
        }
    }

    public class SmallButton : DefaultButton
    {
        public SmallButton()
        {
            Template = SetTemplateContent<SmallButton>();
            Width = 75;
            Height = 25;
        }

        static SmallButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SmallButton), new FrameworkPropertyMetadata(typeof(SmallButton)));
        }
    }

    public class MediumButton : DefaultButton
    {
        public MediumButton()
        {
            Template = SetTemplateContent<MediumButton>();
            Width = 100;
            Height = 25;
        }

        static MediumButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MediumButton), new FrameworkPropertyMetadata(typeof(MediumButton)));
        }
    }

    public class LargeButton : DefaultButton
    {
        public LargeButton()
        {
            Template = SetTemplateContent<LargeButton>();
            Width = 125;
            Height = 25;
        }

        static LargeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LargeButton), new FrameworkPropertyMetadata(typeof(LargeButton)));
        }
    }

    public class ExtraLargeButton : DefaultButton
    {
        public ExtraLargeButton()
        {
            Template = SetTemplateContent<ExtraLargeButton>();
            Width = 150;
            Height = 25;
        }

        static ExtraLargeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExtraLargeButton), new FrameworkPropertyMetadata(typeof(ExtraLargeButton)));
        }
    }
}
