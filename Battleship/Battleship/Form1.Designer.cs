namespace Battleship
{
    partial class Form1
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
            this.LocateShip = new System.Windows.Forms.Button();
            this.showship = new System.Windows.Forms.Button();
            this.hideship = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LocateShip
            // 
            this.LocateShip.BackColor = System.Drawing.Color.Black;
            this.LocateShip.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LocateShip.FlatAppearance.BorderSize = 0;
            this.LocateShip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LocateShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocateShip.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocateShip.ForeColor = System.Drawing.SystemColors.Control;
            this.LocateShip.Location = new System.Drawing.Point(466, 25);
            this.LocateShip.Name = "LocateShip";
            this.LocateShip.Size = new System.Drawing.Size(75, 23);
            this.LocateShip.TabIndex = 0;
            this.LocateShip.Text = "LocateShip";
            this.LocateShip.UseVisualStyleBackColor = false;
            this.LocateShip.Click += new System.EventHandler(this.LocateShip_Click);
            // 
            // showship
            // 
            this.showship.BackColor = System.Drawing.Color.Black;
            this.showship.FlatAppearance.BorderSize = 0;
            this.showship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showship.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showship.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showship.Location = new System.Drawing.Point(466, 383);
            this.showship.Name = "showship";
            this.showship.Size = new System.Drawing.Size(75, 23);
            this.showship.TabIndex = 1;
            this.showship.Text = "ShowShip";
            this.showship.UseVisualStyleBackColor = false;
            this.showship.Click += new System.EventHandler(this.showship_Click);
            // 
            // hideship
            // 
            this.hideship.BackColor = System.Drawing.Color.Black;
            this.hideship.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hideship.FlatAppearance.BorderSize = 0;
            this.hideship.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hideship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideship.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideship.ForeColor = System.Drawing.SystemColors.Control;
            this.hideship.Location = new System.Drawing.Point(466, 55);
            this.hideship.Name = "hideship";
            this.hideship.Size = new System.Drawing.Size(75, 23);
            this.hideship.TabIndex = 2;
            this.hideship.Text = "HideShip";
            this.hideship.UseVisualStyleBackColor = false;
            this.hideship.Click += new System.EventHandler(this.hideship_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Black;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.Control;
            this.clear.Location = new System.Drawing.Point(466, 84);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 3;
            this.clear.Text = "Again";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(466, 190);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 65);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(567, 502);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.hideship);
            this.Controls.Add(this.showship);
            this.Controls.Add(this.LocateShip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LocateShip;
        private System.Windows.Forms.Button showship;
        private System.Windows.Forms.Button hideship;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox textBox1;
    }
}

