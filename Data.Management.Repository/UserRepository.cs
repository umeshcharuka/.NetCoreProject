using Dapper;
using Data.Management.Entities;
using DataManagement.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Data.Management.Repository
{
     public class UserRepository:BaseRepository,IUserRepository {  
        public bool AddUser(User user)
    {
        try
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@UserName", user.UserName);
            parameters.Add("@UserMobile", user.UserMobile);
            parameters.Add("@UserEmail", user.UserEmail);
            parameters.Add("@FaceBookUrl", user.FaceBookUrl);
            parameters.Add("@LinkedInUrl", user.LinkedInUrl);
            parameters.Add("@TwitterUrl", user.TwitterUrl);
            parameters.Add("@PersonalWebUrl", user.PersonalWebUrl);;
            SqlMapper.Execute(con, "AddUser", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public bool DeleteUser(int userId)
    {
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@UserId", userId);
        SqlMapper.Execute(con, "DeleteUser", parameters, commandType: CommandType.StoredProcedure);
        return true;
    }
    public IList<User> GetAllUser()
    {
        IList<User> customerList = SqlMapper.Query<User>(con, "GetAllUsers", commandType: CommandType.StoredProcedure).ToList();
        return customerList;
    }
    public User GetUserById(int userId)
    {
        try
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CustomerID", userId);
            return SqlMapper.Query<User>((SqlConnection)con, "GetUserById", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public bool UpdateUser(User user)
    {
        try
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@UserId", user.UserId);
            parameters.Add("@UserName", user.UserName);
            parameters.Add("@UserMobile", user.UserMobile);
            parameters.Add("@UserEmail", user.UserEmail);
            parameters.Add("@FaceBookUrl", user.FaceBookUrl);
            parameters.Add("@LinkedInUrl", user.LinkedInUrl);
            parameters.Add("@TwitterUrl", user.TwitterUrl);
            parameters.Add("@PersonalWebUrl", user.PersonalWebUrl);
            SqlMapper.Execute(con, "UpdateUser",parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
} 
}
