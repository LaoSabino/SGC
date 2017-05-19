using SGC.Infra;
using SGC.Infra.Interface;
using SGC.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC.DI
{
    public class ModuleDI : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(ICrudUser)).To(typeof(UserRepository));

            Bind(typeof(DBBaseContext)).To(typeof(DBBaseContext)).InSingletonScope();
        }
    }
}
