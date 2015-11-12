namespace IHIS.CloudConnector.DataAccess.AdoNet.Sqlite
{
    /// <summary>
    /// Sqlite specific factory that creates Sql Server specific data access objects.
    /// </summary>
    /// <remarks>
    /// GoF Design Pattern: Factory.
    /// </remarks>
    public class SqliteDaoFactory : DaoFactory
    {
        /// <summary>
        /// Gets a Sql server specific customer data access object.
        /// </summary>
        public override ICustomerDao CustomerDao
        {
            get { return new SqliteCustomerDao();}
        }
    }
}