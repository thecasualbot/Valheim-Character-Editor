namespace ValheimCharacterEditor.Controls
{
    partial class Vector3_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.textBox_Z = new System.Windows.Forms.TextBox();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_Z = new System.Windows.Forms.Label();
            this.Group_Vector3 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(49, 30);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(152, 20);
            this.textBox_X.TabIndex = 0;
            this.textBox_X.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_Y
            // 
            this.textBox_Y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox_Y.Location = new System.Drawing.Point(49, 56);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(152, 20);
            this.textBox_Y.TabIndex = 1;
            this.textBox_Y.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_Z
            // 
            this.textBox_Z.Location = new System.Drawing.Point(49, 82);
            this.textBox_Z.Name = "textBox_Z";
            this.textBox_Z.Size = new System.Drawing.Size(152, 20);
            this.textBox_Z.TabIndex = 2;
            this.textBox_Z.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X.ForeColor = System.Drawing.Color.White;
            this.label_X.Location = new System.Drawing.Point(18, 30);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(15, 15);
            this.label_X.TabIndex = 3;
            this.label_X.Text = "X";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Y.ForeColor = System.Drawing.Color.White;
            this.label_Y.Location = new System.Drawing.Point(18, 56);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(14, 15);
            this.label_Y.TabIndex = 4;
            this.label_Y.Text = "Y";
            // 
            // label_Z
            // 
            this.label_Z.AutoSize = true;
            this.label_Z.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Z.ForeColor = System.Drawing.Color.White;
            this.label_Z.Location = new System.Drawing.Point(18, 82);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(14, 15);
            this.label_Z.TabIndex = 5;
            this.label_Z.Text = "Z";
            // 
            // Group_Vector3
            // 
            this.Group_Vector3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Vector3.ForeColor = System.Drawing.Color.White;
            this.Group_Vector3.Location = new System.Drawing.Point(3, 3);
            this.Group_Vector3.Name = "Group_Vector3";
            this.Group_Vector3.Size = new System.Drawing.Size(215, 110);
            this.Group_Vector3.TabIndex = 6;
            this.Group_Vector3.TabStop = false;
            this.Group_Vector3.Text = "Group_Vector3";
            // 
            // Vector3_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label_Z);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.textBox_Z);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.Group_Vector3);
            this.Name = "Vector3_Control";
            this.Size = new System.Drawing.Size(225, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.TextBox textBox_Z;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_Z;
        private System.Windows.Forms.GroupBox Group_Vector3;
    }
}
