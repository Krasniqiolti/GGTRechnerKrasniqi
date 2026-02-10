using System;
using System.Reflection;
using System.Windows.Forms;

namespace OMG_Krasniqi_Olti
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IModel model = new Model();
            IController controller = new Controller(model);
            Form1 view = new Form1();

            view.SetController(controller);
            controller.SetView(view);

            Application.Run(view);
        }
    }
}
