using System;

namespace 窗口1
{
    partial class UserControl1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button serialswitch;
        private System.Windows.Forms.ComboBox serialPort1; // 使用完整命名空间
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button singleread;
        private System.Windows.Forms.Button aotoread;
        private System.Windows.Forms.TextBox txtSensorInt;
        private System.Windows.Forms.TextBox txtSensorFloat;
        private System.Windows.Forms.TextBox txtTempInt;
        private System.Windows.Forms.TextBox txtTempFloat;
        private System.Windows.Forms.TextBox txtCurrentAddr;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cboBaudRate;


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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.serialswitch = new System.Windows.Forms.Button();
            this.serialPort1 = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.com = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aotoread = new System.Windows.Forms.Button();
            this.singleread = new System.Windows.Forms.Button();
            this.sensorID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.setbaud = new System.Windows.Forms.Button();
            this.cboBaudRate2 = new System.Windows.Forms.TextBox();
            this.setID = new System.Windows.Forms.Button();
            this.txtCurrentAddr = new System.Windows.Forms.TextBox();
            this.serchID = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.数据参数 = new System.Windows.Forms.GroupBox();
            this.txtTempFloat = new System.Windows.Forms.TextBox();
            this.txtTempInt = new System.Windows.Forms.TextBox();
            this.txtSensorFloat = new System.Windows.Forms.TextBox();
            this.txtSensorInt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
           
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.数据参数.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialswitch
            // 
            this.serialswitch.Location = new System.Drawing.Point(118, 212);
            this.serialswitch.Name = "serialswitch";
            this.serialswitch.Size = new System.Drawing.Size(126, 50);
            this.serialswitch.TabIndex = 0;
            this.serialswitch.Text = "串口开关";
            this.serialswitch.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.FormattingEnabled = true;
            this.serialPort1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.serialPort1.Location = new System.Drawing.Point(141, 62);
            this.serialPort1.Name = "serialPort1";
            this.serialPort1.Size = new System.Drawing.Size(140, 26);
            this.serialPort1.TabIndex = 1;
            this.serialPort1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboBaudRate.Location = new System.Drawing.Point(141, 94);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(140, 26);
            this.cboBaudRate.TabIndex = 2;
            this.cboBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox3.Location = new System.Drawing.Point(141, 126);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 26);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBox4.Location = new System.Drawing.Point(141, 190);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(140, 26);
            this.comboBox4.TabIndex = 4;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBox5.Location = new System.Drawing.Point(141, 158);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(140, 26);
            this.comboBox5.TabIndex = 5;
            // 
            // com
            // 
            this.com.AutoSize = true;
            this.com.Location = new System.Drawing.Point(52, 39);
            this.com.Name = "com";
            this.com.Size = new System.Drawing.Size(53, 18);
            this.com.TabIndex = 6;
            this.com.Text = "COM口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "传感器ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "数据位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "校验位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "停止位";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serialswitch);
            this.groupBox1.Controls.Add(this.com);
            this.groupBox1.Location = new System.Drawing.Point(30, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 288);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通讯参数";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aotoread);
            this.groupBox2.Controls.Add(this.singleread);
            this.groupBox2.Controls.Add(this.sensorID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(30, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 170);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据读取";
            // 
            // aotoread
            // 
            this.aotoread.Location = new System.Drawing.Point(158, 90);
            this.aotoread.Name = "aotoread";
            this.aotoread.Size = new System.Drawing.Size(102, 46);
            this.aotoread.TabIndex = 18;
            this.aotoread.Text = "自动读取";
            this.aotoread.UseVisualStyleBackColor = true;
            // 
            // singleread
            // 
            this.singleread.Location = new System.Drawing.Point(42, 90);
            this.singleread.Name = "singleread";
            this.singleread.Size = new System.Drawing.Size(102, 46);
            this.singleread.TabIndex = 19;
            this.singleread.Text = "单次读取";
            this.singleread.UseVisualStyleBackColor = true;
            this.singleread.Click += new System.EventHandler(this.singleread_Click);
            // 
            // sensorID
            // 
            this.sensorID.Location = new System.Drawing.Point(111, 56);
            this.sensorID.Name = "sensorID";
            this.sensorID.Size = new System.Drawing.Size(140, 28);
            this.sensorID.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.setbaud);
            this.groupBox3.Controls.Add(this.cboBaudRate2);
            this.groupBox3.Controls.Add(this.setID);
            this.groupBox3.Controls.Add(this.txtCurrentAddr);
            this.groupBox3.Controls.Add(this.serchID);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Location = new System.Drawing.Point(30, 510);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 238);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数设置";
            // 
            // setbaud
            // 
            this.setbaud.Location = new System.Drawing.Point(20, 152);
            this.setbaud.Name = "setbaud";
            this.setbaud.Size = new System.Drawing.Size(124, 34);
            this.setbaud.TabIndex = 20;
            this.setbaud.Text = "设置波特率";
            this.setbaud.UseVisualStyleBackColor = true;
            this.setbaud.Click += new System.EventHandler(this.button6_Click);
            // 
            // cboBaudRate2
            // 
            this.cboBaudRate2.Location = new System.Drawing.Point(150, 158);
            this.cboBaudRate2.Name = "cboBaudRate2";
            this.cboBaudRate2.Size = new System.Drawing.Size(121, 28);
            this.cboBaudRate2.TabIndex = 21;
            this.cboBaudRate2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // setID
            // 
            this.setID.Location = new System.Drawing.Point(20, 102);
            this.setID.Name = "setID";
            this.setID.Size = new System.Drawing.Size(124, 34);
            this.setID.TabIndex = 18;
            this.setID.Text = "设置ID";
            this.setID.UseVisualStyleBackColor = true;
            this.setID.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtCurrentAddr
            // 
            this.txtCurrentAddr.Location = new System.Drawing.Point(150, 106);
            this.txtCurrentAddr.Name = "txtCurrentAddr";
            this.txtCurrentAddr.Size = new System.Drawing.Size(121, 28);
            this.txtCurrentAddr.TabIndex = 19;
            this.txtCurrentAddr.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // serchID
            // 
            this.serchID.Location = new System.Drawing.Point(20, 52);
            this.serchID.Name = "serchID";
            this.serchID.Size = new System.Drawing.Size(124, 34);
            this.serchID.TabIndex = 17;
            this.serchID.Text = "搜索ID";
            this.serchID.UseVisualStyleBackColor = true;
            this.serchID.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(150, 57);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 28);
            this.txtAddress.TabIndex = 17;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // 数据参数
            // 
            this.数据参数.Controls.Add(this.txtTempFloat);
            this.数据参数.Controls.Add(this.txtTempInt);
            this.数据参数.Controls.Add(this.txtSensorFloat);
            this.数据参数.Controls.Add(this.txtSensorInt);
            this.数据参数.Controls.Add(this.label1);
            this.数据参数.Controls.Add(this.label7);
            this.数据参数.Controls.Add(this.label8);
            this.数据参数.Controls.Add(this.label9);
            this.数据参数.Location = new System.Drawing.Point(338, 27);
            this.数据参数.Name = "数据参数";
            this.数据参数.Size = new System.Drawing.Size(742, 722);
            this.数据参数.TabIndex = 17;
            this.数据参数.TabStop = false;
            this.数据参数.Text = "数据参数";
            // 
            // txtTempFloat
            // 
            this.txtTempFloat.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTempFloat.Location = new System.Drawing.Point(391, 575);
            this.txtTempFloat.Name = "txtTempFloat";
            this.txtTempFloat.Size = new System.Drawing.Size(249, 62);
            this.txtTempFloat.TabIndex = 25;
            // 
            // txtTempInt
            // 
            this.txtTempInt.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTempInt.Location = new System.Drawing.Point(391, 407);
            this.txtTempInt.Name = "txtTempInt";
            this.txtTempInt.Size = new System.Drawing.Size(249, 62);
            this.txtTempInt.TabIndex = 24;
            // 
            // txtSensorFloat
            // 
            this.txtSensorFloat.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSensorFloat.Location = new System.Drawing.Point(391, 239);
            this.txtSensorFloat.Name = "txtSensorFloat";
            this.txtSensorFloat.Size = new System.Drawing.Size(249, 62);
            this.txtSensorFloat.TabIndex = 23;
            // 
            // txtSensorInt
            // 
            this.txtSensorInt.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSensorInt.Location = new System.Drawing.Point(391, 73);
            this.txtSensorInt.Name = "txtSensorInt";
            this.txtSensorInt.Size = new System.Drawing.Size(249, 62);
            this.txtSensorInt.TabIndex = 22;
            this.txtSensorInt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(136, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "温度值(float)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(118, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 36);
            this.label7.TabIndex = 19;
            this.label7.Text = "温度值(unit32)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(100, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 36);
            this.label8.TabIndex = 20;
            this.label8.Text = "传感器值(float)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(82, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(303, 36);
            this.label9.TabIndex = 21;
            this.label9.Text = "传感器值(unit32)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.数据参数);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cboBaudRate);
            this.Controls.Add(this.serialPort1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1138, 802);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.数据参数.ResumeLayout(false);
            this.数据参数.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label com;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox sensorID;
        private System.Windows.Forms.Button setbaud;
        private System.Windows.Forms.TextBox cboBaudRate2;
        private System.Windows.Forms.Button setID;
        private System.Windows.Forms.Button serchID;
        private System.Windows.Forms.GroupBox 数据参数;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comF;
        private System.Windows.Forms.ComboBox comport;
  
    }
}
