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
    public partial class FrmItemManagement : FrmTemplate
    {
        public FrmItemManagement()
        {
            InitializeComponent();

            nudSafeStock.Maximum = int.MaxValue;
            nudSafeStock.Controls.Remove(nudSafeStock.Controls[0]);
        }

        private async void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbItemName.V))
            {
                "物品名不能为空".Msg();
                return;
            }

            if (nudSafeStock.Value <= 0)
            {
                "安全库存不能是0或负数".Msg();
                return;
            }

            var item = new ItemInfo
            {
                ItemName = tbItemName.V,
                ItemType = cbmType.V,
                SafeCount = nudSafeStock.Value._2Int(),
                ImageFileName = Path.GetFileName(tbImagePath.V)
            };

            var info = await item.AddItemAsync<int>();
            if (info.Success)
            {
                "添加成功".Msg();
                if (File.Exists(Application.StartupPath + "\\ItemImage\\" + Path.GetFileName(tbImagePath.V)))
                {
                    if (MessageBox.Show("有文件名相同的文件是否覆盖", "文件处理", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        File.Copy(tbImagePath.V, Application.StartupPath + "\\ItemImage\\" + Path.GetFileName(tbImagePath.V), true);
                    }
                }
                else
                {
                    File.Copy(tbImagePath.V, Application.StartupPath + "\\ItemImage\\" + Path.GetFileName(tbImagePath.V), true);
                }

                LoadInfo();
            }
            else
            {
                "添加失败".Msg();
            }
        }

        public async void LoadInfo()
        {
            dgvItemsData.Columns.Clear();
            var itemData = await ItemNetworkRequest.GetAllItemsAsync<List<ItemData>>();
            itemData.Data.ToList().Bind(dgvItemsData);

            var deleteColumn = new DataGridViewLinkColumn
            {
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForLinkValue = true,
            };

            var editColumn = new DataGridViewLinkColumn
            {
                Name = "Edit",
                Text = "Edit",
                UseColumnTextForLinkValue = true,
            };

            dgvItemsData.Columns.Add(deleteColumn);
            dgvItemsData.Columns.Add(editColumn);
        }

        private async void FrmItemManagement_Load(object sender, EventArgs e)
        {
            var types = TypesAndStateNetworkRequest.GetItemTypesAsync();

            var itemData = ItemNetworkRequest.GetAllItemsAsync<List<ItemData>>();

            await Task.WhenAll(types, itemData);

            types.Result.Data.ToList().Bind(cbmType);
            itemData.Result.Data.ToList().Bind(dgvItemsData);

            var deleteColumn = new DataGridViewLinkColumn
            {
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForLinkValue = true,
            };

            var editColumn = new DataGridViewLinkColumn
            {
                Name = "Edit",
                Text = "Edit",
                UseColumnTextForLinkValue = true,
            };

            dgvItemsData.Columns.Add(deleteColumn);
            dgvItemsData.Columns.Add(editColumn);
        }

        private async void dgvItemsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var currentColumn = dgvItemsData.Columns[e.ColumnIndex];
            var id = dgvItemsData.CurrentRow.Cells["Id"].Value._2Int();
            if (currentColumn == dgvItemsData.Columns["Edit"])
            {
                var frm = new FrmEditItem(id);
                frm.FormClosed += delegate
                {
                    LoadInfo();
                };
                this.GoFrm(frm);
            }

            if (currentColumn == dgvItemsData.Columns["Delete"])
            {
                var info = await id.DeleteItemAsync<string>();
                if (info.Success)
                {
                    "删除成功".Msg();
                    LoadInfo();
                }
                else
                {
                    "删除失败".Msg();
                }
            }
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
    }
    public class ItemData
    {
        public int? Id { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public int SafeCount { get; set; }
        public string ImageFileName { get; set; }
    }
}
