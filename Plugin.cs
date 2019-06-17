using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public string Name => "PluginTemplate";
        public string Description => "Example Plugin for Tests";
        public string Author => "Patrick Jörg, patrick.joerg@gilgends.com";
        public Version Version => new Version("0.1");

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
