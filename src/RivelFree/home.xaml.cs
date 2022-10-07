using System;
using System.Management;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace RivelFree
{
    /// <summary>
    /// Interaction logic for home.xaml
    /// </summary>
    public partial class home : Window
    {
        // variables
        private string cpuname, cpucores;
        private float ramfloat;
        public static bool isactivecore;

        public home()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Title = "RivelFree - " + MainWindow.version;
            titlelabel.Content = "RivelFree - " + MainWindow.version;

            // hide tabcontrol
            Style s = new Style();
            s.Setters.Add(new Setter(UIElement.VisibilityProperty, Visibility.Collapsed));
            tabcontrolcontainer.ItemContainerStyle = s;

            getpcinfo();
            switchwindow(1);
        }

        private void dragbox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // ez
            this.Close();
        }

        // for hardware page
        void getpcinfo()
        {
            // get cpu name
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject mo in mos.Get())
            {
                cpuname = (string)mo["Name"];
            }

            // get cores
            cpucores = Environment.ProcessorCount.ToString();

            cpulabel.Content = cpuname + " / " + cpucores + "cores";

            // get gpu
            using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    gpulabel.Content = obj["Name"];
                }
            }

            // get ram
            ManagementObjectSearcher Search = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");

            foreach (ManagementObject Mobject in Search.Get())
            {
                double Ram_Bytes = (Convert.ToDouble(Mobject["TotalPhysicalMemory"]));

                // it kinda works. kinda
                ConnectionOptions connection = new ConnectionOptions();
                connection.Impersonation = ImpersonationLevel.Impersonate;
                ManagementScope scope = new ManagementScope("\\\\.\\root\\CIMV2", connection);
                scope.Connect();
                ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory"); ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query); foreach (ManagementObject queryObj in searcher.Get())
                {
                    // cut the float, this isnt the pi number LOL
                    ramfloat = (float)(Ram_Bytes / 1073741824);
                    ramfloat = (float)System.Math.Round(ramfloat, 2);
                    ramlabel.Content = (string)ramfloat.ToString() + "GB / " + GetMemoryType(Int32.Parse(queryObj["MemoryType"].ToString()));
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            corepark cp = new corepark(); // c# progres day 69420: object reference is not instance of an object.
            if (isactivecore == false)
            {
                cp.Show();
                isactivecore = true;
            } else
            {
                // maybe custom messagebox if the program will grow
                MessageBox.Show("You cannot open two forms!");
            }
        }

        // windowswitcher !-!!-!!-!!-!!-!!-! 1-7/0-6 | messy code warning 🎇
        public void switchwindow(int window)
        {
            if (window == 1)
            {
                tabcontrolcontainer.SelectedIndex = 0;
                cleantext();
                hardwaretitle.Foreground = System.Windows.Media.Brushes.IndianRed;
            }

            if (window == 2)
            {
                tabcontrolcontainer.SelectedIndex = 1;
                cleantext();
                hardwaretitle.Foreground = System.Windows.Media.Brushes.IndianRed;
            }

            if (window == 3)
            {
                tabcontrolcontainer.SelectedIndex = 2;
                cleantext();
                hardwaretitle.Foreground = System.Windows.Media.Brushes.IndianRed;
            }

            if (window == 4)
            {
                tabcontrolcontainer.SelectedIndex = 3;
                cleantext();
                hardwaretitle.Foreground = System.Windows.Media.Brushes.IndianRed;
            }

            if (window == 5)
            {
                tabcontrolcontainer.SelectedIndex = 4;
                cleantext();
                hardwaretitle.Foreground = System.Windows.Media.Brushes.IndianRed;
            }

            if (window == 6)
            {
                tabcontrolcontainer.SelectedIndex = 5;
                cleantext();
                hardwaretitle.Foreground = System.Windows.Media.Brushes.IndianRed;
            }

            if (window == 7)
            {
                tabcontrolcontainer.SelectedIndex = 6;
                cleantext();
                hardwaretitle.Foreground = System.Windows.Media.Brushes.IndianRed;
            }
        }

        void cleantext()
        {
            hardwaretitle.Foreground = System.Windows.Media.Brushes.White;
            networktitle.Foreground = System.Windows.Media.Brushes.White;
            latencytitle.Foreground = System.Windows.Media.Brushes.White;
            cleanertitle.Foreground = System.Windows.Media.Brushes.White;
            systemtitle.Foreground = System.Windows.Media.Brushes.White;
            tweakstitle.Foreground = System.Windows.Media.Brushes.White;
            optimizationtitle.Foreground = System.Windows.Media.Brushes.White;
        }

        // i will update it later for ddr5
        public string GetMemoryType(int MemoryType)
        {
            switch (MemoryType)
            {
                case 20:
                    return "DDR-2";
                case 21:
                    return "DDR-3";
                default:
                    if (MemoryType == 0 || MemoryType > 22)
                        return "DDR-4-5";
                    else
                        return "Other";
            }
        }
    }
}
