namespace schoolManager.Views;

public partial class ListStud : ContentPage
{
    public ListStud()
    {
        InitializeComponent();
    }
    private void Button_Home(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());   
	}
}