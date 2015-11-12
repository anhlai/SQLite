namespace IHIS.CloudConnector.Contracts.Models.Nuro
{
    public class JapanDateInfo
    {
        public JapanDateInfo() {}
    
        private string _naewonDateJp = "";
        public string NaewonDateJp
        {
            get { return _naewonDateJp; }
            set { _naewonDateJp = value; }
        }
    }
}