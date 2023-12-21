namespace schoolManager.Views;

public partial class ListEns : ContentPage
{

    public ListEns()
    {
        InitializeComponent();
    }

    private void Button_Home(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());   
	}
}