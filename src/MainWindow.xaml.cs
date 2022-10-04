﻿using System;
using System.Net;
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
        public static string version, mustupdate;
        private string serverinfoextracted;

        DispatcherTimer untiload = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // wait 5s until main form
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

            // only for testing
            // MessageBox.Show(version); // should return version
            // MessageBox.Show(mustupdate); // should return 0 or 1

            this.Title = "RivelFree - " + version;
        }


        private void untiload_Tick(object sender, EventArgs e)
        {
            // hide mainwindow
            this.Hide();

            // c#. home home new home is homewindow 😎
            home homewindow = new home();
            homewindow.Show();
        }
    }
}
