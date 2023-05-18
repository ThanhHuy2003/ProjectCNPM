using FinalProject.App.Main.ThongBao;
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

namespace FinalProject.App.Admin.ThongBao
{
    public partial class UCTBAdmin : UserControl
    {
        AdminNotificationBLL listBLL = new AdminNotificationBLL();
        DataTable list;
        public UCTBAdmin()
        {
            InitializeComponent();
        }
        Form frm = new TBDetailAdmin();
        private void btnAddTB_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
        }
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
        private void populateNotification_UCTB(Boolean flag)
        {
            if (flag)
            {
                this.flowLayoutPanel1.Controls.Clear();
                this.list = this.listBLL.searchNotification(tbSearch.Text);
            }
            else
            {
                this.flowLayoutPanel1.Controls.Clear();
                this.list = this.listBLL.getAllNotification();
            }
            if (this.list != null)
            {
                foreach (DataRow row in this.list.Rows)
                {
                    FinalProject.DTO.Notification newItem = new FinalProject.DTO.Notification();
                    newItem.notificationID = row["notificationID"].ToString();
                    newItem.notificationPicture = row["notificationPicture"].ToString();
                    newItem.notificationName = row["notificationName"].ToString();
                    newItem.notificationDate = row["notificationDate"].ToString();

                    CardTB Item = new CardTB();
                    Item.ID = newItem.notificationID;
                    var request = WebRequest.Create(newItem.notificationPicture);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        Item.Picture = Bitmap.FromStream(stream);
                        Item.Picture = resizeImage(Item.Picture, 255, 143);
                    }

                    Item.Title = newItem.notificationName;
                    Item.Date = newItem.notificationDate.Split(' ')[0];

                    this.flowLayoutPanel1.Controls.Add(Item);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu MenuData");
            }
        }
        private void UCTBAdmin_Load(object sender, EventArgs e)
        {
            populateNotification_UCTB(false);
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            populateNotification_UCTB(true);
        }
    }
}
