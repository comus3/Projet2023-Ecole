namespace schoolManager.Models;

public class Etudiant : Person
{
    List<Eval> evaluations;
    public List<Etudiant> listEtudiant;

    public Etudiant(string firstName,string lastName,List<Eval> evaluations,List<Etudiant> listEtudiant) :
    base(firstName,lastName)
    {
        this.evaluations = evaluations;
        listEtudiant.Add(this);
    }
    public void Add(Eval eval)
    {
        evaluations.Add(eval);
    }
    public double Average()
    {
        int numOfEval = 0;
        int sumOfValues = 0;
        int sumOfECTS = 0;
        foreach(Eval eval in evaluations)
        {
            numOfEval += 1;
            sumOfValues += eval.activite.ECTS * eval.Note();
            sumOfECTS = eval.activite.ECTS;
        }
        return sumOfValues/sumOfECTS/numOfEval;
    }
    public string Bulletin()
    {
        string output = "";
        foreach(Eval eval in evaluations)
        {
            output += string.Format("Pour le cours de {0}, vous avez une note de {1}. {2} Crédits",eval.activite.Name,eval.Note(),eval.activite.ECTS);
        }
        output += string.Format("Pour une fabuleuse moyenne de {0}. Bravo {1}!",Average(),displayName());
        return output;
    }
}
