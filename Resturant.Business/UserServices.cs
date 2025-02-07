using Resturant.DataAcess;
using Resturant.DataAcess.Models;
using BCrypt.Net;
using System.Data;

namespace Resturant.Business
{
    public class UserServices
    {
        RestContext Db;

        public object MessageBoxIcon { get; private set; }

        public  UserServices()
        {
            Db = new RestContext();
        }

        // Authontication
        public User UserAuthontication(string email, string pass)
        {
            //UserServices x = new UserServices();
            //string hashPass = x.HashPassword(pass);
            return Db.Users.Where(u => u.U_Email == email && u.U_Password == pass).FirstOrDefault();
        }

        // check to sign up
        public User UserAuthonticationByEmail(string email)
        {
            return Db.Users.Where(u => u.U_Email == email).FirstOrDefault();
        }

        // Encrypt the password 
        //public string HashPassword(string password)
        //{
        //    return BCrypt.Net.BCrypt.HashPassword(password);
        //}


        // add user (signup)
        public void AddNewUser(string name, string email, string pas, string add, string phone, DateOnly BD)
        {
            Db.Users.Add(new User() {U_Name = name, U_Email = email, U_Password = pas, U_Address = add, U_Phone = phone, U_BirthDate = BD} );
            Db.SaveChanges();
        }

        // Get All User (Admin Dashbord)
        public List<User> GetAllUsers()
        {
            return Db.Users.ToList();
        }

        // Delete User
        public int DeleteUser(int id)
        {
            User u = Db.Users.Where(u=>u.U_Id == id).FirstOrDefault();
            Db.Users.Remove(u);
            return Db.SaveChanges();
        }

        // Update User Role
        public int UpdateUserRole(int id, string role)
        {
            User u = Db.Users.Where(u=>u.U_Id == id).FirstOrDefault();
            u.U_Role = role;
            return Db.SaveChanges();
        }

        // Get user by id
        public User GetUserById(int id)
        {
            return Db.Users.FirstOrDefault(u => u.U_Id == id);
        }

        // Update User Info
        public int UpdateUserById(int id, string name, string address, string phone, DateOnly bd, string pass)
        {
            User u = Db.Users.Where(u => u.U_Id == id).FirstOrDefault();
            u.U_Name = name;
            u.U_Address = address;
            u.U_Phone = phone;
            u.U_BirthDate = bd;
            u.U_Password = pass;

            return Db.SaveChanges();
        }

    }
}
