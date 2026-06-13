namespace WarehouseManagementSystem
{
    partial class FrmItemManagement
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbItemName = new WarehouseManagementSystem.Tb();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmType = new WarehouseManagementSystem.Cbm();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSafeStock = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetImage = new System.Windows.Forms.Button();
            this.tbImagePath = new WarehouseManagementSystem.Tb();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.dgvItemsData = new WarehouseManagementSystem.Dgv();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSafeStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "物品管理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(5, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "物品名：";
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(77, 30);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(100, 22);
            this.tbItemName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(199, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "物品类型：";
            // 
            // cbmType
            // 
            this.cbmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmType.FormattingEnabled = true;
            this.cbmType.Location = new System.Drawing.Point(288, 31);
            this.cbmType.Name = "cbmType";
            this.cbmType.Size = new System.Drawing.Size(121, 21);
            this.cbmType.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(428, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "安全库存：";
            // 
            // nudSafeStock
            // 
            this.nudSafeStock.Location = new System.Drawing.Point(517, 30);
            this.nudSafeStock.Name = "nudSafeStock";
            this.nudSafeStock.Size = new System.Drawing.Size(107, 22);
            this.nudSafeStock.TabIndex = 8;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(537, 82);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(87, 24);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "添加物品";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnGetImage);
            this.groupBox1.Controls.Add(this.tbImagePath);
            this.groupBox1.Controls.Add(this.pbItemImage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.tbItemName);
            this.groupBox1.Controls.Add(this.nudSafeStock);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbmType);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 123);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加物品";
            // 
            // btnGetImage
            // 
            this.btnGetImage.Location = new System.Drawing.Point(203, 82);
            this.btnGetImage.Name = "btnGetImage";
            this.btnGetImage.Size = new System.Drawing.Size(75, 23);
            this.btnGetImage.TabIndex = 12;
            this.btnGetImage.Text = "物品图片";
            this.btnGetImage.UseVisualStyleBackColor = true;
            this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click);
            // 
            // tbImagePath
            // 
            this.tbImagePath.Location = new System.Drawing.Point(10, 82);
            this.tbImagePath.Name = "tbImagePath";
            this.tbImagePath.ReadOnly = true;
            this.tbImagePath.Size = new System.Drawing.Size(167, 22);
            this.tbImagePath.TabIndex = 11;
            // 
            // pbItemImage
            // 
            this.pbItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbItemImage.Location = new System.Drawing.Point(288, 67);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(100, 50);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemImage.TabIndex = 10;
            this.pbItemImage.TabStop = false;
            // 
            // dgvItemsData
            // 
            this.dgvItemsData.AllowUserToAddRows = false;
            this.dgvItemsData.AllowUserToDeleteRows = false;
            this.dgvItemsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsData.Location = new System.Drawing.Point(12, 226);
            this.dgvItemsData.Name = "dgvItemsData";
            this.dgvItemsData.RowHeadersVisible = false;
            this.dgvItemsData.RowTemplate.Height = 42;
            this.dgvItemsData.Size = new System.Drawing.Size(639, 218);
            this.dgvItemsData.TabIndex = 11;
            this.dgvItemsData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemsData_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(8, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "物品：";
            // 
            // FrmItemManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 480);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvItemsData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmItemManagement";
            this.Text = "FrmItemManagement";
            this.Load += new System.EventHandler(this.FrmItemManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSafeStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Tb tbItemName;
        private System.Windows.Forms.Label label3;
        private Cbm cbmType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSafeStock;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private Dgv dgvItemsData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetImage;
        private Tb tbImagePath;
        private System.Windows.Forms.PictureBox pbItemImage;
    }
}