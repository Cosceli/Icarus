namespace Icarus
{
    partial class WBB200
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WBB200));
            this.txtZer = new System.Windows.Forms.TextBox();
            this.txtRamp = new System.Windows.Forms.TextBox();
            this.txtTakeoff = new System.Windows.Forms.TextBox();
            this.txtZFindex = new System.Windows.Forms.TextBox();
            this.txtRWindex = new System.Windows.Forms.TextBox();
            this.txtTOindex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtZer
            // 
            this.txtZer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtZer.Location = new System.Drawing.Point(545, 80);
            this.txtZer.Name = "txtZer";
            this.txtZer.Size = new System.Drawing.Size(137, 20);
            this.txtZer.TabIndex = 1;
            this.txtZer.Leave += new System.EventHandler(this.WBB200_Load);
            // 
            // txtRamp
            // 
            this.txtRamp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRamp.Location = new System.Drawing.Point(545, 128);
            this.txtRamp.Name = "txtRamp";
            this.txtRamp.Size = new System.Drawing.Size(137, 20);
            this.txtRamp.TabIndex = 3;
            // 
            // txtTakeoff
            // 
            this.txtTakeoff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTakeoff.Location = new System.Drawing.Point(545, 177);
            this.txtTakeoff.Name = "txtTakeoff";
            this.txtTakeoff.Size = new System.Drawing.Size(137, 20);
            this.txtTakeoff.TabIndex = 5;
            this.txtTakeoff.Leave += new System.EventHandler(this.WBB200_Load);
            // 
            // txtZFindex
            // 
            this.txtZFindex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtZFindex.Location = new System.Drawing.Point(729, 80);
            this.txtZFindex.Name = "txtZFindex";
            this.txtZFindex.Size = new System.Drawing.Size(137, 20);
            this.txtZFindex.TabIndex = 2;
            this.txtZFindex.Leave += new System.EventHandler(this.WBB200_Load);
            // 
            // txtRWindex
            // 
            this.txtRWindex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRWindex.Location = new System.Drawing.Point(729, 128);
            this.txtRWindex.Name = "txtRWindex";
            this.txtRWindex.Size = new System.Drawing.Size(137, 20);
            this.txtRWindex.TabIndex = 4;
            this.txtRWindex.Leave += new System.EventHandler(this.WBB200_Load);
            // 
            // txtTOindex
            // 
            this.txtTOindex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTOindex.Location = new System.Drawing.Point(729, 177);
            this.txtTOindex.Name = "txtTOindex";
            this.txtTOindex.Size = new System.Drawing.Size(137, 20);
            this.txtTOindex.TabIndex = 6;
            this.txtTOindex.Leave += new System.EventHandler(this.WBB200_Load);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(455, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Zero Fuel Weight";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(472, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ramp Weight";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(463, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Takeoff Weight";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(868, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ARM Zero Fuel Weight";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(868, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ARM Ramp Weight";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(868, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ARM Takeoff Weight";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cartesianChart1.BackgroundImage = global::Icarus.Properties.Resources.Fundo_Envelope4;
            this.cartesianChart1.ForeColor = System.Drawing.Color.Transparent;
            this.cartesianChart1.Location = new System.Drawing.Point(500, 237);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(434, 299);
            this.cartesianChart1.TabIndex = 8;
            this.cartesianChart1.TabStop = false;
            this.cartesianChart1.Text = "cartesianChart1";
            this.cartesianChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Icarus.Properties.Resources.Logo_200x200_Form;
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WBB200
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTOindex);
            this.Controls.Add(this.txtRWindex);
            this.Controls.Add(this.txtZFindex);
            this.Controls.Add(this.txtTakeoff);
            this.Controls.Add(this.txtRamp);
            this.Controls.Add(this.txtZer);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WBB200";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WB_B200";
            this.Load += new System.EventHandler(this.WBB200_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.TextBox txtZer;
        private System.Windows.Forms.TextBox txtRamp;
        private System.Windows.Forms.TextBox txtTakeoff;
        private System.Windows.Forms.TextBox txtZFindex;
        private System.Windows.Forms.TextBox txtRWindex;
        private System.Windows.Forms.TextBox txtTOindex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}