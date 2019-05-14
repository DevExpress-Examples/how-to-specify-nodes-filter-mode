using System.Windows;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Grid;
using System.Collections.Generic;

namespace How_to_Specify_Nodes_Filter_Mode {
    public partial class MainWindow : Window {
        public class Employee {
            public int ID { get; set; }
            public int ParentID { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
            public string Department { get; set; }
            public bool OnVacation { get; set; }
            public bool Enabled { get; set; }
            public override string ToString() {
                return Name;
            }
        }

        public static class Stuff {
            public static ObservableCollection<Employee> GetStuff() {
                ObservableCollection<Employee> stuff = new ObservableCollection<Employee>();
                stuff.Add(new Employee() { ID = 1, ParentID = 0, Name = "Gregory S. Price", Department = "", Position = "President", OnVacation = false, Enabled = false });
                stuff.Add(new Employee() { ID = 5, ParentID = 1, Name = "Karen J. Kelly", Department = "Finance", Position = "Vice President", OnVacation = false, Enabled = true });
                stuff.Add(new Employee() { ID = 2, ParentID = 1, Name = "Irma R. Marshall", Department = "Marketing", Position = "Vice President", OnVacation = false, Enabled = false });
                stuff.Add(new Employee() { ID = 3, ParentID = 1, Name = "John C. Powell", Department = "Operations", Position = "Vice President", OnVacation = false, Enabled = false });                

                stuff.Add(new Employee() { ID = 6, ParentID = 2, Name = "Brian C. Cowling", Department = "Marketing", Position = "Manager", OnVacation = false, Enabled = false });
                stuff.Add(new Employee() { ID = 7, ParentID = 2, Name = "Thomas C. Dawson", Department = "Marketing", Position = "Manager", OnVacation = true, Enabled = false });
                stuff.Add(new Employee() { ID = 8, ParentID = 2, Name = "Angel M. Wilson", Department = "Marketing", Position = "Manager", OnVacation = false, Enabled = true });
                stuff.Add(new Employee() { ID = 9, ParentID = 2, Name = "Bryan R. Henderson", Department = "Marketing", Position = "Manager", OnVacation = false, Enabled = true });

                stuff.Add(new Employee() { ID = 10, ParentID = 3, Name = "Harold S. Brandes", Department = "Operations", Position = "Manager", OnVacation = true, Enabled = true });
                stuff.Add(new Employee() { ID = 11, ParentID = 3, Name = "Michael S. Blevins", Department = "Operations", Position = "Manager", OnVacation = false, Enabled = true });
                stuff.Add(new Employee() { ID = 12, ParentID = 3, Name = "Jan K. Sisk", Department = "Operations", Position = "Manager", OnVacation = false, Enabled = true });
                stuff.Add(new Employee() { ID = 13, ParentID = 3, Name = "Sidney L. Holder", Department = "Operations", Position = "Manager", OnVacation = false, Enabled = true });

                stuff.Add(new Employee() { ID = 14, ParentID = 1, Name = "James L. Kelsey", Department = "Production", Position = "Manager", OnVacation = false, Enabled = false });
                stuff.Add(new Employee() { ID = 15, ParentID = 1, Name = "Howard M. Carpenter", Department = "Production", Position = "Manager", OnVacation = false, Enabled = true });
                stuff.Add(new Employee() { ID = 16, ParentID = 1, Name = "Jennifer T. Tapia", Department = "Production", Position = "Manager", OnVacation = false, Enabled = true });

                return stuff;
            }
        }
        public MainWindow() {
            InitializeComponent();
            gridControl.ItemsSource = Stuff.GetStuff();
        }
    }
}
