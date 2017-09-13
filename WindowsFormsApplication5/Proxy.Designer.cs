namespace WindowsFormsApplication5
{
    partial class Proxy
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
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.TB_Sources = new System.Windows.Forms.TextBox();
            this.LB_GatheredProxies = new System.Windows.Forms.ListBox();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(416, 73);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(133, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "Gather Proxies";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(416, 143);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(134, 36);
            this.materialFlatButton2.TabIndex = 3;
            this.materialFlatButton2.Text = "SAVE Proxy List";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // TB_Sources
            // 
            this.TB_Sources.Location = new System.Drawing.Point(12, 73);
            this.TB_Sources.Multiline = true;
            this.TB_Sources.Name = "TB_Sources";
            this.TB_Sources.Size = new System.Drawing.Size(195, 199);
            this.TB_Sources.TabIndex = 4;
            // 
            // LB_GatheredProxies
            // 
            this.LB_GatheredProxies.FormattingEnabled = true;
            this.LB_GatheredProxies.Location = new System.Drawing.Point(213, 73);
            this.LB_GatheredProxies.Name = "LB_GatheredProxies";
            this.LB_GatheredProxies.Size = new System.Drawing.Size(195, 199);
            this.LB_GatheredProxies.TabIndex = 2;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(416, 109);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(135, 36);
            this.materialFlatButton3.TabIndex = 5;
            this.materialFlatButton3.Text = "Open Proxy List";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // Proxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 295);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.TB_Sources);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.LB_GatheredProxies);
            this.Controls.Add(this.materialFlatButton1);
            this.Name = "Proxy";
            this.Text = "Proxy";
            this.Load += new System.EventHandler(this.Proxy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.TextBox TB_Sources;
        private System.Windows.Forms.ListBox LB_GatheredProxies;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
    }
}