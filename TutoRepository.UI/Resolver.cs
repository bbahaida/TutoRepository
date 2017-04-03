using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoRepository.UI
{
    public class Resolver : Registry
    {
        public Resolver()
        {
            Scan(sc => 
            {
                sc.TheCallingAssembly();
                sc.WithDefaultConventions();
            });
        }
    }
}
