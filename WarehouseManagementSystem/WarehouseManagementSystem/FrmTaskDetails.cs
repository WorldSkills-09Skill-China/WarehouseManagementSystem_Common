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
    public partial class FrmTaskDetails : FrmTemplate
    {
        int _id;
        public FrmTaskDetails(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FrmTaskDetails_Load(object sender, EventArgs e)
        {
            var data = await _id.GetTaskDetail<TaskDetail>();
            var info = data.Data;
            lblTaskDetails.Text = $@"
RecordType: {info.RecordType}
Item: {info.Item}
ItemCount: {info.ItemCount}
Note: {info.Note}
CreateTime: {info.CreateTime}
EndTime: {info.EndTime}
User: {info.User}
PlaceForStorageDetail: {info.PlaceForStorageDetail}
";
        }

        private async void btnCancelTask_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要取消这个任务吗", "取消任务", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var info = await _id.DeleteRecordAsync<TaskData>();
                if (info.Success)
                {
                    "取消成功".Msg();
                    this.Close();
                }
                else
                {
                    "取消失败".Msg();
                }
            }
        }
    }

    public class TaskDetail
    {
        public string RecordType { get; set; }
        public string Item { get; set; }
        public int ItemCount { get; set; }
        public string Note { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime EndTime { get; set; }
        public string User { get; set; }
        public string PlaceForStorageDetail { get; set; }
    }
}
