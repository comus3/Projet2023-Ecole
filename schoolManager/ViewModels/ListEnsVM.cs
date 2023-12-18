using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using schoolManager.Models;
namespace schoolManager.ViewModels;

using System;
using System.Collections.Generic;

internal class ListEnsVM
{
    
    //Enseignant.ListEnseignant;

    public string Ens => "enseignants";
    //Enseignant.ListEnseignant[getListEnseignant];

    // Enseignant.getListEnseignant(){0}.attrigbut1
    List<Enseignant> enseignants = Enseignant.ListEnseignant;
    
}
