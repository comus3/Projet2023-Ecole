using schoolManager.Models;

namespace schoolManager.Views;

public partial class ListStud : ContentPage
{
    public ListStud()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public List<Etudiant> studList = Etudiant.ListEtudiant;
    public List<Etudiant> StudList {get {return studList;}}
    private void Button_Home(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());   
	}
}