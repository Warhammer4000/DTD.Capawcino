using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Capawcino.DatabaseManager;
using DTD.Capawcino.Entities;

namespace DTD.Capawcino.BusinessLogic
{
    public static class BusinessLogicManager
    {
        public static BusinessConfigurations BusinessConfigurations =>
            new CRUDManager().LoadRecords<BusinessConfigurations>(DatabaseStrings.BusinessConfigTable)[0];
    }
}
