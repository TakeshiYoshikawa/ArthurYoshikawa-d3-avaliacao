using ArthurYoshikawa_d3_avaliacao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArthurYoshikawa_d3_avaliacao.Models.Base
{
    public abstract class BaseLog
    {
        public abstract void Log(User user, string state);
    }
}
