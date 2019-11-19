namespace STUDENT_MANAGEMENT_SYSTEM
{
    partial class Form2
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
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentAddress = new System.Windows.Forms.Label();
            this.lblStudentClass = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.txtStudentClass = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(148, 53);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(59, 13);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student_Id";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(148, 107);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(78, 13);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student_Name";
            // 
            // lblStudentAddress
            // 
            this.lblStudentAddress.AutoSize = true;
            this.lblStudentAddress.Location = new System.Drawing.Point(148, 155);
            this.lblStudentAddress.Name = "lblStudentAddress";
            this.lblStudentAddress.Size = new System.Drawing.Size(88, 13);
            this.lblStudentAddress.TabIndex = 2;
            this.lblStudentAddress.Text = "Student_Address";
            // 
            // lblStudentClass
            // 
            this.lblStudentClass.AutoSize = true;
            this.lblStudentClass.Location = new System.Drawing.Point(148, 209);
            this.lblStudentClass.Name = "lblStudentClass";
            this.lblStudentClass.Size = new System.Drawing.Size(75, 13);
            this.lblStudentClass.TabIndex = 3;
            this.lblStudentClass.Text = "Student_Class";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(280, 53);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 20);
            this.txtStudentId.TabIndex = 4;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(280, 107);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtStudentName.TabIndex = 5;
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.Location = new System.Drawing.Point(280, 155);
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(100, 20);
            this.txtStudentAddress.TabIndex = 6;
            // 
            // txtStudentClass
            // 
            this.txtStudentClass.Location = new System.Drawing.Point(280, 209);
            this.txtStudentClass.Name = "txtStudentClass";
            this.txtStudentClass.Size = new System.Drawing.Size(100, 20);
            this.txtStudentClass.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(108, 262);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(238, 262);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(362, 262);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 343);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtStudentClass);
            this.Controls.Add(this.txtStudentAddress);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblStudentClass);
            this.Controls.Add(this.lblStudentAddress);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentId);
            this.Name = "Form2";
            this.Text = "Add Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentAddress;
        private System.Windows.Forms.Label lblStudentClass;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentAddress;
        private System.Windows.Forms.TextBox txtStudentClass;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}