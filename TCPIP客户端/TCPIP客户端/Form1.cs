using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPIP客户端
{
    public partial class Form1 : Form
    {
        private Socket socket;
        private Socket newsocket;
        private Thread thread;


        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 开始监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Listen_Click(object sender, EventArgs e)
        {
            this.btn_Listen.Enabled = false;
            IPAddress ip = IPAddress.Parse(this.txt_IP.Text.Trim());
            IPEndPoint server = new IPEndPoint(ip,Convert.ToInt32(txt_port.Text));
            socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            socket.Bind(server);
            socket.Listen(10);
            newsocket = socket.Accept();
            this.txt_State.Text += "与客户端" + newsocket.RemoteEndPoint.ToString() + "建立连接\n";
            thread = new Thread(new ThreadStart(AcceptMessage));
            thread.Start();
        }

        /// <summary>
        /// 开启新的线程，用于接收数据
        /// </summary>
        private void AcceptMessage()
        {
            while (true)
            {
                try
                {
                    byte[] message = new byte[1024];
                    int size = newsocket.Receive(message);
                    if (size == 0)
                    {
                        break;
                    }
                    txt_receive.Text += System.Text.Encoding.Unicode.GetString(message) + "\n";
                }
                catch (Exception ex)
                {

                    this.BeginInvoke(new Action(() =>
                    {
                        txt_State.Text += "与客户断开连接\n";
                    }                    
                    ));
                    break;
                }
            }
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e)
        {
            string str = this.txt_send.Text;
            byte[] sendbytes = System.Text.Encoding.Unicode.GetBytes(str);
            try
            {
                newsocket.Send(sendbytes,sendbytes.Length,SocketFlags.None);
                this.txt_send.Text = "";
            }
            catch 
            {
                MessageBox.Show("无法发送！！","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 停止监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_Click(object sender, EventArgs e)
        {
            this.btn_Listen.Enabled = true;
            try
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                if (newsocket.Connected)
                {
                    newsocket.Close();
                    thread.Abort();
                }
            }
            catch 
            {
                MessageBox.Show("监听尚未开始，关闭无效！！","消息提示",MessageBoxButtons.OK,MessageBoxIcon.Error);              
            }
        }

        /// <summary>
        /// 窗口关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                if (newsocket.Connected)
                {
                    newsocket.Close();
                    thread.Abort();
                }
            }
            catch
            {
            }
        }
    }
}
