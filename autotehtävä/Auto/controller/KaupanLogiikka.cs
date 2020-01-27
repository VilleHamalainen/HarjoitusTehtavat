using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autokauppa.model;
using Autokauppa.view;

namespace Autokauppa.controller
{
    
    
    public class KaupanLogiikka: DatabaseHallinta
    {
        DatabaseHallinta dbModel = new DatabaseHallinta();

        public bool connectDB()
        {
            return dbModel.connectDatabase();
        }


        public bool TestDatabaseConnection()
        {
            bool doesItWork = dbModel.connectDatabase();
            return doesItWork;
        }

        public bool saveAuto(Auto newAuto) 
        {
            

            bool didItGoIntoDatabase = dbModel.saveAutoIntoDatabase(newAuto);
            return didItGoIntoDatabase;
        }

        public List<AutonMerkki> getAllAutoMakers() {

            return dbModel.getAllAutoMakersFromDatabase();
        }

        public List<AutonMalli> getAutoModels(int makerId) {

            return dbModel.getAutoModelsByMakerId(makerId);
        }

        public List<Polttoaine> GetAllFuels()
        {
            return dbModel.GetAllFuelsFromDatabase();
        }

        public List<Varit> GetAllColors()
        {
            return dbModel.GetAllColorsFromDatabase();
        }

        public Auto GetNextCar()
        {
            return getNextCarFromDatabase();
        }


    }
}
