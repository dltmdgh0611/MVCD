using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCD_Client
{
    public partial class Form1 : Form
    {
        bool P_en, Q_en;

        int sel_cb_index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Btn_Click(object sender, EventArgs e)
        {
            
            serialPort1.Write("s");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void SEND_BTN_Click(object sender, EventArgs e)
        {

        }

        private void sel_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sel_cb.Items[sel_cb.SelectedIndex].ToString() == "1차 함수")
            {
                sel_cb_index = 0;
                ExpressionP.Load(@"C:\Users\user\Pictures\graphs\1f.PNG");
                P_en = false;
                Q_en = false;
                p_tb.Enabled = P_en;
                q_tb.Enabled = Q_en;

            }
        }

        private void XMOVE_cb_CheckedChanged(object sender, EventArgs e)
        {
            P_en = !P_en;
            p_tb.Enabled = P_en;
        }

        private void YMOVE_cb_CheckedChanged(object sender, EventArgs e)
        {
            Q_en = !Q_en;
            q_tb.Enabled = Q_en;
        }
    }
}
