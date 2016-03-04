using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

using Gma.QrCodeNet.Encoding;
using System.Text.RegularExpressions;

using System.Management;

namespace QRcode
{
    public partial class Form1 : Form
    {
        static SerialClass sc = new SerialClass();
        int printOffset = 0;

        static void sc_DataReceived(object sender, SerialDataReceivedEventArgs e, byte[] bits)
        {
            Console.WriteLine(Encoding.Default.GetString(bits));
        }

        public static bool IsNumAndEnCh(string input)
        {
            string pattern = @"^[A-Za-z0-9]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }

        /// <summary>
        /// 枚举win32 api
        /// </summary>
        public enum HardwareEnum
        {
            // 硬件
            Win32_Processor, // CPU 处理器
            Win32_PhysicalMemory, // 物理内存条
            Win32_Keyboard, // 键盘
            Win32_PointingDevice, // 点输入设备，包括鼠标。
            Win32_FloppyDrive, // 软盘驱动器
            Win32_DiskDrive, // 硬盘驱动器
            Win32_CDROMDrive, // 光盘驱动器
            Win32_BaseBoard, // 主板
            Win32_BIOS, // BIOS 芯片
            Win32_ParallelPort, // 并口
            Win32_SerialPort, // 串口
            Win32_SerialPortConfiguration, // 串口配置
            Win32_SoundDevice, // 多媒体设置，一般指声卡。
            Win32_SystemSlot, // 主板插槽 (ISA & PCI & AGP)
            Win32_USBController, // USB 控制器
            Win32_NetworkAdapter, // 网络适配器
            Win32_NetworkAdapterConfiguration, // 网络适配器设置
            Win32_Printer, // 打印机
            Win32_PrinterConfiguration, // 打印机设置
            Win32_PrintJob, // 打印机任务
            Win32_TCPIPPrinterPort, // 打印机端口
            Win32_POTSModem, // MODEM
            Win32_POTSModemToSerialPort, // MODEM 端口
            Win32_DesktopMonitor, // 显示器
            Win32_DisplayConfiguration, // 显卡
            Win32_DisplayControllerConfiguration, // 显卡设置
            Win32_VideoController, // 显卡细节。
            Win32_VideoSettings, // 显卡支持的显示模式。

            // 操作系统
            Win32_TimeZone, // 时区
            Win32_SystemDriver, // 驱动程序
            Win32_DiskPartition, // 磁盘分区
            Win32_LogicalDisk, // 逻辑磁盘
            Win32_LogicalDiskToPartition, // 逻辑磁盘所在分区及始末位置。
            Win32_LogicalMemoryConfiguration, // 逻辑内存配置
            Win32_PageFile, // 系统页文件信息
            Win32_PageFileSetting, // 页文件设置
            Win32_BootConfiguration, // 系统启动配置
            Win32_ComputerSystem, // 计算机信息简要
            Win32_OperatingSystem, // 操作系统信息
            Win32_StartupCommand, // 系统自动启动程序
            Win32_Service, // 系统安装的服务
            Win32_Group, // 系统管理组
            Win32_GroupUser, // 系统组帐号
            Win32_UserAccount, // 用户帐号
            Win32_Process, // 系统进程
            Win32_Thread, // 系统线程
            Win32_Share, // 共享
            Win32_NetworkClient, // 已安装的网络客户端
            Win32_NetworkProtocol, // 已安装的网络协议
            Win32_PnPEntity,//all device
        }
        /// <summary>
        /// WMI取硬件信息
        /// </summary>
        /// <param name="hardType"></param>
        /// <param name="propKey"></param>
        /// <returns></returns>
        public static string[] MulGetHardwareInfo(HardwareEnum hardType, string propKey)
        {

            List<string> strs = new List<string>();
            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + hardType))
                {
                    var hardInfos = searcher.Get();
                    foreach (var hardInfo in hardInfos)
                    {
                        if (hardInfo.Properties[propKey].Value != null) {
                            if (hardInfo.Properties[propKey].Value.ToString().Contains("COM"))
                            {
                                strs.Add(hardInfo.Properties[propKey].Value.ToString());
                            }
                        }
                        

                    }
                    searcher.Dispose();
                }
                return strs.ToArray();
            }
            catch
            {
                return null;
            }
            finally
            { strs = null; }
        }
        //通过WMI获取COM端口
        string[] ss = MulGetHardwareInfo(HardwareEnum.Win32_PnPEntity, "Name");

        public Form1()
        {
            InitializeComponent();
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custum", Convert.ToInt32(textBox_width.Text) + printOffset, Convert.ToInt32(textBox_height.Text) + printOffset);
            PrintController printController = new StandardPrintController();
            printDocument.PrintController = printController; 
            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(OnPrintPage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {                       
            //string[] PortName = System.IO.Ports.SerialPort.GetPortNames();
            comboBox.Items.AddRange(ss);
                       
        }

        public static string ToHexString(byte[] bytes) // 0xae00cf => "AE00CF "
        {
            string hexString = string.Empty;

            if (bytes != null)
            {

                StringBuilder strB = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    strB.Append(bytes[i].ToString("X2"));
                }

                hexString = strB.ToString();

            } return hexString;

        }

        //串口接收函数定义
        public string recData(SerialPort x)
        {
            try
            {
                char[] buf = new char[21];
                x.Read(buf,0,20);

                //string z = ToHexString(buf);

                //string z = BitConverter.ToString(buf).Replace("-", string.Empty);

                string z = new string(buf);
                
                label_data.Text = z;

                return (z);
            }
            catch (Exception ex)
            {
                MessageBox.Show("接收失败！\n" + ex.Data,"系统提示");
                return "-1";
            }
        }
        // 0 o O O
        //串口发送函数定义
        public void sendData(SerialPort x, string data)
        {
            try
            {
                x.Write(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("发送失败！\n" + ex.Data, "系统提示");
            }
        }

        //串口定义
        public void serialPortConfig(SerialPort sp)
        {
            //波特率
            sp.BaudRate = int.Parse("9600");
            //数据位
            sp.DataBits = int.Parse("8");
            //DTR位
            sp.DtrEnable = false;
            //RTS位
            sp.RtsEnable = false;
            //停止位
            sp.StopBits = (System.IO.Ports.StopBits)int.Parse("1");
            //丢弃空字节传输
            sp.DiscardNull = true;
            //读取延时
            sp.ReadTimeout = 500;
            //写入延时
            sp.WriteTimeout = 500;
            //打开串口
            //serialPort.Open();
        }

        private void button_serial_Click(object sender, EventArgs e)
        {
            //string[] PortName = System.IO.Ports.SerialPort.GetPortNames();
            
            System.IO.Ports.SerialPort curr_Port;
            //MessageBox.Show(comboBox.SelectedIndex.ToString());
            if (comboBox.SelectedIndex == (-1)) {
                MessageBox.Show("请选择串口设备！", "系统提示");
                return;
            }
            string temp = ss[comboBox.SelectedIndex];
            temp = temp.Substring(temp.IndexOf("COM"), 4);
            curr_Port = new System.IO.Ports.SerialPort(temp);

            //if (curr_Port.PortName == "COM1") continue;
            serialPortConfig(curr_Port);
            try
            {
                curr_Port.Open();
            }
            catch (Exception ex) {
                MessageBox.Show("端口打开失败！\n" + ex.Data, "系统提示");
            }
            if (curr_Port.IsOpen)
            {
                label_debug.Text = curr_Port.PortName;
                
                button_serial.BackColor = Color.Green;
                if (textBox_atcmd.Text == "") {
                    MessageBox.Show("请输入AT指令！","系统提示");
                }
                sendData(curr_Port,textBox_atcmd.Text);
                System.Threading.Thread.Sleep(50);
                string data = recData(curr_Port);
                if (data != "")
                {
                    int start = data.IndexOf(':');
                    string _data = data.Substring(start+1);
                    if (_data.Length == 13 )
                    {
                        textBox_qrcode.Text = _data;
                    }
                    else {
                        MessageBox.Show("蓝牙MAC地址错误！", "系统提示");
                    }
                    
                    //MessageBox.Show(_data, "系统提示");
                }
                else
                {
                    MessageBox.Show("无数据返回！", "系统提示");
                    //MessageBox.Show(curr_Port.ReadTimeout.ToString(), "系统提示");
                }                    
            }
            button_serial.BackColor = Color.Red;
            curr_Port.Close();
            

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            pictureBox.Image = qrCodeImgControl.Image;
        
        }

        private void button_print_Click(object sender, EventArgs e)
        {

            if (textBox_qrcode.Text == "")
            {
                MessageBox.Show("无打印内容！", "系统提示");
                return;
            }

            try
            {
                //3、調用PrintDocument.Print()方法
                printDocument.Print();
            }
            catch (InvalidPrinterException ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void OnPrintPage(object sender, PrintPageEventArgs e)
        {
            if (textBox_qrcode.Text=="") return;
            
            Font drawFont = new Font("Arial", trackBar.Value > 0
                ?(float)(4.0 * (trackBar.Value / 10.0F)):0.1F);            

            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Point pImage = new Point(Convert.ToInt32(textBox_width.Text) * trackBar_x.Value / trackBar_x.Maximum, 
                Convert.ToInt32(textBox_height.Text) * (trackBar_y.Maximum - trackBar_y.Value) / trackBar_y.Maximum);
            Point pString = new Point(Convert.ToInt32(textBox_width.Text) * trackBar_x.Value / trackBar_x.Maximum, 
                Convert.ToInt32(textBox_height.Text) * (trackBar_y.Maximum - trackBar_y.Value) / trackBar_y.Maximum + (int)(pictureBox.Image.Height * trackBar.Value / 10));
            Size s = new Size((int)(pictureBox.Image.Height * trackBar.Value / 10), (int)(pictureBox.Image.Height * trackBar.Value / 10 ));
            e.Graphics.DrawImage(
              pictureBox.Image,
              new Rectangle(pImage, s),
              new Rectangle(0, 0, pictureBox.Image.Width, pictureBox.Image.Height),
              GraphicsUnit.Pixel);
            if(checkBox.Checked) e.Graphics.DrawString(textBox_qrcode.Text, drawFont, drawBrush, pString);
        }

        private void textBox_qrcode_TextChanged(object sender, EventArgs e)
        {
            qrCodeImgControl.Text = textBox_qrcode.Text;
            printPreviewControl.Document = printDocument;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            printPreviewControl.Document = printDocument;
        }

        private void updatePageSize() {
            try
            {
                printDocument.PrintPage -= new System.Drawing.Printing.PrintPageEventHandler(OnPrintPage);
                printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custum", Convert.ToInt32(textBox_width.Text) + printOffset, Convert.ToInt32(textBox_height.Text) + printOffset);
                printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(OnPrintPage);
                printPreviewControl.Update();
                printPreviewControl.Refresh();
            }
            catch (Exception e) {
                MessageBox.Show("输入错误！\n" + e.Data, "系统提示");
            }
            //printPreviewControl.Document = printDocument;
        }

        private void textBox_width_TextChanged(object sender, EventArgs e)
        {
            updatePageSize();
        }

        private void textBox_height_TextChanged(object sender, EventArgs e)
        {
            updatePageSize();    
        }

        private void button_readme_Click(object sender, EventArgs e)
        {

            string readme = "●.修改完宽/高之后，需要点击一次串口才能更新预览.\n" +
                            "●.左上角的DEBUG标签做调试用，可无视.\n" +
                            "●.顶部中间的标签用于显示蓝牙返回的原始数据.\n" +
                            "●.右上角的二维码与打印预览区域的二维码相同.\n" +
                            "●.滑动滑条时可以先点击滑块，然后使用鼠标中键滚动.\n" +
                            "●.底部滑条为二维码缩放.\n";

            MessageBox.Show(readme, "系统提示");            
        }

        private void trackBar_x_Scroll(object sender, EventArgs e)
        {
            printPreviewControl.Document = printDocument;
        }

        private void trackBar_y_Scroll(object sender, EventArgs e)
        {
            printPreviewControl.Document = printDocument;
        }

        private void button_printSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.ShowDialog();
        }

    }
}
