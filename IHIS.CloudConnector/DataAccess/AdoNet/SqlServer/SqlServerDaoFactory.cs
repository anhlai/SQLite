namespace IHIS.CloudConnector.DataAccess.AdoNet.SqlServer
{
    /// <summary>
    /// Sql Server specific factory that creates Sql Server specific data access objects.
    /// </summary>
    /// <remarks>
    /// GoF Design Pattern: Factory.
    /// </remarks>
    public class SqlServerDaoFactory : DaoFactory
    {
        /// <summary>
        /// Gets a Sql server specific customer data access object.
        /// </summary>
        public override ICustomerDao CustomerDao
        {
            get { return new SqlServerCustomerDao(); }
        }
    }
}
