using schoolManager.Services;
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
        Navigation.PushAsync(new AddEns());   
	}
    private void Button_AddAct(object sender, EventArgs e)
	{
        Navigation.PushAsync(new AddAct());  
	}
    private void Button_AddStud(object sender, EventArgs e)
	{
        Navigation.PushAsync(new AddStud());  
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
	private void Save(object sender, EventArgs e){
		AppServices.SaveChanges();
		DisplayAlert("Success","the changes are saved","Ok");

	}
	private void Load(object sender, EventArgs e){
		AppServices.loadData();
		DisplayAlert("Success","the data are loaded","Ok");			
	}

	private void InitializeBackupPicker()
        {
            // Populate the cascading menu with backup file names
            var backupList = AppServices.GenerateBackupList();
            foreach (var backupFileName in backupList)
            {
                backupPicker.Items.Add(backupFileName);
            }
        }

        private void OnBackupSelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selection change if needed
            // You can access the selected item using: backupPicker.SelectedItem
        }

        private void OnLoadDataClicked(object sender, EventArgs e)
        {
            // Call AppServices.loadData with the selected item as parameter
            string selectedBackup = (string)backupPicker.SelectedItem;
            AppServices.LoadData(selectedBackup);
        }


}