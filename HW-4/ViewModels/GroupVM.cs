using HW_4.Commands;
using HW_4.Entities;
using HW_4.UserControl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;

namespace HW_4.ViewModels
{
    public class GroupVM : INotifyPropertyChanged
    {
        public Grid grid { get; set; }
        public AddCMD Add { get; set; }
        public EditCMD Edit { get; set; }
        public RejectCMD Reject { get; set; }
        public DeleteCMD Delete { get; set; }

        public OpenGroupsCMD AddUC { get; set; }
        public GroupVM()
        {
            AddUC = new OpenGroupsCMD(this);
            Add = new AddCMD(this);
            Edit = new EditCMD(this);
            Reject = new RejectCMD(this);
            Delete = new DeleteCMD(this);

            CurrentGroup = new Group();
        }

        int state;
        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(State)));
            }
        }

        ObservableCollection<Group> groups;
        public ObservableCollection<Group> Groups {
            get
            {
                return groups;
            }
            set
            {
                groups = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Groups)));
            }
        }

        List<ServiceType> serviceTypes;
        public List<ServiceType> ServiceTypes
        {
            get
            {
                return serviceTypes;
            }
            set
            {
                serviceTypes = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(ServiceTypes)));
            }
        }

        List<Level> levels;
        public List<Level> Levels
        {
            get
            {
                return levels;
            }
            set
            {
                levels = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Levels)));
            }
        }

        List<Branch> branches;
        public List<Branch> Branches
        {
            get
            {
                return branches;
            }
            set
            {
                branches = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Branches)));
            }
        }

        private Group group;

        public Group SelectedGroup
        {
            get { return group; }
            set
            {
                group = value;
                if(value!=null)
                CurrentGroup =  value.Clone();
            }
        }

        private Group currentGroup;

        public Group CurrentGroup
        {
            get { return currentGroup; }
            set { currentGroup = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentGroup))); }
        }

        private string _searchText;

        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;

                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SearchText)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredItems)));
            }
        }

        ObservableCollection<Group> myFilteredItems;
        public ObservableCollection<Group> MyFilteredItems
        {
            get
            {
                if (SearchText == null) return groups;
                
                return (ObservableCollection<Group>)groups.Where(x => x.Name.ToLower().Contains(SearchText.ToLower()) || x.ServiceType.Name.ToLower().Contains(SearchText.ToLower()) ||
                x.Level.Name.ToLower().Contains(SearchText.ToLower()) || x.Branch.Address.ToLower().Contains(SearchText.ToLower()));
            }
            set
            {
                myFilteredItems = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredItems)));
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
