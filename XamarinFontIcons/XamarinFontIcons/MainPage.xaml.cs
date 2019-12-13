using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFontIcons
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Title = "Main page title";
            string fontFamily = (Xamarin.Forms.OnPlatform<string>)Xamarin.Forms.Application.Current.Resources["FontAwesomeRegularOTF"]; 
            string glyph = "\uf2bb";
            btnContactOtf.ImageSource = new FontImageSource()
            {
                FontFamily = fontFamily,
                Glyph = glyph,
                Color = btnContactOtf.TextColor
            };
            fontFamily = (Xamarin.Forms.OnPlatform<string>)Xamarin.Forms.Application.Current.Resources["FontAwesomeRegularTTF"];
            btnContactTtf.ImageSource = new FontImageSource()
            {
                FontFamily = fontFamily,
                Glyph = glyph,
                Color = btnContactTtf.TextColor
            };
        }
    }
}
