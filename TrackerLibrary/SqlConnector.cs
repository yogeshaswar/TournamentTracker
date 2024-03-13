using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        public PersonModel CreatePerson(PersonModel model)
        {
            // TODO Open Connection to database and save 
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("Tournaments")))
            {

                var p = new DynamicParameters(); // p  = dynamic parameter
                                                 // insert into database
                p.Add("@FirstName", model.FirstName);

                p.Add("@LastName", model.LastName);

                p.Add("@Email", model.Email);

                p.Add("@CellphoneNumber", model.CellphoneNumber);

                // get from database
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // to execute sp in database

                connection.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);

                model.id = p.Get<int>("@id"); // its gonna look into list of p and get id

                return model;

            }


        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Open Connection to database and save 

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("Tournaments")))
            {

                var p = new DynamicParameters(); // p  = dynamic parameter
                                                 // insert into database
                p.Add("@PlaceNumber", model.PlaceNumber);

                p.Add("@PlaceName", model.PlaceName);

                p.Add("@PrizeAmount", model.PrizeAmount);

                p.Add("@PrizePercentage", model.PrizePercentage);

                // get from database
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // to execute sp in database

                connection.Execute("dbo.spPrize_Insert", p, commandType: CommandType.StoredProcedure);

                model.id = p.Get<int>("@id"); // its gonna look into list of p and get id

                return model;

            }
        }
    }
}
