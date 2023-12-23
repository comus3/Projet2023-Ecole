namespace schoolManager.Views;
using System;
using schoolManager.Models;

public partial class AddStud : ContentPage
{
    public AddStud()
    {
        InitializeComponent();
        BindingContext = this;
    }
    private void OnCreateClicked(object sender, EventArgs e)
        {
            string firstName = FirstNameEntry.Text;
            string lastName = LastNameEntry.Text;

                // Create Etudiant object using the provided constructor
            Etudiant newEtudiant = new Etudiant(firstName, lastName);

                // Perform any additional actions with the newEtudiant object as needed

                // You can navigate to another page or display a message, for example:
            DisplayAlert("Success", $"Etudiant created: {newEtudiant.FirstName} {newEtudiant.LastName}", "OK");
        }
}