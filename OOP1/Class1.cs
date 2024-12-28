using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public enum Weekday
    {
        monday=1,
        tuesday=2,
        wednesday=3,
        thursday=4,
        friday=5,
        saturday=6,
        sunday=7

    }
    public enum Seas_on
    {
        spring,
        summer,
        autumn,
        winter
    }

    [Flags]
    public enum Permissions:byte
    {
        Read=1,
        Write=2,
        Delete=4,
        Execute=8
    }
    public class User
    {
        public int id;
        public Permissions permission { get; set; }
    }
    
    public enum Colors
    {
        red,
        green,
        blue
    }
}
