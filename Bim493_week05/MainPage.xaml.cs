using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bim493_week05
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        public string Hello { get; set; } = "Hello Bim493";
        public string Hello2 { get; set; } = "Mobile Programming 1 Course Week05";

        void btnClick_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new MyPage2());
        }
    }
}
