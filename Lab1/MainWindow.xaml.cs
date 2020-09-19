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

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PrintPigLatin_Click(object sender, RoutedEventArgs e)
        {
            String piglatinFirst;//to output
            String piglatinLast;// to output
            String first = firstname.Text; //from textbox
            String last = lastname.Text; //from textbox
            //To process first name
            piglatinFirst = first.Substring(1, first.Length - 1) + first.Substring(0, 1).ToLower() + "ay";
            piglatinFirst = piglatinFirst.Substring(0, 1).ToUpper() + piglatinFirst.Substring(1, piglatinFirst.Length - 1);
            //to process last name
            piglatinLast = last.Substring(1, last.Length - 1) + last.Substring(0, 1).ToLower() + "ay";
            piglatinLast = piglatinLast.Substring(0, 1).ToUpper() + piglatinLast.Substring(1, piglatinLast.Length - 1);
            MessageBox.Show("Your name in piglatin is " + piglatinFirst + " " + piglatinLast);

        }
    }
}
