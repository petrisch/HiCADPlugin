using ISD.Scripting;
using ISD.BaseTypes;
using ISD.Math;
using ISD.CAD.Base;
using ISD.CAD.Data;
using ISD.CAD.Contexts;
using ISD.CAD.Creators;
using System.Windows.Controls;

namespace PluginTemplate
{
    class FigureLoader : ScriptBase 
    {
        //[Context(typeof(UnconstrainedContext))]

        public FigureLoader(int pr_Height)
        {

            Init();
           //create(Context.ActiveScene.MainAssembly);

           BlockCreator bc = new BlockCreator();
            bc.Length = 100;
            bc.Width = 150;
            bc.Height = pr_Height;
            bc.Name = "Block";
           // Part prt = CreatePart(bc);
            //Part prt = Context.CreatePart(bc);

        }

        public static void Init()
        {

           //Context.NewScene("New_Figure.SZA");
           // var ac = new AssemblyCreator();
           // ac.Name = "Hauptfigur";
           //Context.ActiveScene.CreateMainAssembly(ac);
        }
    }

    /*public static UnconstrainedContext Context
    {
        get { return BaseContext as UnconstrainedContext; }
    }*/
}
