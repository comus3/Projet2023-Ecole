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
    // public void Evaluation(){
    //     foreach(Etudiant etudiant in studList){
    //         List<Eval> listEval = Eval.findStudentEvals(etudiant.UidStudent);
    //     }
    // }
    
    //public List <Eval> listEval = Eval.findStudentEvals(baptiste.UidStudent);

    public List<Eval> listEval = Eval.ListEval;
    public List<Eval> ListEval {get{return listEval;}}
    public List<Etudiant> StudList {get {return studList;}}
    private void Button_Home(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());   
	}
}