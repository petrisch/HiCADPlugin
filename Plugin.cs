using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Windows.Forms;

using ISD.Plugin;
using System.Windows.Controls;


namespace PluginTemplate
{
    public class Plugin : IPlugin
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        // [STAThread]

        public string Name => "Hi Patrick";
        public string Description => "My Plugin is this";
        public string Author => "Patrick Jörg";
        public Version Version => new Version("1.0");

        public System.Windows.Controls.Control UserInterface => new Plugininterface();

        public Menu UserMenu => new Menu();


        public void Dispose()
        {
            throw new NotImplementedException();

            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/

        }
        public void Initialize(IPluginHost host)
        {
            throw new NotImplementedException();
        }
    }
}
