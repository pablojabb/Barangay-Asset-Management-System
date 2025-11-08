using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementSystem.Reports
{
    internal class logs
    {
        public string log_id { get; set; }
        public string asset_name { get; set; }
        public string status { get; set; }
        public string condition { get; set; }
        public string assigned_to { get; set; }
        public string date { get; set; }
    }
}
