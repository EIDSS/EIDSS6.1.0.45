﻿using System.Data.SqlClient;
using System.Linq;

namespace EIDSS.Reports.Parameterized.Human.AJ.DataSets {
    
    
    public partial class WhoMeaslesRubellaDataSet {
    }
}

namespace EIDSS.Reports.Parameterized.Human.AJ.DataSets.WhoMeaslesRubellaDataSetTableAdapters
{


    public partial class spRepHumWhoMeaslesRubellaTableAdapter 
    {
        internal int CommandTimeout
        {
            get { return CommandCollection.Select(c => c.CommandTimeout).FirstOrDefault(); }
            set
            {
                foreach (SqlCommand command in CommandCollection)
                {
                    command.CommandTimeout = value;
                }
            }
        }
    }
}