namespace schoolManager.Views;

public partial class FirstPage : ContentPage
{

    public FirstPage()
    {
        InitializeComponent();
    }

    private void Button1_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());   
	}
    private void Button2_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());  
	}
}