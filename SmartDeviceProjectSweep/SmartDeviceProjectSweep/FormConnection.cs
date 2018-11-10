using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartDeviceProjectSweep.WebRef;
using System.Net;
using System.IO;

namespace SmartDeviceProjectSweep
{
    public partial class FormConnection : Form
    {
        public FormConnection()
        {
            InitializeComponent();

            Utility.IniOperation ini = new Utility.IniOperation();
            ini.Config("config.ini");

            textBox3.Text = ini.get("host");
            textBox2.Text = ini.get("user");
            textBox1.Text = ini.get("password");
            comboBox3.Text = ini.get("dbname");

            //System.Net.HttpWebRequest req = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create("http://192.168.0.101/home/test");
            //req.Method = "Get";
            //System.IO.MemoryStream streanm = (System.IO.MemoryStream) req.GetResponse().GetResponseStream();
            //byte[] b = new byte[req.GetResponse().ContentLength];
            //streanm.Read(b, 0, (int)req.GetResponse().ContentLength);
            //string result = System.Text.Encoding.UTF8.GetString(b, 0, b.Length);                                                                                   
        }

        SmartDeviceProjectBll.Bll.ConnecBll _bll = new SmartDeviceProjectBll.Bll.ConnecBll();

        //Connect test
        private void button3_Click_1(object sender, EventArgs e)
        {
            //WebResponse result = null;

            //try
            //{
            //    WebRequest req = WebRequest.Create("http://192.168.0.101/home/test");
            //    result = req.GetResponse();
            //    Stream ReceiveStream = result.GetResponseStream();

            //    //read the stream into a string
            //    StreamReader sr = new StreamReader(ReceiveStream);
            //    string resultstring = sr.ReadToEnd();

            //    Console.WriteLine("\r\nResponse stream received");
            //    Console.WriteLine(resultstring);
            //}
            //catch (Exception exp)
            //{
            //    Console.Write("\r\nRequest failed. Reason:");
            //    Console.WriteLine(exp.Message);
            //}
            //finally
            //{
            //    if (result != null)
            //    {
            //        result.Close();
            //    }
            //}

            //Console.WriteLine("\r\nPress Enter to exit.");
            //Console.ReadLine();

            //Service1 se = new Service1();
            ////se.he();
            //MessageBox.Show(se.he());
            DataTable da = new DataTable();
            //try
            //{
            string connstr = "server=" + textBox3.Text + ";Database=master;Uid=" + textBox2.Text + ";Pwd=" + textBox1.Text + "";
            da = _bll.GetDataTable(connstr);
            if (da != null && da.Rows.Count > 0)
            {
                comboBox3.DataSource = da;
                comboBox3.DisplayMember = "name";
            }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.StackTrace);
            //}
        }
        //Sure  Save
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("请填写数据库名称");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("请填写用户名");
                return;
            }
            if (string.IsNullOrEmpty(comboBox3.Text))
            {
                MessageBox.Show("请选择数据库");
                return;
            }
            Utility.IniOperation ini = new Utility.IniOperation();
            ini.Config("config.ini");
            ini.set("host", textBox3.Text);
            ini.set("user", textBox2.Text);
            ini.set("password", textBox1.Text);
            ini.set("dbname", comboBox3.Text);
            ini.save();
            this.Close();
        }
        //Close
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //DataTable da = new DataTable();
            ////try
            ////{
            //string connstr = "server=" + textBox3.Text + ";Database=master;Uid=" + textBox2.Text + ";Pwd=" + textBox1.Text + "";
            //da = _bll.GetDataTable(connstr);
            //if (da != null && da.Rows.Count > 0)
            //{
            //    comboBox3.DataSource = da;
            //    comboBox3.DisplayMember = "name";
            //}
        }
    }
}