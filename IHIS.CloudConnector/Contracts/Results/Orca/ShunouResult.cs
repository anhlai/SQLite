using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Orca;

namespace IHIS.CloudConnector.Contracts.Results.Orca
{
    public class ShunouResult : AbstractContractResult
    {
        private PatientInformation _patientInfo;
        private List<IncomeInformation> _incomeInformation = new List<IncomeInformation>();

        public PatientInformation PatientInfo
        {
            get { return _patientInfo; }
            set { _patientInfo = value; }
        }

        public List<IncomeInformation> IncomeInformation
        {
            get { return _incomeInformation; }
            set { _incomeInformation = value; }
        }
    }
}