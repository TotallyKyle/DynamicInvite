using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicInvite.Presenter;
namespace DynamicInvite
{
    class DatabaseAccess
    {
        private MainPresenter presenter;


        public DatabaseAccess(MainPresenter presenter)
        {
            this.presenter = presenter;
        }

    }
}
