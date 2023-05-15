using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main
{
    public partial class CardCH : UserControl
    {
        public CardCH()
        {
            InitializeComponent();
        }
        #region Properties

        private string _title;
        private string _description;
        private Image _pic;
        private string _date;

        [Category("Custom Props")]
        public string Title { get { return _title; } set { _title = value; kryptonLabel36.Text = value; } }
        [Category("Custom Props")]
        public string Description { get { return _description; } set { _description = value; kryptonLabel35.Text = value; } }
        [Category("Custom Props")]
        public Image Picture { get { return _pic; } set { _pic = value; pictureBox12.Image = value; } }
        [Category("Custom Props")]
        public string Date { get { return _date; } set { _date = value; kryptonLabel1.Text = value; } }
        #endregion

        private void ButtonKM1_Click(object sender, EventArgs e)
        {
            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("https://www.google.com/maps/place/119+Nguy%E1%BB%85n+Th%E1%BB%8B+Th%E1%BA%ADp,+T%C3%A2n+Ph%C3%BA,+Qu%E1%BA%ADn+7,+Th%C3%A0nh+ph%E1%BB%91+H%E1%BB%93+Ch%C3%AD+Minh,+Vi%E1%BB%87t+Nam/@10.7379978,106.7182535,17z/data=!3m1!4b1!4m6!3m5!1s0x31752f8723fb8c9d:0x88f9b2c06109e0e1!8m2!3d10.7379978!4d106.7208284!16s%2Fg%2F11c89h33k7?hl=vi-VN");
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(queryaddress.ToString());
        }
    }
}
