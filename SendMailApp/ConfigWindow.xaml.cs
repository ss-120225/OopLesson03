﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SendMailApp
{
    /// <summary>
    /// ConfigWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfigWindow : Window
    {
        public ConfigWindow()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, RoutedEventArgs e)
        {
            Config cf = (Config.GetInstance()).GetDefaultStatus();
            //Config defaultData = cf.GetDefaultStatus();
            tbSmtp.Text = cf.Smtp;
            tbUserName.Text = tbUserName.Text = cf.MailAddress;
            tbPassWord.Password = cf.PassWord;
            tbPort.Text = cf.Port.ToString();
            cbSsl.IsChecked = cf.Ssl;
        }

        private void btApply_Click(object sender, RoutedEventArgs e)
        {
            (Config.GetInstance()).UpdateStatus
                (
                tbSmtp.Text,
                tbUserName.Text, 
                tbPassWord.Password,
                int.Parse(tbPort.Text),
                cbSsl.IsChecked??false
                );
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btOk_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
