namespace IHIS.CloudConnector.DataAccess.AdoNet.SqlServer
{
    using IHIS.CloudConnector.DataAccess.Entities;

    public class SqlServerCustomerDao : ICustomerDao
    {
        public bool TableExists(string tableName)
        {
            throw new System.NotImplementedException();
        }

        public Customer FindById(int customerId)
        {
            throw new System.NotImplementedException();
        }
    }
}