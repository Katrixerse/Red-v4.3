namespace WindowsFormsApplication5
{
    partial class Geoip
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
            this.materialFlatButton26 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton25 = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialFlatButton26
            // 
            this.materialFlatButton26.AutoSize = true;
            this.materialFlatButton26.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton26.Depth = 0;
            this.materialFlatButton26.Icon = null;
            this.materialFlatButton26.Location = new System.Drawing.Point(69, 152);
            this.materialFlatButton26.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton26.Name = "materialFlatButton26";
            this.materialFlatButton26.Primary = false;
            this.materialFlatButton26.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton26.TabIndex = 16;
            this.materialFlatButton26.Text = "Clear";
            this.materialFlatButton26.UseVisualStyleBackColor = true;
            this.materialFlatButton26.Click += new System.EventHandler(this.materialFlatButton26_Click);
            // 
            // materialFlatButton25
            // 
            this.materialFlatButton25.AutoSize = true;
            this.materialFlatButton25.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton25.Depth = 0;
            this.materialFlatButton25.Icon = null;
            this.materialFlatButton25.Location = new System.Drawing.Point(15, 152);
            this.materialFlatButton25.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton25.Name = "materialFlatButton25";
            this.materialFlatButton25.Primary = false;
            this.materialFlatButton25.Size = new System.Drawing.Size(46, 36);
            this.materialFlatButton25.TabIndex = 15;
            this.materialFlatButton25.Text = "GET";
            this.materialFlatButton25.UseVisualStyleBackColor = true;
            this.materialFlatButton25.Click += new System.EventHandler(this.materialFlatButton25_Click);
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(321, 111);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(255, 186);
            this.textBox9.TabIndex = 14;
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(15, 120);
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(288, 23);
            this.materialSingleLineTextField4.TabIndex = 13;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.Text = "127.0.0.1";
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(333, 79);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 29);
            this.label26.TabIndex = 12;
            this.label26.Text = "Info:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(10, 85);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 29);
            this.label25.TabIndex = 11;
            this.label25.Text = "IP:";
            // 
            // Geoip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 300);
            this.Controls.Add(this.materialFlatButton26);
            this.Controls.Add(this.materialFlatButton25);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.materialSingleLineTextField4);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Name = "Geoip";
            this.Text = "Geoip";
            this.Load += new System.EventHandler(this.Geoip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton26;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton25;
        private System.Windows.Forms.TextBox textBox9;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
    }
}