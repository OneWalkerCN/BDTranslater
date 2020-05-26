using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class YamlElement
    {
        // 您的APP ID
        public string AppId { get; set; }
        // 您的密钥
        public string SecretKey { get; set; }
        //api网址
        public string Url { get; set; }
        //翻译次数
        public int Times { get; set; }
        //请求发送间隔时间
        public int Gaptime { get; set; }

        public YamlElement() { }

        public YamlElement(string appId, string secretKey, string url, int times, int gaptime)
        {
            AppId = appId;
            SecretKey = secretKey;
            Url = url;
            Times = times;
            Gaptime = gaptime;
        }
    }
}
