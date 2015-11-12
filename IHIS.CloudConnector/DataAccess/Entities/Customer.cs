namespace IHIS.CloudConnector.DataAccess.Entities
{
    public class Customer
    {
        private int id;

        private string name;

        private int dob;

        private int insertDate;

        private int updateDate;

        public Customer()
        {
        }

        public Customer(int id, string name, int dob, int insertDate, int updateDate)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
            this.insertDate = insertDate;
            this.updateDate = updateDate;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Dob
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        public int InsertDate
        {
            get
            {
                return insertDate;
            }
            set
            {
                insertDate = value;
            }
        }

        public int UpdateDate
        {
            get
            {
                return updateDate;
            }
            set
            {
                updateDate = value;
            }
        }
    }
}