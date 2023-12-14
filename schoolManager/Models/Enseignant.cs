﻿namespace schoolManager.Models;

public class Enseignant : Person
{
    private int salaire;
    public static List<Enseignant> listEnseignant;

    public Enseignant(int salaire,string firstName,string lastName) :
    base(firstName,lastName)
    {
        this.salaire = salaire;
        listEnseignant.Add(this);
    }
    public void Raise(int amt)
    {
        salaire += amt;
    }
    public string ReturnSalary()
    {
        return salaire.ToString();
    }
}
