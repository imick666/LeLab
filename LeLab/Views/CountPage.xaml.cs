using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LeLab.Views
{
    public partial class CountPage : ContentPage
    {

        private int count = 0;

        public CountPage()
        {
            InitializeComponent();

            countLabel.Text = count.ToString();

        }

        

        void CountButtonClick(System.Object sender, System.EventArgs e)
        {
            count++;

            countLabel.Text = count.ToString();
        }
    }
}
