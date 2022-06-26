using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Mvvm;
using System.Net.Http;
using System.Threading.Tasks;

namespace DXApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new Employee();
        }

        static HttpClient client = new HttpClient();

        /*static async Task<Employee> GetEmployeeAsync()
        {
            Employee stuffServer = null;
            HttpResponseMessage response = await client.GetAsync("http://localhost:5251/api/Test");
            if (response.IsSuccessStatusCode)
            {
                stuffServer = await response.Content.ReadAsAsync<Employee>();
            }
            return stuffServer;
        }*/

    }
    public class Employee
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
    }
    public static class Staff
    {
        public static List<Employee> GetStaff()
        {
            List<Employee> staff = new List<Employee>();
            staff.Add(new Employee() { ID = 0, Name = "Gregory S. Price", Department = "", Position = "President" });
            staff.Add(new Employee() { ID = 1, ParentID = 0, Name = "Irma R. Marshall", Department = "Marketing", Position = "Vice President" });
            staff.Add(new Employee() { ID = 2, ParentID = 0, Name = "John C. Powell", Department = "Operations", Position = "Vice President" });
            staff.Add(new Employee() { ID = 3, ParentID = 0, Name = "Christian P. Laclair", Department = "Production", Position = "Vice President" });
            staff.Add(new Employee() { ID = 4, ParentID = 0, Name = "Karen J. Kelly", Department = "Finance", Position = "Vice President" });
            staff.Add(new Employee() { ID = 5, ParentID = 1, Name = "Brian C. Cowling", Department = "Marketing", Position = "Manager" });
            staff.Add(new Employee() { ID = 6, ParentID = 1, Name = "Thomas C. Dawson", Department = "Marketing", Position = "Manager" });
            staff.Add(new Employee() { ID = 7, ParentID = 1, Name = "Angel M. Wilson", Department = "Marketing", Position = "Manager" });
            staff.Add(new Employee() { ID = 8, ParentID = 1, Name = "Bryan R. Henderson", Department = "Marketing", Position = "Manager" });
            staff.Add(new Employee() { ID = 9, ParentID = 2, Name = "Harold S. Brandes", Department = "Operations", Position = "Manager" });
            staff.Add(new Employee() { ID = 10, ParentID = 2, Name = "Michael S. Blevins", Department = "Operations", Position = "Manager" });
            staff.Add(new Employee() { ID = 11, ParentID = 2, Name = "Jan K. Sisk", Department = "Operations", Position = "Manager" });
            staff.Add(new Employee() { ID = 12, ParentID = 2, Name = "Sidney L. Holder", Department = "Operations", Position = "Manager" });
            staff.Add(new Employee() { ID = 13, ParentID = 3, Name = "James L. Kelsey", Department = "Production", Position = "Manager" });
            staff.Add(new Employee() { ID = 14, ParentID = 3, Name = "Howard M. Carpenter", Department = "Production", Position = "Manager" });
            staff.Add(new Employee() { ID = 15, ParentID = 3, Name = "Jennifer T. Tapia", Department = "Production", Position = "Manager" });
            staff.Add(new Employee() { ID = 16, ParentID = 4, Name = "Judith P. Underhill", Department = "Finance", Position = "Manager" });
            staff.Add(new Employee() { ID = 17, ParentID = 4, Name = "Russell E. Belton", Department = "Finance", Position = "Manager" });
            return staff;
        }
    }
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Employees = Staff.GetStaff();
        }
        public List<Employee> Employees { get; private set; }
    }
}
