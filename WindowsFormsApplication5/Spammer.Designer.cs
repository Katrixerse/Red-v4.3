namespace WindowsFormsApplication5
{
    partial class Spammer
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
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.MaterialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.MaterialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.MaterialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.MaterialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(74, 231);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(47, 20);
            this.Label17.TabIndex = 37;
            this.Label17.Text = "None";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(8, 231);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(60, 20);
            this.Label16.TabIndex = 36;
            this.Label16.Text = "Status:";
            // 
            // MaterialFlatButton4
            // 
            this.MaterialFlatButton4.AutoSize = true;
            this.MaterialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaterialFlatButton4.Depth = 0;
            this.MaterialFlatButton4.Icon = null;
            this.MaterialFlatButton4.Location = new System.Drawing.Point(425, 142);
            this.MaterialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaterialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialFlatButton4.Name = "MaterialFlatButton4";
            this.MaterialFlatButton4.Primary = false;
            this.MaterialFlatButton4.Size = new System.Drawing.Size(108, 36);
            this.MaterialFlatButton4.TabIndex = 35;
            this.MaterialFlatButton4.Text = "Screenshot";
            this.MaterialFlatButton4.UseVisualStyleBackColor = true;
            this.MaterialFlatButton4.Click += new System.EventHandler(this.MaterialFlatButton4_Click);
            // 
            // MaterialFlatButton3
            // 
            this.MaterialFlatButton3.AutoSize = true;
            this.MaterialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaterialFlatButton3.Depth = 0;
            this.MaterialFlatButton3.Icon = null;
            this.MaterialFlatButton3.Location = new System.Drawing.Point(425, 178);
            this.MaterialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaterialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialFlatButton3.Name = "MaterialFlatButton3";
            this.MaterialFlatButton3.Primary = false;
            this.MaterialFlatButton3.Size = new System.Drawing.Size(45, 36);
            this.MaterialFlatButton3.TabIndex = 34;
            this.MaterialFlatButton3.Text = "Set";
            this.MaterialFlatButton3.UseVisualStyleBackColor = true;
            this.MaterialFlatButton3.Click += new System.EventHandler(this.MaterialFlatButton3_Click);
            // 
            // MaterialFlatButton2
            // 
            this.MaterialFlatButton2.AutoSize = true;
            this.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaterialFlatButton2.Depth = 0;
            this.MaterialFlatButton2.Icon = null;
            this.MaterialFlatButton2.Location = new System.Drawing.Point(425, 108);
            this.MaterialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialFlatButton2.Name = "MaterialFlatButton2";
            this.MaterialFlatButton2.Primary = false;
            this.MaterialFlatButton2.Size = new System.Drawing.Size(56, 36);
            this.MaterialFlatButton2.TabIndex = 33;
            this.MaterialFlatButton2.Text = "Stop";
            this.MaterialFlatButton2.UseVisualStyleBackColor = true;
            this.MaterialFlatButton2.Click += new System.EventHandler(this.MaterialFlatButton2_Click);
            // 
            // MaterialFlatButton1
            // 
            this.MaterialFlatButton1.AutoSize = true;
            this.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaterialFlatButton1.Depth = 0;
            this.MaterialFlatButton1.Icon = null;
            this.MaterialFlatButton1.Location = new System.Drawing.Point(425, 73);
            this.MaterialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialFlatButton1.Name = "MaterialFlatButton1";
            this.MaterialFlatButton1.Primary = false;
            this.MaterialFlatButton1.Size = new System.Drawing.Size(64, 36);
            this.MaterialFlatButton1.TabIndex = 32;
            this.MaterialFlatButton1.Text = "Start";
            this.MaterialFlatButton1.UseVisualStyleBackColor = true;
            this.MaterialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(78, 77);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(332, 85);
            this.TextBox1.TabIndex = 31;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(121, 178);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(289, 23);
            this.materialSingleLineTextField1.TabIndex = 30;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Speed(ms):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Text:";
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(425, 245);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(73, 20);
            this.TextBox4.TabIndex = 27;
            this.TextBox4.Visible = false;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(-12, 249);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(80, 20);
            this.TextBox3.TabIndex = 26;
            this.TextBox3.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Spammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 249);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.MaterialFlatButton4);
            this.Controls.Add(this.MaterialFlatButton3);
            this.Controls.Add(this.MaterialFlatButton2);
            this.Controls.Add(this.MaterialFlatButton1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox3);
            this.Name = "Spammer";
            this.Text = "Spammer";
            this.Load += new System.EventHandler(this.Spammer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label16;
        internal MaterialSkin.Controls.MaterialFlatButton MaterialFlatButton4;
        internal MaterialSkin.Controls.MaterialFlatButton MaterialFlatButton3;
        internal MaterialSkin.Controls.MaterialFlatButton MaterialFlatButton2;
        internal MaterialSkin.Controls.MaterialFlatButton MaterialFlatButton1;
        internal System.Windows.Forms.TextBox TextBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}