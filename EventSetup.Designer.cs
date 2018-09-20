﻿namespace MiidBoxOffice
{
    partial class EventSetup
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtEventCode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGetTicketClassesForEvent = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.txtPOSID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblError = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Set up Event";
			// 
			// txtEventCode
			// 
			this.txtEventCode.Enabled = false;
			this.txtEventCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEventCode.Location = new System.Drawing.Point(20, 95);
			this.txtEventCode.Margin = new System.Windows.Forms.Padding(2);
			this.txtEventCode.Name = "txtEventCode";
			this.txtEventCode.Size = new System.Drawing.Size(137, 26);
			this.txtEventCode.TabIndex = 1;
			this.txtEventCode.Text = "12080";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 67);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Enter Event Code";
			// 
			// btnGetTicketClassesForEvent
			// 
			this.btnGetTicketClassesForEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(185)))));
			this.btnGetTicketClassesForEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGetTicketClassesForEvent.ForeColor = System.Drawing.Color.White;
			this.btnGetTicketClassesForEvent.Location = new System.Drawing.Point(172, 93);
			this.btnGetTicketClassesForEvent.Margin = new System.Windows.Forms.Padding(2);
			this.btnGetTicketClassesForEvent.Name = "btnGetTicketClassesForEvent";
			this.btnGetTicketClassesForEvent.Size = new System.Drawing.Size(149, 31);
			this.btnGetTicketClassesForEvent.TabIndex = 3;
			this.btnGetTicketClassesForEvent.Text = "REFRESH";
			this.btnGetTicketClassesForEvent.UseVisualStyleBackColor = false;
			this.btnGetTicketClassesForEvent.Click += new System.EventHandler(this.btnGetTicketClassesForEvent_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 30);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(322, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "The follwoing tickets are linked to your event:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(32, 191);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 82;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(920, 228);
			this.dataGridView1.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(758, 508);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(210, 42);
			this.button1.TabIndex = 6;
			this.button1.Text = "CONTINUE";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtUserID
			// 
			this.txtUserID.Enabled = false;
			this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserID.Location = new System.Drawing.Point(96, 451);
			this.txtUserID.Margin = new System.Windows.Forms.Padding(2);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Size = new System.Drawing.Size(102, 26);
			this.txtUserID.TabIndex = 7;
			this.txtUserID.Text = "10122";
			this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
			// 
			// txtPOSID
			// 
			this.txtPOSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPOSID.Location = new System.Drawing.Point(337, 451);
			this.txtPOSID.Margin = new System.Windows.Forms.Padding(2);
			this.txtPOSID.Name = "txtPOSID";
			this.txtPOSID.Size = new System.Drawing.Size(76, 26);
			this.txtPOSID.TabIndex = 8;
			this.txtPOSID.TextChanged += new System.EventHandler(this.txtPOSID_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(227, 454);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "Enter POS ID";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(15, 454);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "User ID";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblError.ForeColor = System.Drawing.Color.Firebrick;
			this.lblError.Location = new System.Drawing.Point(444, 454);
			this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(51, 20);
			this.lblError.TabIndex = 11;
			this.lblError.Text = "label4";
			this.lblError.Visible = false;
			this.lblError.Click += new System.EventHandler(this.lblError_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MiidBoxOffice.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(821, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(147, 66);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(18, 131);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(950, 305);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tickets";
			// 
			// EventSetup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(980, 561);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPOSID);
			this.Controls.Add(this.txtUserID);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnGetTicketClassesForEvent);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEventCode);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "EventSetup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Miid Box Office - Event Setup";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetTicketClassesForEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPOSID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}