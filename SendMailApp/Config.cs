﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Serialization.Configuration;

namespace SendMailApp
{
    public class Config
    {
        //単一のインスタンス
        private static Config instance;

        //インスタンスの取得
        public static Config GetInstance()
        {
            if (instance == null)
            {
                instance = new Config();
            }
            return instance;
        }

        public string Smtp { get; set; }   //SMTPサーバー
        public string MailAddress { get; set; }　//自メールアドレス
        public string PassWord { get; set; }     //パスワード
        public int Port { get; set; }　　　　//ポート番号
        public bool Ssl { get; set; }　　　　//SSL設定

        

        //コンストラクタ (外部からnewできなくする)
        private Config() {}
        

        //初期設定用
        public void DefaultSet()
        {
            Smtp = "smtp.gmail.com";
            MailAddress = "ojsinfosys01@gmail.com";
            PassWord = "ojsInfosys2020";
            Port = 587;
            Ssl = true;
        }

        //初期値取得用
        public Config GetDefaultStatus()
        {
            Config obj = new Config()
            {
                Smtp = "smtp.gmail.com",
                MailAddress = "ojsinfosys01@gmail.com",
                PassWord = "ojsInfosys2020",
                Port = 587,
                Ssl = true,
            };            
            return obj;
        }

        //設定データ更新
        public bool UpdateStatus(string smtp,string mailAddress,string passWord,int port,bool ssl)
        {
           this.Smtp = smtp;
           this.MailAddress = mailAddress;
           this.PassWord = passWord;
           this.Port = port;
           this.Ssl = ssl;            

            return true;
        }

        //シリアル化
        public void Serialise()
        {
            
            using (var writer = XmlWriter.Create("config.xml"))
            {
                var serializer = new XmlSerializer(instance.GetType());
                // 指定のオブジェクトをシリアル化する
                serializer.Serialize(writer, instance);
            }
        }

        //逆シリアル化
        public void DeSerialise()
        {
            using(var reader=XmlReader.Create("config.xml"))
            {
                var serializer = new XmlSerializer(typeof(Config));
                instance = serializer.Deserialize(reader) as Config;
            }
        }
    }
}
