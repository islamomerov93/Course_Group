using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public ServiceType ServiceType { get; set; }
        public Level Level { get; set; }
        public Branch Branch { get; set; }
        public string Note { get; set; }

        public Group Clone()
        {
            return new Group(No, Name, ServiceType, Level, Branch, Note);
        }
        public Group()
        {

        }
        public Group(int no, string name, ServiceType serviceType, Level level, Branch branch, string note)
        {
            No = no;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            ServiceType = serviceType ?? throw new ArgumentNullException(nameof(serviceType));
            Level = level ?? throw new ArgumentNullException(nameof(level));
            Branch = branch ?? throw new ArgumentNullException(nameof(branch));
            Note = note ?? throw new ArgumentNullException(nameof(note));
        }
    }
}
