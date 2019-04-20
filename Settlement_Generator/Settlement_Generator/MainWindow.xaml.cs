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
using System.Data.SQLite;

namespace Settlement_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        private string[] GeneralSizes = { "Large", "Medium", "Small" };

        public MainWindow()
        {
            InitializeComponent();

            GeneralCombo.ItemsSource = GeneralSizes;
        }

        private void SizeRadio_Check(object sender, RoutedEventArgs e)
        {
            //Show the textbox for when this is the first time a radio button was selected
            SizeText.Visibility = Visibility.Visible;

            //Check which radio button is selected
            if(GeneralRadio.IsChecked.Value)
            {
                //Reveal relevant entry and hide other entry
                GeneralCombo.Visibility = Visibility.Visible;
                SpecificTextBox.Visibility = Visibility.Hidden;

                //Reset other entry
                SpecificTextBox.Text = "";
            }
            if(SpecificRadio.IsChecked.Value)
            {
                //Reveal relevant entry and hide other entry
                SpecificTextBox.Visibility = Visibility.Visible;
                GeneralCombo.Visibility = Visibility.Hidden;

                //Reset other entry
                GeneralCombo.SelectedValue = null;
            }
        }

        private void GenerateClick(object sender, RoutedEventArgs e)
        {
            //Clear statusbar from any earlier messages
            StatusBar.Items.Clear();

            //Check if all of the data has been entered
            if(ValidValues())
            {

            }
            else
            {
                //display an error if something is missing
                StatusBar.Items.Add("Error: More information needed");
            }
        }

        private bool ValidValues()
        {
            return (GeneralRadio.IsChecked.Value || SpecificRadio.IsChecked.Value) && (GeneralCombo.SelectedValue != null || SpecificTextBox.Text != "");
        }
    }
}
