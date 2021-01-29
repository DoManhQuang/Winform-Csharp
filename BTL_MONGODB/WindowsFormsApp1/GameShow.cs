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
        public int[] visit_help = { 0, 0, 0, 0, 0 };

        public string[] answer_help = { "0", "A", "B", "C", "D" };

        public string[] master_name = { "0", "Albert Einstein", "Isaac Newton", 
            "Carl Friedrich Gauss", "Thomas A. Edison", "Michael Faraday" };

        public string[] phone_name = { "0", "Mẹ", "Bố", "Em Gái", "Anh Trai", "Bạn Thân" };

        public string[] file_images = { "../Image/logo.jpeg", "../Image/KG_A_1.png", 
            "../Image/KG_B_1.png", "../Image/KG_C_1.png", "../Image/KG_D_1.png" };

        public string[] file_false_image = { "../Image/logo.jpeg", "../Image/false_master.png", 
            "../Image/false_phone.png", "../Image/false_people.png", "../Image/false_5050.png" };
        public GameShow()
        {
            InitializeComponent();
        }

        public void setColorButton()
        {
            btn1.BackColor = Color.LightGray;
            btn2.BackColor = Color.LightGray;
            btn3.BackColor = Color.LightGray;
            btn4.BackColor = Color.LightGray;
            btn5.BackColor = Color.Yellow;
            btn6.BackColor = Color.LightGray;
            btn7.BackColor = Color.LightGray;
            btn8.BackColor = Color.LightGray;
            btn9.BackColor = Color.LightGray;
            btn10.BackColor = Color.Yellow;
            btn11.BackColor = Color.LightGray;
            btn12.BackColor = Color.LightGray;
            btn13.BackColor = Color.LightGray;
            btn14.BackColor = Color.LightGray;
            btn15.BackColor = Color.Yellow;
        }

        private void GameShow_Load(object sender, EventArgs e)
        {
            cauhoi += 1;
            SHOW_PLAY_GAME(cauhoi);
        }

        public void setButtonColor(int number)
        {
            if (number == 0)
            {
                btn1.BackColor = Color.Orange;
            }
            else if (number == 1)
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.Orange;
            }
            else if (number == 2)
            {
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.Orange;
            }
            else if (number == 3)
            {
                btn3.BackColor = Color.GreenYellow;
                btn4.BackColor = Color.Orange;
            }
            else if (number == 4)
            {
                btn4.BackColor = Color.GreenYellow;
                btn5.BackColor = Color.Orange;
            }
            else if (number == 5)
            {
                btn5.BackColor = Color.Green;
                btn6.BackColor = Color.Orange;
            }
            else if (number == 6)
            {
                btn6.BackColor = Color.GreenYellow;
                btn7.BackColor = Color.Orange;
            }
            else if (number == 7)
            {
                btn7.BackColor = Color.GreenYellow;
                btn8.BackColor = Color.Orange;
            }
            else if (number == 8)
            {
                btn8.BackColor = Color.GreenYellow;
                btn9.BackColor = Color.Orange;
            }
            else if (number == 9)
            {
                btn9.BackColor = Color.GreenYellow;
                btn10.BackColor = Color.Orange;
            }
            else if (number == 10)
            {
                btn10.BackColor = Color.Green;
                btn11.BackColor = Color.Orange;
            }
            else if (number == 11)
            {
                btn11.BackColor = Color.GreenYellow;
                btn12.BackColor = Color.Orange;
            }
            else if (number == 12)
            {
                btn12.BackColor = Color.GreenYellow;
                btn13.BackColor = Color.Orange;
            }
            else if (number == 13)
            {
                btn13.BackColor = Color.GreenYellow;
                btn14.BackColor = Color.Orange;
            }
            else if (number == 14)
            {
                btn14.BackColor = Color.GreenYellow;
                btn15.BackColor = Color.Orange;
            }
            else if (number == 15)
            {
                btn15.BackColor = Color.Green;
            }
        }

        public List<BsonDocument> RANDOM_LIST_QnA()
        {
            List<BsonDocument> lstRD = GetBL.GET_LIST_RANDOM_DATA_TABLE_QnA();
            return lstRD;
        }

        void setEnabledIsFalse()
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            pbHelp5050.Enabled = false;
            pbHelpMaster.Enabled = false;
            pbHelpPhone.Enabled = false;
            pbHelpPeople.Enabled = false;
            pbHelpKG.Enabled = false;
        }

        void setEnabledIsTrue()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            pbHelp5050.Enabled = true;
            pbHelpMaster.Enabled = true;
            pbHelpPhone.Enabled = true;
            pbHelpPeople.Enabled = true;
            pbHelpKG.Enabled = true;
        }

        void setButtonAnsTrueIsGreen(int ans)
        {
            if (ans == -1)
            {
                btnA.BackColor = Color.Green;
            }
            else if (ans == -2)
            {
                btnB.BackColor = Color.Green;
            }
            else if (ans == -3)
            {
                btnC.BackColor = Color.Green;
            }
            else if (ans == -4)
            {
                btnD.BackColor = Color.Green;
            }
        }

        public void resetButton_Textbox()
        {
            btnA.BackColor = Color.Yellow;
            btnB.BackColor = Color.Yellow;
            btnC.BackColor = Color.Yellow;
            btnD.BackColor = Color.Yellow;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            pbHelpKG.Image = Image.FromFile(file_images[0]);
            setButtonColor(cauhoi);
            btnA.Text = "A: " + gameplay[cauhoi]["ans1"].ToString();
            btnB.Text = "B: " + gameplay[cauhoi]["ans2"].ToString();
            btnC.Text = "C: " + gameplay[cauhoi]["ans3"].ToString();
            btnD.Text = "D: " + gameplay[cauhoi]["ans4"].ToString();
            txtCauHoi.Text = ("Câu Hỏi: " + gameplay[cauhoi]["question"].ToString()).ToUpper();
        }
        public void SHOW_PLAY_GAME(int cauhoi)
        {
            if (cauhoi == 0)
            {
                gameplay = RANDOM_LIST_QnA();
                setColorButton();
            }
            resetButton_Textbox();
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
                        return ans;
                    }
                    else
                    {
                        MessageBox.Show("Đó là câu trả lời sai.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return gameplay[cauhoi]["ans_true"].AsInt32 * -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return 0;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.BackColor = Color.Orange;
            int rs = ViewAnswer(1);
            if (rs > 0)
            {
                btnA.BackColor = Color.Green;
                GameShow_Load(sender, e);
            }
            else if (rs < 0)
            {
                btnA.BackColor = Color.Red;
                setEnabledIsFalse();
                setButtonAnsTrueIsGreen(rs);
            }
            else if (rs == 0)
            {
                btnA.BackColor = Color.Yellow;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.BackColor = Color.Orange;
            int rs = ViewAnswer(2);
            if (rs > 0)
            {
                btnB.BackColor = Color.Green;
                GameShow_Load(sender, e);
            }
            else if (rs < 0)
            {
                btnB.BackColor = Color.Red;
                setEnabledIsFalse();
                setButtonAnsTrueIsGreen(rs);
            }
            else if (rs == 0)
            {
                btnB.BackColor = Color.Yellow;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.BackColor = Color.Orange;
            int rs = ViewAnswer(3);
            if (rs > 0)
            {
                btnC.BackColor = Color.Green;
                GameShow_Load(sender, e);
            }
            else if (rs < 0)
            {
                btnC.BackColor = Color.Red;
                setEnabledIsFalse();
                setButtonAnsTrueIsGreen(rs);
            }
            else if (rs == 0)
            {
                btnC.BackColor = Color.Yellow;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Orange;
            int rs = ViewAnswer(4);
            if (rs > 0)
            {
                btnD.BackColor = Color.Green;
                GameShow_Load(sender, e);
            }
            else if (rs < 0)
            {
                btnD.BackColor = Color.Red;
                setEnabledIsFalse();
                setButtonAnsTrueIsGreen(rs);
            }
            else if (rs == 0)
            {
                btnC.BackColor = Color.Yellow;
            }
        }

        private void pbHelpMaster_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn lựa chọn sự trợ giúp từ Chuyên Gia ?", "Thông Báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    int indexAns = gameplay[cauhoi]["ans_true"].AsInt32;
                    string ansHelp = answer_help[indexAns];
                    string mater = master_name[indexAns];
                    MessageBox.Show("Chuyên gia " + mater + ": Tôi nghĩ " + ansHelp + " là câu trả lời đúng.",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pbHelpMaster.Enabled = false;
                    pbHelpMaster.Image = Image.FromFile(file_false_image[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pbHelpPhone_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn lựa chọn sự trợ giúp từ Người Thân ?", "Thông Báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    int indexAns = gameplay[cauhoi]["ans_true"].AsInt32;
                    string ansHelp = answer_help[indexAns];
                    string name = phone_name[indexAns];
                    MessageBox.Show("Người Thân " + name + ": Tôi nghĩ " + ansHelp + " là câu trả lời đúng.",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pbHelpPhone.Enabled = false;
                    pbHelpPhone.Image = Image.FromFile(file_false_image[2]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pbHelpPeople_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn lựa chọn sự trợ giúp từ Khán Giả ?", "Thông Báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    int indexAns = gameplay[cauhoi]["ans_true"].AsInt32;
                    string local_images = file_images[indexAns];
                    pbHelpKG.Image = Image.FromFile(local_images);
                    pbHelpPeople.Enabled = false;
                    pbHelpPeople.Image = Image.FromFile(file_false_image[3]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void setButton5050(int ans)
        {
            if(ans == 1)
            {
                btnB.BackColor = Color.Red;
                btnB.Enabled = false;
                btnD.BackColor = Color.Red;
                btnD.Enabled = false;
            }
            else if (ans == 2)
            {
                btnA.BackColor = Color.Red;
                btnA.Enabled = false;
                btnC.BackColor = Color.Red;
                btnC.Enabled = false;
            }
            else if (ans == 3)
            {
                btnA.BackColor = Color.Red;
                btnA.Enabled = false;
                btnD.BackColor = Color.Red;
                btnD.Enabled = false;
            }
            else if (ans == 4)
            {
                btnA.BackColor = Color.Red;
                btnA.Enabled = false;
                btnB.BackColor = Color.Red;
                btnB.Enabled = false;
            }
        }
        private void pbHelp5050_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn lựa chọn sự trợ giúp 50:50 ?", "Thông Báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    int ans = gameplay[cauhoi]["ans_true"].AsInt32;
                    setButton5050(ans);
                    pbHelp5050.Enabled = false;
                    pbHelp5050.Image = Image.FromFile(file_false_image[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            cauhoi = -1;
            setEnabledIsTrue();
            GameShow_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
