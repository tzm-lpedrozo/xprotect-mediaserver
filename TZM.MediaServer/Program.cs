using System;
using System.Windows.Forms;
using VideoOS.Platform.SDK.UI.LoginDialog;

namespace TZM.MediaServer {

    static class Program {

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VideoOS.Platform.SDK.Environment.Initialize();
            VideoOS.Platform.SDK.UI.Environment.Initialize();
            VideoOS.Platform.SDK.Export.Environment.Initialize();
            Application.Run(new DialogLoginForm((result) => {
                if (result) {
                    Application.Run(new MediaServer());
                }
            }));
        }

    }

}
