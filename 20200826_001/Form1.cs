// 패킷을 캡처하는거는 C#에는 없다.
// 인터넷에서 패킷구조, 이더넷구조, TCP, IP 구조를 찾아서 이더넷헤더를 분석해서 만들었다.
// 1. 네트웤 레이어(프로토콜)에 대해서 알아야함. -> 인터넷에서 찾아서 정리한 후에 삽입
// 2. C#으로 짰기때문에 C#에대한 기술도 서술해야함
// 따라서 나는 네트웤을 알고 C#의 Form도 알고 있다는 뜻임.
// C#에 대한 설명은 using을 통해 설명하면된다. Linq, 캡처라이브러리(Cap), 제네릭를 사용. Cap은 다운받아서했기때문에 외부에서 받아서 사용할 수 있다는 뜻
// PPT 형태로 제출
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SharpPcap;
using System.Net;

namespace _20200826_001
{
    public partial class Form1 : Form
    {
        // 변수 선언
        int XMargin = 10;    // 가로
        int XSize = 120;     // Label 가로크기
        int XInteval = 15;   // Label 사이 가로크기

        int YMargin = 15;    // 세로크기
        int YSize = 20;     // Label 세로크기
        int YInteval = 10;   // Label 사이 세로크기
        List<FactoLabel> aFactoLabel = new List<FactoLabel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        List<string> NicName = new List<string>();
        foreach (ICaptureDevice Temp in CaptureDeviceList.Instance)
        {
            string[] arrTemp = Temp.ToString().Split('\n');
            NicName.Add(arrTemp[1].Substring("FriendlyName: ".Length));
        }

        for (int iTemp = 0; iTemp < NicName.Count; ++iTemp)    // 캐패시터는 총 용량이고 Count는 개수
        {
            Button aButton = new Button();
            aButton.Text = NicName[iTemp];  // 화면에 나타나는 UI이름
            aButton.Name = "Facto" + iTemp; // 버튼 자체의 이름(변수이름처럼) //버튼 이름이 Facto0, Facto1, Facto2 가 됨
            aButton.Location = new System.Drawing.Point(30, 30 * iTemp); // 버튼의 위치를 지정(Point는 클래스임) (가로, 세로)
            aButton.Click += new EventHandler(Facto_Click); 
            Controls.Add(aButton); // 버튼 객체만 만들고 폼자체에 띄우는 거를 작성
        }
        (sender as Button).Enabled = false; // 버튼을 클릭하면 다시 클릭 못하게 해주는 구문
        }


        private void Print_TCP(byte[] Data)
        {
           

            ////////////데이터입력/////////////////////////////////////////////////////////////
            //그룹박스만 정해주고 데이터를 패킷의 이름과 값으로 대입해주기
            

            aFactoLabel.Add(new FactoLabel() { Name = "4L Protocol", Value = "" });
            int Port1 = BitConverter.ToUInt16(Data.Skip<byte>(34).Take(2).Reverse().ToArray(), 0);
            int Port2 = BitConverter.ToUInt16(Data.Skip<byte>(34).Take(2).Reverse().ToArray(), 0);
            Port1 = Port1 < 1024 ? Port1 : 0;
            Port2 = Port2 < 1024 ? Port1 : 0;
            Port1 = (Port1 < Port2) ? Port1 : Port2; // 2가 크면 포트1의 갖고, 2가 작으면 2
            
            switch (Port1)
            {
                case 7:
                    aFactoLabel[0].Value = "ECHO";  // 제일 작은값이 7이면 ECHO 출력
                    break;
                case 13:
                    aFactoLabel[0].Value = "DAYTIME";  
                    break;
                case 20:
                    aFactoLabel[0].Value = "FTP : Data";
                    break;
                case 21:
                    aFactoLabel[0].Value = "FTP : Control";
                    break;
                case 22:
                    aFactoLabel[0].Value = "Secure SHell";
                    break;
                case 23:
                    aFactoLabel[0].Value = "Telnet Protocol";
                    break;
                case 25:
                    aFactoLabel[0].Value = "SMTP";
                    break;
                case 37:
                    aFactoLabel[0].Value = "TIME Protocol";
                    break;
                case 53:
                    aFactoLabel[0].Value = "DNS";
                    break;
                case 80:
                    aFactoLabel[0].Value = "HTTP";
                    break;
                case 443:
                    aFactoLabel[0].Value = "HTTPS";
                    break;

                default:
                    aFactoLabel[0].Value = "Not Support";
                    break;
            }

            

            UInt32 iNum = BitConverter.ToUInt16(Data.Skip<byte>(34).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Source Port", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt16(Data.Skip<byte>(36).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Destination Port", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt32(Data.Skip<byte>(38).Take(4).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Sequence Number", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt32(Data.Skip<byte>(42).Take(4).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Ack Number", Value = iNum.ToString() });

            iNum = (UInt32)((Data[46] >> 4) * 4);
            aFactoLabel.Add(new FactoLabel() { Name = "Offset", Value = iNum.ToString() });

            iNum = Data[47];
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Urgent", Value = (0 != (iNum & 1 << 5)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Ack", Value = (0 != (iNum & 1 << 4)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Push", Value = (0 != (iNum & 1 << 3)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Res", Value = (0 != (iNum & 1 << 2)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Syn", Value = (0 != (iNum & 1 << 1)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Fin", Value = (0 != (iNum & 1 << 0)).ToString() });

            iNum = BitConverter.ToUInt16(Data.Skip<byte>(48).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Windows Size", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt16(Data.Skip<byte>(50).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Checksum", Value = string.Format("0x{0:X4}", iNum) });

            iNum = BitConverter.ToUInt16(Data.Skip<byte>(52).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Urgent Pointer", Value = string.Format("0x{0:X4}", iNum) });

            ///////////그룹박스 설정///////////////////////////////////////////////////////////
            GroupBox aGroupBox = new GroupBox();
            aGroupBox.Location = new Point(380, 17);
            aGroupBox.Name = "GroupTCP";
            aGroupBox.Size = new Size(XMargin * 2 + XSize * 2 + XInteval, (YInteval + YSize) * aFactoLabel.Count + YMargin);
            aGroupBox.Text = "TCP Layer";


            ///////////라벨 설정/////////////////////////////////////////////////////////////
            for (int Count = 0; Count < aFactoLabel.Count; ++Count)
            {
                Label aLabel = new Label();
                aLabel.Name = "*****";
                aLabel.Text = aFactoLabel[Count].Name;
                aLabel.Location = new Point(XMargin, (YSize + YInteval) * Count + YMargin);
                aLabel.Size = new Size(XSize, YSize);
                aLabel.BorderStyle = BorderStyle.FixedSingle;
                aLabel.TextAlign = ContentAlignment.MiddleCenter;
                aGroupBox.Controls.Add(aLabel);

                aLabel = new Label();
                aLabel.Name = "******!!!!!!";
                aLabel.Text = aFactoLabel[Count].Value;
                aLabel.Location = new Point(XMargin + XSize + XInteval, (YSize + YInteval) * Count + YMargin);
                aLabel.Size = new Size(XSize, YSize);
                aLabel.BorderStyle = BorderStyle.FixedSingle;
                aLabel.TextAlign = ContentAlignment.MiddleCenter;
                aGroupBox.Controls.Add(aLabel);
            }

            //그룹박스 출력
            Controls.Add(aGroupBox);
        }




            private void Print_MAC(byte[] EtherData)
             {
            string data1 = "";   // Destination Mac
            for (int iTemp = 0; iTemp < 6; ++iTemp)
            {
                data1 += string.Format("{0:X2} ", EtherData[iTemp]);
            }

            string data2 = "";
            for (int iTemp = 6; iTemp < 12; ++iTemp)
            {
                data2 += string.Format("{0:X2} ", EtherData[iTemp]);
            }

            // 첫번째 줄 라벨
            Label aLabel = new Label();
            aLabel.Name = "LabelDMAC";
            aLabel.Text = "Destination MAC";
            aLabel.Location = new Point(30, 30);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "LabelDMACData";
            aLabel.Text = "Source MAC";
            aLabel.Location = new Point(30, 60);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);


            // 두번째줄 라벨
            aLabel = new Label();
            aLabel.Name = "LabelSMAC";
            aLabel.Text = data1;
            aLabel.Location = new Point(160, 30);
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "LabelSMACData";
            aLabel.Text = data2;
            aLabel.Location = new Point(160, 60);
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);


            // 3번째줄 라벨 ARP? 출력
            aLabel = new Label();
            aLabel.Name = "L2 Protocol";
            aLabel.Text = "Next Protocol";
            aLabel.Location = new Point(30, 90);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "LabelProtoData";
            int iNum = BitConverter.ToInt16(EtherData.Skip<byte>(12)   // EtherData의 12번째 데이터값 불러올껀데
                                   .Take(2)                // 12번째부터 2개를 선택하고(Take)
                                   .Reverse()              // 그걸 뒤집어주고(Reverse)
                                   .ToArray(), 0);         //문자형태로바꿔라(ToArray), 처음의 반환을 시작해라 (,0)
            switch (iNum)
            {
                case 0x0800:
                    data1 = "IP";
                    break;
                case 0x0200:
                    data1 = "Xerox PUP";
                    break;
                case 0x0500:
                    data1 = "Sprite";
                    break;
                case 0x0806:
                    data1 = "Address resolution";
                    break;
                case 0x8035:
                    data1 = "Reverse ARP";
                    break;
                case 0x809B:
                    data1 = "AppleTalk protocol";
                    break;
                case 0x80F3:
                    data1 = "AppleTalk ARP";
                    break;
                case 0x8100:
                    data1 = "IEEE 802.1Q VLAN tagging";
                    break;
                case 0x8137:
                    data1 = "IPX";
                    break;
                case 0x86dd:
                    data1 = "IP protocol version 6";
                    break;
                case 0x9000:
                    data1 = "used to test interfaces";
                    break;
                default:
                    data1 = "Unknown";
                    break;
            }

            //aLabel.Text = iNum.ToString();  // int형태인 iNum을 ToString으로 반환해서 라벨에 출력
            aLabel.Text = data1;
            aLabel.Location = new Point(160, 90);
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            GroupBox aGroupBox = new GroupBox();
            aGroupBox.Location = new Point(30, 20);
            aGroupBox.Name = "GroupMAC";
            aGroupBox.Size = new Size(XMargin * 2 + XSize * 2 + XInteval, (YInteval + YSize) * aFactoLabel.Count + YMargin);
            aGroupBox.Text = "MAC Layer";

        }

        private int Del_Button_Device(object sender)
        {
            int DeviceNum = Convert.ToInt32((sender as Button).Name.Substring("Facto".Length));
            CaptureDeviceList.Instance[DeviceNum].Open(DeviceMode.Normal, 0);
            // Open()의 두번째인자가 read_timeout인데, 0이되면 nonblocking이된다.
            // 한쪽만 도청하는거를 노말모드, 프로미스코스모드(난장판모드)는 가리지않는다.

            for (int iTemp = 0; iTemp < CaptureDeviceList.Instance.Count; ++iTemp)
            {
                foreach (Control Temp in Controls)
                {
                    if ("Facto" + iTemp == Temp.Name)
                    {
                        Controls.Remove(Temp);
                    }
                }
            }
            return DeviceNum;
        }

        private void Print_IP(byte[] IPData)
        {
            //IP 왼쪽 라벨
            Label aLabel = new Label();
            aLabel = new Label();
            aLabel.Name = "LabelIPV";
            aLabel.Text = "IP Version";
            aLabel.Location = new Point(30, 150);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "LabelIPHL";
            aLabel.Text = "IP Head Legnth";
            aLabel.Location = new Point(30, 180);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "LabelIPTOS";
            aLabel.Text = "IP TOS";
            aLabel.Location = new Point(30, 210);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "LabelIP_TL";
            aLabel.Text = "IP Total Length";
            aLabel.Location = new Point(30, 240);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "LabelIP_ID";
            aLabel.Text = "IP IDentification";
            aLabel.Location = new Point(30, 270);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "LabelFD";
            aLabel.Text = "Fragment DF";
            aLabel.Location = new Point(30, 300);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "LabelFM";
            aLabel.Text = "Fragment MF";
            aLabel.Location = new Point(30, 320);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "LabeIPFOs";
            aLabel.Text = "Fragment Offset";
            aLabel.Location = new Point(30, 340);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "Label_IP_TTL";
            aLabel.Text = "Time To Live";
            aLabel.Location = new Point(30, 370);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "LabelPROTO";
            aLabel.Text = "L3 Protocol";
            aLabel.Location = new Point(30, 400);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);


            aLabel = new Label();
            aLabel.Name = "Label_IP_HCs";
            aLabel.Text = "Header Checksum";
            aLabel.Location = new Point(30, 430);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "Label_IP_HCs";
            aLabel.Text = "Source IP";
            aLabel.Location = new Point(30, 460);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "Label_IP_HCs";
            aLabel.Text = "Destination IP";
            aLabel.Location = new Point(30, 490);
            aLabel.Size = new Size(120, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            /////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////

            byte byteTemp = IPData[14];

            // IP 오른쪽 라벨
            aLabel = new Label();
            aLabel.Name = "IPVData"; 
            aLabel.Text = "IPv" + (byteTemp >> 4).ToString();  // 비트연산자로 4칸 왼쪽 옮겨준다
            aLabel.Location = new Point(160, 150);   
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();   
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = ((byteTemp & 0x0F)*4).ToString() + " Bytes";
            aLabel.Name = "LabelIP_HL_Data";
            aLabel.Location = new Point(160, 180); 
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            byteTemp = IPData[15];   // 14 다음이므로 15번부터 시작

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = string.Format("0x{0:X2}", byteTemp);
            aLabel.Name = "LabelIP_TOS_Data";
            aLabel.Location = new Point(160, 210);
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            int iNum = BitConverter.ToInt16(IPData.Skip<byte>(16)   // IPData의 16번째 데이터값 불러올껀데
                                  .Take(2)                // 12번째부터 2개를 선택하고(Take)
                                  .Reverse()              // 그걸 뒤집어주고(Reverse)
                                  .ToArray(), 0);         //문자형태로바꿔라(ToArray), 처음의 반환을 시작해라 (,0)

            aLabel = new Label();
            aLabel.Name = "LabelIP_TL";
            aLabel.Text = iNum.ToString() + " Bytes";
            aLabel.Location = new Point(160, 240);
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);


            iNum = BitConverter.ToUInt16(IPData.Skip<byte>(18)   // IPID의 18번째 데이터값 불러올껀데
                                  .Take(2)                // 12번째부터 2개를 선택하고(Take)
                                  .Reverse()              // 그걸 뒤집어주고(Reverse)
                                  .ToArray(), 0);         //문자형태로바꿔라(ToArray), 처음의 반환을 시작해라 (,0)

            aLabel = new Label();
            aLabel.Name = "Label_IP_ID_Data";
            aLabel.Text = iNum.ToString();
            aLabel.Location = new Point(160, 270);
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            iNum = BitConverter.ToUInt16(IPData.Skip<byte>(20).Take(2).Reverse().ToArray(), 0); // Take의 2는 2바이트이다.
            // 20번째부터 땡겨오기


            aLabel = new Label();
            aLabel.Name = "Label_IP_DF_Data";
            aLabel.Text = (0 != (iNum & (1 << 14))).ToString();   // 0하고 다른지 비교(0하고 다르면 1이라는뜻)
            // bool 값을 T/F 문자형태로 바꿔줌(False 같은게 출력됨)
            aLabel.Location = new Point(160, 300);
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "Label_IP_MF_Data";
            aLabel.Text = (0 != (iNum & (1 << 13))).ToString();
            aLabel.Location = new Point(160, 320);
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.Name = "Label_IP_Offset_Data";
            aLabel.Text = (iNum & 0x1FFF).ToString();
            aLabel.Location = new Point(160, 340);
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            byteTemp = IPData[22];

            aLabel = new Label();
            aLabel.Name = "Label_IP_TTL_Data";
            aLabel.Text = byteTemp.ToString();
            aLabel.Location = new Point(160, 370);
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            

            byteTemp = IPData[23];

            
            aLabel = new Label();
            aLabel.Name = "LabelPROTO_Data";
            switch (byteTemp)
            {
                case 0:
                    aLabel.Text = "IP";
                    break;
                case 1:
                    aLabel.Text = "ICMP";
                    break;
                case 2:
                    aLabel.Text = "IGMP";
                    break;
                case 4:
                    aLabel.Text = "IPIP";
                    break;
                case 6:
                    aLabel.Text = "TCP";
                    break;
                case 8:
                    aLabel.Text = "EGP";
                    break;
                case 12:
                    aLabel.Text = "PUP";
                    break;
                case 17:
                    aLabel.Text = "UDP";
                    break;
                case 22:
                    aLabel.Text = "IDP";
                    break;
                case 29:
                    aLabel.Text = "TP";
                    break;
                case 33:
                    aLabel.Text = "DCCP";
                    break;
                case 41:
                    aLabel.Text = "IPV6";
                    break;
                default:
                    aLabel.Text = "Unknown";
                    break;
            }
            aLabel.Location = new Point(160, 400);
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);


            iNum = BitConverter.ToUInt16(IPData.Skip<byte>(24).Take(2).Reverse().ToArray(), 0);


            aLabel = new Label();
            aLabel.Name = "Label_IP_HCS_Data";
            aLabel.Text = string.Format("0x{0:X4}", iNum);
            aLabel.Location = new Point(160, 430);
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);
             

            IPAddress aIPAddress = new IPAddress(IPData.Skip<byte>(26).Take(4).ToArray());


            aLabel = new Label();
            aLabel.Name = "Label_IP_SData";
            aLabel.Text = aIPAddress.ToString();
            aLabel.Location = new Point(160, 460);
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);

            
            aIPAddress = new IPAddress(IPData.Skip<byte>(30).Take(4).ToArray());

            aLabel = new Label();
            aLabel.Name = "Label_IP_DData";
            aLabel.Text = aIPAddress.ToString();
            aLabel.Location = new Point(160, 490);
            aLabel.Size = new Size(200, 20);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aLabel);


            GroupBox aGroupBox = new GroupBox();
            aGroupBox.Location = new Point(30, 140);
            aGroupBox.Name = "GroupIP";
            aGroupBox.Size = new Size(XMargin * 2 + XSize * 2 + XInteval, (YInteval + YSize) * aFactoLabel.Count + YMargin);
            aGroupBox.Text = "IP Layer";
        }

            //Facto 버튼이 생성됬을때 클릭하면 발생하는 이벤트 메서드
            private void Facto_Click(object sender, EventArgs e)  // object 객체는 버튼객체이고, sender에 정보가 저장되어있다.
        {
            //// 버튼의 Name을 추출해보자.
            // MessageBox.Show((sender as Button).Name.Substring("Facto".Length));
            //// as를 통해 형변환이 가능한지 알아보고, . 을 찍어서 뜨는 Name을 작성해서 Name을 추출할 수 있다.
            //// Substring을 통해 번호만 추출해줄 수 있다.(Facto만 빼고 추출하니까 번호만 추출되는것이다. 버튼1, 버튼2, 버튼3에서 버튼을 뺀것처럼)

            int DeviceNum = Del_Button_Device(sender);
            CaptureDeviceList.Instance[DeviceNum].Open(DeviceMode.Normal, 0);
            RawCapture aRawCapture = CaptureDeviceList.Instance[DeviceNum].GetNextPacket();  // 패킷을 건져올려준다.(GetNextPacket()은 RawCapture을 반환한다)
            // MessageBox.Show(aRawCapture.LinkLayerType.ToString());                                                                                 

            Print_MAC(aRawCapture.Data);     // 1계층 출력
            int iNum = BitConverter.ToInt16(aRawCapture.Data.Skip<byte>(12).Take(2).Reverse().ToArray(), 0);        
            if (iNum == 0x0800)  // IP 패킷일때 IP 출력
            {
                Print_IP(aRawCapture.Data);      // 2계층 출력
                Print_TCP(aRawCapture.Data);  // 3계층 출력
                if (6 == aRawCapture.Data[23]) // TCP 패킷일 때
                {
                //    Print_TCP(aRawCapture.Data);  // 3계층 출력
                }

            }



        }
    }
}