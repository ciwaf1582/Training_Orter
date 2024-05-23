namespace 연습
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.ckbPasta = new System.Windows.Forms.CheckBox();
            this.ckbSteak = new System.Windows.Forms.CheckBox();
            this.ckbTang = new System.Windows.Forms.CheckBox();
            this.btnEvent = new System.Windows.Forms.Button();
            this.radioAgree = new System.Windows.Forms.RadioButton();
            this.ckbSoon = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.radioDiagree = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.ListBox();
            this.cbPay = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "주문하세요.";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(128, 40);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(117, 12);
            this.lblOrder.TabIndex = 3;
            this.lblOrder.Text = "텍스트를 출력합니다";
            // 
            // ckbPasta
            // 
            this.ckbPasta.AutoSize = true;
            this.ckbPasta.Location = new System.Drawing.Point(107, 129);
            this.ckbPasta.Name = "ckbPasta";
            this.ckbPasta.Size = new System.Drawing.Size(60, 16);
            this.ckbPasta.TabIndex = 4;
            this.ckbPasta.Text = "파스타";
            this.ckbPasta.UseVisualStyleBackColor = true;
            // 
            // ckbSteak
            // 
            this.ckbSteak.AutoSize = true;
            this.ckbSteak.Location = new System.Drawing.Point(194, 129);
            this.ckbSteak.Name = "ckbSteak";
            this.ckbSteak.Size = new System.Drawing.Size(72, 16);
            this.ckbSteak.TabIndex = 4;
            this.ckbSteak.Text = "스테이크";
            this.ckbSteak.UseVisualStyleBackColor = true;
            // 
            // ckbTang
            // 
            this.ckbTang.AutoSize = true;
            this.ckbTang.Location = new System.Drawing.Point(294, 129);
            this.ckbTang.Name = "ckbTang";
            this.ckbTang.Size = new System.Drawing.Size(60, 16);
            this.ckbTang.TabIndex = 4;
            this.ckbTang.Text = "탕수육";
            this.ckbTang.UseVisualStyleBackColor = true;
            // 
            // btnEvent
            // 
            this.btnEvent.Location = new System.Drawing.Point(16, 164);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(350, 56);
            this.btnEvent.TabIndex = 5;
            this.btnEvent.Text = "주문";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // radioAgree
            // 
            this.radioAgree.AutoSize = true;
            this.radioAgree.Location = new System.Drawing.Point(55, 90);
            this.radioAgree.Name = "radioAgree";
            this.radioAgree.Size = new System.Drawing.Size(47, 16);
            this.radioAgree.TabIndex = 6;
            this.radioAgree.TabStop = true;
            this.radioAgree.Text = "동의";
            this.radioAgree.UseVisualStyleBackColor = true;
            // 
            // ckbSoon
            // 
            this.ckbSoon.AutoSize = true;
            this.ckbSoon.Location = new System.Drawing.Point(16, 129);
            this.ckbSoon.Name = "ckbSoon";
            this.ckbSoon.Size = new System.Drawing.Size(60, 16);
            this.ckbSoon.TabIndex = 4;
            this.ckbSoon.Text = "순대국";
            this.ckbSoon.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "이벤트에 응모하려면 개인정보 동의해주세요.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioDiagree);
            this.groupBox1.Controls.Add(this.radioAgree);
            this.groupBox1.Location = new System.Drawing.Point(16, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개인정보";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(472, 28);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(117, 95);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "응모";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // radioDiagree
            // 
            this.radioDiagree.AutoSize = true;
            this.radioDiagree.Location = new System.Drawing.Point(178, 90);
            this.radioDiagree.Name = "radioDiagree";
            this.radioDiagree.Size = new System.Drawing.Size(71, 16);
            this.radioDiagree.TabIndex = 6;
            this.radioDiagree.TabStop = true;
            this.radioDiagree.Text = "동의안함";
            this.radioDiagree.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 464);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(400, 95);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "주문 시 요구사항";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 95);
            this.button1.TabIndex = 7;
            this.button1.Text = "접수";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnReceipt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 626);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "결재 방법";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(190, 626);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "결재 정보";
            // 
            // lbArea
            // 
            this.lbArea.FormattingEnabled = true;
            this.lbArea.ItemHeight = 12;
            this.lbArea.Items.AddRange(new object[] {
            "..."});
            this.lbArea.Location = new System.Drawing.Point(194, 679);
            this.lbArea.Name = "lbArea";
            this.lbArea.ScrollAlwaysVisible = true;
            this.lbArea.Size = new System.Drawing.Size(120, 76);
            this.lbArea.TabIndex = 9;
            // 
            // cbPay
            // 
            this.cbPay.FormattingEnabled = true;
            this.cbPay.Items.AddRange(new object[] {
            "신용 카드",
            "무통장 입금",
            "포인트"});
            this.cbPay.Location = new System.Drawing.Point(16, 679);
            this.cbPay.Name = "cbPay";
            this.cbPay.Size = new System.Drawing.Size(121, 20);
            this.cbPay.TabIndex = 10;
            this.cbPay.SelectedIndexChanged += new System.EventHandler(this.cbPay_SelectedIndexChanged);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(488, 679);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(117, 95);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "결재";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_CIick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 832);
            this.Controls.Add(this.cbPay);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.ckbTang);
            this.Controls.Add(this.ckbSteak);
            this.Controls.Add(this.ckbSoon);
            this.Controls.Add(this.ckbPasta);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.CheckBox ckbPasta;
        private System.Windows.Forms.CheckBox ckbSteak;
        private System.Windows.Forms.CheckBox ckbTang;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.RadioButton radioAgree;
        private System.Windows.Forms.CheckBox ckbSoon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.RadioButton radioDiagree;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbArea;
        private System.Windows.Forms.ComboBox cbPay;
        private System.Windows.Forms.Button btnPay;
    }
}

