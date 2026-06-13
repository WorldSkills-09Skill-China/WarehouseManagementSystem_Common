using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagementSystem
{
    public partial class FrmReleaseTask : Form
    {
        int _id;
        ItemAnomaly _item;
        public FrmReleaseTask(ItemAnomaly item, int id)
        {
            InitializeComponent();
            _id = id;
            _item = item;

            nudItemCount.Maximum = int.MaxValue;
            nudItemCount.Minimum = int.MinValue;
            nudItemCount.Controls.Remove(nudItemCount.Controls[0]);
        }

        private async void FrmReleaseTask_Load(object sender, EventArgs e)
        {
            var operatorsData = UsersNetworkRequest.GetOperatorsAsync();

            var items = ItemNetworkRequest.GetItemsAsync();

            var types = TypesAndStateNetworkRequest.GetRecordTypesAsync();

            var places = PlaceForStorageDetailsNetworkRequest.GetPlacesAsync();

            await Task.WhenAll(operatorsData, items, types, places);

            operatorsData.Result.Data.Insert(0, new CbmData { Id = -1, Name = null });
            operatorsData.Result.Data.Bind(cbmOperator);
            items.Result.Data.Bind(cbmItem);
            types.Result.Data.Bind(cbmType);
            places.Result.Data.Bind(cbmPlaceForStorage);

            if (_id != 0)
            {
                cbmItem.SelectedValue = _id;
                cbmType.SelectedValue = _item.TypeId ? 1 : 2;
                nudItemCount.Value = _item.ItemCount;
            }
        }

        private async void btnReleaseTask_Click(object sender, EventArgs e)
        {
            if (nudItemCount.Value <= 0)
            {
                "物品数量不可以为0或者负数".Msg();
                return;
            }

            var data = new TaskData
            {
                RecordTypeId = cbmType.V,
                ItemId = cbmItem.V,
                ItemCount = nudItemCount.Value._2Int(),
                Note = tbNote.V,
                CreateTime = DateTime.Now,
                EndTime = dtpEndTime.Value,
                FindishedTime = null,
                UserId = cbmOperator.V,
                PlaceForStorageDetailId = cbmPlaceForStorage.V,
                IsDelete = false,
            };
            var info = await new TaskData
            {
                RecordTypeId = cbmType.V,
                ItemId = cbmItem.V,
                ItemCount = nudItemCount.Value._2Int(),
                Note = tbNote.V,
                CreateTime = DateTime.Now,
                EndTime = dtpEndTime.Value,
                FindishedTime = null,
                UserId = cbmOperator.V,
                PlaceForStorageDetailId = cbmPlaceForStorage.V,
                IsDelete = false,
            }.AddTask<int?>();
            if (info.Success)
            {
                "添加成功".Msg();
                if (!cbAffirm.Checked)
                {
                    new FrmTaskDetails(info.Data.Value).Show();
                }
            }
            else
            {
                info.Message.Msg();
            }
        }

        private async void cbmItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var info = await cbmItem.V.GetItemImageAsync<string>();
            pbItem.ImageLocation = $"ItemImage\\{info.Data}";
        }

        private async void cbmPlaceForStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var info = await cbmPlaceForStorage.V.GetPlaceImageAsync<string>();
            pbPlaceForStorage.ImageLocation = $"PlaceImage\\{info.Data}";
        }
    }
}
