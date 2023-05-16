using FinalProject.App.Main.ThucDon;
using FinalProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main.GioHang
{
    public partial class UCGH : UserControl
    {
        public UCGH()
        {
            File ehe = new File();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(ehe.readLanguage());
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
        private void populateCartData_CartTable_UCTD()
        {
            flowLayoutPanel1.Controls.Clear();

            CartTableBLL cartTableBLL = new CartTableBLL();

            if (cartTableBLL.populateCartData_CartTable_BLL() != null)
            {
                foreach (DataRow row in cartTableBLL.populateCartData_CartTable_BLL().Rows)
                {
                    FinalProject.DTO.CartDataItem newCartDataItem = new FinalProject.DTO.CartDataItem();

                    newCartDataItem.dishID = row["dishID"].ToString();
                    newCartDataItem.dishPicture = row["dishPicture"].ToString();
                    newCartDataItem.dishName = row["dishName"].ToString();
                    newCartDataItem.dishDescription = row["dishDescription"].ToString();
                    newCartDataItem.dishPrice = int.Parse(row["dishPrice"].ToString());
                    newCartDataItem.dishType = row["dishType"].ToString();
                    newCartDataItem.totalQuantity = int.Parse(row["totalQuantity"].ToString());

                    CardGH Item = new CardGH(flowLayoutPanel1);

                    var request = WebRequest.Create(newCartDataItem.dishPicture);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        Item.Picture = Bitmap.FromStream(stream);
                        Item.Picture = resizeImage(Item.Picture, 255, 143);
                    }
                    Item.ID = newCartDataItem.dishID;
                    Item.Title = newCartDataItem.dishName;
                    Item.Price = newCartDataItem.dishPrice;
                    Item.Quantity = newCartDataItem.totalQuantity;
                    Item.ButtonClicked += ChildControl_ButtonClicked;

                    this.flowLayoutPanel1.Controls.Add(Item);
                }
            }
        }
        private void ChildControl_ButtonClicked(object sender, EventArgs e)
        {
            label1.Focus();
            populateCartData_CartTable_UCTD();
        }
        private void UCGH_Load(object sender, EventArgs e)
        {
            populateCartData_CartTable_UCTD();
        }
    }
}
