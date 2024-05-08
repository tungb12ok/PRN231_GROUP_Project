using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
namespace BussinessLogic.Repository
{
    public interface IUserRepository
    {
        public User login (string username, string password);
        public User getUsetID(int uid);
        public bool register(User user);
        public bool update(User user);
        public bool updateStatus(int uid, int statusId);

    }
}
