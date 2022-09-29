using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace WebApplication11.Models
{
    public class UserService : IUser
    {
        SqlConnection conn;
        SqlCommand comm;
        public UserService()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
        }
        User IUser.AddUser(User user)
        {
            comm.CommandText = "insert into Users values('" + user.UserName + "','" + user.Password + "','" + user.Mobile + "','" + user.Status + "')";
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                return user;
            }
            return null;
        }

        void IUser.DeleteUser(string name)
        {
            comm.CommandText = "Delete from Users where UserName='" + name+"'";
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
            
        }

        List<User> IUser.GetAllUsers()
        {
            List<User> list = new List<User>();
            comm.CommandText = "select * from Users";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                

                string username = reader["UserName"].ToString();
                string password = reader["Password"].ToString();
                string mobile = reader["Mobile"].ToString();
                string status = reader["Status"].ToString();
                list.Add(new User(username,password,mobile, status));
            }
            conn.Close();
            return list;
        }

        User IUser.GetUserByUserName(string name)
        {
            User user = new User();
            comm.CommandText = "select * from Users where UserName='" + name + "'";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {


                string username = reader["UserName"].ToString();
                string password = reader["Password"].ToString();
                string mobile = reader["Mobile"].ToString();
                string status = reader["Status"].ToString();
                user=new User(username, password, mobile, status);
            }
            conn.Close();
            return user;
            

        }

        User IUser.UpdateUser(User user)
        {
            User user1 = new User();
            comm.CommandText = "update Users set Password='"+user.Password+"',Mobile='"+user.Mobile+"',Status='"+user.Status+"' where UserName='" + user.UserName+ "'";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {

                
                string username = reader["UserName"].ToString();
                string password = reader["Password"].ToString();
                string mobile = reader["Mobile"].ToString();
                string status = reader["Status"].ToString();
                user1 = new User(username, password, mobile, status);
            }
            conn.Close();
            return user1;
        }

        void IUser.UserStatus(string name,string status)
        {
            comm.CommandText = "Update Users Set Status='" +status+"' where UserName='" + name + "'";
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();

        }
    }
}