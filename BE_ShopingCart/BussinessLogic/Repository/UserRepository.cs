using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Repository
{
    public class UserRepository : IUserRepository
    {
        public User getUsetID(int uid) => UserServices.Instance.getUsetID(uid);

        public User login(string username, string password) => UserServices.Instance.login(username, password);

        public bool register(User user) => UserServices.Instance.register(user);

        public bool update(User user) => UserServices.Instance.update(user);

        public bool updateStatus(int uid, int statusId) => UserServices.Instance.updateStatus(uid, statusId);
    }
}
