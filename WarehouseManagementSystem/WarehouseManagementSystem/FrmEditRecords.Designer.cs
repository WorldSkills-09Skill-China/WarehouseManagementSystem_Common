namespace WarehouseManagementSystem
{
    partial class FrmEditRecords
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbPlaceForStorage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbmType = new WarehouseManagementSystem.Cbm();
            this.cbmState = new WarehouseManagementSystem.Cbm();
            this.cbmPlaceForStorage = new WarehouseManagementSystem.Cbm();
            this.cbmOperator = new WarehouseManagementSystem.Cbm();
            this.cbmItem = new WarehouseManagementSystem.Cbm();
            this.tbNote = new WarehouseManagementSystem.Tb();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudItemCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFinishedTime = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceForStorage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "编辑仓库记录";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbPlaceForStorage);
            this.groupBox2.Location = new System.Drawing.Point(517, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 172);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "存放位置";
            // 
            // pbPlaceForStorage
            // 
            this.pbPlaceForStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPlaceForStorage.Location = new System.Drawing.Point(3, 16);
            this.pbPlaceForStorage.Name = "pbPlaceForStorage";
            this.pbPlaceForStorage.Size = new System.Drawing.Size(213, 153);
            this.pbPlaceForStorage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlaceForStorage.TabIndex = 0;
            this.pbPlaceForStorage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbItem);
            this.groupBox1.Location = new System.Drawing.Point(517, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 171);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "物品";
            // 
            // pbItem
            // 
            this.pbItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbItem.Location = new System.Drawing.Point(3, 16);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(213, 152);
            this.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem.TabIndex = 0;
            this.pbItem.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpFinishedTime);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbmType);
            this.panel1.Controls.Add(this.cbmState);
            this.panel1.Controls.Add(this.cbmPlaceForStorage);
            this.panel1.Controls.Add(this.cbmOperator);
            this.panel1.Controls.Add(this.cbmItem);
            this.panel1.Controls.Add(this.tbNote);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCommit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.nudItemCount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpEndTime);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(71, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 365);
            this.panel1.TabIndex = 29;
            // 
            // cbmType
            // 
            this.cbmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmType.FormattingEnabled = true;
            this.cbmType.Location = new System.Drawing.Point(152, 138);
            this.cbmType.Name = "cbmType";
            this.cbmType.Size = new System.Drawing.Size(198, 21);
            this.cbmType.TabIndex = 37;
            // 
            // cbmState
            // 
            this.cbmState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmState.FormattingEnabled = true;
            this.cbmState.Location = new System.Drawing.Point(152, 170);
            this.cbmState.Name = "cbmState";
            this.cbmState.Size = new System.Drawing.Size(198, 21);
            this.cbmState.TabIndex = 36;
            // 
            // cbmPlaceForStorage
            // 
            this.cbmPlaceForStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmPlaceForStorage.FormattingEnabled = true;
            this.cbmPlaceForStorage.Location = new System.Drawing.Point(152, 106);
            this.cbmPlaceForStorage.Name = "cbmPlaceForStorage";
            this.cbmPlaceForStorage.Size = new System.Drawing.Size(198, 21);
            this.cbmPlaceForStorage.TabIndex = 34;
            this.cbmPlaceForStorage.SelectedIndexChanged += new System.EventHandler(this.cbmPlaceForStorage_SelectedIndexChanged);
            // 
            // cbmOperator
            // 
            this.cbmOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmOperator.FormattingEnabled = true;
            this.cbmOperator.Location = new System.Drawing.Point(152, 74);
            this.cbmOperator.Name = "cbmOperator";
            this.cbmOperator.Size = new System.Drawing.Size(198, 21);
            this.cbmOperator.TabIndex = 33;
            // 
            // cbmItem
            // 
            this.cbmItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmItem.FormattingEnabled = true;
            this.cbmItem.Location = new System.Drawing.Point(152, 11);
            this.cbmItem.Name = "cbmItem";
            this.cbmItem.Size = new System.Drawing.Size(198, 21);
            this.cbmItem.TabIndex = 32;
            this.cbmItem.SelectedIndexChanged += new System.EventHandler(this.cbmItem_SelectedIndexChanged);
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(152, 264);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(198, 20);
            this.tbNote.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(96, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "备注：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "任务类型：";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(122)))));
            this.btnCancel.Location = new System.Drawing.Point(286, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 42);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(98, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "物品：";
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(122)))));
            this.btnCommit.Location = new System.Drawing.Point(37, 307);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(109, 42);
            this.btnCommit.TabIndex = 25;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(98, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "数量：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(65, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "操作人员：";
            // 
            // nudItemCount
            // 
            this.nudItemCount.Location = new System.Drawing.Point(152, 43);
            this.nudItemCount.Name = "nudItemCount";
            this.nudItemCount.Size = new System.Drawing.Size(198, 20);
            this.nudItemCount.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "记录状态：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(66, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "存放位置：";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy/MM/dd  mm:ss";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(152, 202);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(198, 20);
            this.dtpEndTime.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(64, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "截止时间：";
            // 
            // dtpFinishedTime
            // 
            this.dtpFinishedTime.CustomFormat = "yyyy/MM/dd  mm:ss";
            this.dtpFinishedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinishedTime.Location = new System.Drawing.Point(152, 233);
            this.dtpFinishedTime.Name = "dtpFinishedTime";
            this.dtpFinishedTime.Size = new System.Drawing.Size(198, 20);
            this.dtpFinishedTime.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.Location = new System.Drawing.Point(64, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 21);
            this.label10.TabIndex = 38;
            this.label10.Text = "完成时间：";
            // 
            // FrmEditRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditRecords";
            this.Text = "FrmEditRecords";
            this.Load += new System.EventHandler(this.FrmEditRecords_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceForStorage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbPlaceForStorage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudItemCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private Tb tbNote;
        private System.Windows.Forms.Label label9;
        private Cbm cbmPlaceForStorage;
        private Cbm cbmOperator;
        private Cbm cbmItem;
        private Cbm cbmState;
        private Cbm cbmType;
        private System.Windows.Forms.DateTimePicker dtpFinishedTime;
        private System.Windows.Forms.Label label10;
    }
}