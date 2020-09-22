using System;
using System.Data;
using MySql.Data.MySqlClient;
class Program
{
    static void Main(string[] args)
    {
        DataSet aDataSet = new DataSet();
        string Query = "SERVER=192.168.0.161;DATABASE=mydb;UID=root;PASSWORD=1234;";
            
        using (MySqlConnection aMySqlConnection = new MySqlConnection(Query))  // DB에 로그인 된 상태
        {
            Query = "SELECT * FROM tblRegister";
            MySqlDataAdapter aMySqlDataAdapter = new MySqlDataAdapter(Query, aMySqlConnection);
            aMySqlDataAdapter.Fill(aDataSet,"tblRegister");
        }
        DataRow aDataRow;
        aDataRow = aDataSet.Tables["tblRegister"].Rows[0];
        Console.WriteLine(aDataSet.Tables["tblRegister"].Rows.Count);
        string Temp = (string)aDataRow["name"];   // 마리아DB의 name을 Temp에 저장 
        // 왼쪽은 string, 오른쪽은 object이므로 string으로 캐스팅
        Console.WriteLine(Temp);
        Console.WriteLine(aDataRow["name"] + ":" + aDataRow["num2"]);

    }
}

