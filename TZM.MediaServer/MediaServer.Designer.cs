namespace TZM.MediaServer {

    partial class MediaServer {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaServer));
            this.LstCameras = new System.Windows.Forms.ListView();
            this.ImgStatus = new System.Windows.Forms.ImageList(this.components);
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.BtnEncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstCameras
            // 
            this.LstCameras.HideSelection = false;
            this.LstCameras.Location = new System.Drawing.Point(15, 12);
            this.LstCameras.Name = "LstCameras";
            this.LstCameras.Size = new System.Drawing.Size(373, 261);
            this.LstCameras.SmallImageList = this.ImgStatus;
            this.LstCameras.TabIndex = 1;
            this.LstCameras.UseCompatibleStateImageBehavior = false;
            this.LstCameras.View = System.Windows.Forms.View.List;
            // 
            // ImgStatus
            // 
            this.ImgStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgStatus.ImageStream")));
            this.ImgStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgStatus.Images.SetKeyName(0, "ok_button.png");
            this.ImgStatus.Images.SetKeyName(1, "delete_button_error.png");
            // 
            // TrayIcon
            // 
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "TZM Media Server";
            this.TrayIcon.Visible = true;
            this.TrayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
            // 
            // BtnEncerrar
            // 
            this.BtnEncerrar.Location = new System.Drawing.Point(311, 279);
            this.BtnEncerrar.Name = "BtnEncerrar";
            this.BtnEncerrar.Size = new System.Drawing.Size(77, 23);
            this.BtnEncerrar.TabIndex = 2;
            this.BtnEncerrar.Text = "Finalizar";
            this.BtnEncerrar.UseVisualStyleBackColor = true;
            this.BtnEncerrar.Click += new System.EventHandler(this.BtnEncerrar_Click);
            // 
            // MediaServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 314);
            this.Controls.Add(this.BtnEncerrar);
            this.Controls.Add(this.LstCameras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MediaServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TZM - Milestone XProtect Media Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MediaServer_FormClosing);
            this.Load += new System.EventHandler(this.MediaServer_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView LstCameras;
        private System.Windows.Forms.ImageList ImgStatus;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.Button BtnEncerrar;
    }

}
