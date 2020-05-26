using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using WindowsFormsApp1;

namespace BDTranslate20T
{
    /// <summary>
    /// 向翻译引擎发送请求，并返回翻译结果
    /// </summary>
    static class TranslateHelper
    {
        /// <summary>
        /// 用以向百度翻译接口发送请求，获取翻译信息
        /// </summary>
        /// <param name="p">翻译文本</param>
        /// <param name="from">源语言</param>
        /// <param name="to">目标语言</param>
        /// <param name="appId">APPID</param>
        /// <param name="secretKey">密匙</param>
        /// <param name="url">api地址</param>
        /// <returns>翻译结果文本</returns>
        public static string BDrequest(string p, string from, string to, string appId, string secretKey, string url)
        {
            Random rd = new Random();
            string salt = rd.Next(100000).ToString();
            string sign = EncryptString(appId + p + salt + secretKey);
            //参数体
            string requestStr = "";
            requestStr += "q=" + HttpUtility.UrlEncode(p);
            requestStr += "&from=" + from;
            requestStr += "&to=" + to;
            requestStr += "&appid=" + appId;
            requestStr += "&salt=" + salt;
            requestStr += "&sign=" + sign;
            //参数体的byte数组
            byte[] requestByte = Encoding.UTF8.GetBytes(requestStr);
            //Console.WriteLine(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = null;
            request.Timeout = 6000;

            #region 添加Post 参数
            
            request.ContentLength = requestByte.Length;
            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(requestByte, 0, requestByte.Length);
                reqStream.Close();
            }
            #endregion

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            //Console.WriteLine(retString);
            JavaScriptSerializer Serializer = new JavaScriptSerializer();
            Json json = Serializer.Deserialize<Json>(retString);
            string result = null;
            foreach (Trans_result _Result in json.trans_result)
            {
                result += _Result.dst + "\n\n";
            }
            return result;
        }

        // 计算MD5值
        public static string EncryptString(string str)
        {
            MD5 md5 = MD5.Create();
            // 将字符串转换成字节数组
            byte[] byteOld = Encoding.UTF8.GetBytes(str);
            // 调用加密方法
            byte[] byteNew = md5.ComputeHash(byteOld);
            // 将加密结果转换为字符串
            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteNew)
            {
                // 将字节转换成16进制表示的字符串，
                sb.Append(b.ToString("x2"));
            }
            // 返回加密的字符串
            return sb.ToString();
        }

    }
}
