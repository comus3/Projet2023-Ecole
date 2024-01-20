using schoolManager.Models;
using Windows.UI.Core;

namespace schoolManager.Views;

public partial class ListStud : ContentPage
{
    public ListStud()
    {
        InitializeComponent();
        Evaluation();
        Console.WriteLine($"count: {EvalList.Count}");
        //Console.WriteLine($"count: {evalList.Count}");
        Console.WriteLine(EvalList);
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