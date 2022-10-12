using System;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;
using fubon_future_test.Classes;
using FubonE01API;

namespace fubon_future_test
{
    public partial class Form1 : Form
    {
        #region 屬性
        private Fubon_Mananger_API_2 fubonApi = null; //富邦 API 物件
        int apiRet = 0; //Api 回傳值
        XmlDocument xmlDoc = new XmlDocument(); //解析 XML
        #endregion

        #region 建構子
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始化物件
            fubonApi = new Fubon_Mananger_API_2(); //富邦 API 物件

            // 加入商品下拉
            cboSymbolCode.Items.Add(new ComboboxItem("TXF", "大台指期近月"));
            cboSymbolCode.Items.Add(new ComboboxItem("MXF", "小台指期近月"));
            cboSymbolCode.Items.Add(new ComboboxItem("EXF", "電子期近月"));

            // 加入方向下拉
            cboBuySell.Items.Add(new ComboboxItem("B", "BUY"));
            cboBuySell.Items.Add(new ComboboxItem("S", "SELL"));

            //加入方式下拉
            cboTradeType.Items.Add(new ComboboxItem("R", "ROD"));
            cboTradeType.Items.Add(new ComboboxItem("I", "IOC"));
            cboTradeType.Items.Add(new ComboboxItem("F", "FOK"));

            // 加入倉別下拉
            cboNewClose.Items.Add(new ComboboxItem("0", "新倉"));
            cboNewClose.Items.Add(new ComboboxItem("1", "平倉"));
            cboNewClose.Items.Add(new ComboboxItem("2", "自動"));
            cboNewClose.Items.Add(new ComboboxItem("4", "當沖"));

        }
        #endregion

        #region 動作
        /// <summary>
        /// 富邦登入測試
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFubonLoginTest_Click(object sender, EventArgs e)
        {
            if (txtFubonAcct.Text == "")
            {
                MessageBox.Show("請輸入 [帳號]");
                return;
            }
            if (txtFubonPwd.Text == "")
            {
                MessageBox.Show("請輸入 [密碼]");
                return;
            }

            string UserInfo = "";
            cboOrderAcct.Items.Clear();

            // 登入富邦
            apiRet = fubonApi.eLogin(txtFubonAcct.Text, txtFubonPwd.Text, ref UserInfo);

            if (apiRet >= 0)
            {
                // 登入成功
                txtMessage.AppendText("登入成功" + "\n");

                // 取得下單帳號
                xmlDoc.LoadXml(UserInfo);
                XmlNodeList rows = xmlDoc.GetElementsByTagName("Row");
                for (int i = 0; i < rows.Count; i++)
                {
                    string Type = rows[i].Attributes["Type"].Value;
                    if (Type == "F")
                    {
                        // F=期貨帳號

                        // 加入下單帳號
                        cboOrderAcct.Items.Add(new ComboboxItem(rows[i].Attributes["MsgKey"].Value, rows[i].Attributes["MsgKey"].Value));
                    }
                }
                if (cboOrderAcct.Items.Count > 0)
                {
                    cboOrderAcct.SelectedIndex = 0;
                }

                // 取得交易日
                string TradeDay = ""; // 回傳值1：交易日
                string UserTDate = "";// 回傳值2：MSGXML
                apiRet = fubonApi.eTDate("F", ref TradeDay, ref UserTDate);

                if (apiRet >= 0)
                {
                    txtTradeDate.Text = TradeDay;
                }
                else
                {
                    txtMessage.AppendText(apiRet.ToString(CultureInfo.InvariantCulture) + "\n");
                }

                // 預設憑證路徑
                string caPath = "C:\\CAFubon\\{0}\\{0}.pfx";
                txtCaPath.Text = string.Format(caPath, txtFubonAcct.Text);

                // 啟用按鈕
                btnCheckCa.Enabled = true;
                btnSendEntrust.Enabled = true;
            }
            else
            {
                // 解析XML
                xmlDoc.LoadXml(UserInfo);
                string Code = xmlDoc.GetElementsByTagName("Error")[0].Attributes["Code"].Value;
                string Msg = xmlDoc.GetElementsByTagName("Error")[0].Attributes["Msg"].Value;

                txtMessage.AppendText("登入失敗 Code=" + Code + "Msg=" + Msg + "\n");
            }
        }

        /// <summary>
        /// 憑證測試
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckCa_Click(object sender, EventArgs e)
        {
            if (txtCaPwd.Text == "")
            {
                MessageBox.Show("請輸入 [憑證密碼]");
                return;
            }
            if (txtCaPath.Text == "")
            {
                MessageBox.Show("請輸入 [憑證路徑]");
                return;
            }

            // 驗證憑證
            string MessageStr = "";
            bool chkRet = fubonApi.AddPreSignData(txtFubonAcct.Text, txtCaPwd.Text, txtCaPath.Text, ref MessageStr);
            if (chkRet)
            {
                txtMessage.AppendText("憑證驗證成功" + "\n");
            }
            else
            {
                txtMessage.AppendText("憑證驗證失敗" + "\n");
            }
        }

        /// <summary>
        /// 送出委託單
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendEntrust_Click(object sender, EventArgs e)
        {
            if (ComboUtil.GetItem(cboOrderAcct).Value == "")
            {
                MessageBox.Show("請選擇下單帳號");
                return;
            }
            if (cboSymbolCode.Text == "")
            {
                MessageBox.Show("請輸入 [商品]");
                return;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("請輸入 [價格]");
                return;
            }
            if (cboBuySell.Text == "")
            {
                MessageBox.Show("請輸入 [方向]");
                return;
            }
            if (cboTradeType.Text == "")
            {
                MessageBox.Show("請輸入 [方式]");
                return;
            }
            if (cboNewClose.Text == "")
            {
                MessageBox.Show("請輸入 [倉別]");
                return;
            }
            if (txtQty.Text == "")
            {
                MessageBox.Show("請輸入 [口數]");
                return;
            }

            // 取得下單參數
            string MsgKey = ComboUtil.GetItem(cboOrderAcct).Value;//下單帳號
            string TDate = txtTradeDate.Text;//交易日
            string ProductType = "0"; //商品別｛0：期貨／1：選擇權｝
            string CommID = ComboUtil.GetItem(cboSymbolCode).Value; //商品代碼
            string CommID_EP = "";//參考價(期貨為空白)
            string CommID_YM = GetFubonFutureYM();//交易年月(EX：200901)
            string CommID_CP = ""; //C：Call／P：Put(期貨為空白)

            // 交易方向
            string BS = ComboUtil.GetItem(cboBuySell).Value;//買賣別｛B：買進／S：賣出｝

            string PriceType = "";//價位別｛0：限價／4：市價／24：範圍市價｝
            string Price = "";//委託價格(市價為空白)
            if (txtPrice.Text == "M")
            {
                PriceType = "4";
            }
            else
            {
                PriceType = "0";
                Price = txtPrice.Text;
            }

            string Qty = txtQty.Text;//口數
            string Offset = ComboUtil.GetItem(cboNewClose).Value;//倉別｛0：新倉／1：平倉／2：自動倉／4：當沖｝
            string Cond = ComboUtil.GetItem(cboTradeType).Value;//委託別｛R：ROD／F：FOK／I：IOC｝

            string MSGXML = ""; //回傳XML
            // 呼叫富邦下單
            apiRet = fubonApi.efOrder(MsgKey, TDate, ProductType, CommID, CommID_EP, CommID_YM, CommID_CP, BS, PriceType, Price, Qty, Offset, Cond, ref MSGXML);
            if (apiRet >= 0)
            {
                txtMessage.AppendText("下單成功 " + "\n");
                txtMessage.AppendText(MSGXML + "\n");
            }
            else
            {
                // 解析XML
                xmlDoc.LoadXml(MSGXML);
                string Code = xmlDoc.GetElementsByTagName("Error")[0].Attributes["Code"].Value;
                string Msg = xmlDoc.GetElementsByTagName("Error")[0].Attributes["Msg"].Value;

                txtMessage.AppendText("下單失敗 " + Msg + "\n");
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 取得富邦期貨交易年月
        /// </summary>
        /// <returns></returns>
        private string GetFubonFutureYM()
        {
            string FutureYM = "";

            int year = Convert.ToInt32(DateTime.Now.Year.ToString());
            int month = DateTime.Now.Month;
            DateTime monthExp = GetMonthExpDate(DateTime.Now);
            if (DateTime.Now > monthExp)
            {
                month += 1;
                if (month == 13)
                {
                    month = 1;
                    year = year + 1;
                }
            }
            FutureYM = year + month.ToString("00");
            return FutureYM;
        }

        /// <summary>
        /// 取得月份到期日(當月第3個星期三)
        /// </summary>
        /// <returns></returns>
        private DateTime GetMonthExpDate(DateTime date)
        {
            // 本月第一天
            DateTime firstDay = new DateTime(date.Year, date.Month, 1, 14, 0, 0);
            // 找到第一個星期三
            while (firstDay.DayOfWeek != DayOfWeek.Wednesday)
                firstDay = firstDay.AddDays(1);
            firstDay = firstDay.AddDays(14);
            return firstDay;
        }
        #endregion

        #region 事件

        #endregion

    }
}
