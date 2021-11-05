using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Shared
{
  public class Machine
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public bool Status { get; set; }

        public string SentData { get; set; }
    }
}
