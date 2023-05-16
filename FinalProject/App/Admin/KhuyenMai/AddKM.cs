using FinalProject.BLL;
using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Admin.KhuyenMai
{
    public partial class AddKM : Form
    {
        public AddKM()
        {
            InitializeComponent();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            StoreAddressTableBLL storeBLL = new StoreAddressTableBLL();
            foreach (DataRow row in storeBLL.populateStoreAddressData_StoreAddressTable_BLL().Rows)
            {
                comboSource.Add(row["storeID"].ToString(), row["storeName"].ToString());
            }
            cbCCN.DataSource = new BindingSource(comboSource, null);
            cbCCN.DisplayMember = "Value";
            cbCCN.ValueMember = "Key";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PromotionTableBLL ehe = new PromotionTableBLL();
            PromotionItem item = new PromotionItem();
            item.promotionPicture = tbPoster.Text;
            item.promotionName = txtTD.Text; 
            item.promotionDescription = txtND.Text;
            item.promotionPercent = 50;
            item.promotionDate = "17-5-2023";
            ehe.addPromotion(item);
        }
    }
}
