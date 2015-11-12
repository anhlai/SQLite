namespace IHIS.CloudConnector.DataAccess
{
    /// <summary>
    /// Abstract factory class that creates data access objects.
    /// </summary>
    /// <remarks>
    /// GoF Design Pattern: Factory.
    /// </remarks>
    public abstract class DaoFactory
    {
        /// <summary>
        /// Gets a customer data access object.
        /// </summary>
        public abstract ICustomerDao CustomerDao { get; }
    }

    /// <summary>
    /// Abstract factory class that creates data access objects.
    /// </summary>
    /// <remarks>
    /// GoF Design Pattern: Factory.
    /// </remarks>
    public abstract class CopyOfDaoFactory
    {
        /// <summary>
        /// Gets a customer data access object.
        /// </summary>
        public abstract ICustomerDao CustomerDao { get; }
    }
}
