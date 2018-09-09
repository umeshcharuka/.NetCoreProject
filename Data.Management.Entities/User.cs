using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Management.Entities
{
    public class User
    {
        public int UserId
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public string UserMobile
        {
            get;
            set;
        }
        public string UserEmail
        {
            get;
            set;
        }
        public string FaceBookUrl
        {
            get;
            set;
        }
        public string LinkedInUrl
        {
            get;
            set;
        }
        public string TwitterUrl
        {
            get;
            set;
        }
        public string PersonalWebUrl
        {
            get;
            set;
        }
        public bool IsDeleted
        {
            get;
            set;
        }
    }
}
