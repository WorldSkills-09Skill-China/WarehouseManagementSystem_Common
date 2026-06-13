namespace WarehouseManagementSystem
{
    partial class FrmTaskDetails
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
            this.lblTaskDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTaskDetails
            // 
            this.lblTaskDetails.AutoSize = true;
            this.lblTaskDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDetails.Location = new System.Drawing.Point(42, 78);
            this.lblTaskDetails.Name = "lblTaskDetails";
            this.lblTaskDetails.Size = new System.Drawing.Size(52, 21);
            this.lblTaskDetails.TabIndex = 0;
            this.lblTaskDetails.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "任务详情";
            // 
            // btnCancelTask
            // 
            this.btnCancelTask.BackColor = System.Drawing.Color.Black;
            this.btnCancelTask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTask.ForeColor = System.Drawing.Color.White;
            this.btnCancelTask.Location = new System.Drawing.Point(253, 383);
            this.btnCancelTask.Name = "btnCancelTask";
            this.btnCancelTask.Size = new System.Drawing.Size(88, 35);
            this.btnCancelTask.TabIndex = 2;
            this.btnCancelTask.Text = "取消任务";
            this.btnCancelTask.UseVisualStyleBackColor = false;
            this.btnCancelTask.Click += new System.EventHandler(this.btnCancelTask_Click);
            // 
            // FrmTaskDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.btnCancelTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTaskDetails);
            this.Name = "FrmTaskDetails";
            this.Text = "FrmTaskDetails";
            this.Load += new System.EventHandler(this.FrmTaskDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelTask;
    }
}