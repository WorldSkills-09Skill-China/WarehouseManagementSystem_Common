
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
    public partial class FrmWarehouseRecords : FrmTemplate
    {
        public FrmWarehouseRecords()
        {
            InitializeComponent();
        }

        public async void LoadInfo()
        {
            dgvRecordsData.Columns.Clear();
            var allRecords = await WarehouseRecordsNetworkRequest.GetRecordsAsync<List<Record>>();
            var data = allRecords.Data.Where(a =>
            (a.UserId == cbmOperator.V || cbmOperator.V == -1) &&
                (a.ItemId == cbmItem.V || cbmItem.V == -1) &&
                (string.IsNullOrEmpty(tbSearch.V) || a.ItemName.Contains(tbSearch.V)) &&
                (!cbOnlyLoadUnfinishedTask.Checked || a.RecordState == "未完成") &&
                a.CreateTime >= dtpFirstTime.Value &&
                a.CreateTime <= dtpLastTime.Value
            ).ToList()
            .OrderByDescending(a => a.RecordState == "待审核").ToList();
            dgvRecordsData.DataSource = data;

            var editColumn = new DataGridViewLinkColumn
            {
                Name = "Edit",
                Text = "Edit",
                UseColumnTextForLinkValue = true,
            };

            var deleteColumn = new DataGridViewLinkColumn
            {
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForLinkValue = true,
            };

            var cancelColumn = new DataGridViewLinkColumn
            {
                Name = "Cancel",
            };

            var approvalRecord = new DataGridViewLinkColumn
            {
                Name = "Approval",
            };

            dgvRecordsData.Columns.Add(editColumn);
            dgvRecordsData.Columns.Add(deleteColumn);
            dgvRecordsData.Columns.Add(cancelColumn);
            dgvRecordsData.Columns.Add(approvalRecord);

            foreach (DataGridViewRow row in dgvRecordsData.Rows)
            {
                if (row.Cells["RecordState"].Value.ToString() == "待审核")
                {
                    row.DefaultCellStyle.ForeColor = Color.Green;
                    row.Cells["Cancel"].Value = "Cancel";
                    row.Cells["Approval"].Value = "Approval";
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void dtpFirstTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFirstTime.Value > dtpLastTime.Value)
            {
                "时间逻辑错误".Msg();
                return;
            }
            LoadInfo();
        }

        private void dtpLastTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFirstTime.Value > dtpLastTime.Value)
            {
                "时间逻辑错误".Msg();
                return;
            }
            LoadInfo();
        }

        private void cbOnlyLoadUnfinishedTask_CheckedChanged(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private async void dgvRecordsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var currentColumn = dgvRecordsData.Columns[e.ColumnIndex];
            var id = dgvRecordsData.CurrentRow.Cells["Id"].Value._2Int();
            if (currentColumn == dgvRecordsData.Columns["Edit"])
            {
                var frm = new FrmEditRecords(id);
                frm.FormClosed += delegate
                {
                    LoadInfo();
                };
                this.GoFrm(frm);
            }

            if (currentColumn == dgvRecordsData.Columns["Delete"])
            {
                var info = await id.DeleteRecordAsync<string>();
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

            if (currentColumn == dgvRecordsData.Columns["Approval"] && dgvRecordsData.CurrentCell.Value != null)
            {
                var info = await id.ApprocalTaskAsync<string>();
                if (info.Success)
                {
                    LoadInfo();
                }
                else
                {
                    "审批失败".Msg();
                }
            }

            if (currentColumn == dgvRecordsData.Columns["Cancel"] && dgvRecordsData.CurrentCell.Value != null)
            {
                var info = await id.DeleteRecordAsync<string>();
                if (info.Success)
                {
                    "取消成功".Msg();
                    LoadInfo();
                }
                else
                {
                    "取消失败".Msg();
                }
            }
        }

        private async void FrmWarehouseRecords_Load(object sender, EventArgs e)
        {
            var operatorsData = await UsersNetworkRequest.GetOperatorsAsync();
            operatorsData.Data.Insert(0, new CbmData { Name = "All", Id = -1 });
            operatorsData.Data.Bind(cbmOperator);

            var items = await ItemNetworkRequest.GetItemsAsync();
            items.Data.Insert(0, new CbmData { Name = "All", Id = -1 });
            items.Data.Bind(cbmItem);
            LoadInfo();
        }
    }
}
