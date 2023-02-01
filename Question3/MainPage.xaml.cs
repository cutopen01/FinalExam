namespace Question3;
using Question3;


    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new KeypadViewModel();
        }

    }
