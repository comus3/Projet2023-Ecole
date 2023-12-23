namespace schoolManager.Views;

using System.Collections.ObjectModel;
using schoolManager.Models;

public partial class ListEns : ContentPage
{

    public ListEns()
    {
        InitializeComponent();
        Console.WriteLine($"count: {displayList.Count}");
        BindingContext = this;
    }

    public List<Enseignant> displayList = Enseignant.ListEnseignant;
    public List<Enseignant> DisplayList {get {return displayList;}}

    public string Count {get{return Convert.ToString(displayList.Count);}}
    private void Button_Home(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());   
	}
}