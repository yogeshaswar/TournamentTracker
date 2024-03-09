using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextFileConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // TODO Save TextFile
            return model;
        }
    }
}
