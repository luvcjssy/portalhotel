using EC08_SHBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace EC08_SHBS
{
    public class CustomRoleProvider : RoleProvider
    {
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            ////-----------------ket noi voi database de lay quyen cua tai khoan-----------------
            PortalEntities db = new PortalEntities(); //tao ket noi voi database
            NguoiDung account = db.NguoiDungs.Single(x => x.userName.Equals(username)); //tuong duong voi cau lenh "Select Top 1 From Accounts Where NameAccount = username"
            if (account != null) //neu tim thay tai khoan
            {
                return new String[] { account.LoaiNguoiDung.tenLoai }; //tra ve quyen cua nguoi dung
            }
            else
                return new String[] { }; //new khong tim thay tai khoan thi gan quyen bang null
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}