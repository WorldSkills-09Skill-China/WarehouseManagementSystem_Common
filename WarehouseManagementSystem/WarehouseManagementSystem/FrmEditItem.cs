using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagementSystem
{
    public partial class FrmEditItem : FrmTemplate
    {
        int _id;
        public FrmEditItem(int id)
        {
            InitializeComponent();
            _id = id;

            nudSafeStock.Maximum = int.MaxValue;
            nudSafeStock.Controls.Remove(nudSafeStock.Controls[0]);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetImage_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图片|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbImagePath.Text = openFileDialog.FileName;
                pbItemImage.ImageLocation = openFileDialog.FileName;
            }
        }

        private async void btnCommit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbItemName.V))
            {
                "物品名不可以为空".Msg();
                return;
            }

            if (nudSafeStock.Value <= 0)
            {
                "安全库存不能是0或负数".Msg();
                return;
            }

            var item = new ItemInfo
            {
                Id = _id,
                ItemName = tbItemName.V,
                ItemType = cbmType.V,
                SafeCount = nudSafeStock.Value._2Int(),
                ImageFileName = Path.GetFileName(tbImagePath.V)
            };

            var info = await item.EditItemAsync<TaskData>();
            if (info.Success)
            {
                "提交成功".Msg();
                this.Close();
            }
            else
            {
                "提交失败".Msg();
            }
        }

        private async void FrmEditItem_Load(object sender, EventArgs e)
        {
            var info = _id.GetItemAsync<ItemData>();
            var types = TypesAndStateNetworkRequest.GetItemTypesAsync();
            await Task.WhenAll(types, info);

            types.Result.Data.ToList().Bind(cbmType);

            var item = info.Result.Data;
            tbImagePath.Text = item.ImageFileName;
            pbItemImage.ImageLocation = $"ItemImage\\{item.ImageFileName}";
            tbItemName.Text = item.ItemName;
            cbmType.SelectedValue = item.ItemType;
            nudSafeStock.Value = item.SafeCount;
        }
    }
    public class ItemInfo
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int ItemType { get; set; }
        public int SafeCount { get; set; }
        public string ImageFileName { get; set; }
    }
}
