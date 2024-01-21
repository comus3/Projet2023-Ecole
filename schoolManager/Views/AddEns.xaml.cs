namespace schoolManager.Views;
using System;
using schoolManager.Models;
using Microsoft.Maui.Controls;

public partial class AddEns : ContentPage
{
    public AddEns()
    {
        InitializeComponent();
    }
    private void OnCreateClicked(object sender, EventArgs e)
        {
            // Fetch values from the fields
            int salaire;
            if (int.TryParse(salaireEntry.Text, out salaire))
            {
                string firstName = firstNameEntry.Text;
                string lastName = lastNameEntry.Text;

                // Create Enseignant object using the constructor
                Enseignant newEnseignant = new Enseignant(salaire, firstName, lastName);

                DisplayAlert("Success", $"Enseignant created: {newEnseignant.FirstName} {newEnseignant.LastName} {newEnseignant.Salaire}", "OK");
                firstNameEntry.Text = string.Empty;
                lastNameEntry.Text = string.Empty;
                salaireEntry.Text = string.Empty;
                // Do something with the new Enseignant object if needed
                // (e.g., add it to a list or perform some other operation)
            }
            else
            {
                // Handle invalid salaire input (not an integer)
                // You may want to display an error message or take appropriate action
            }
        }
}