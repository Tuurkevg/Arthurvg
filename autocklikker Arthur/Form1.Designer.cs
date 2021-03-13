
namespace autocklikker_Arthur
{
    partial class Arthur_clicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arthur_clicker));
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.txttext = new System.Windows.Forms.TextBox();
            this.txttijd = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(83, 95);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(94, 23);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(83, 125);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(94, 23);
            this.btnstop.TabIndex = 1;
            this.btnstop.Text = "stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // txttext
            // 
            this.txttext.Location = new System.Drawing.Point(204, 98);
            this.txttext.Name = "txttext";
            this.txttext.Size = new System.Drawing.Size(102, 20);
            this.txttext.TabIndex = 2;
            // 
            // txttijd
            // 
            this.txttijd.Location = new System.Drawing.Point(204, 127);
            this.txttijd.Name = "txttijd";
            this.txttijd.Size = new System.Drawing.Size(27, 20);
            this.txttijd.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Groetjes van Arthurvg ;)";
            // 
            // Arthur_clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttijd);
            this.Controls.Add(this.txttext);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Arthur_clicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arthurclicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.TextBox txttext;
        private System.Windows.Forms.TextBox txttijd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

