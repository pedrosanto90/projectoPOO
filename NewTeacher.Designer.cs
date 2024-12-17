namespace projectoPOO
{
    partial class NewTeacher
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
            this.txtAddBirthdateTeacher = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtAddLastNameTeacher = new System.Windows.Forms.TextBox();
            this.txtAddPhoneTeacher = new System.Windows.Forms.TextBox();
            this.txtAddNameTeacher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnCancelAddTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddBirthdateTeacher
            // 
            this.txtAddBirthdateTeacher.CustomFormat = "yyyy-mm-dd";
            this.txtAddBirthdateTeacher.Location = new System.Drawing.Point(388, 211);
            this.txtAddBirthdateTeacher.MaxDate = new System.DateTime(2024, 12, 8, 0, 0, 0, 0);
            this.txtAddBirthdateTeacher.Name = "txtAddBirthdateTeacher";
            this.txtAddBirthdateTeacher.Size = new System.Drawing.Size(200, 20);
            this.txtAddBirthdateTeacher.TabIndex = 30;
            this.txtAddBirthdateTeacher.Value = new System.DateTime(2024, 12, 8, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Novo Docente";
            // 
            // txtphone
            // 
            this.txtphone.AutoSize = true;
            this.txtphone.Location = new System.Drawing.Point(226, 195);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(49, 13);
            this.txtphone.TabIndex = 28;
            this.txtphone.Text = "Telefone";
            // 
            // txtdate
            // 
            this.txtdate.AutoSize = true;
            this.txtdate.Location = new System.Drawing.Point(427, 195);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(104, 13);
            this.txtdate.TabIndex = 26;
            this.txtdate.Text = "Data de Nascimento";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(427, 117);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(42, 13);
            this.lbl2.TabIndex = 25;
            this.lbl2.Text = "Apelido";
            // 
            // txtAddLastNameTeacher
            // 
            this.txtAddLastNameTeacher.Location = new System.Drawing.Point(430, 133);
            this.txtAddLastNameTeacher.Name = "txtAddLastNameTeacher";
            this.txtAddLastNameTeacher.Size = new System.Drawing.Size(100, 20);
            this.txtAddLastNameTeacher.TabIndex = 24;
            // 
            // txtAddPhoneTeacher
            // 
            this.txtAddPhoneTeacher.Location = new System.Drawing.Point(229, 211);
            this.txtAddPhoneTeacher.Name = "txtAddPhoneTeacher";
            this.txtAddPhoneTeacher.Size = new System.Drawing.Size(100, 20);
            this.txtAddPhoneTeacher.TabIndex = 22;
            // 
            // txtAddNameTeacher
            // 
            this.txtAddNameTeacher.Location = new System.Drawing.Point(229, 133);
            this.txtAddNameTeacher.Name = "txtAddNameTeacher";
            this.txtAddNameTeacher.Size = new System.Drawing.Size(100, 20);
            this.txtAddNameTeacher.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Primeiro Nome";
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(694, 403);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeacher.TabIndex = 32;
            this.btnAddTeacher.Text = "Adicionar";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnCancelAddTeacher
            // 
            this.btnCancelAddTeacher.Location = new System.Drawing.Point(592, 403);
            this.btnCancelAddTeacher.Name = "btnCancelAddTeacher";
            this.btnCancelAddTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddTeacher.TabIndex = 31;
            this.btnCancelAddTeacher.Text = "Cancelar";
            this.btnCancelAddTeacher.UseVisualStyleBackColor = true;
            this.btnCancelAddTeacher.Click += new System.EventHandler(this.btnCancelAddTeacher_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnCancelAddTeacher);
            this.Controls.Add(this.txtAddBirthdateTeacher);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtAddLastNameTeacher);
            this.Controls.Add(this.txtAddPhoneTeacher);
            this.Controls.Add(this.txtAddNameTeacher);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtAddBirthdateTeacher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtphone;
        private System.Windows.Forms.Label txtdate;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtAddLastNameTeacher;
        private System.Windows.Forms.TextBox txtAddPhoneTeacher;
        private System.Windows.Forms.TextBox txtAddNameTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnCancelAddTeacher;
    }
}