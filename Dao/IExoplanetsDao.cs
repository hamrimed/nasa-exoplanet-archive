using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Dao
{
    public interface IExoplanetsDao
    {
        ICollection<Planet> SelectAll();
        ICollection<Planet> SelectByKey(String key, object value);
    }
}
