using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Diagnostics;
using QLDiem.XuLyDiem;
using System.IO;

namespace QLDiem.GiaoDien
{
    public partial class frmTroGiup : Form
    {
        public frmTroGiup()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "mailto:damvanphuong127@gmail.com";
                process.Start();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "https://youtu.be/0RdP51wfIto";
                process.Start();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "https://damvanphuong.blogspot.com/";
                process.Start();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "http://vanphuongpro.blogspot.com";
                process.Start();
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "https://damvanphuong.000webhostapp.com";
                process.Start();
            }
        }        
    }
}
