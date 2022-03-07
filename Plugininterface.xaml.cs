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


namespace PluginTemplate
{
    /// <summary>
    /// Interaktionslogik für Plugininterface.xaml
    /// </summary>
    public partial class Plugininterface : UserControl
    {
        public Plugininterface()
        {
            InitializeComponent();
        }

        public void LoadFigureButton(object sender, RoutedEventArgs e)
        {
            String filename = SolidHeight.Text;
            MessageBox.Show(SolidHeight.Text);

            PropertyReader propertyReader = new PropertyReader();

            FigureLoader prFigure = new FigureLoader(Convert.ToInt32(propertyReader.GetProperty("pr_lichte_breite_L", filename)));

        }

    }
}
