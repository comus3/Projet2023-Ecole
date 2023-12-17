using schoolManager.Views;

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
    private void Button_AddStud(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());  
	}

	private void Button_ListEns(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ListEns());
	}
	private void Button_ListAct(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ListAct());
	}
	private void Button_ListStud(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ListStud());
	}
}