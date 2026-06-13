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
    public partial class FrmEditRecords : FrmTemplate
    {
        int _id;
        public FrmEditRecords(int id)
        {
            InitializeComponent();
            nudItemCount.Maximum = int.MaxValue;
            nudItemCount.Controls.Remove(nudItemCount.Controls[0]);

            _id = id;
        }

        private async void btnCommit_Click(object sender, EventArgs e)
        {
            if (nudItemCount.Value <= 0)
            {
                "物品数量不能是0或负数".Msg();
                return;
            }

            var task = new TaskData
            {
                Id = _id,
                RecordTypeId = cbmType.V,
                ItemId = cbmItem.V,
                ItemCount = nudItemCount.Value._2Int(),
                RecordStateId = cbmState.V,
                Note = tbNote.V,
                CreateTime = DateTime.Now,
                EndTime = dtpEndTime.Value,
                FindishedTime = dtpFinishedTime.Value,
                StateId = cbmState.V,
                UserId = cbmOperator.V,
                PlaceForStorageDetailId = cbmPlaceForStorage.V,
                IsDelete = false,
            };

            var info = await task.EditRecordsAsync<TaskData>();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void cbmPlaceForStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var info = await cbmPlaceForStorage.V.GetPlaceImageAsync<string>();
            pbPlaceForStorage.ImageLocation = $"PlaceImage\\{info.Data}";
        }

        private async void cbmItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var info = await cbmItem.V.GetItemImageAsync<string>();
            pbItem.ImageLocation = $"ItemImage\\{info.Data}";
        }

        private async void FrmEditRecords_Load(object sender, EventArgs e)
        {
            var operatorsData = UsersNetworkRequest.GetOperatorsAsync();

            var items = ItemNetworkRequest.GetItemsAsync();

            var types = TypesAndStateNetworkRequest.GetRecordTypesAsync();

            var places = PlaceForStorageDetailsNetworkRequest.GetPlacesAsync();

            var states = TypesAndStateNetworkRequest.GetRecordStatesAsync();

            await Task.WhenAll(operatorsData, items, types, places, states);

            operatorsData.Result.Data.Insert(0, new CbmData { Id = -1, Name = null });
            operatorsData.Result.Data.Bind(cbmOperator);
            items.Result.Data.Bind(cbmItem);
            types.Result.Data.Bind(cbmType);
            places.Result.Data.Bind(cbmPlaceForStorage);
            states.Result.Data.Bind(cbmState);
        }
    }

    public class TaskData
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int ItemCount { get; set; }
        public int PlaceForStorageDetailId { get; set; }
        public int RecordTypeId { get; set; }
        public int RecordStateId { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? FindishedTime { get; set; }
        public int StateId { get; set; }
        public int? UserId { get; set; }
        public bool IsDelete { get; set; }
        public string Note { get; set; }
    }

}
