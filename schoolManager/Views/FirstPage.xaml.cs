using Xamarin.Forms.Xaml;

namespace schoolManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
            BindingContext = new FirstViewModel();
        }
    }
}