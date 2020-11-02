using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Bim493_week05
{
    public partial class MyPage2 : ContentPage
    {
        public Random random_generator = new Random();
        public MyPage2()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            //MyButton.SetValue(Grid.RowProperty, 1);
            //MyButton.SetValue(Grid.ColumnProperty, 1);
            MyButton.SetValue(Grid.RowProperty, random_generator.Next(0, 6));
            MyButton.SetValue(Grid.ColumnProperty, random_generator.Next(0, 6));
        }
    }
}
