namespace schoolManager;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		Console.WriteLine("On demarre");
	}
}
