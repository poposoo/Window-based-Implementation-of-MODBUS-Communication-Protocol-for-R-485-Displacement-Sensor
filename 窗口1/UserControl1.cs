using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Timers;
using System.Linq;
using System.Collections.Generic;

namespace 窗口1
{
    public partial class UserControl1 : UserControl
    {
        // 串口与定时器
        private SerialPort _serialPort = new SerialPort();
        private System.Timers.Timer _autoReadTimer = new System.Timers.Timer(1000);
        private CRC16ModBus crc = new CRC16ModBus();

        // UI控件（需在设计器中添加）
     

        public UserControl1()
        {
            InitializeComponent();
            InitializeSerialSettings();
            _autoReadTimer.Elapsed += AutoReadTimer_Elapsed;
        }

        //--------------------------
        // CRC校验类
        //--------------------------
        public class CRC16ModBus
        {
            private readonly byte[] auchCRCHi = {
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00,
                0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,0x00, 0xC1,
                0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,0x00, 0xC1, 0x81,
                0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,0x00, 0xC1, 0x81, 0x40,
                0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,0x00, 0xC1, 0x81, 0x40, 0x01,
                0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0,
                0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80,
                0x41, 0x00, 0xC1, 0x81, 0x40,0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
                0x01, 0xC0, 0x80, 0x41,0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00,
                0xC1, 0x81, 0x40,0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
                0x80, 0x41,0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80,
                0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80,
                0x41,0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
                0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,0x00,
                0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,0x00, 0xC1,
                0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81,
                0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,0x00, 0xC1, 0x81, 0x40,
                0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,0x00, 0xC1, 0x81, 0x40, 0x00,
                0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0,
                0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,0x00, 0xC1, 0x81, 0x40
            };

            private readonly byte[] auchCRCLo = {
                0x00, 0xC0, 0xC1, 0x01, 0xC3, 0x03, 0x02, 0xC2, 0xC6, 0x06, 0x07, 0xC7,
                0x05, 0xC5, 0xC4, 0x04, 0xCC, 0x0C, 0x0D, 0xCD, 0x0F, 0xCF, 0xCE, 0x0E,
                0x0A, 0xCA, 0xCB, 0x0B, 0xC9, 0x09, 0x08, 0xC8, 0xD8, 0x18, 0x19, 0xD9,
                0x1B, 0xDB, 0xDA, 0x1A, 0x1E, 0xDE, 0xDF, 0x1F, 0xDD, 0x1D, 0x1C, 0xDC,
                0x14, 0xD4, 0xD5, 0x15, 0xD7, 0x17, 0x16, 0xD6, 0xD2, 0x12, 0x13, 0xD3,
                0x11, 0xD1, 0xD0, 0x10, 0xF0, 0x30, 0x31, 0xF1, 0x33, 0xF3, 0xF2, 0x32,
                0x36, 0xF6, 0xF7, 0x37, 0xF5, 0x35, 0x34, 0xF4, 0x3C, 0xFC, 0xFD, 0x3D,
                0xFF, 0x3F, 0x3E, 0xFE, 0xFA, 0x3A, 0x3B, 0xFB, 0x39, 0xF9, 0xF8, 0x38,
                0x28, 0xE8, 0xE9, 0x29, 0xEB, 0x2B, 0x2A, 0xEA, 0xEE, 0x2E, 0x2F, 0xEF,
                0x2D, 0xED, 0xEC, 0x2C, 0xE4, 0x24, 0x25, 0xE5, 0x27, 0xE7, 0xE6, 0x26,
                0x22, 0xE2, 0xE3, 0x23, 0xE1, 0x21, 0x20, 0xE0, 0xA0, 0x60, 0x61, 0xA1,
                0x63, 0xA3, 0xA2, 0x62, 0x66, 0xA6, 0xA7, 0x67, 0xA5, 0x65, 0x64, 0xA4,
                0x6C, 0xAC, 0xAD, 0x6D, 0xAF, 0x6F, 0x6E, 0xAE, 0xAA, 0x6A, 0x6B, 0xAB,
                0x69, 0xA9, 0xA8, 0x68, 0x78, 0xB8, 0xB9, 0x79, 0xBB, 0x7B, 0x7A, 0xBA,
                0xBE, 0x7E, 0x7F, 0xBF, 0x7D, 0xBD, 0xBC, 0x7C, 0xB4, 0x74, 0x75, 0xB5,
                0x77, 0xB7, 0xB6, 0x76, 0x72, 0xB2, 0xB3, 0x73, 0xB1, 0x71, 0x70, 0xB0,
                0x50, 0x90, 0x91, 0x51, 0x93, 0x53, 0x52, 0x92, 0x96, 0x56, 0x57, 0x97,
                0x55, 0x95, 0x94, 0x54, 0x9C, 0x5C, 0x5D, 0x9D, 0x5F, 0x9F, 0x9E, 0x5E,
                0x5A, 0x9A, 0x9B, 0x5B, 0x99, 0x59, 0x58, 0x98, 0x88, 0x48, 0x49, 0x89,
                0x4B, 0x8B, 0x8A, 0x4A, 0x4E, 0x8E, 0x8F, 0x4F, 0x8D, 0x4D, 0x4C, 0x8C,
                0x44, 0x84, 0x85, 0x45, 0x87, 0x47, 0x46, 0x86, 0x82, 0x42, 0x43, 0x83,
                0x41, 0x81, 0x80, 0x40
            };

            public ushort Calculate(byte[] data)
            {
                byte uchCRCHi = 0xFF;
                byte uchCRCLo = 0xFF;
                foreach (byte b in data)
                {
                    int uIndex = uchCRCHi ^ b;
                    uchCRCHi = (byte)(uchCRCLo ^ auchCRCHi[uIndex]);
                    uchCRCLo = auchCRCLo[uIndex];
                }
                return (ushort)((uchCRCHi << 8) | uchCRCLo);
            }
        }

        //--------------------------
        // 初始化串口设置
        //--------------------------
        private void InitializeSerialSettings()
        {
            // 初始化COM端口列表
            string[] ports = SerialPort.GetPortNames();
            serialPort1.Items.AddRange(ports);
            if (ports.Length > 0) serialPort1.SelectedIndex = 0;

        }
        //--------------------------
        // 串口连接/断开
        //--------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen)
            {
                try
                {
                    if (string.IsNullOrEmpty(serialPort1.Text))
                    {
                        MessageBox.Show("请选择COM端口");
                        return;
                    }

                    _serialPort.PortName = serialPort1.Text;
                    _serialPort.BaudRate = int.Parse(cboBaudRate.Text);
                    _serialPort.DataBits = int.Parse(comboBox3.Text);
                    _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox5.Text);
                    _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox4.Text);

                    _serialPort.Open();
                    serialswitch.Text = "断开连接";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"连接失败: {ex.Message}");
                    _serialPort.Close();
                    serialswitch.Text = "连接串口";
                }
            }
            else
            {
                _serialPort.Close();
                serialswitch.Text = "连接串口";
            }
        }

        //--------------------------
        // 设备搜索
        //--------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen)
            {
                MessageBox.Show("请先连接串口");
                return;
            }

            byte[] scanCmd = { 0x00, 0x03, 0x00, 0x00, 0x00, 0x10 };
            ushort crcVal = crc.Calculate(scanCmd);
            byte[] fullCmd = new byte[scanCmd.Length + 2];
            Array.Copy(scanCmd, fullCmd, scanCmd.Length);
            fullCmd[scanCmd.Length] = (byte)(crcVal & 0xFF);
            fullCmd[scanCmd.Length + 1] = (byte)(crcVal >> 8);
            _serialPort.Write(fullCmd, 0, fullCmd.Length);
        }

        //--------------------------
        // 设置设备地址
        //--------------------------
        private void button5_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAddress.Text, out int newID) || newID < 1 || newID > 247)
            {
                MessageBox.Show("地址需为1-247的整数");
                return;
            }

            byte currentAddr = byte.Parse(txtCurrentAddr.Text);
            byte[] cmd = {
                currentAddr, 0x10, 0x00, 0x10, 0x00, 0x01, 0x02,
                (byte)(newID >> 8), (byte)newID
            };

            ushort crcVal = crc.Calculate(cmd);
            byte[] fullCmd = new byte[cmd.Length + 2];
            Array.Copy(cmd, fullCmd, cmd.Length);
            fullCmd[cmd.Length] = (byte)(crcVal & 0xFF);
            fullCmd[cmd.Length + 1] = (byte)(crcVal >> 8);
            _serialPort.Write(fullCmd, 0, fullCmd.Length);
        }

        //--------------------------
        //--------------------------
        // 自动读取定时器事件
        //--------------------------
        private void AutoReadTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            SendReadCommand();
        }

        //--------------------------
        // 单次读取传感器数据
        //--------------------------
        private void singleread_Click(object sender, EventArgs e)
        {
            SendReadCommand();
        }

        //--------------------------
        // 数据解析核心方法
        //--------------------------
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] buffer = new byte[_serialPort.BytesToRead];
                _serialPort.Read(buffer, 0, buffer.Length);

                // 校验数据长度（参考文档应答帧长度）
                if (buffer.Length < 35) return;

                // CRC校验
                int crcIndex = buffer.Length - 2;
                ushort receivedCRC = (ushort)((buffer[crcIndex + 1] << 8) | buffer[crcIndex]);
                byte[] dataForCrc = new byte[buffer.Length - 2];
                Array.Copy(buffer, 0, dataForCrc, 0, buffer.Length - 2);
                ushort calculatedCRC = crc.Calculate(dataForCrc);
                // 解析传感器值（int32高字节在前）
                int sensorInt = (buffer[3] << 24) | (buffer[4] << 16) | (buffer[5] << 8) | buffer[6];
                float sensorIntValue = sensorInt / 1000.0f;

                // 解析温度值（int32高字节在前）
                int tempInt = (buffer[7] << 24) | (buffer[8] << 16) | (buffer[9] << 8) | buffer[10];
                float tempIntValue = tempInt / 1000.0f;

                // 解析浮点数值（IEEE 754格式）
                byte[] floatBytes = new byte[4];
                Array.Copy(buffer, 15, floatBytes, 0, 4);
                if (BitConverter.IsLittleEndian) Array.Reverse(floatBytes);
                float sensorFloat = BitConverter.ToSingle(floatBytes, 0);

                Array.Copy(buffer, 19, floatBytes, 0, 4);
                if (BitConverter.IsLittleEndian) Array.Reverse(floatBytes);
                float tempFloat = BitConverter.ToSingle(floatBytes, 0);

                // 更新UI
                this.Invoke((MethodInvoker)delegate
                {
                    txtSensorInt.Text = sensorIntValue.ToString("F3");
                    txtSensorFloat.Text = sensorFloat.ToString("F6");
                    txtTempInt.Text = tempIntValue.ToString("F3");
                    txtTempFloat.Text = tempFloat.ToString("F6");
                });
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show($"数据解析错误: {ex.Message}");
                });
            }
        }

        //--------------------------
        // 发送读取命令
        //--------------------------
        private void SendReadCommand()
        {
            if (!_serialPort.IsOpen) return;

            try
            {
                byte currentAddr = byte.Parse(txtCurrentAddr.Text);
                byte[] cmd = { currentAddr, 0x03, 0x00, 0x00, 0x00, 0x10 };
                ushort crcVal = crc.Calculate(cmd);

                byte[] fullCmd = new byte[cmd.Length + 2];
                Array.Copy(cmd, fullCmd, cmd.Length);
                fullCmd[cmd.Length] = (byte)(crcVal & 0xFF);
                fullCmd[cmd.Length + 1] = (byte)(crcVal >> 8);

                _serialPort.Write(fullCmd, 0, fullCmd.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"读取失败: {ex.Message}");
            }
        }

        //--------------------------
        // 停止位选择事件处理
        //--------------------------
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen) return;

            try
            {
                _serialPort.StopBits = comboBox4.Text switch
                {
                    "1" => StopBits.One,
                    "1.5" => StopBits.OnePointFive,
                    "2" => StopBits.Two,
                    _ => StopBits.None
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"停止位设置失败: {ex.Message}");
            }
        }
        //--------------------------
        // ComboBox事件处理（空实现）
        //--------------------------
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 处理COM端口选择
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen)
            {
                MessageBox.Show("请先连接串口");
                return;
            }

            // 获取当前设备地址
            if (!byte.TryParse(txtCurrentAddr.Text, out byte currentAddr) || currentAddr < 1 || currentAddr > 247)
            {
                MessageBox.Show("当前设备地址无效（需1-247）");
                return;
            }

            // 将波特率转换为索引
            Dictionary<int, int> baudRateMap = new Dictionary<int, int>
    {
        { 1200, 0 }, { 2400, 1 }, { 4800, 2 }, { 9600, 3 },
        { 19200, 4 }, { 38400, 5 }, { 57600, 6 }, { 115200, 7 }
    };

            if (!int.TryParse(cboBaudRate2.Text, out int baudRate) || !baudRateMap.ContainsKey(baudRate))
            {
                MessageBox.Show("无效的波特率（支持：1200/2400/4800/9600/19200/38400/57600/115200）");
                return;
            }

            int baudIndex = baudRateMap[baudRate];

            try
            {
                // 构造写寄存器命令帧
                byte[] cmd =
                {
            currentAddr,             // 从机地址
            0x10,                    // 功能码10H
            0x00, 0x11,              // 寄存器地址0011（波特率）
            0x00, 0x01,              // 写入1个寄存器
            0x02,                    // 写入字节数（2字节）
            (byte)(baudIndex >> 8),  // 索引值高字节（实际为0，因为索引最大7）
            (byte)baudIndex          // 索引值低字节
        };

                // 计算CRC校验
                ushort crcVal = crc.Calculate(cmd);
                byte[] fullCmd = new byte[cmd.Length + 2];
                Array.Copy(cmd, fullCmd, cmd.Length);
                fullCmd[cmd.Length] = (byte)(crcVal & 0xFF);  // CRC低字节在前
                fullCmd[cmd.Length + 1] = (byte)(crcVal >> 8);

                // 发送命令
                _serialPort.Write(fullCmd, 0, fullCmd.Length);
                MessageBox.Show("波特率设置命令已发送");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"设置失败: {ex.Message}");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cboBaudRate.Text, out int baudRate))
            {

            }
        }

 

    }
}