using BussinessLogic.Repository;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class UserServices : IUserRepository
    {
        private FPTshopContext context;
        private static UserServices instance = null;
        private readonly static Object instanceLock = new Object();


        public UserServices()
        {
            context = new FPTshopContext();
        }

        public static UserServices Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserServices();
                    }
                    return instance;
                }
            }
        }

        public User getUsetID(int uid)
        {
            throw new NotImplementedException();
        }

        public User login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool register(User user)
        {
            throw new NotImplementedException();
        }

        public bool update(User user)
        {
            throw new NotImplementedException();
        }

        public bool updateStatus(int uid, int statusId)
        {
            throw new NotImplementedException();
        }
    }
}
