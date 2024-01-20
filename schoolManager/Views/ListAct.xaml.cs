using schoolManager.Models;

namespace schoolManager.Views;

public partial class ListAct : ContentPage
{
    public ListAct()
    {
        InitializeComponent();
        BindingContext = this;
    }
    public List<Activite> actList = Activite.ListActivite;
    public List<Activite> ActList {get{return actList;}}
    // private void Uid_Name(){
    //     foreach (Activite activite in actList){
    //         string UidTeacher = Activite.findActivite();
    //         List<Enseignant> ensName = Enseignant.findEnseignant(actList.UidTeacher).FirstName;
    //     }
    // }
    
    private void Button_Home(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());   
	}
}