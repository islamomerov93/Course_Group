using HW_4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4.Commands
{
    public class AddCMD : BaseCommand
    {
        GroupVM GroupVM;

        public AddCMD(GroupVM GroupVM)
        {
            this.GroupVM = GroupVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == GroupVM.State)
            {
                GroupVM.Groups.Add(GroupVM.CurrentGroup);
                GroupVM.State = 0;
                return;
            }
            int value = Convert.ToInt32(parameter);
            GroupVM.State = value;
        }
    }
}
