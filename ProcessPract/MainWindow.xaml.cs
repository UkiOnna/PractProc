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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                ProcessInfo temp = new ProcessInfo(process.Id.ToString(), process.ProcessName);
                listBox.Items.Add(temp);
            }
           
        }

        private void KillClick(object sender, RoutedEventArgs e)
        {
            ProcessInfo killedItem = listBox.SelectedItem as ProcessInfo;
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                if (killedItem.idBlock.Text == process.Id.ToString())
                {
                    process.Kill();
                }
            }

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                listBox.Items.RemoveAt(i);
            }

            foreach (var process in processes)
            {
                ProcessInfo temp = new ProcessInfo(process.Id.ToString(), process.ProcessName);
                listBox.Items.Add(temp);
            }

        }
    }
}
