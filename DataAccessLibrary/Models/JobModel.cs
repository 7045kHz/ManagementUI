using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class JobModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Execution_Server { get; set; }
        public int Enabled { get; set; }
        public string Job_Definition { get; set; }
        public string Job_Schedule { get; set; }
        public DateTime Created_On { get; set; }
        public DateTime Last_Updated { get; set; }
        public string Started { get; set; }
        public string Finished { get; set; }

    }
}
