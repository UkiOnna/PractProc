using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ProcessPract
{
    /// <summary>
    /// Логика взаимодействия для ProcessInfo.xaml
    /// </summary>
    public partial class ProcessInfo : UserControl
    {
        public ProcessInfo(string id,string name)
        {
            InitializeComponent();

            nameBlock.Text = name;
            idBlock.Text = id;
        }
    }
}
