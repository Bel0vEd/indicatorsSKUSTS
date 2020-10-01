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

namespace WpfControlLibrary1
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            Instance = this;
        }
        public static UserControl1 Instance { get; private set; }
        
        
        public void setValueMoment(double value)
        {
            Moment.setValue(Convert.ToInt32(value));
        }

        public void setMaxValueMoment(int value)
        {
            Moment.ArcMaxValue = value;
        }
        public void setValueRevolution(double value)
        {
            Revolution.setValue(Convert.ToInt32(value));
        }
        public void setMaxValueRevolution(int value)
        {
            Revolution.ArcMaxValue = value;
        }
    }
}
