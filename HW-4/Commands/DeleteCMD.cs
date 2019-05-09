using HW_4.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4.Commands
{
    public class DeleteCMD : BaseCommand
    {
        GroupVM GroupVM;

        public DeleteCMD(GroupVM GroupVM)
        {
            this.GroupVM = GroupVM;
        }

        public override void Execute(object parameter)
        {
            int value = Convert.ToInt32(parameter);
            GroupVM.State = value;
            GroupVM.Groups.Remove(GroupVM.Groups.FirstOrDefault(x=>x.No == GroupVM.CurrentGroup.No));
            GroupVM.MyFilteredItems = new ObservableCollection<Entities.Group>(GroupVM.Groups);
            GroupVM.CurrentGroup = null;
        }
    }
}
