namespace schoolManager;

public partial class MainPage : ContentPage
{
// 	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

// 	private void OnCounterClicked(object sender, EventArgs e)
// 	{
// 		count++;

// 		if (count == 1)
// 			CounterBtn.Text = $"Clicked {count} time";
// 		else
// 			CounterBtn.Text = $"Clicked {count} times";

// 		SemanticScreenReader.Announce(CounterBtn.Text);
// 	}
// }
    private void Button1_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());   
	}
    private void Button2_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());  
	}
    private void Button3_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());  
	}
}