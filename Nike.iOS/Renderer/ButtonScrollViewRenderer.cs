using System;
using Nike.Controls;
using Nike.iOS.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomScrollView), typeof(SuperScrollViewRenderer))]
namespace Nike.iOS.Renderer
{
    public class SuperScrollViewRenderer : ScrollViewRenderer { protected override void OnElementChanged(VisualElementChangedEventArgs e) { base.OnElementChanged(e); DelaysContentTouches = false; } }
}
