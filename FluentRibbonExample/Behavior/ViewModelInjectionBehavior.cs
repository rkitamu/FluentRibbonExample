using CommunityToolkit.Mvvm.DependencyInjection;
using System.ComponentModel;
using System.Windows;

namespace FluentRibbonExample.Behavior
{
    public class ViewModelInjectionBehavior
    {
        public static Ioc IocContainer => Ioc.Default;
        public static Type GetViewModel(DependencyObject obj) => (Type)obj.GetValue(ViewModelProperty);
        public static void SetViewModel(DependencyObject obj, Type value) => obj.SetValue(ViewModelProperty, value);

        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.RegisterAttached(
                "ViewModel",
                typeof(Type),
                typeof(ViewModelInjectionBehavior),
                new FrameworkPropertyMetadata(null,
                    FrameworkPropertyMetadataOptions.NotDataBindable,
                    ViewModelChanged
            ));

        private static void ViewModelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (DesignerProperties.GetIsInDesignMode(d))
                return;

            if (d is FrameworkElement fe && e.NewValue is Type vmType)
            {
                var vm = IocContainer.GetService(vmType);
                if (vm == null)
                {
                    throw new InvalidOperationException($"Could not resolve ViewModel of type {vmType.FullName} from the IoC container.");
                }
                else
                {
                    fe.DataContext = vm;
                }
            }
        }
    }
}
