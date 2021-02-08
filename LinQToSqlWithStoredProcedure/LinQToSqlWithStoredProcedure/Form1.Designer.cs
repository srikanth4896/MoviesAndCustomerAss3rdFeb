
namespace LinQToSqlWithStoredProcedure
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeSalary = new System.Windows.Forms.Label();
            this.lblDeptNo = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtEmployeeNAme = new System.Windows.Forms.TextBox();
            this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.txtDeptNo = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(563, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(76, 251);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(81, 17);
            this.lblEmployeeId.TabIndex = 1;
            this.lblEmployeeId.Text = "EmployeeId";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(79, 298);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(107, 17);
            this.lblEmployeeName.TabIndex = 2;
            this.lblEmployeeName.Text = "EmployeeName";
            // 
            // lblEmployeeSalary
            // 
            this.lblEmployeeSalary.AutoSize = true;
            this.lblEmployeeSalary.Location = new System.Drawing.Point(75, 348);
            this.lblEmployeeSalary.Name = "lblEmployeeSalary";
            this.lblEmployeeSalary.Size = new System.Drawing.Size(110, 17);
            this.lblEmployeeSalary.TabIndex = 3;
            this.lblEmployeeSalary.Text = "EmployeeSalary";
            // 
            // lblDeptNo
            // 
            this.lblDeptNo.AutoSize = true;
            this.lblDeptNo.Location = new System.Drawing.Point(82, 394);
            this.lblDeptNo.Name = "lblDeptNo";
            this.lblDeptNo.Size = new System.Drawing.Size(56, 17);
            this.lblDeptNo.TabIndex = 4;
            this.lblDeptNo.Text = "DeptNo";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(237, 251);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeId.TabIndex = 5;
            // 
            // txtEmployeeNAme
            // 
            this.txtEmployeeNAme.Location = new System.Drawing.Point(237, 298);
            this.txtEmployeeNAme.Name = "txtEmployeeNAme";
            this.txtEmployeeNAme.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeNAme.TabIndex = 6;
            // 
            // txtEmployeeSalary
            // 
            this.txtEmployeeSalary.Location = new System.Drawing.Point(237, 348);
            this.txtEmployeeSalary.Name = "txtEmployeeSalary";
            this.txtEmployeeSalary.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeSalary.TabIndex = 7;
            // 
            // txtDeptNo
            // 
            this.txtDeptNo.Location = new System.Drawing.Point(237, 394);
            this.txtDeptNo.Name = "txtDeptNo";
            this.txtDeptNo.Size = new System.Drawing.Size(100, 22);
            this.txtDeptNo.TabIndex = 8;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(57, 453);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(123, 32);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "InsertEmployee";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(237, 452);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 33);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UpdateEmployee";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(402, 452);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 33);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DeleteEmployee";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtDeptNo);
            this.Controls.Add(this.txtEmployeeSalary);
            this.Controls.Add(this.txtEmployeeNAme);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.lblDeptNo);
            this.Controls.Add(this.lblEmployeeSalary);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeSalary;
        private System.Windows.Forms.Label lblDeptNo;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeNAme;
        private System.Windows.Forms.TextBox txtEmployeeSalary;
        private System.Windows.Forms.TextBox txtDeptNo;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

