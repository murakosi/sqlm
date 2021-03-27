﻿using MasudaManager.DataAccess;
using System.Collections.Generic;
using System;

namespace MasudaManager.Utility.DbObject
{
    public class TableColumnPropertyStrategy : IDbObjectStrategy
    {
        IDataAccess _dataAccess = DataAccessProvider.GetDataAccess();
        IDbObjectStrategy _parent;
        IDbObjectStrategy _child;
        IDbCommandBuilder _builder = new DbCommandBuilder();

        public TableColumnPropertyStrategy(IDbObjectStrategy parent, IDbObjectStrategy child)
        {
            _parent = parent;
            _child = child;
        }

        public IDbObjectStrategy ParentStrategy { get { return _parent; } }

        public IDbObjectStrategy ChildStrategy { get { return _child; } }

        public DbObjectType ObjectType { get { return _parent.ObjectType; } }

        public DbObjectPropertyType PropertyType { get { return DbObjectPropertyType.TableColumn; } }

        public bool SupportClickInsert { get { return true; } }

        public int InsertableColumnIndex { get { return (int)TableColumnDataColumn.ColumnName; } }

        public bool SupportFilter { get { return true; } }

        public int FilterableColumnIndex { get { return (int)TableColumnDataColumn.ColumnName; } }

        public bool SupportDisplayData { get { return false; } }

        public bool SupportCreateSql { get { return false; } }

        public bool SupportEditData { get { return false; } }

        public bool SupportExport { get { return false; } }

        public bool SupportImport { get { return false; } }

        public IDbCommandBuilder CommandBuilder
        {
            get
            {
                _builder.CreateCommand(_dataAccess.SqlLibrary.SqlTableColumnPropertyInfo,
                    DbObjectDbCommandParameters.GetPropertyParemeterNames(_parent.ObjectType),
                    GetParamValue());
                return _builder;
            }
        }

        public int NameColumnIndex { get { return 0; } }

        public int KeyColumnIndex { get { return 0; } }

        public object CurrentKeyValue { get; set; }
        
        object[] GetParamValue()
        {
            return new object[] { _dataAccess.CurrentConnectionData.UserId.ToUpper(), _parent.CurrentKeyValue };
        }
    
    }
}
