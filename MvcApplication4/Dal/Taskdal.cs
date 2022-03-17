using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace MvcApplication4.Dal
{
    public class Taskdal
    {
        public int insertperson(Models.Event events)
        {
            string strcon = ConfigurationManager.ConnectionStrings["testEntities1"].ConnectionString;
            MySqlConnection con = new MySqlConnection(strcon);
            try
            {
                string sql = "insert into insertuser(firstname,lastname,email,address,city,number)values('"+events.firstname+"','"+events.lastname+"','"+events.email+"','"+events.address+"','"+events.city+"','"+events.number+"')";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                int status = cmd.ExecuteNonQuery();
                if (status > 0)
                {
                    return status;
                }
                else
                {
                     return status;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return 0;
        }
        public List<Models.Event> getpersonList()
        {
            string strcon = ConfigurationManager.ConnectionStrings["testEntities1"].ConnectionString;
            MySqlConnection con = new MySqlConnection(strcon);
            List<Models.Event> person = new List<Models.Event>();
            try
            {

                con.Open();
                using (MySqlCommand cmd1 = new MySqlCommand("select id,firstname,lastname,email,address,city,number from insertuser", con))
                {
                    cmd1.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd1))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                            foreach (DataRow dr in dt.Rows)
                            {
                                Models.Event e1 = new Models.Event();
                                e1.id = Convert.ToInt32(dr[0].ToString());
                                e1.firstname = dr[1].ToString();
                                e1.lastname = dr[2].ToString();
                                e1.email = dr[3].ToString();
                                e1.address = dr[4].ToString();
                                e1.city = dr[5].ToString();
                                e1.number = Convert.ToInt32(dr[6].ToString());
                                person.Add(e1);
                            }
                        }
                    }
                }
                con.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        public Models.Event getpersonListByid(string id)
        {
            string strcon = ConfigurationManager.ConnectionStrings["testEntities1"].ConnectionString;
            MySqlConnection con = new MySqlConnection(strcon);
            List<Models.Event> person = new List<Models.Event>();
            Models.Event e1 = new Models.Event();
            try
            {
                con.Open();
                using (MySqlCommand cmd1 = new MySqlCommand("select id,firstname,lastname,email,address,city,number from insertuser where id='" + id + "'", con))
                {
                    cmd1.CommandType = CommandType.Text;

                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd1))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                            foreach (DataRow dr in dt.Rows)
                            {
                                //Models.Event e1 = new Models.Event();
                                e1.id = Convert.ToInt32(dr[0].ToString());
                                e1.firstname = dr[1].ToString();
                                e1.lastname = dr[2].ToString();
                                e1.email = dr[3].ToString();
                                e1.address = dr[4].ToString();
                                e1.city = dr[5].ToString();
                                e1.number = Convert.ToInt32(dr[6].ToString());
                                //person.Add(e1);
                            }
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return e1;
        }
        public int update(Models.Event events) 
        {
            string strcon = ConfigurationManager.ConnectionStrings["testEntities1"].ConnectionString;
            MySqlConnection con = new MySqlConnection(strcon);
            try
            {
                string sql = "update insertuser set firstname='"+events.firstname+"',lastname='"+events.lastname+"',email='"+events.email+"',address='"+events.address+"',city='"+events.city+"',number='"+events.number+"' where id='"+events.id+"' ";
                
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                int status = cmd.ExecuteNonQuery();
                if (status > 0)
                {
                    return status;
                }
                else
                {
                    return status;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return 0;
        }
        public int deleteperson(string id) 
        {
            string strcon = ConfigurationManager.ConnectionStrings["testEntities1"].ConnectionString;
            MySqlConnection con = new MySqlConnection(strcon);
            try
            {
                string sql = "delete from insertuser where id='"+id+"'";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                int status = cmd.ExecuteNonQuery();
                if (status > 0)
                {
                    return status;
                }
                else
                {
                    return status;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return 0;
        }
       
    }
}