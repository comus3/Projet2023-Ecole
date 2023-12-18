using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using schoolManager.Models;
namespace schoolManager.ViewModels;

//using System.Collections.Generic;


internal class ListEnsVM
{
    public string Ens => "enseignants";
    
    public string enseignants => Enseignant.ListEnseignant;
    public string ens => Enseignant.getListEnseignant;


    //Enseignant.ListEnseignant[getListEnseignant];
    // Enseignant.getListEnseignant(){0}.attrigbut1
    //List<Enseignant> enseignants = Enseignant.ListEnseignant;
    
}
