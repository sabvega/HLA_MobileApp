using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HLA
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            Page page = new Page()
            {
                Name = nameEntry.Text,
                Email = emailEntry.Text
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Page>();
                var numberOfRows = conn.Insert(page);

                if (numberOfRows > 0)
                {
                    DisplayAlert("Success", "Person Added", "yay");
                } else
                {
                    DisplayAlert("Failure", "Person Not Added", "shit");
                }
            }
                
        }
    }
}