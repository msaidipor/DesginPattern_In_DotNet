using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{


    /// <summary>
    /// The "Subject" Interface
    /// </summary>
    public interface IDatabase
    {
        string GetData();
    }

    /// <summary>
    /// The "RealSubject" Class
    /// </summary>
    public class Database : IDatabase
    {
        public string GetData()
        {
            return "Data From Database";
        }
    }


    /// <summary>
    /// The "Proxy" Class
    /// </summary>
    public class ProxyDatabase : IDatabase
    {
        private readonly Database _database=new();
        private string _cacheData;
        public ProxyDatabase(Database database)
        {
                _database=database;
        }

        public string GetData()
        {
            if (string.IsNullOrEmpty(_cacheData)) _cacheData = _database.GetData();
            else _cacheData = "cache:"+ _cacheData;
            
            return _cacheData;
        }
    }


    
}
