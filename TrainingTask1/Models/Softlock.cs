using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingTask1.Models
{
    public class Softlock
    {
        public int Employee_id { get; set; }
        public string Manager { get; set; }
        public DateTime Reqdate { get; set; }
        public string Status { get; set; }
        public DateTime LastUpdated { get; set; }
        public int LockId { get; set; }
        public string Requestmessage { get; set; }
        public string WfmRemark { get; set; }
        public string ManagerStatus { get; set; }
        public string MgrStatusComments { get; set; }
        public DateTime MgrLastUpdate { get; set; }
    }
}
