using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMDemo.Views
{
    /// <summary>
    /// Interaction logic for StudentView.xaml
    /// </summary>
    public partial class StudentView : UserControl
    {
        public StudentView()
        {
            InitializeComponent();

            //View First Construction in Code-behind
            this.DataContext = new MVVMDemo.ViewModel.StudentViewModel();

            /*
             * Another way is that you can get View first construction is by simply constructing the view model yourself in the code behind of your View by setting the DataContext property there with the instance.
               Typically, the DataContext property is set in the constructor method of view, but you could also defer the construction until the Load event of the view fires.
            */
        }
    }
}
