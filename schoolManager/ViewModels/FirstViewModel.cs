using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using schoolManager.Models;
namespace schoolManager.ViewModels;

public class FirstViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Etudiant Baptiste { get; set; }

        public FirstViewModel()
        {
            Baptiste = new Etudiant("Batou", "Chouchou", new List<Evaluation>());
        }
    // public string Title1 => "Affichage";
    // //    Enseignant.getListEnseignant();
    // // Enseignant.getListEnseignant(){0}.attrigbut1

    
    // public string Message => "Liste des Enseignants";
    // public ICommand ShowMoreInfoCommand { get; }
    
}