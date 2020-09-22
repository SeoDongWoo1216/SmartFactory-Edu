using System;
using System.Windows.Forms;
namespace _20200819_006
{
    public partial class Form1 : Form
    {
        //private RadioButton checkedRB;
        private string gender;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string result = "국적 : ";
            
            for(var Count = 0; Count < groupBox1.Controls.Count; ++Count)        // Controls.Count로 배열처럼 요소 수를 가져올 수 있다.
            {
                // Controls는 그룹박스 내부 전부다를 뜻함
                RadioButton Temp = (RadioButton)groupBox1.Controls[Count]; // 그룹박스와 라디오 버튼을 형변환으로 일치시켜준다.
                if (Temp.Checked)   // 라디오버튼이 체크되면 발동하는 if문
                {
                    result += Temp.Text;  // 결과에 Temp가 가지고있는 Text값을 대입해준다.
                    break;  // 체크됬으니까 for문 종료
                }
            }

            result += "\n성별 : " + gender;
            MessageBox.Show(result);






            //string result = "국적 : ";
            //if (rbKorea.Checked)  // 대한민국이 체크됬을때
            //    result += "국적 : 대한민국\n";
            //else if (rbChina.Checked)  // 중국이 체크됬을때
            //    result += "국적 : 중국\n";
            //else if (rbCanada.Checked)  // 캐나다가 체크됬을때
            //    result += "국적 : 캐나다\n";
            //else if (rbOthers.Checked)  // 그 외에 가 체크됬을때 
            //    result += "국적 : 그 외의 국가\n";

            //if (checkedRB == rbMale)
            //    result += "성별 : 남성";
            //else if (checkedRB == rbFemale)
            //    result += "성별 : 여성";

            //MessageBox.Show(result, "결과");
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            //checkedRB = rbMale;
            gender = "남성";
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            //checkedRB = rbFemale;
            gender = "여성";
        }
    }
}
