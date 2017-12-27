using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamlTest.Droid.Renderers;
using XamlTest.Droid.Utilities;

[assembly: ExportRenderer(typeof(Label), typeof(FontAwesomeLabelRenderer))]

namespace XamlTest.Droid.Renderers
{
    public class FontAwesomeLabelRenderer : LabelRenderer
    {
        public FontAwesomeLabelRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            FontAwesomeUtility.CheckAndSetTypeFace(Control);
        }
    }
}