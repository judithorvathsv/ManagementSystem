using System;

namespace ManagementSystem.Models
{
    public class Machine
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool Status { get; set; }

        public string SentData { get; set; }


        public Machine()
        {
            Id = Guid.NewGuid().ToString("n");
        }
    }

}
