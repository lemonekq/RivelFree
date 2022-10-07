using System;
using System.Windows;

namespace RivelFree
{
    /// <summary>
    /// Interaction logic for corepark.xaml
    /// </summary>
    public partial class corepark : Window
    {
        public corepark()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            home.isactivecore = false; // switch
        }
    }
}
