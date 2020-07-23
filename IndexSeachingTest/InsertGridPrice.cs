using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndexSeachingTest
{
    public partial class InsertGridPrice : Form
    {
        string strConnString = "Data Source=127.0.0.1;Initial Catalog=FactoryDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";
        string mode = "";
        public InsertGridPrice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReviewSort();
        }

        private void ReviewSort()
        {
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open();
                string strQuery = " Select Name, Size, Fabric, Division, FacLocation, Number " +
                                  " FROM FactorySampleTbl " +
                                  " order By Number DESC; ";
                //GrdPriceTbl.Sort.GrdPriceTbl();
            }
        }

        private void InsertGridPrice_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'factoryDBDataSet.FactorySampleTbl' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.factorySampleTblTableAdapter.Fill(this.factoryDBDataSet.FactorySampleTbl);

        }
    }
}
