using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DataAccessLayer
{
    public abstract class DbStorage: IStorage
    {
        public string DbConnectionStr
        {
            get;
            set;
        }

        public MySqlConnection DbConn
        {
            get;
            set;
        }

        protected DbStorage(string dbConnectionStr)
        {
            this.DbConnectionStr = dbConnectionStr;
        }

        public long ExecuteScalar(MySqlCommand sqlCommand)
        {
            return 0;
        }

        public void ExecuteNonQuery(MySqlCommand sqlCommand)
        {
            int nrAffectedRows = sqlCommand.ExecuteNonQuery();
            if(nrAffectedRows > 1)
            {
                throw new ArgumentOutOfRangeException("Insert in db affect more than one row!");
            }
        }

        public MySqlDataReader ExecuteReader(MySqlCommand sqlCommand)
        {
            return null;
        }

        public abstract void Create(object obj);

        public abstract object Read(object identifier);

        public abstract object ReadAll();

        public abstract void Update(object obj);

        public abstract void Delete(object identifier);
    }
}
