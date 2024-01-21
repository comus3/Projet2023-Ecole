namespace schoolManager.Views;

using System;
using Microsoft.Maui.Controls;
using schoolManager.Models;

public partial class AddAct : ContentPage
{
    private string uidTeacher = Guid.Empty.ToString(); // Default value for undefined

    public AddAct()
    {
        InitializeComponent();

        // Populate the picker with teacher names
        foreach (var enseignant in Enseignant.ListEnseignant)
        {
            teacherPicker.Items.Add(enseignant.FirstName);
        }

        // Set the BindingContext to the current instance
        BindingContext = this;
    }

    private void OnTeacherSelectedIndexChanged(object sender, EventArgs e)
        {
            // Update uidTeacher when a teacher is selected
            var selectedTeacherName = teacherPicker.SelectedItem?.ToString();
            if (selectedTeacherName != null)
            {
                uidTeacher = Enseignant.getUidFromName(selectedTeacherName);
            }
            else{
                uidTeacher = Guid.Empty.ToString();
            }
        }

        private void OnCreateClicked(object sender, EventArgs e)
        {
            // Fetch values from the fields
            var name = nameEntry.Text;
            var code = codeEntry.Text;
            var ects = int.TryParse(ectsEntry.Text, out var ectsValue) ? ectsValue : 0;

            // Create Activite object using the constructor
            var activite = new Activite(name, code, uidTeacher, ects);

            DisplayAlert("Success", $"Activite created: {activite.Name} {activite.Code} {activite.Ects}", "OK");
            nameEntry.Text = string.Empty;
            codeEntry.Text = string.Empty;
            ectsEntry.Text = string.Empty;

            // Perform any additional logic with the created Activite object
            // (e.g., save to database, display a message, etc.)

            // For demonstration purposes, print the details to console
            Console.WriteLine($"Name: {activite.Name}, Code: {activite.Code}, Teacher: {activite.UidTeacher}, ECTS: {activite.Ects}");
        }         
}
        