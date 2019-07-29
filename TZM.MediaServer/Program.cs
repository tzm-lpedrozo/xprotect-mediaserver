using System;
using System.Windows.Forms;
using VideoOS.Platform.SDK;

namespace TZM.MediaServer {

    static class Program {

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VideoOS.Platform.SDK.Environment.Initialize();
            VideoOS.Platform.SDK.Media.Environment.Initialize();
            VideoOS.Platform.SDK.Export.Environment.Initialize();
            var context = MultiEnvironment.CreateSingleServerUserContext("TZM\\lpedrozo", "********", true, new Uri("http://192.168.1.240"));
            if (MultiEnvironment.LoginUserContext(context, true, true)) {
                Application.Run(new MediaServer());
            }
        }

    }

}
