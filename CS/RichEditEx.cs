using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace ColosSchemesDemo1 {
    public class RichEditEx : RichEditBox {

        public RichEditEx() {
            DefaultStyleKey = typeof(RichEditEx);
        }

        protected Uri _Source;

        public Uri Source {
            get {
                return this._Source;
            }
            set {
                this._Source = value;
                this.OnSourceChanged();
            }
        }

        async void OnSourceChanged() {
            if (Source == null) {
                Document.SetText(Windows.UI.Text.TextSetOptions.None, null);
            }
            else {
                var file = await StorageFile.GetFileFromApplicationUriAsync(Source);
                var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                Document.LoadFromStream(Windows.UI.Text.TextSetOptions.FormatRtf, stream);
            }
        }
    }
}
