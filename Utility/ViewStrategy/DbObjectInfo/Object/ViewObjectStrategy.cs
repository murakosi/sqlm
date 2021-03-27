﻿using MasudaManager.DataAccess;
using System.Collections.Generic;

namespace MasudaManager.Utility.DbObject
{
    public class ViewObjectStrategy : IDbObjectStrategy
    {
        IDataAccess _dataAccess = DataAccessProvider.GetDataAccess();
        IDbObjectStrategy _child;
        IDbCommandBuilder _builder = new DbCommandBuilder();

        static ViewObjectStrategy _instance = new ViewObjectStrategy();
        static ViewObjectStrategy() { }
        private ViewObjectStrategy()
        {
            _child = 
                new GeneralPropertyStrategy(this,
                    new TableColumnPropertyStrategy(this, null));
        }
        public static ViewObjectStrategy Instance
        {
            get { return _instance; }
        }

        public IDbObjectStrategy ParentStrategy { get { return null; } }

        public IDbObjectStrategy ChildStrategy { get { return _child; } }

        public DbObjectType ObjectType { get { return DbObjectType.View; } }

        public DbObjectPropertyType PropertyType { get { return DbObjectPropertyType.None; } }

        public bool SupportClickInsert { get { return true; } }

        public int InsertableColumnIndex { get { return (int)TableDataColumn.Name; } }

        public bool SupportFilter { get { return true; } }

        public int FilterableColumnIndex { get { return (int)TableDataColumn.Name; } }

        public bool SupportDisplayData { get { return true; } }

        public bool SupportCreateSql { get { return true; } }

        public bool SupportEditData { get { return true; } }

        public bool SupportExport { get { return false; } }

        public bool SupportImport { get { return false; } }

        public IDbCommandBuilder CommandBuilder
        {
            get
            {
                _builder.CreateCommand(_dataAccess.SqlLibrary.SqlViewObjectInfo,
                    DbObjectDbCommandParameters.GetObjectParemeterNames(DbObjectType.View),
                    GetParamValue());
                return _builder;
            }
        }

        public int NameColumnIndex { get { return 0; } }

        public int KeyColumnIndex { get { return 0; } }

        public object CurrentKeyValue { get; set; }

        object[] GetParamValue()
        {
            return new object[] { _dataAccess.CurrentConnectionData.UserId.ToUpper() };
        }
    }
}
