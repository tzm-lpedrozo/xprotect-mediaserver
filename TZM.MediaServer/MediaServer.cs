using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using VideoOS.Platform;
using VideoOS.Platform.Data;

namespace TZM.MediaServer {

    public partial class MediaServer : Form {

        private Dictionary<Guid, Item> Cameras = new Dictionary<Guid, Item>();

        public MediaServer() {
            InitializeComponent();
            VideoOS.Platform.SDK.Environment.Initialize();
            VideoOS.Platform.SDK.UI.Environment.Initialize();
            var cameras = Configuration.Instance.GetItemsByKind(Kind.Camera);
            foreach (var camera in cameras) {
                Cameras[camera.FQID.ObjectId] = camera;
            }
            // --------
            foreach (var camera in cameras) {
                var jpegSource = new JPEGVideoSource(camera);
                jpegSource.Init();
                var jpegData = jpegSource.GetAtOrBefore(new DateTime()) as JPEGData;
                File.WriteAllBytes("C:/test/test.jpg", jpegData.Bytes);
            }
        }

        private void MediaServer_Load(object sender, EventArgs e) {
        }

    }

}
