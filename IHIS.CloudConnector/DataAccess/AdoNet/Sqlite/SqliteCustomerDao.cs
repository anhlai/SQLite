using System;
//using System.Data.SQLite;
using System.Text;

namespace IHIS.CloudConnector.DataAccess.AdoNet.Sqlite
{
    using System.Data;
    using System.Data.Common;

    using IHIS.CloudConnector.DataAccess.Entities;

    public class SqliteCustomerDao : ICustomerDao
    {
        public bool TableExists(string tableName)
        {
            StringBuilder query = new StringBuilder();
            query.Append("SELECT COUNT(*) FROM SQLITE_MASTER ");
            query.Append("WHERE TYPE = 'table' AND NAME = "+ Db.Escape(tableName) + ";");

            return ((long) Db.GetScalar(query.ToString()) > 0);            
        }

        public Customer FindById(int customerId)
        {
            StringBuilder query = new StringBuilder();
            query.Append(" SELECT                     ");
            query.Append(" 	main.Customer.Id,         ");
            query.Append(" 	main.Customer.Name,       ");
            query.Append(" 	main.Customer.DoB,        ");
            query.Append(" 	main.Customer.InsertDate, ");
            query.Append(" 	main.Customer.UpdateDate  ");
            query.Append(" FROM                       ");
            query.Append(" 	main.Customer             ");
            query.Append(" WHERE                      ");
            query.Append(" 	main.Customer.Id = @Id    ");
            
            using (DbConnection connection = Db.CreateConnection())
            {
                using (DbCommand command = Db.CreateCommand())
                {
                    command.CommandText = query.ToString();
                    command.CommandType = CommandType.Text;                    
                    command.Parameters.Add(Db.CreateParameter("@Id", DbType.Int32, customerId));
                    command.Connection = connection;
                    connection.Open();
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer();
                            customer.Id = Int32.Parse(reader["Id"].ToString());
                            customer.Name = reader["Name"].ToString();
                            customer.Dob = Int32.Parse(reader["DoB"].ToString());
                            return customer;   
                        }
                    }                                        
                }
            }

            return null;   
        }
    }
}