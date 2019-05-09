using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4.Entities
{
    public class Level
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Level(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
