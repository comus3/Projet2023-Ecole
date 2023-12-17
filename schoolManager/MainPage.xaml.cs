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
    private void Button_AddEns(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());   
	}
    private void Button_AddAct(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());  
	}
    private void Button_AddStu(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());  
	}
}