//ICI tous les services qui vont call les methodes de DAL  
//qui vont etres utilises par lapp
//a faire: save ,load ,modfiy(immuable?)
//

using schoolManager.Models;

namespace schoolManager.Services
{
    public class ModelSercices
    {
        private readonly JsonDataAccess jsonDataAccess;
        private Dictionary<string, Dictionary<string, object>> data;

        public ModelServices(JsonDataAccess jsonDataAccess)
        {
            this.jsonDataAccess = jsonDataAccess;
            InitializeData();
        }

        private void InitializeData()
        {
            data = jsonDataAccess.LoadData();
        }

        public void SaveChanges()
        {
            jsonDataAccess.SaveData(data);
        }

        // Add methods for manipulating the data, e.g., adding, updating, deleting items
    }
}
