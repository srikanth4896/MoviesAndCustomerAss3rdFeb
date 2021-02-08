using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace Customer
{
    class AssignCustomer
    {
        public int Cid { get; set; }
        public string CName { get; set; }
        public DateTime DOB { get; set; }
        public string City { get; set; }


        public static void GetDataByGetFieldValue()
        {
            Console.WriteLine("Data By using GetDataFieldValue");
            SqlConnection cn = null;
            SqlCommand cm = null;
            SqlDataReader dr = null;
            List<AssignCustomer> list;
            try
            {
                list = new List<AssignCustomer>();
                using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString()))
                {
                    using (cm = new SqlCommand("Select * from Customertab", cn))
                    {
                        cn.Open();
                        using (dr = cm.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                list.Add(new AssignCustomer
                                {
                                    Cid = dr.GetFieldValue<int>(dr.GetOrdinal("Custid")),
                                    CName = dr.GetFieldValue<string>(dr.GetOrdinal("CustName")),
                                    DOB = dr.GetFieldValue<DateTime>(dr.GetOrdinal("DOB")),
                                    City = dr.GetFieldValue<string>(dr.GetOrdinal("City"))
                                });
                            }
                        }
                    }

                }
                var a = list.GetEnumerator();
                while (a.MoveNext())
                {

                    Console.WriteLine($"{a.Current.Cid}\t{a.Current.CName}\t\t {a.Current.DOB}\t\t\t {a.Current.City}\t");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static void GetDataByGetMethodsOfDr()
        {
            Console.WriteLine("Data By using Get Methods");
            List<AssignCustomer> list = new List<AssignCustomer>();
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString()))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("select *from CustomerTab", cn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (dr.Read())
                        {
                            list.Add(new AssignCustomer
                            {
                                Cid = dr.GetInt32(dr.GetOrdinal("Custid")),
                                CName = dr.GetString(dr.GetOrdinal("CustName")),
                                DOB = dr.GetDateTime(dr.GetOrdinal("DOB")),
                                City = dr.GetString(dr.GetOrdinal("City"))
                            });
                        }
                    }
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Cid}\t{item.CName}\t\t{item.DOB}\t\t{item.City}");
            }


            Console.ReadLine();
        }
        public static void GetDataBySqlDataReader()
        {
            Console.WriteLine("By using StringBuilder");
            StringBuilder sb = new StringBuilder();
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString()))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("select *from CustomerTab", cn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (dr.Read())
                        {
                            sb.AppendLine($"CustId{dr[0].ToString()}");
                            sb.AppendLine($"CustName{dr[1].ToString()}");
                            sb.AppendLine($"DOB{dr[2].ToString()}");
                            sb.AppendLine($"City{dr[3].ToString()}");
                            sb.AppendLine();
                        }

                    }
                }
                var res = sb.ToString();
                Console.WriteLine(res);
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
           
            //AssignCustomer.GetDataByGetFieldValue();
            //AssignCustomer.GetDataByGetMethodsOfDr();
            AssignCustomer.GetDataBySqlDataReader();
            Console.ReadLine();
        }
    }
}