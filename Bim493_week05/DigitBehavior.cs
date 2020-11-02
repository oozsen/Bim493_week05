using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Bim493_week05
{
    public class DigitBehavior : Behavior<Entry>
    {
        private const string digitRegex = @"^[0-9]+$";

        public static readonly BindablePropertyKey IsValidPropertyKey = BindableProperty.CreateReadOnly(
            "IsValid",
            typeof(bool),
            typeof(DigitBehavior),
            false);

        public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

        public bool IsValid
        {
            get
            {
                return (bool)this.GetValue(IsValidProperty);
            }
            set
            {
                this.SetValue(IsValidPropertyKey, value);
            }
        }
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += bindable_TextChanged;
        }

        private void bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry entry;
            entry = (Entry)sender;
            bool b = (entry.Text.Length == 11) ? true : false;                       

            //this.IsValid = Regex.IsMatch(e.NewTextValue, digitRegex);
            this.IsValid = Regex.IsMatch(e.NewTextValue, digitRegex) && b;
            entry.TextColor = this.IsValid ? Color.Default : Color.Red;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= this.bindable_TextChanged;
        }
    }
}
