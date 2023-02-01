using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace Question1
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }


        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            label2.FontSize = value;
            label2.FontAttributes = FontAttributes.Italic;


            label1.Text = String.Format("Font Size: {0}", ((int)value));
            
        }




    }
}