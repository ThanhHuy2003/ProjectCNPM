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
            
        }
    }
}
