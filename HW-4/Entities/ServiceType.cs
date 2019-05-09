using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ServiceType(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
