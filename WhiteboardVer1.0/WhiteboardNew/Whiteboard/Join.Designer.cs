﻿
namespace Whiteboard
{
    partial class Join
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
            this.Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.TextBox();
            this.joinARoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nickname";
            // 
            // Name
            // 
            this.Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Name.Location = new System.Drawing.Point(146, 97);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(140, 27);
            this.Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(86, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code";
            // 
            // Code
            // 
            this.Code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Code.Location = new System.Drawing.Point(146, 145);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(140, 27);
            this.Code.TabIndex = 1;
            // 
            // joinARoom
            // 
            this.joinARoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.joinARoom.BackColor = System.Drawing.Color.White;
            this.joinARoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinARoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.joinARoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.joinARoom.Location = new System.Drawing.Point(154, 197);
            this.joinARoom.Name = "joinARoom";
            this.joinARoom.Size = new System.Drawing.Size(123, 46);
            this.joinARoom.TabIndex = 2;
            this.joinARoom.Text = "JOIN";
            this.joinARoom.UseVisualStyleBackColor = false;
            this.joinARoom.Click += new System.EventHandler(this.joinARoom_Click);
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.joinARoom);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            //this.Name = "Join";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Join";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Button joinARoom;
    }
}