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

namespace FactorySample
{
    public partial class FactorySample : Form
    {
        string strConnString = "Data Source=127.0.0.1;Initial Catalog=FactoryDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";
        string mode = "";
        public FactorySample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatchingFactory();
            ShowmetheMoney();
        }

        private void ShowmetheMoney()
        {
            int Price = 0;

            int a = 0;
            if ("면" == CboFabric.SelectedItem.ToString())
            {
                a = 100;

            }
            else if ("린넨" == CboFabric.SelectedItem.ToString())
            {
                a = 200;
            }
            else
            {
                a = 300;
            }


            int b = 0;
            if ("상의" == CboDivision.SelectedItem.ToString())
            {
                b = 500;
            }
            else if ("하의" == CboDivision.SelectedItem.ToString())
            {
                b = 600;
            }
            else
            {
                b = 700;
            }

            int c = a + b;

            int d;
            if ("100" == CboCount.SelectedItem.ToString())
            {
                d = 100;
            }
            else if ("200" == CboCount.SelectedItem.ToString())
            {
                d = 200;
            }
            else
            {
                d = 300;
            }

            Price = c * d;
            TxtYourPrice.Text = Price.ToString("#,###");
        }

        private void MatchingFactory()
        {
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open();
                string strQuery = "SELECT Name,Size,Fabric,Division,FacLocation " +
                                  "FROM dbo.FactorySampleTbl " +
                                  " WHERE Size = @Size " +
                                  " AND Fabric = @Fabric " +
                                  " AND Division = @Division " +
                                  " AND FacLocation = @FacLocation ";
 
                SqlParameter parmSize = new SqlParameter("@Size", SqlDbType.Int);
                parmSize.Value = CboSize.SelectedItem;

                SqlParameter parmFabric = new SqlParameter("@Fabric", SqlDbType.NChar, 10);
                parmFabric.Value = CboFabric.SelectedItem;

                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.NChar, 10);
                parmDivision.Value = CboDivision.SelectedItem;

                SqlParameter parmFacLocation = new SqlParameter("@FacLocation", SqlDbType.NChar, 10);
                parmFacLocation.Value = CboFacLocation.SelectedItem;


                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();

                dataAdapter.SelectCommand.Parameters.Add(parmSize);
                dataAdapter.SelectCommand.Parameters.Add(parmFabric);
                dataAdapter.SelectCommand.Parameters.Add(parmDivision);
                dataAdapter.SelectCommand.Parameters.Add(parmFacLocation);

                dataAdapter.Fill(ds, "FactorySampleTbl");

                GrdFactorytbl.DataSource = ds;
                GrdFactorytbl.DataMember = "FactorySampleTbl";

                MessageBox.Show(GrdFactorytbl.Rows.Count.ToString() + "개의 공장이 매칭되었습니다");

                
            }
        }
    }
}
