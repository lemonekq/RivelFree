using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows;
using System.Windows.Threading;

namespace RivelFree
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public static string serverinfo = "https://raw.githubusercontent.com/lemonekq/RivelFree/main/res/static.txt";
        public static string version, mustupdate, tempdir;
        private string serverinfoextracted;

        DispatcherTimer untiload = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // wait 3s until main form
            untiload.Tick += untiload_Tick;
            untiload.Interval = new TimeSpan(0, 0, 3);
            untiload.Start();

            // get data
            using (WebClient client = new WebClient())
            {
                serverinfoextracted = client.DownloadString(serverinfo);
            }

            // some slicing
            string[] serverinfodata = serverinfoextracted.Split(new char[] { ';' }, 2);
            version = serverinfodata[0]; mustupdate = serverinfodata[1];
            mustupdate = mustupdate.Remove(mustupdate.Length - 2);
            version = version.Substring(8);
            mustupdate = mustupdate.Substring(7);

            if (Int32.Parse(mustupdate) == 1)
            {
                MessageBox.Show("You should update your version for new features! github.com/lemonekq/rivalfree");
            } 

            // only for testing
            // MessageBox.Show(version); // should return version
            // MessageBox.Show(mustupdate); // should return 0 or 1

            this.Title = "RivelFree - " + version;
            tempdir = System.IO.Path.GetTempPath() + "/RivelFree/";
            CreateFolder(tempdir); // .
            Directory.Delete(tempdir, true);
            CreateFolder(tempdir);

            Ping pingSender = new Ping(); PingOptions options = new PingOptions();
            options.DontFragment = true;
            string data = "RivelFree @ UpTimeChecker"; byte[] buffer = Encoding.ASCII.GetBytes(data); int timeout = 120;
            PingReply reply = pingSender.Send("google.com", timeout, buffer, options);
            if (reply.Status != IPStatus.Success)
            {
                MessageBox.Show("Function will be not working due to your network. Contact lemonek if needed!");
            }
        }

        public void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        // painful one
        private void untiload_Tick(object sender, EventArgs e)
        {

            // c#. home home new home is homewindow 😎
            home homewindow = new home();
            homewindow.Show();

            // awful memory leak fix, my bad 😭
            untiload.Stop();

            // hide mainwindow
            this.Close();
        }
    }
}
