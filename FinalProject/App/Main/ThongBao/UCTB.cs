using FinalProject.App.Main.ThucDon;
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

namespace FinalProject.App.Main
{
    public partial class UCTB : UserControl
    {
        public UCTB()
        {
            InitializeComponent();
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
        private void populateNotification_UCTB()
        {
            AdminNotificationBLL notif = new AdminNotificationBLL();

            if (notif.getAllNotification() != null)
            {
                foreach (DataRow row in notif.getAllNotification().Rows)
                {
                    FinalProject.DTO.Notification newMenuItem = new FinalProject.DTO.Notification();


                    newMenuItem.notificationID = row["notificationID"].ToString();
                    newMenuItem.notificationPicture = row["notificationPicture"].ToString();
                    newMenuItem.notificationName = row["notificationName"].ToString();
                    newMenuItem.notificationDescription = row["notificationDescription"].ToString();
                    MessageBox.Show(newMenuItem.notificationID);
                    CardTD Item = new CardTD();
                    var request = WebRequest.Create(newMenuItem.notificationPicture);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        Item.Picture = Bitmap.FromStream(stream);
                        Item.Picture = resizeImage(Item.Picture, 255, 143);
                    }

                    Item.Title = newMenuItem.notificationName;

                    this.menuNotification.Controls.Add(Item);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu MenuData");
            }
        }

        private void UCTB_Load(object sender, EventArgs e)
        {
            populateNotification_UCTB();
        }
    }
}
