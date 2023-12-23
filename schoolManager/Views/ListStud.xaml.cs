using schoolManager.Models;

namespace schoolManager.Views;

public partial class ListStud : ContentPage
{
    public ListStud()
    {
        InitializeComponent();
        //Console.WriteLine($"counte: {EvalList.Count}");
        //Console.WriteLine($"counte: {StudList.Count}");
        BindingContext = this;
    }

    List<List<Eval>> evalList = new List<List<Eval>>();
    public List<List<Eval>> EvalList {get {return evalList;}}
    public void Evaluation(){

        foreach(Etudiant etudiant in studList){
            List<Eval> evals = Eval.findStudentEvals(etudiant.UidStudent);
            evalList.Add(evals);
        }
    }
    
    //public List <Eval> listEval = Eval.findStudentEvals(baptiste.UidStudent);
    public List<Etudiant> studList = Etudiant.ListEtudiant;

    public List<Etudiant> StudList {get {return studList;}}
    private void Button_Home(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());   
	}
}