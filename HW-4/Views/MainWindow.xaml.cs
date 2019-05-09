using HW_4.Entities;
using HW_4.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace HW_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GroupVM GroupVM;
        int No = 1;
        public MainWindow()
        {
            InitializeComponent();
            this.GroupVM = new GroupVM();
            List<Branch> Branches = new List<Branch>();
            Branch branch1 = new Branch( "050-586-67-18", "Nizami Street");
            Branch branch2 = new Branch( "050-586-67-18", "Koroglu Street");
            Branch branch3 = new Branch( "050-586-67-18", "28 May Street");
            Branch branch4 = new Branch("050-586-67-18", "N.Narimanov Street");
            Branches.Add(branch1);
            Branches.Add(branch2);
            Branches.Add(branch3);
            Branches.Add(branch4);
            GroupVM.Branches = Branches;

            List<ServiceType> ServiceTypes = new List<ServiceType>();
            ServiceType serviceType1 = new ServiceType("Programming");
            ServiceType serviceType2 = new ServiceType("Networking");
            ServiceType serviceType3 = new ServiceType("Design");
            ServiceType serviceType4 = new ServiceType("Java");
            ServiceTypes.Add(serviceType1);
            ServiceTypes.Add(serviceType2);
            ServiceTypes.Add(serviceType3);
            ServiceTypes.Add(serviceType4);
            GroupVM.ServiceTypes = ServiceTypes;

            List<Level> Levels = new List<Level>();
            Level Level1 = new Level("1 Course");
            Level Level2 = new Level("2 Course");
            Level Level3 = new Level("3 Course");
            Level Level4 = new Level("4 Course");
            Levels.Add(Level1);
            Levels.Add(Level2);
            Levels.Add(Level3);
            Levels.Add(Level4);
            GroupVM.Levels = Levels;

            ObservableCollection<Group> Groups = new ObservableCollection<Group>();
            Group group1 = new Group(No++,"AZE-1814", serviceType1, Level1, branch1, "Max 6 people");
            Group group2 = new Group(No++,"AZE-1815", serviceType2, Level2, branch2, "Max 6 people");
            Group group3 = new Group(No++,"AZE-1816", serviceType3, Level3, branch3, "Max 6 people");
            Group group4 = new Group(No++,"AZE-1817", serviceType4, Level4, branch4, "Max 6 people");
            Groups.Add(group1);
            Groups.Add(group2);
            Groups.Add(group3);
            Groups.Add(group4);
            GroupVM.Groups = Groups;

            GroupVM.grid = mainGrid;

            DataContext = GroupVM;
        }
    }
}
