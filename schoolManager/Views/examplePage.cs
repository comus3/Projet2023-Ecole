// Example usage in your application code
using schoolManager.DAL;
using schoolManager.Services;

namespace schoolManager
{
    public class YourAppClass
    {
        public void ModifyData()
        {
            var jsonDataAccess = new JsonDataAccess("path/to/your/data.json");
            var yourModelService = new ModelSercices(jsonDataAccess);

            // Modify the data using methods in YourModelService

            // Save changes to the JSON file
            yourModelService.SaveChanges();
        }
    }
}
