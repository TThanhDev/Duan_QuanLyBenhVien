﻿namespace QuanLyBenhVien
{
    partial class Admin_ThuQuyen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRoleUser = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.panelThuQuyen = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 94);
            this.panel1.TabIndex = 2;
            // 
            // btnRoleUser
            // 
            this.btnRoleUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoleUser.Location = new System.Drawing.Point(700, 6);
            this.btnRoleUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnRoleUser.Name = "btnRoleUser";
            this.btnRoleUser.Size = new System.Drawing.Size(336, 82);
            this.btnRoleUser.TabIndex = 2;
            this.btnRoleUser.Text = "REVOKE ROLE FROM USER";
            this.btnRoleUser.UseVisualStyleBackColor = true;
            this.btnRoleUser.Click += new System.EventHandler(this.btnRoleUser_Click);
            // 
            // btnRole
            // 
            this.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRole.Location = new System.Drawing.Point(353, 6);
            this.btnRole.Margin = new System.Windows.Forms.Padding(6);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(335, 82);
            this.btnRole.TabIndex = 1;
            this.btnRole.Text = "REVOKE PRIVELEGE FROM ROLE";
            this.btnRole.UseVisualStyleBackColor = true;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnUser
            // 
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUser.Location = new System.Drawing.Point(6, 6);
            this.btnUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(335, 82);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "REVOKE PRIVELEGE FROM USER";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // panelThuQuyen
            // 
            this.panelThuQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelThuQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThuQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelThuQuyen.Location = new System.Drawing.Point(0, 94);
            this.panelThuQuyen.Margin = new System.Windows.Forms.Padding(6);
            this.panelThuQuyen.Name = "panelThuQuyen";
            this.panelThuQuyen.Size = new System.Drawing.Size(1042, 764);
            this.panelThuQuyen.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnRoleUser, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRole, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 94);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Admin_ThuQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 858);
            this.Controls.Add(this.panelThuQuyen);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Admin_ThuQuyen";
            this.Text = "Admin_ThuQuyen";
            this.Load += new System.EventHandler(this.Admin_ThuQuyen_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRoleUser;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panelThuQuyen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}