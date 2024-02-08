using LogBookMaui.Viewmodels;

namespace LogBookMaui
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewmodel mainviewmodel)
        {
            InitializeComponent();
            this.BindingContext = mainviewmodel;
        }

        
    }

}
