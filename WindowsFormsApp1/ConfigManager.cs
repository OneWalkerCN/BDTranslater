using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;
using YamlDotNet.Serialization;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 管理配置信息（保存/读取）
    /// </summary>
   public class ConfigManager
    {
        /// <summary>
        /// 保存配置信息
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="secretKey"></param>
        /// <param name="url"></param>
        /// <param name="times"></param>
        /// <param name="gaptime"></param>
      static public void SaveConfig(string appId, string secretKey, string url, int times, int gaptime)
        {
            //Console.WriteLine(appId + secretKey + url);
            YamlElement element = new YamlElement(appId, secretKey, url, times, gaptime);

            //序列器
            Serializer serializer = new Serializer();
            //将保存对象序列化到strWriter
            string strWriter = serializer.Serialize(element);
            //Console.WriteLine(strWriter);
            using (TextWriter writer = File.CreateText("config.yml"))
            {
                writer.Write(strWriter);
            }
        }
        /// <summary>
        /// 读取配置信息
        /// </summary>
        static public YamlElement ReadConfig() {
            try
            {
                using (TextReader reader = File.OpenText(@"config.yml"))
                {
                    //反序列化
                    Deserializer deserializer = new Deserializer();
                    var configFromFile = deserializer.Deserialize<YamlElement>(reader);
                    return configFromFile;
                }
            }
            catch (FileNotFoundException d) {
                Console.WriteLine(d.Message);
                return null;
            }
        }
    }
}
