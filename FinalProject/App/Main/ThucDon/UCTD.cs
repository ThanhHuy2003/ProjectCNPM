using FinalProject.App.Main.ThucDon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FinalProject.App
{
    public partial class UCTD : UserControl
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public static Image ResizeImage(Image image, int width, int height)
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
        public UCTD()
        {
            InitializeComponent();
        }

        private void UCTD_Load(object sender, EventArgs e)
        {
            //togglePanelMain("Card");
            populateItems();
        }
        /*CardTD cardTD;

        public void togglePanelMain(String panelName)
        {
            this.panelCard.Controls.Clear();
            this.panelCard.AutoScroll = true;
            switch (panelName)
            {
                case "Card":
                    if (this.cardTD == null)
                    {
                        this.cardTD = new CardTD();
                        this.panelCard.Controls.Add(cardTD);
                        this.cardTD.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.cardTD.Location = new System.Drawing.Point(0, 0);
                        this.cardTD.Name = "cardTD";
                        this.Size = new System.Drawing.Size(1200, 800);
                        this.cardTD.TabIndex = 0;
                        this.cardTD.AutoScroll = true;
                    }
                    else
                    {
                        this.panelCard.Controls.Add(cardTD);
                    }
                    break;
                default:
                    break;
            }
        }*/
        private void populateItems()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT * FROM MenuDataTable";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {

                    string dPicture = row["dishPicture"].ToString();
                    string dName = row["dishName"].ToString();
                    string dDescription = row["dishDescription"].ToString();
                    CardTD Item = new CardTD();
                    var request = WebRequest.Create(dPicture);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        Item.Picture = Bitmap.FromStream(stream);
                        Item.Picture = ResizeImage(Item.Picture, 255, 126);
                    }
                    Item.Title = dName;
                    Item.Description = dDescription;

                    this.flowPanel.Controls.Add(Item);

                    /*CardTD[] listItems = new CardTD[1];
                    for (int i = 0; i < listItems.Length; i++)
                    {
                        listItems[i] = new CardTD();
                        var request = WebRequest.Create(dPicture);

                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            listItems[i].Picture = Bitmap.FromStream(stream);
                            listItems[i].Picture = ResizeImage(listItems[i].Picture, 255, 126);
                        }
                        listItems[i].Title = dName;
                        listItems[i].Description = dDescription;

                        this.panelCard.Controls.Add(listItems[i]);

                    }*/
                }
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
