using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4.Entities
{
    public class Branch
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }

        public Branch(string number, string address)
        {
            Number = number ?? throw new ArgumentNullException(nameof(number));
            Address = address ?? throw new ArgumentNullException(nameof(address));
        }
    }
}
