using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextFileConnector : IDataConnection
    {
        public PersonModel CreatePerson(PersonModel model)
        {
            // TODO save Person Model TextFile
            return new PersonModel();
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // TODO Save TextFile
            return model;
        }
    }
}
