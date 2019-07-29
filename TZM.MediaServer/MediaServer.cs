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
            var items = Configuration.Instance.GetItemsByKind(Kind.Camera);
            foreach (var item in items) {
                LoadItems(item);
            }
        }

        private void LoadItems(Item item) {
            foreach (var child in item.GetChildren()) {
                if (child.FQID.Kind == Kind.Camera && child.HasChildren == VideoOS.Platform.HasChildren.No) {
                    Cameras[child.FQID.ObjectId] = child;
                    var status = 0;
                    var jpegSource = new JPEGVideoSource(child);
                    try {
                        jpegSource.Init(640, 480);
                        var jpegData = jpegSource.GetNearest(new DateTime()) as JPEGData;
                        File.WriteAllBytes($"C:/Snapshots/{child.Name}.jpg", jpegData.Bytes);
                    } catch (Exception e) {
                        Console.WriteLine(e.Message);
                        status = 1;
                    }
                    LstCameras.Items.Add(child.Name, status);
                } else {
                    if (child.HasChildren != VideoOS.Platform.HasChildren.No) {
                        LoadItems(child);
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
