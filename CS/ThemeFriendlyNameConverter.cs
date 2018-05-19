using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ColosSchemesDemo1 {
    public class ThemeFriendlyNameConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            switch ((ElementTheme)value) {
                case ElementTheme.Light:
                    return "Light";
                case ElementTheme.Default:
                case ElementTheme.Dark:
                    return "Dark";
            }

            return string.Empty;
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
