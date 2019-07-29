using System;
using System.Windows.Forms;
using VideoOS.Platform.SDK;
using VideoOS.Platform.SDK.UI.LoginDialog;

namespace TZM.MediaServer {

    static class Program {

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VideoOS.Platform.SDK.Environment.Initialize();
            VideoOS.Platform.SDK.Media.Environment.Initialize();
            VideoOS.Platform.SDK.Export.Environment.Initialize();
            var success = false;
            Application.Run(new DialogLoginForm(result => success = result));
            if (success) {
                Application.Run(new MediaServer());
            }
        }

    }

}
