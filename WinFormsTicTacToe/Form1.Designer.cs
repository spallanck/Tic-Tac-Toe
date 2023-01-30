namespace WinFormsTicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerVsComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(231, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.computerVsComputerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.fileToolStripMenuItem.Text = "Game Options";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // computerVsComputerToolStripMenuItem
            // 
            this.computerVsComputerToolStripMenuItem.Name = "computerVsComputerToolStripMenuItem";
            this.computerVsComputerToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.computerVsComputerToolStripMenuItem.Text = "Computer vs. Computer";
            this.computerVsComputerToolStripMenuItem.Click += new System.EventHandler(this.computerVsComputerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1.ForeColor = System.Drawing.Color.Black;
            this.A1.Location = new System.Drawing.Point(8, 22);
            this.A1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.A1.MaximumSize = new System.Drawing.Size(56, 48);
            this.A1.MinimumSize = new System.Drawing.Size(56, 48);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(56, 48);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A2.ForeColor = System.Drawing.Color.Black;
            this.A2.Location = new System.Drawing.Point(84, 22);
            this.A2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(56, 48);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A3.ForeColor = System.Drawing.Color.Black;
            this.A3.Location = new System.Drawing.Point(162, 22);
            this.A3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(56, 48);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C1.ForeColor = System.Drawing.Color.Black;
            this.C1.Location = new System.Drawing.Point(8, 140);
            this.C1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(56, 48);
            this.C1.TabIndex = 4;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C2.ForeColor = System.Drawing.Color.Black;
            this.C2.Location = new System.Drawing.Point(84, 140);
            this.C2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(56, 48);
            this.C2.TabIndex = 5;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C3.ForeColor = System.Drawing.Color.Black;
            this.C3.Location = new System.Drawing.Point(162, 140);
            this.C3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(56, 48);
            this.C3.TabIndex = 6;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B2.ForeColor = System.Drawing.Color.Black;
            this.B2.Location = new System.Drawing.Point(84, 82);
            this.B2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(56, 48);
            this.B2.TabIndex = 7;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B3.ForeColor = System.Drawing.Color.Black;
            this.B3.Location = new System.Drawing.Point(162, 82);
            this.B3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(56, 48);
            this.B3.TabIndex = 8;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B1.ForeColor = System.Drawing.Color.Black;
            this.B1.Location = new System.Drawing.Point(8, 82);
            this.B1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(56, 48);
            this.B1.TabIndex = 9;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(231, 206);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(247, 245);
            this.MinimumSize = new System.Drawing.Size(247, 245);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button A1;
        private Button A2;
        private Button A3;
        private Button C1;
        private Button C2;
        private Button C3;
        private Button B2;
        private Button B3;
        private Button B1;
        private ToolStripMenuItem computerVsComputerToolStripMenuItem;
    }
}