using HW_4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4.Commands
{
    public class EditCMD : BaseCommand
    {
        GroupVM GroupVM;
        public EditCMD(GroupVM GroupVM)
        {
            this.GroupVM = GroupVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == 2)
            {
                GroupVM.State = 1;
                return;
            }
        }
    }
}
