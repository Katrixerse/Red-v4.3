namespace WindowsFormsApplication5
{
    partial class Email
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
            this.label29 = new System.Windows.Forms.Label();
            this.materialFlatButton27 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(83, 219);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(130, 15);
            this.label29.TabIndex = 16;
            this.label29.Text = "*Works with gmail only";
            // 
            // materialFlatButton27
            // 
            this.materialFlatButton27.AutoSize = true;
            this.materialFlatButton27.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton27.Depth = 0;
            this.materialFlatButton27.Icon = null;
            this.materialFlatButton27.Location = new System.Drawing.Point(118, 240);
            this.materialFlatButton27.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton27.Name = "materialFlatButton27";
            this.materialFlatButton27.Primary = false;
            this.materialFlatButton27.Size = new System.Drawing.Size(61, 36);
            this.materialFlatButton27.TabIndex = 15;
            this.materialFlatButton27.Text = "Login";
            this.materialFlatButton27.UseVisualStyleBackColor = true;
            this.materialFlatButton27.Click += new System.EventHandler(this.materialFlatButton27_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(100, 154);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(97, 24);
            this.label28.TabIndex = 14;
            this.label28.Text = "Password:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(117, 81);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 24);
            this.label27.TabIndex = 13;
            this.label27.Text = "Email:";
            // 
            // materialSingleLineTextField6
            // 
            this.materialSingleLineTextField6.Depth = 0;
            this.materialSingleLineTextField6.Hint = "";
            this.materialSingleLineTextField6.Location = new System.Drawing.Point(33, 193);
            this.materialSingleLineTextField6.MaxLength = 100;
            this.materialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField6.Name = "materialSingleLineTextField6";
            this.materialSingleLineTextField6.PasswordChar = '*';
            this.materialSingleLineTextField6.SelectedText = "";
            this.materialSingleLineTextField6.SelectionLength = 0;
            this.materialSingleLineTextField6.SelectionStart = 0;
            this.materialSingleLineTextField6.Size = new System.Drawing.Size(214, 23);
            this.materialSingleLineTextField6.TabIndex = 12;
            this.materialSingleLineTextField6.TabStop = false;
            this.materialSingleLineTextField6.UseSystemPasswordChar = false;
            this.materialSingleLineTextField6.Click += new System.EventHandler(this.materialSingleLineTextField6_Click);
            // 
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Hint = "";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(33, 113);
            this.materialSingleLineTextField5.MaxLength = 100;
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(214, 23);
            this.materialSingleLineTextField5.TabIndex = 11;
            this.materialSingleLineTextField5.TabStop = false;
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
            this.materialSingleLineTextField5.Click += new System.EventHandler(this.materialSingleLineTextField5_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 296);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.materialFlatButton27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.materialSingleLineTextField6);
            this.Controls.Add(this.materialSingleLineTextField5);
            this.Name = "Email";
            this.Text = "Mass Email Sender";
            this.Load += new System.EventHandler(this.Email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label29;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        public MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField6;
        public MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
    }
}