namespace schoolManager.Views;

public partial class ListAct : ContentPage
{
    public ListAct()
    {
        InitializeComponent();
    }
    private void Button_Home(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());   
	}
}