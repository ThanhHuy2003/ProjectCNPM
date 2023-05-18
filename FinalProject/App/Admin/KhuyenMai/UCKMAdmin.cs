using FinalProject.App.Admin.KhuyenMai;
using FinalProject.App.Login;
using FinalProject.App.Main.KhuyenMai;
using FinalProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalProject.Main;

namespace FinalProject.App.Admin
{
    public partial class UCKMAdmin : UserControl
    {
        MainAdmin main = new MainAdmin();
        public UCKMAdmin()
        {
            InitializeComponent();
        }
        Form frm = new AddKM();
        public Image resizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        private void populatePromotionData_PromotionTable_UCKM()
        {
            PromotionTableBLL promotionTableBLL = new PromotionTableBLL();

            if (promotionTableBLL.populatePromotionData_PromotionTable_BLL() != null)
            {
                foreach (DataRow row in promotionTableBLL.populatePromotionData_PromotionTable_BLL().Rows)
                {
                    FinalProject.DTO.PromotionItem newPromotionItem = new FinalProject.DTO.PromotionItem();
                    newPromotionItem.promotionID = row["promotionID"].ToString();
                    newPromotionItem.promotionPicture = row["promotionPicture"].ToString();
                    newPromotionItem.promotionName = row["promotionName"].ToString();
                    newPromotionItem.promotionDescription = row["promotionDescription"].ToString();
                    newPromotionItem.promotionDate = row["promotionDate"].ToString();
                    newPromotionItem.promotionPercent = int.Parse(row["promotionPercent"].ToString());

                    try
                    {
                        CardKMForDisplay Item = new CardKMForDisplay();

                        var request = WebRequest.Create(newPromotionItem.promotionPicture);

                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            Item.Picture = Bitmap.FromStream(stream);
                            Item.Picture = resizeImage(Item.Picture, 228, 187);
                        }

                        Item.Title = newPromotionItem.promotionName;
                        Item.Description = newPromotionItem.promotionDescription;

                        this.flowLayoutPanel1.Controls.Add(Item);
                    }
                    catch
                    {
                        MessageBox.Show("Không tìm được poster của khuyến mãi id: " + newPromotionItem.promotionID + "| name:" + newPromotionItem.promotionName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu PromotionData");
            }
        }
        private void btnAddKM_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            //Search method
            //Do something
            PromotionTableBLL ehe = new PromotionTableBLL();
        }

        private void UCKMAdmin_Load(object sender, EventArgs e)
        {
            populatePromotionData_PromotionTable_UCKM();
        }
    }
}
