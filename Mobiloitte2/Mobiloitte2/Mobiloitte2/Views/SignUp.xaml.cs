using Xamarin.Forms;

namespace Mobiloitte2.Views
{
    public partial class SignUp : ContentPage
    {
        public bool IsVisible = false;
        public SignUp()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            fMAle.Source = "radio2";
            Others.Source = "radio2";
            MAle.Source = "radio1";
        }

        private void TapGestureRecognizer_Tapped_1(object sender, System.EventArgs e)
        {
            MAle.Source = "radio2";
            Others.Source = "radio2";
            fMAle.Source = "radio1";
        }

        private void TapGestureRecognizer_Tapped_2(object sender, System.EventArgs e)
        {
            MAle.Source = "radio2";
            fMAle.Source = "radio2";
            Others.Source = "radio1";
        }

        private void TapGestureRecognizer_Tapped_3(object sender, System.EventArgs e)
        {
            RememberTapped.Source = IsVisible ? "tick" : "untick";
            IsVisible = !IsVisible;
        }
    }
}
