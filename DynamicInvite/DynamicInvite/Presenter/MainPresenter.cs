using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicInvite.Presenter
{
    class MainPresenter
    {
        private DatabaseAccess db;

        public MainPresenter()
        {
            initialize();
        }

        private void initialize()
        {
            db = new DatabaseAccess(this);
        }
        
    }
}
