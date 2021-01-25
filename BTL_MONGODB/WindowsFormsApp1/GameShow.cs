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
            btnA.BackColor = Color.Yellow;
            btnB.BackColor = Color.Yellow;
            btnC.BackColor = Color.Yellow;
            btnD.BackColor = Color.Yellow;

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
            // lblCauHoi.Text += ": " + gameplay[cauhoi]["question"].ToString();
            txtCauHoi.Text += ": " + gameplay[cauhoi]["question"].ToString();
        }

        public int ViewAnswer(int ans)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Đây là đáp án bạn lựa chọn ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    if (Int32.Equals(ans, gameplay[cauhoi]["ans_true"].AsInt32))
                    {
                        MessageBox.Show("Đó là câu trả lời đúng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return 1;
                    }
                    else
                    {
                        MessageBox.Show("Đó là câu trả lời sai.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return -1;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.BackColor = Color.Orange;
            int rs = ViewAnswer(1);
            if (rs == -1)
            {
                btnA.BackColor = Color.Yellow;
            }
            else if (rs == 1)
            {
                btnA.BackColor = Color.Green;
                GameShow_Load(sender, e);
            }
            else
            {
                btnA.BackColor = Color.Red;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.BackColor = Color.Orange;
            int rs = ViewAnswer(2);
            if (rs == -1)
            {
                btnB.BackColor = Color.Yellow;
            }
            else if (rs == 1)
            {
                btnB.BackColor = Color.Green;
                GameShow_Load(sender, e);
            }
            else
            {
                btnB.BackColor = Color.Red;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.BackColor = Color.Orange;
            int rs = ViewAnswer(1);
            if (rs == -1)
            {
                btnC.BackColor = Color.Yellow;
            }
            else if (rs == 1)
            {
                btnC.BackColor = Color.Green;
                GameShow_Load(sender, e);
            }
            else
            {
                btnC.BackColor = Color.Red;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Orange;
            int rs = ViewAnswer(1);
            if (rs == -1)
            {
                btnD.BackColor = Color.Yellow;
            }
            else if (rs == 1)
            {
                btnD.BackColor = Color.Green;
            }
            else
            {
                btnD.BackColor = Color.Red;
            }
        }
    }
}
