namespace WarehouseManagementSystem
{
    partial class FrmEditItem
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
            this.btnGetImage = new System.Windows.Forms.Button();
            this.tbImagePath = new WarehouseManagementSystem.Tb();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.tbItemName = new WarehouseManagementSystem.Tb();
            this.nudSafeStock = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmType = new WarehouseManagementSystem.Cbm();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSafeStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetImage
            // 
            this.btnGetImage.Location = new System.Drawing.Point(602, 146);
            this.btnGetImage.Name = "btnGetImage";
            this.btnGetImage.Size = new System.Drawing.Size(75, 23);
            this.btnGetImage.TabIndex = 22;
            this.btnGetImage.Text = "物品图片";
            this.btnGetImage.UseVisualStyleBackColor = true;
            this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click);
            // 
            // tbImagePath
            // 
            this.tbImagePath.Location = new System.Drawing.Point(412, 151);
            this.tbImagePath.Name = "tbImagePath";
            this.tbImagePath.ReadOnly = true;
            this.tbImagePath.Size = new System.Drawing.Size(167, 20);
            this.tbImagePath.TabIndex = 21;
            // 
            // pbItemImage
            // 
            this.pbItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbItemImage.Location = new System.Drawing.Point(427, 74);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(136, 71);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemImage.TabIndex = 20;
            this.pbItemImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(118, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "物品名：";
            // 
            // btnCommit
            // 
            this.btnCommit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.Location = new System.Drawing.Point(214, 268);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(87, 31);
            this.btnCommit.TabIndex = 19;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(190, 93);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(154, 20);
            this.tbItemName.TabIndex = 14;
            // 
            // nudSafeStock
            // 
            this.nudSafeStock.Location = new System.Drawing.Point(190, 193);
            this.nudSafeStock.Name = "nudSafeStock";
            this.nudSafeStock.Size = new System.Drawing.Size(154, 20);
            this.nudSafeStock.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(101, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "物品类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(101, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "安全库存：";
            // 
            // cbmType
            // 
            this.cbmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmType.FormattingEnabled = true;
            this.cbmType.Location = new System.Drawing.Point(190, 151);
            this.cbmType.Name = "cbmType";
            this.cbmType.Size = new System.Drawing.Size(154, 21);
            this.cbmType.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 47);
            this.label1.TabIndex = 23;
            this.label1.Text = "物品编辑";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(450, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 31);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetImage);
            this.Controls.Add(this.tbImagePath);
            this.Controls.Add(this.pbItemImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.nudSafeStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbmType);
            this.Name = "FrmEditItem";
            this.Text = "FrmEditItem";
            this.Load += new System.EventHandler(this.FrmEditItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSafeStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetImage;
        private Tb tbImagePath;
        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCommit;
        private Tb tbItemName;
        private System.Windows.Forms.NumericUpDown nudSafeStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Cbm cbmType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
    }
}