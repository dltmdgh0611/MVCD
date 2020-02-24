namespace MVCD_Client
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Start_Btn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.sel_cb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.select_lb = new System.Windows.Forms.Label();
            this.funcs = new System.Windows.Forms.GroupBox();
            this.fprime_rb = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.XMOVE_cb = new System.Windows.Forms.CheckBox();
            this.YMOVE_cb = new System.Windows.Forms.CheckBox();
            this.ExpressionP = new System.Windows.Forms.PictureBox();
            this.SEND_BTN = new System.Windows.Forms.Button();
            this.a_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.q_tb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpressionP)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_Btn
            // 
            this.Start_Btn.Location = new System.Drawing.Point(712, 355);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(121, 62);
            this.Start_Btn.TabIndex = 0;
            this.Start_Btn.Text = "Start";
            this.Start_Btn.UseVisualStyleBackColor = true;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Btn_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            // 
            // sel_cb
            // 
            this.sel_cb.FormattingEnabled = true;
            this.sel_cb.Items.AddRange(new object[] {
            "1차 함수",
            "2차 함수",
            "3차 함수",
            "4차 함수",
            "지수 함수",
            "로그 함수",
            "원",
            "타원",
            "쌍곡선",
            "포물선",
            "cos",
            "sin",
            "tan"});
            this.sel_cb.Location = new System.Drawing.Point(712, 62);
            this.sel_cb.Name = "sel_cb";
            this.sel_cb.Size = new System.Drawing.Size(121, 20);
            this.sel_cb.TabIndex = 1;
            this.sel_cb.SelectedIndexChanged += new System.EventHandler(this.sel_cb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.q_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.p_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.a_tb);
            this.groupBox1.Controls.Add(this.ExpressionP);
            this.groupBox1.Location = new System.Drawing.Point(210, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 405);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "expression";
            // 
            // select_lb
            // 
            this.select_lb.AutoSize = true;
            this.select_lb.Location = new System.Drawing.Point(766, 36);
            this.select_lb.Name = "select_lb";
            this.select_lb.Size = new System.Drawing.Size(67, 12);
            this.select_lb.TabIndex = 3;
            this.select_lb.Text = "func select";
            // 
            // funcs
            // 
            this.funcs.Location = new System.Drawing.Point(12, 12);
            this.funcs.Name = "funcs";
            this.funcs.Size = new System.Drawing.Size(192, 405);
            this.funcs.TabIndex = 4;
            this.funcs.TabStop = false;
            this.funcs.Text = "functions";
            // 
            // fprime_rb
            // 
            this.fprime_rb.AutoSize = true;
            this.fprime_rb.Location = new System.Drawing.Point(741, 133);
            this.fprime_rb.Name = "fprime_rb";
            this.fprime_rb.Size = new System.Drawing.Size(64, 16);
            this.fprime_rb.TabIndex = 5;
            this.fprime_rb.TabStop = true;
            this.fprime_rb.Text = "Inverse";
            this.fprime_rb.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(741, 111);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Originally";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // XMOVE_cb
            // 
            this.XMOVE_cb.AutoSize = true;
            this.XMOVE_cb.Location = new System.Drawing.Point(741, 182);
            this.XMOVE_cb.Name = "XMOVE_cb";
            this.XMOVE_cb.Size = new System.Drawing.Size(69, 16);
            this.XMOVE_cb.TabIndex = 7;
            this.XMOVE_cb.Text = "X_move";
            this.XMOVE_cb.UseVisualStyleBackColor = true;
            this.XMOVE_cb.CheckedChanged += new System.EventHandler(this.XMOVE_cb_CheckedChanged);
            // 
            // YMOVE_cb
            // 
            this.YMOVE_cb.AutoSize = true;
            this.YMOVE_cb.Location = new System.Drawing.Point(741, 204);
            this.YMOVE_cb.Name = "YMOVE_cb";
            this.YMOVE_cb.Size = new System.Drawing.Size(69, 16);
            this.YMOVE_cb.TabIndex = 8;
            this.YMOVE_cb.Text = "Y_move";
            this.YMOVE_cb.UseVisualStyleBackColor = true;
            this.YMOVE_cb.CheckedChanged += new System.EventHandler(this.YMOVE_cb_CheckedChanged);
            // 
            // ExpressionP
            // 
            this.ExpressionP.Location = new System.Drawing.Point(6, 24);
            this.ExpressionP.Name = "ExpressionP";
            this.ExpressionP.Size = new System.Drawing.Size(462, 375);
            this.ExpressionP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExpressionP.TabIndex = 0;
            this.ExpressionP.TabStop = false;
            // 
            // SEND_BTN
            // 
            this.SEND_BTN.Location = new System.Drawing.Point(712, 272);
            this.SEND_BTN.Name = "SEND_BTN";
            this.SEND_BTN.Size = new System.Drawing.Size(121, 77);
            this.SEND_BTN.TabIndex = 9;
            this.SEND_BTN.Text = "Send";
            this.SEND_BTN.UseVisualStyleBackColor = true;
            this.SEND_BTN.Click += new System.EventHandler(this.SEND_BTN_Click);
            // 
            // a_tb
            // 
            this.a_tb.Location = new System.Drawing.Point(36, 365);
            this.a_tb.Name = "a_tb";
            this.a_tb.Size = new System.Drawing.Size(60, 21);
            this.a_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "p";
            // 
            // p_tb
            // 
            this.p_tb.Location = new System.Drawing.Point(123, 365);
            this.p_tb.Name = "p_tb";
            this.p_tb.Size = new System.Drawing.Size(60, 21);
            this.p_tb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "q";
            // 
            // q_tb
            // 
            this.q_tb.Location = new System.Drawing.Point(209, 365);
            this.q_tb.Name = "q_tb";
            this.q_tb.Size = new System.Drawing.Size(60, 21);
            this.q_tb.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 429);
            this.Controls.Add(this.SEND_BTN);
            this.Controls.Add(this.YMOVE_cb);
            this.Controls.Add(this.XMOVE_cb);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.fprime_rb);
            this.Controls.Add(this.funcs);
            this.Controls.Add(this.select_lb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sel_cb);
            this.Controls.Add(this.Start_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpressionP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Btn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox sel_cb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ExpressionP;
        private System.Windows.Forms.Label select_lb;
        private System.Windows.Forms.GroupBox funcs;
        private System.Windows.Forms.RadioButton fprime_rb;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox XMOVE_cb;
        private System.Windows.Forms.CheckBox YMOVE_cb;
        private System.Windows.Forms.Button SEND_BTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox q_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox p_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox a_tb;
    }
}

