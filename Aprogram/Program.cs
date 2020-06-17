using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprogram
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            OnProgramStart.Initialize("nanoclient", "859404", "k5YOT8E4Sl01S3ukSZFXBrExlyvUueQMmX7", "5.0.1.0");
            API.Log("nanoclient", "Program Started");
            App app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}