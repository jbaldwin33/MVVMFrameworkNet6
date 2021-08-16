//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Media;
//using MVVMFramework.Controls;

//namespace TestApp
//{
//    public class LargeTextBox : TextBox
//    {
//        /*
//         * <Setter Property="Height" Value="30"/>
//      <Setter Property="FontSize" Value="20"/>
//      <Setter Property="Padding" Value="5,-2,0,0"></Setter>
//      <Setter Property="Template">
//        <Setter.Value>
//          <ControlTemplate TargetType="{x:Type TextBoxBase}">
//            <Border Name="Border" CornerRadius="2" Padding="2"
//                    Background="{StaticResource WindowBackgroundBrush}"
//                    BorderBrush="{StaticResource SolidBorderBrush}"
//                    BorderThickness="1" >
//              <ScrollViewer CanContentScroll="False" x:Name="PART_ContentHost"/>
//         */
//        static ControlTemplate SetTemplateContent<T>() where T : Control
//        {
//            var template = new ControlTemplate(typeof(T));
//            var scrollViewer = new FrameworkElementFactory(typeof(ScrollViewer))
//            {
//                Name = "PART_ContentHost"
//            };
//            var border = new FrameworkElementFactory(typeof(Border));
//            border.SetValue(Border.CornerRadiusProperty, new TemplateBindingExtension(Border.CornerRadiusProperty));
//            border.SetValue(Border.PaddingProperty, new TemplateBindingExtension(Border.PaddingProperty));
//            border.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(Border.BackgroundProperty));
//            border.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(Border.BorderBrushProperty));
//            border.SetValue(Border.BorderThicknessProperty, new TemplateBindingExtension(Border.BorderThicknessProperty));
//            scrollViewer.SetValue(NameProperty, new TemplateBindingExtension(NameProperty));
//            scrollViewer.SetValue(ContentControl.ContentProperty, new TemplateBindingExtension(ContentControl.ContentProperty));
//            scrollViewer.SetValue(ScrollViewer.CanContentScrollProperty, new TemplateBindingExtension(ScrollViewer.CanContentScrollProperty));
//            scrollViewer.SetValue(FrameworkElement.HorizontalAlignmentProperty, new TemplateBindingExtension(FrameworkElement.HorizontalAlignmentProperty));
//            scrollViewer.SetValue(FrameworkElement.VerticalAlignmentProperty, new TemplateBindingExtension(FrameworkElement.VerticalAlignmentProperty));
//            border.AppendChild(scrollViewer);
//            template.VisualTree = border;
//            return template;
//        }
//        public LargeTextBox()
//        {
            
//            Width = 150;
//            Height = 30;
//            FontSize = 20;
//        }

//        static LargeTextBox()
//        {
//            DefaultStyleKeyProperty.OverrideMetadata(typeof(LargeTextBox), new FrameworkPropertyMetadata(typeof(LargeTextBox)));
//        }
//    }
//}
