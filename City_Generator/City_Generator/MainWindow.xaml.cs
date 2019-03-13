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

namespace City_Generator
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

    public abstract class Settlement
    {
        protected string[] GeneralSizes = {"Large", "Medium", "Small"};
        protected int MinSpecificSize = 0;
        protected int MaxSpecificSize = int.MaxValue;
        protected bool Church = true;
        protected Resource[] Resources = {};
        protected int ResourceCount = 0;

        public string[] GetSizes()
        {
            return GeneralSizes;
        }

        public int GetMinSpecificSize()
        {
            return MinSpecificSize;
        }

        public int GetMaxSpecificSize()
        {
            return MinSpecificSize;
        }

        public bool GetChurch()
        {
            return Church;
        }

        public Resource[] GetResources()
        {
            return Resources;
        }

        public int GetResourceCount()
        {
            return ResourceCount;
        }
1    }

    public class City : Settlement
    {
        public City()
        {
            this.GeneralSizes = {"Metropolis", "Standard", "Border"};
        }
    }

    public class Hamlet : Settlement
    {
        public Hamlet()
        {
            this.MinSpecificSize = 1;
            this.MaxSpecificSize = 100;
            this.Church = false;
        }
    }

    public abstract class Resource
    {
        protected string Name = "Resource";
        protected string Type = "Type";

        public string GetName()
        {
            return Name;
        }

        public string GetType()
        {
            return Type;
        }
    }


}
