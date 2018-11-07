using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace XFButtonGestureRecognizersIssue
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            ((VisualElement)sender).BackgroundColor = Color.LightBlue;
        }
    }
}
