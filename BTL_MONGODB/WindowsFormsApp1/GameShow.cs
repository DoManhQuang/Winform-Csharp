using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WindowsFormsApp1
{
    public partial class GameShow : Form
    {
        BLLayer GetBL = new BLLayer();
        public static List<BsonDocument> gameplay;
        public static int cauhoi = -1;
        public GameShow()
        {
            InitializeComponent();
        }

        private void GameShow_Load(object sender, EventArgs e)
        {
            cauhoi += 1;
            SHOW_PLAY_GAME();
        }

        public List<BsonDocument> RANDOM_LIST_QnA()
        {
            List<BsonDocument> lstRD = GetBL.GET_LIST_FULL_DATA_TABLE_QnA();
            return lstRD;
        }

       
        public void SHOW_PLAY_GAME()
        {
            gameplay = RANDOM_LIST_QnA();
            btnA.Text += ": " + gameplay[cauhoi]["ans1"].ToString();
            btnB.Text += ": " + gameplay[cauhoi]["ans2"].ToString();
            btnC.Text += ": " + gameplay[cauhoi]["ans3"].ToString();
            btnD.Text += ": " + gameplay[cauhoi]["ans4"].ToString();
            lblCauHoi.Text += ": " + gameplay[cauhoi]["question"].ToString();
        }

    }
}
