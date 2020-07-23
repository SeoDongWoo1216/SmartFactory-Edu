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

namespace EmptyCombox
{
    public partial class Form1 : Form
    {
        string strConnString = "Data Source=172.30.1.36;Initial Catalog=ConDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";
        string mode = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMatching_Click(object sender, EventArgs e)
        {
            MatchingFactory();
        }

        private void MatchingFactory()
        {
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open();
                string strQuery = "SELECT FacName,Size,Fabric,Division,Price,FacLocation,Grade " +
                                  "FROM dbo.Sample1" +
                                  "WHERE Division = @Division" +
                                  "AND Fabric = @Fabric ";

                
                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.NVarChar, 10);
                parmDivision.Value = CboDivision.SelectedItem;

                SqlParameter parmFabric = new SqlParameter("@Fabric", SqlDbType.NVarChar, 10);
                parmFabric.Value = CboFabric.SelectedItem;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();

                dataAdapter.SelectCommand.Parameters.Add(parmDivision);
                dataAdapter.SelectCommand.Parameters.Add(parmFabric);

                dataAdapter.Fill(ds, "Sample1");

                GrdFactorytbl.DataSource = ds;
                GrdFactorytbl.DataMember = "Sample1";
            }
        }
    }
}
