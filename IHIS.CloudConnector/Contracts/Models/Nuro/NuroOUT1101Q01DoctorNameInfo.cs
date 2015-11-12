namespace IHIS.CloudConnector.Contracts.Models.Nuro
{
    public class NuroOUT1101Q01DoctorNameInfo
    {
        public NuroOUT1101Q01DoctorNameInfo() {}
    
        private string _doctorName = "";
        public string DoctorName
        {
            get { return _doctorName; }
            set { _doctorName = value; }
        }
    }
}