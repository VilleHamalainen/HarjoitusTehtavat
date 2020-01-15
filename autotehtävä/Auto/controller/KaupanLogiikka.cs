using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autokauppa.model;

namespace Autokauppa.controller
{
    
    
    public class KaupanLogiikka: DatabaseHallinta
    {
        DatabaseHallinta dbModel = new DatabaseHallinta();

        public bool TestDatabaseConnection()
        {
            bool doesItWork = dbModel.connectDatabase();
            return doesItWork;
        }

        public bool saveAuto(model.Auto newAuto) 
        {
            bool didItGoIntoDatabase = dbModel.saveAutoIntoDatabase(newAuto);
            return didItGoIntoDatabase;
        }

        public List<int> getAllAutoMakers() {

            return dbModel.getAllAutoMakersFromDatabase();
        }

        public List<int> getAutoModels(int makerId) {

            return dbModel.getAutoModelsByMakerId(makerId);
        }
    }
}
