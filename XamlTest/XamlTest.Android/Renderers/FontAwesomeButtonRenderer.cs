using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamlTest.Droid.Utilities;
using XamlTest.Droid.Renderers;

[assembly: ExportRenderer(typeof(Button), typeof(FontAwesomeButtonRenderer))]

namespace XamlTest.Droid.Renderers
{
    public class FontAwesomeButtonRenderer : ButtonRenderer
    {
        public FontAwesomeButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            FontAwesomeUtility.CheckAndSetTypeFace(Control);
        }
    }
}