using DevExpress.Core;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace ColosSchemesDemo1 {
    public class MainViewModel : ViewModelBase {

        public MainViewModel() {
            this.ColorSchemeName = this.ColorSchemeNames[0];
        }

        protected List<string> _ColorSchemeNames;
        public List<string> ColorSchemeNames {
            get {
                if (this._ColorSchemeNames == null) {
                    this._ColorSchemeNames = new List<string>() { ThemeManager.GenericSchemeName, "Custom" };
                }
                return this._ColorSchemeNames;
            }
        }

        protected List<ElementTheme> _Themes;

        public List<ElementTheme> Themes {
            get {
                if (this._Themes == null) {
                    this._Themes = new List<ElementTheme>() { ElementTheme.Light, ElementTheme.Dark };
                }
                return this._Themes;
            }
        }

        public string ColorSchemeName {
            get {
                return ThemeManager.CurrentColorSchemeName;
            }
            set {
                ThemeManager.CurrentColorSchemeName = value;
                this.RaisePropertyChanged("ColorSchemeName");
            }
        }


    }
}
