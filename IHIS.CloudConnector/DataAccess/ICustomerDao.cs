namespace IHIS.CloudConnector.DataAccess
{
    using IHIS.CloudConnector.DataAccess.Entities;

    public interface ICustomerDao
    {
        bool TableExists(string tableName);

        Customer FindById(int customerId);
    }
}