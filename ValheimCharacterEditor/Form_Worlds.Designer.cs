namespace ValheimCharacterEditor
{
    partial class Form_Worlds
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
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.comboBox_worlds = new System.Windows.Forms.ComboBox();
            this.label_Worlds = new System.Windows.Forms.Label();
            this.button_Apply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_set_LP_DP = new System.Windows.Forms.Button();
            this.button_set_LP_SP = new System.Windows.Forms.Button();
            this.button_set_LP_HP = new System.Windows.Forms.Button();
            this.vector3_DeathPoint = new ValheimCharacterEditor.Controls.Vector3_Control();
            this.vector3_SpawnPoint = new ValheimCharacterEditor.Controls.Vector3_Control();
            this.vector3_LogoutPoint = new ValheimCharacterEditor.Controls.Vector3_Control();
            this.vector3_HomePoint = new ValheimCharacterEditor.Controls.Vector3_Control();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.Color.White;
            this.button_Exit.Location = new System.Drawing.Point(461, 3);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(19, 23);
            this.button_Exit.TabIndex = 7;
            this.button_Exit.Text = "x";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Minimize
            // 
            this.button_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minimize.ForeColor = System.Drawing.Color.White;
            this.button_Minimize.Location = new System.Drawing.Point(445, 3);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(19, 23);
            this.button_Minimize.TabIndex = 9;
            this.button_Minimize.Text = "-";
            this.button_Minimize.UseVisualStyleBackColor = false;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // comboBox_worlds
            // 
            this.comboBox_worlds.FormattingEnabled = true;
            this.comboBox_worlds.Location = new System.Drawing.Point(70, 35);
            this.comboBox_worlds.Name = "comboBox_worlds";
            this.comboBox_worlds.Size = new System.Drawing.Size(160, 21);
            this.comboBox_worlds.TabIndex = 12;
            // 
            // label_Worlds
            // 
            this.label_Worlds.AutoSize = true;
            this.label_Worlds.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Worlds.Location = new System.Drawing.Point(12, 36);
            this.label_Worlds.Name = "label_Worlds";
            this.label_Worlds.Size = new System.Drawing.Size(52, 20);
            this.label_Worlds.TabIndex = 13;
            this.label_Worlds.Text = "World";
            // 
            // button_Apply
            // 
            this.button_Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Apply.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Apply.ForeColor = System.Drawing.Color.White;
            this.button_Apply.Location = new System.Drawing.Point(388, 420);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(80, 28);
            this.button_Apply.TabIndex = 14;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = false;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.button_set_LP_HP);
            this.groupBox1.Controls.Add(this.button_set_LP_SP);
            this.groupBox1.Controls.Add(this.button_set_LP_DP);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 140);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Logout Point To";
            // 
            // button_set_LP_DP
            // 
            this.button_set_LP_DP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_set_LP_DP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_set_LP_DP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_set_LP_DP.ForeColor = System.Drawing.Color.White;
            this.button_set_LP_DP.Location = new System.Drawing.Point(6, 22);
            this.button_set_LP_DP.Name = "button_set_LP_DP";
            this.button_set_LP_DP.Size = new System.Drawing.Size(200, 28);
            this.button_set_LP_DP.TabIndex = 19;
            this.button_set_LP_DP.Text = "Death Point";
            this.button_set_LP_DP.UseVisualStyleBackColor = false;
            this.button_set_LP_DP.Click += new System.EventHandler(this.button_set_LP_DP_Click);
            // 
            // button_set_LP_SP
            // 
            this.button_set_LP_SP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_set_LP_SP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_set_LP_SP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_set_LP_SP.ForeColor = System.Drawing.Color.White;
            this.button_set_LP_SP.Location = new System.Drawing.Point(6, 56);
            this.button_set_LP_SP.Name = "button_set_LP_SP";
            this.button_set_LP_SP.Size = new System.Drawing.Size(200, 28);
            this.button_set_LP_SP.TabIndex = 20;
            this.button_set_LP_SP.Text = "Spawn Point";
            this.button_set_LP_SP.UseVisualStyleBackColor = false;
            this.button_set_LP_SP.Click += new System.EventHandler(this.button_set_LP_SP_Click);
            // 
            // button_set_LP_HP
            // 
            this.button_set_LP_HP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_set_LP_HP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_set_LP_HP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_set_LP_HP.ForeColor = System.Drawing.Color.White;
            this.button_set_LP_HP.Location = new System.Drawing.Point(6, 90);
            this.button_set_LP_HP.Name = "button_set_LP_HP";
            this.button_set_LP_HP.Size = new System.Drawing.Size(200, 28);
            this.button_set_LP_HP.TabIndex = 21;
            this.button_set_LP_HP.Text = "Home Point";
            this.button_set_LP_HP.UseVisualStyleBackColor = false;
            this.button_set_LP_HP.Click += new System.EventHandler(this.button_set_LP_HP_Click);
            // 
            // vector3_DeathPoint
            // 
            this.vector3_DeathPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vector3_DeathPoint.Location = new System.Drawing.Point(243, 186);
            this.vector3_DeathPoint.Name = "vector3_DeathPoint";
            this.vector3_DeathPoint.Size = new System.Drawing.Size(225, 120);
            this.vector3_DeathPoint.TabIndex = 17;
            this.vector3_DeathPoint.vector_name = "Group_Vector3";
            // 
            // vector3_SpawnPoint
            // 
            this.vector3_SpawnPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vector3_SpawnPoint.Location = new System.Drawing.Point(243, 62);
            this.vector3_SpawnPoint.Name = "vector3_SpawnPoint";
            this.vector3_SpawnPoint.Size = new System.Drawing.Size(225, 120);
            this.vector3_SpawnPoint.TabIndex = 16;
            this.vector3_SpawnPoint.vector_name = "Group_Vector3";
            // 
            // vector3_LogoutPoint
            // 
            this.vector3_LogoutPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vector3_LogoutPoint.Location = new System.Drawing.Point(12, 186);
            this.vector3_LogoutPoint.Name = "vector3_LogoutPoint";
            this.vector3_LogoutPoint.Size = new System.Drawing.Size(225, 120);
            this.vector3_LogoutPoint.TabIndex = 15;
            this.vector3_LogoutPoint.vector_name = "Group_Vector3";
            // 
            // vector3_HomePoint
            // 
            this.vector3_HomePoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vector3_HomePoint.Location = new System.Drawing.Point(12, 62);
            this.vector3_HomePoint.Name = "vector3_HomePoint";
            this.vector3_HomePoint.Size = new System.Drawing.Size(225, 120);
            this.vector3_HomePoint.TabIndex = 11;
            this.vector3_HomePoint.vector_name = "Group_Vector3";
            // 
            // Form_Worlds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(486, 458);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vector3_DeathPoint);
            this.Controls.Add(this.vector3_SpawnPoint);
            this.Controls.Add(this.vector3_LogoutPoint);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.label_Worlds);
            this.Controls.Add(this.comboBox_worlds);
            this.Controls.Add(this.vector3_HomePoint);
            this.Controls.Add(this.button_Minimize);
            this.Controls.Add(this.button_Exit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Worlds";
            this.Text = "From_Worlds";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Worlds_FormClosing);
            this.Load += new System.EventHandler(this.Form_Worlds_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Minimize;
        private Controls.Vector3_Control vector3_HomePoint;
        private System.Windows.Forms.ComboBox comboBox_worlds;
        private System.Windows.Forms.Label label_Worlds;
        private System.Windows.Forms.Button button_Apply;
        private Controls.Vector3_Control vector3_LogoutPoint;
        private Controls.Vector3_Control vector3_SpawnPoint;
        private Controls.Vector3_Control vector3_DeathPoint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_set_LP_DP;
        private System.Windows.Forms.Button button_set_LP_SP;
        private System.Windows.Forms.Button button_set_LP_HP;
    }
}