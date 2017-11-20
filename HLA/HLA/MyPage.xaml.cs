using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HLA
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Success", "We have handled the click event", "Great!");
        }
    }
}
