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

using System.Net;

namespace WSPRAlarm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            download();
        }

        private void download()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(@"http://db1.wspr.live/?query=SELECT * FROM wspr.rx WHERE time>'2021-06-22 12:00:00' AND rx_sign='M0JFG_KIWI' ORDER BY time LIMIT 10000;", @"myfile.txt");
        }
    }
}
