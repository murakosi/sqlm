﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasudaManager.Utility.ViewState
{
    public class DbObjectInfoLogOffState : IViewState
    {
        static DbObjectInfoLogOffState _instance = new DbObjectInfoLogOffState();
        static DbObjectInfoLogOffState() { }
        private DbObjectInfoLogOffState() { }
        public static DbObjectInfoLogOffState Instance
        {
            get { return _instance; }
        }

        public bool CanOpenConnection { get { return false; } }
        public bool CanCloseConnection { get { return false; } }
        public bool CanExecuteSql { get { return false; } }
        public bool CanCancelSql { get { return false; } }
        public bool CanChangeDbData { get { return false; } }
        public bool HasBusyProcess { get { return false; } }
        public string ViewText { get { return null; } }
        public string StatusText { get { return null; } }

        public IViewState ChangeState()
        {
            return DbObjectInfoLogOnState.Instance;
        }
    }
}
