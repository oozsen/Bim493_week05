using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Bim493_week05
{
    public partial class DateCell : ViewCell
    {
        public DateCell()
        {
            InitializeComponent();
            BindingContext = this;
        }
        public static readonly BindableProperty LabelProperty =
            BindableProperty.Create(
                "Label",
                typeof(string),
                typeof(DateCell));
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }
     }
}
