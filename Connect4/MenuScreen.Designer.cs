namespace Connect4
{
    partial class MenuScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMatchmake = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatchmakingServer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMatchmake
            // 
            this.btnMatchmake.Location = new System.Drawing.Point(12, 194);
            this.btnMatchmake.Name = "btnMatchmake";
            this.btnMatchmake.Size = new System.Drawing.Size(260, 55);
            this.btnMatchmake.TabIndex = 0;
            this.btnMatchmake.Text = "Matchmake";
            this.btnMatchmake.UseVisualStyleBackColor = true;
            this.btnMatchmake.Click += new System.EventHandler(this.btnMatchmake_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matchmaking Server:";
            // 
            // lblMatchmakingServer
            // 
            this.lblMatchmakingServer.AutoSize = true;
            this.lblMatchmakingServer.Location = new System.Drawing.Point(9, 25);
            this.lblMatchmakingServer.Name = "lblMatchmakingServer";
            this.lblMatchmakingServer.Size = new System.Drawing.Size(112, 13);
            this.lblMatchmakingServer.TabIndex = 2;
            this.lblMatchmakingServer.Text = "lblMatchmakingServer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "lblServerStatus";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(76, 101);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(196, 20);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username:";
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMatchmakingServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMatchmake);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MenuScreen";
            this.Text = "Connect 4 Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMatchmake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatchmakingServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
    }
}