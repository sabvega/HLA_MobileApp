using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HLA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void ToolbarItem_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyPage());
        }
    }
}
