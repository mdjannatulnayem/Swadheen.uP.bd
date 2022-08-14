//Team GigaHertz
//Munimalistic ALU
//Brainiac2022
//ASL

using System.Windows.Forms;

namespace Minimalistic_ALU
{
    static class Program
    {
        [System.STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
