using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Middleware
{
    public interface IMap
    {
        void Mapping (Profile profile);
    }
}
