using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public enum Role {Captain, Helmsman, Sailer, Cook, Gunner }
    internal class Crew : Person
    {
        public Role Role { get; set; }
        public Schedule Schedule { get; set; }
    }

    public class Schedule
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
