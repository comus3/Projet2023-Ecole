namespace schoolManager.Views;

public partial class FirstPage : ContentPage
{
    public FirstPage()
    {
        InitializeComponent();
    }
}
// using Microsoft.Maui.Controls;

// namespace schoolManager.Views;

//     public partial class FirstPage : ContentPage
//     {
//         TableView enseignantsTable, activitesTable, etudiantsTable;

//         public FirstPage()
//         {
//             InitializeUI();
//         }

//         void InitializeUI()
//         {
//             enseignantsTable = new TableView
//             {
//                 HasUnevenRows = true,
//                 Root = new TableRoot
//                 {
//                     new TableSection("Enseignants")
//                     {
//                         // Ajoutez les Enseignants ici
//                     }
//                 }
//             };

//             activitesTable = new TableView
//             {
//                 HasUnevenRows = true,
//                 Root = new TableRoot
//                 {
//                     new TableSection("Activités")
//                     {
//                         // Ajoutez les Activités ici
//                     }
//                 }
//             };

//             etudiantsTable = new TableView
//             {
//                 HasUnevenRows = true,
//                 Root = new TableRoot
//                 {
//                     new TableSection("Étudiants")
//                     {
//                         // Ajoutez les Étudiants ici
//                     }
//                 }
//             };

//             Content = new StackLayout
//             {
//                 Children = { enseignantsTable, activitesTable, etudiantsTable }
//             };
//         }
//     }