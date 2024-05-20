using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Adapter
{

    /// <summary>
    /// Model
    /// </summary>
    public class User
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }




    /// <summary>
    /// ITarget
    /// </summary>
    public interface IReport
    {
        /// <summary>
        /// return Json
        /// </summary>
        /// <returns></returns>
        string GenerateReport();
    }


    /// <summary>
    /// Adapter Class
    /// </summary>
    public class UserReportAdapter : IReport
    {
        private readonly UserService _daptee;
        public UserReportAdapter()
        {
            _daptee = new UserService();
        }
        public string GenerateReport()
        {
            return JsonConvert.SerializeObject(_daptee.GetUsers());

        }
    }


    /// <summary>
    /// Adaptee
    /// </summary>

    public class UserService
    {

        public List<User> GetUsers()
        {
            return new List<User>
            {
                new User
                {
                    FullName="Mohsen Saidipor",
                    Age=30,
                    Email="Mohsen@mail.com"
                },
                 new User
                {
                    FullName="Reza Rahimi",
                    Age=30,
                    Email="reza@mail.com"
                },
                new User
                {
                    FullName="Nasim Mohammadi",
                    Age=30,
                    Email="nasim@mail.com"
                },
            };

        }

    }
}
