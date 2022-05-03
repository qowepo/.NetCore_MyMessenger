using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        //GET

        [HttpGet]
        public string GETAuthorization()
        {
            Console.WriteLine(String.Format("Тут форма для Авторизации"));
            return "Тут форма для Авторизации";
        }

        [HttpGet("Registration")]
        public string GETRegistration()
        {
            Console.WriteLine(String.Format("Тут форма для Регистрации"));
            return "Тут форма для Регистрации";
        }



        // POST 
        [HttpPost()]
        public IActionResult POSTAuthorization([FromBody] User User)
        {
            if (User == null)
                return BadRequest();
            if (!UserInDB(User))
                return new BadRequestResult();

            //Console.WriteLine(String.Format("В БД есть пользователь с Логином {0}, и Паролем {1}", User.UserLogin, User.UserPassword));
            return new OkResult();
        }
        

        [HttpPost("Registration")]
        public IActionResult POSTRegistration([FromBody] User User)
        {
            if (User == null)
                return BadRequest();
            if (!UserAddInDB(User))
                return new BadRequestResult();
            return new OkResult();
        }



        bool UserInDB(User User)
        {
            string connection = @"Data Source=LENOVO-IP5\SQLEXPRESS;Initial Catalog=MessengerDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            try
            {
                con.Open();

                SqlDataAdapter sdAdapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string query = "SELECT * FROM AuthorizationDB WHERE login_user LIKE '" +
                    User.UserLogin + "' AND password_user LIKE '" + User.UserPassword + "'";
                SqlCommand command = new SqlCommand(query, con);
                sdAdapter.SelectCommand = command;
                sdAdapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    Console.WriteLine(String.Format("В БД ЕСТЬ пользователь с Логином {0}, Паролем {1}",
                      User.UserLogin, User.UserPassword));
                    User.UserName = "NIkita";
                    User.UserSurname = "Nikulin";
                    return true;
                }

                Console.WriteLine(String.Format("В БД НЕТ пользователя с Логином {0}, Паролем {1}",
                     User.UserLogin, User.UserPassword));
                return false;
            }
            catch(Exception ex) 
            {
                Console.WriteLine(String.Format(ex.ToString()));
                return false;
            }

            finally
            {
                con.Close();
            }
        }

        bool UserAddInDB(User User)
        {
            string connection = @"Data Source=LENOVO-IP5\SQLEXPRESS;Initial Catalog=MessengerDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            try
            {
                con.Open();

                SqlDataAdapter sdAdapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string query = "INSERT INTO AuthorizationDB (name_user, surname_user, login_user, password_user) VALUES ('" + User.UserName + "', '" + User.UserSurname + "', '" + User.UserLogin + "', '" +
                    User.UserPassword + "')";
                SqlCommand command = new SqlCommand(query, con);
                

                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine(String.Format("В БД Добавлен пользователь с Логином {0}, Паролем {1}, Именем {2} и Фамилией {3}",
                      User.UserLogin, User.UserPassword,  User.UserName, User.UserSurname));
                    return true;
                }

                Console.WriteLine(String.Format("В БД НЕ ДОБАВЛЕН пользователя с Логином {0}, Паролем {1},  Именем {2} и Фамилией {3}",
                     User.UserLogin, User.UserPassword, User.UserName, User.UserSurname));
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(String.Format(ex.ToString()));
                return false;
            }

            finally
            {
                con.Close();
            }
        }
    }
}
