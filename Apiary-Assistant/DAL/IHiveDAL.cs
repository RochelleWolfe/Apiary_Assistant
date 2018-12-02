using Apiary_Assistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apiary_Assistant.DAL
{
    public interface IHiveDAL
    {
        IEnumerable<Hive> GetStartHives();
    }
}
