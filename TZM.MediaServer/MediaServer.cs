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
            var count = 0;
            InitializeComponent();
            var configs = Configuration.Instance.GetItems();
            foreach (var config in configs) {
                foreach (var cameraGroup in config.GetChildren()) {
                    foreach (var defaultCameraGroup in cameraGroup.GetChildren()) {
                        foreach (var camera in defaultCameraGroup.GetChildren()) {
                            if (camera.FQID.Kind == Kind.Camera) {
                                Cameras[camera.FQID.ObjectId] = camera;
                                var status = 0;
                                var jpegSource = new JPEGVideoSource(camera);
                                try {
                                    jpegSource.Init();
                                    var jpegData = jpegSource.GetAtOrBefore(new DateTime()) as JPEGData;
                                    File.WriteAllBytes($"C:/Snapshots/{camera.Name}.jpg", jpegData.Bytes);
                                } catch (Exception e) {
                                    Console.WriteLine(e.Message);
                                    status = 1;
                                }
                                LstCameras.Items.Add(camera.Name, status);
                                ++count;
                            }
                        }
                    }
                }
            }
        }

        private void MediaServer_Load(object sender, EventArgs e) {
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e) {
            Show();
        }

        private void MediaServer_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Hide();
            }
        }

        private void BtnEncerrar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

    }

}
