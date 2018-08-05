namespace TCPIP客户端
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_receive = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.txt_State = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "监听端口";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(131, 33);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(133, 21);
            this.txt_IP.TabIndex = 2;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(131, 78);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(133, 21);
            this.txt_port.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_State);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(378, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器状态";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "接收数据";
            // 
            // txt_receive
            // 
            this.txt_receive.Location = new System.Drawing.Point(92, 172);
            this.txt_receive.Multiline = true;
            this.txt_receive.Name = "txt_receive";
            this.txt_receive.Size = new System.Drawing.Size(579, 130);
            this.txt_receive.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(11, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "发送信息";
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(92, 341);
            this.txt_send.Multiline = true;
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(579, 139);
            this.txt_send.TabIndex = 8;
            // 
            // btn_Listen
            // 
            this.btn_Listen.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_Listen.Location = new System.Drawing.Point(17, 502);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(89, 23);
            this.btn_Listen.TabIndex = 9;
            this.btn_Listen.Text = "开始监听";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_send.Location = new System.Drawing.Point(146, 502);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(89, 23);
            this.btn_send.TabIndex = 10;
            this.btn_send.Text = "发送消息";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_stop.Location = new System.Drawing.Point(286, 504);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(105, 23);
            this.btn_stop.TabIndex = 11;
            this.btn_stop.Text = "停止监听";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // txt_State
            // 
            this.txt_State.Location = new System.Drawing.Point(7, 20);
            this.txt_State.Multiline = true;
            this.txt_State.Name = "txt_State";
            this.txt_State.Size = new System.Drawing.Size(280, 101);
            this.txt_State.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 537);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.txt_send);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_receive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_State;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_receive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_stop;
    }
}

