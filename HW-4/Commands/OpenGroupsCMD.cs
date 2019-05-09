using HW_4.UserControl;
using HW_4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4.Commands
{
    public class OpenGroupsCMD : BaseCommand
    {
        GroupVM GroupVM;
        
        public OpenGroupsCMD(GroupVM groupVM)
        {
            GroupVM = groupVM ?? throw new ArgumentNullException(nameof(groupVM));
        }

        public override void Execute(object parameter)
        {
            GroupVM.grid.Children.Add(new GroupInfoUC());
        }
    }
}
