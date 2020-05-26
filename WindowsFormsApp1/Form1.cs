using System;
using System.Threading;
using System.Windows.Forms;
using System.Speech.Synthesis;
using BDTranslate20T;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // 原文
        string q;
        // 改成您的APP ID
        string appId;
        // 改成您的密钥
        string secretKey;
        //网址
        string url;
        //次数
        int times;
        //请求发送间隔时间
        int gaptime;
        //语音引擎访问
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        
        public Form1()
        {
            InitializeComponent();
            //读取配置
            YamlElement y = ConfigManager.ReadConfig();
            if (y != null)
            {
                APPID.Text = y.AppId;
                SecrateTxt.Text = y.SecretKey;
                APIAddress.Text = y.Url;
                gapTime.Text = y.Gaptime.ToString();
                TranslateTimes.Text = y.Times.ToString();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            StartTranslate();
        }
       
        private void Speech_Click(object sender, EventArgs e)
        {
            //读出output输入框中的内容
            speechSynthesizer.SpeakAsync(OutPutTxt.Text);
        }

        //开始翻译
        void StartTranslate()
        {
            // 获取参数
            q = InputTxt.Text;
            appId = APPID.Text;
            secretKey = SecrateTxt.Text;
            url = APIAddress.Text;
            times = int.Parse(TranslateTimes.Text);
            gaptime = int.Parse(gapTime.Text);
            //设置进度条最大范围
            progress.Maximum = times;
            //新建线程以实现接口访问
            Thread th = new Thread(new ThreadStart(() =>
            {
                for (int i = 1; i <= times; i++)
                {
                    progress.Invoke(new Action(() => {
                        progress.Value = i;
                    }));
                    q = TranslateHelper.BDrequest(q, "zh", "en", appId, secretKey, url);
                    Thread.Sleep(gaptime);
                    q = TranslateHelper.BDrequest(q, "en", "zh", appId, secretKey, url);
                    Thread.Sleep(gaptime);

                }
                //进度完毕后重置
                progress.Invoke(new Action(() => {
                    progress.Value = 0;
                }));
                OutPutTxt.Invoke(new Action(() => {
                    OutPutTxt.Text = q;
                }));
            }));
            th.Start();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // 获取参数
            q = InputTxt.Text;
            appId = APPID.Text;
            secretKey = SecrateTxt.Text;
            url = APIAddress.Text;
            times = int.Parse(TranslateTimes.Text);
            gaptime = int.Parse(gapTime.Text);
            ConfigManager.SaveConfig(appId,secretKey,url,times,gaptime);
            MessageBox.Show(this, "保存成功", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
 
}
