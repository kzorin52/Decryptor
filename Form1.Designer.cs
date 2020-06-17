namespace DragnDropTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.gunaLabel2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(830, 32);
            this.guna2Panel1.TabIndex = 7;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Animated = true;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(695, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.PressedColor = System.Drawing.Color.Gainsboro;
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 32);
            this.guna2ControlBox3.TabIndex = 3;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(740, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.Gainsboro;
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 32);
            this.guna2ControlBox2.TabIndex = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(5, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(59, 15);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "{this.Text}";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(785, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.Gainsboro;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 32);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AllowDrop = true;
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.Controls.Add(this.gunaLabel1);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.Location = new System.Drawing.Point(12, 57);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(806, 381);
            this.guna2Panel2.TabIndex = 8;
            this.guna2Panel2.Click += new System.EventHandler(this.gunaLabel1_Click);
            this.guna2Panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.guna2Panel2_DragDrop);
            this.guna2Panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.guna2Panel2_DragEnter);
            this.guna2Panel2.DragLeave += new System.EventHandler(this.guna2Panel2_DragLeave);
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.gunaLabel1.Location = new System.Drawing.Point(292, 178);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(246, 60);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Drop files to decrypt here,\r\nor click to browse...\r\n";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 455);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Decryptor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

