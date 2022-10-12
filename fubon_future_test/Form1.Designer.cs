
namespace fubon_future_test
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTradeDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboOrderAcct = new System.Windows.Forms.ComboBox();
            this.btnFubonLoginTest = new System.Windows.Forms.Button();
            this.txtFubonPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFubonAcct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSendEntrust = new System.Windows.Forms.Button();
            this.cboTradeType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboNewClose = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBuySell = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSymbolCode = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCaPwd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCheckCa = new System.Windows.Forms.Button();
            this.txtCaPath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTradeDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboOrderAcct);
            this.groupBox2.Controls.Add(this.btnFubonLoginTest);
            this.groupBox2.Controls.Add(this.txtFubonPwd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFubonAcct);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 116);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "富邦帳號";
            // 
            // txtTradeDate
            // 
            this.txtTradeDate.Location = new System.Drawing.Point(100, 81);
            this.txtTradeDate.Name = "txtTradeDate";
            this.txtTradeDate.ReadOnly = true;
            this.txtTradeDate.Size = new System.Drawing.Size(100, 22);
            this.txtTradeDate.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(6, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "交易日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "下單帳號：";
            // 
            // cboOrderAcct
            // 
            this.cboOrderAcct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderAcct.FormattingEnabled = true;
            this.cboOrderAcct.Location = new System.Drawing.Point(100, 50);
            this.cboOrderAcct.Name = "cboOrderAcct";
            this.cboOrderAcct.Size = new System.Drawing.Size(236, 20);
            this.cboOrderAcct.TabIndex = 5;
            // 
            // btnFubonLoginTest
            // 
            this.btnFubonLoginTest.Location = new System.Drawing.Point(262, 81);
            this.btnFubonLoginTest.Name = "btnFubonLoginTest";
            this.btnFubonLoginTest.Size = new System.Drawing.Size(71, 23);
            this.btnFubonLoginTest.TabIndex = 4;
            this.btnFubonLoginTest.Text = "登入";
            this.btnFubonLoginTest.UseVisualStyleBackColor = true;
            this.btnFubonLoginTest.Click += new System.EventHandler(this.btnFubonLoginTest_Click);
            // 
            // txtFubonPwd
            // 
            this.txtFubonPwd.Location = new System.Drawing.Point(236, 22);
            this.txtFubonPwd.Name = "txtFubonPwd";
            this.txtFubonPwd.PasswordChar = '*';
            this.txtFubonPwd.Size = new System.Drawing.Size(100, 22);
            this.txtFubonPwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(174, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼：";
            // 
            // txtFubonAcct
            // 
            this.txtFubonAcct.Location = new System.Drawing.Point(68, 22);
            this.txtFubonAcct.Name = "txtFubonAcct";
            this.txtFubonAcct.Size = new System.Drawing.Size(100, 22);
            this.txtFubonAcct.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Location = new System.Drawing.Point(12, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 140);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "訊息";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(6, 21);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(683, 113);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSendEntrust);
            this.groupBox3.Controls.Add(this.cboTradeType);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtQty);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cboNewClose);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cboBuySell);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cboSymbolCode);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Location = new System.Drawing.Point(12, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(695, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "期貨下單";
            // 
            // btnSendEntrust
            // 
            this.btnSendEntrust.Enabled = false;
            this.btnSendEntrust.Location = new System.Drawing.Point(506, 29);
            this.btnSendEntrust.Name = "btnSendEntrust";
            this.btnSendEntrust.Size = new System.Drawing.Size(106, 41);
            this.btnSendEntrust.TabIndex = 61;
            this.btnSendEntrust.Text = "送出委託單";
            this.btnSendEntrust.UseVisualStyleBackColor = true;
            this.btnSendEntrust.Click += new System.EventHandler(this.btnSendEntrust_Click);
            // 
            // cboTradeType
            // 
            this.cboTradeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTradeType.FormattingEnabled = true;
            this.cboTradeType.Location = new System.Drawing.Point(296, 48);
            this.cboTradeType.Name = "cboTradeType";
            this.cboTradeType.Size = new System.Drawing.Size(62, 20);
            this.cboTradeType.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(293, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "方式";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(432, 48);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(58, 22);
            this.txtQty.TabIndex = 58;
            this.txtQty.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(429, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 57;
            this.label8.Text = "口數";
            // 
            // cboNewClose
            // 
            this.cboNewClose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewClose.FormattingEnabled = true;
            this.cboNewClose.Location = new System.Drawing.Point(364, 48);
            this.cboNewClose.Name = "cboNewClose";
            this.cboNewClose.Size = new System.Drawing.Size(62, 20);
            this.cboNewClose.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(361, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "倉別";
            // 
            // cboBuySell
            // 
            this.cboBuySell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuySell.FormattingEnabled = true;
            this.cboBuySell.Location = new System.Drawing.Point(226, 48);
            this.cboBuySell.Name = "cboBuySell";
            this.cboBuySell.Size = new System.Drawing.Size(64, 20);
            this.cboBuySell.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(223, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "方向";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(132, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "價格";
            // 
            // cboSymbolCode
            // 
            this.cboSymbolCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSymbolCode.FormattingEnabled = true;
            this.cboSymbolCode.Location = new System.Drawing.Point(9, 48);
            this.cboSymbolCode.Name = "cboSymbolCode";
            this.cboSymbolCode.Size = new System.Drawing.Size(120, 20);
            this.cboSymbolCode.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "商品";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(135, 46);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(85, 22);
            this.txtPrice.TabIndex = 62;
            this.txtPrice.Text = "M";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtCaPath);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.btnCheckCa);
            this.groupBox4.Controls.Add(this.txtCaPwd);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(376, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 113);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "檢查憑證";
            // 
            // txtCaPwd
            // 
            this.txtCaPwd.Location = new System.Drawing.Point(100, 20);
            this.txtCaPwd.Name = "txtCaPwd";
            this.txtCaPwd.PasswordChar = '*';
            this.txtCaPwd.Size = new System.Drawing.Size(100, 22);
            this.txtCaPwd.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "憑證密碼：";
            // 
            // btnCheckCa
            // 
            this.btnCheckCa.Enabled = false;
            this.btnCheckCa.Location = new System.Drawing.Point(247, 78);
            this.btnCheckCa.Name = "btnCheckCa";
            this.btnCheckCa.Size = new System.Drawing.Size(71, 23);
            this.btnCheckCa.TabIndex = 6;
            this.btnCheckCa.Text = "檢查憑證";
            this.btnCheckCa.UseVisualStyleBackColor = true;
            this.btnCheckCa.Click += new System.EventHandler(this.btnCheckCa_Click);
            // 
            // txtCaPath
            // 
            this.txtCaPath.Location = new System.Drawing.Point(100, 48);
            this.txtCaPath.Name = "txtCaPath";
            this.txtCaPath.Size = new System.Drawing.Size(218, 22);
            this.txtCaPath.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(6, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "憑證路徑：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(7, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "如果不驗證，將會下單時開窗驗證";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 395);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "富邦期貨下單";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboOrderAcct;
        private System.Windows.Forms.Button btnFubonLoginTest;
        private System.Windows.Forms.TextBox txtFubonPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFubonAcct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSendEntrust;
        private System.Windows.Forms.ComboBox cboTradeType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboNewClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboBuySell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboSymbolCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTradeDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCheckCa;
        private System.Windows.Forms.TextBox txtCaPwd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCaPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

