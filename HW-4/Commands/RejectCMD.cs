using HW_4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4.Commands
{
    public class RejectCMD : BaseCommand
    {
        GroupVM GroupVM;
        public RejectCMD(GroupVM GroupVM)
        {
            this.GroupVM = GroupVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == GroupVM.State)
            {
                GroupVM.State = 0;
            GroupVM.CurrentGroup = null;
                return;
            }
            int value = Convert.ToInt32(parameter);
            GroupVM.State = value;
        }
    }
}
