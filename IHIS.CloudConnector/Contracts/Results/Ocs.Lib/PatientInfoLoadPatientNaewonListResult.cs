using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
    public class PatientInfoLoadPatientNaewonListResult : AbstractContractResult
    {
        private List<LoadPatientBaseInfo> _patientBaseItem = new List<LoadPatientBaseInfo>();
        private List<LoadPatientNaewonListInfo> _patientNaewonItem = new List<LoadPatientNaewonListInfo>();

        public List<LoadPatientBaseInfo> PatientBaseItem
        {
            get { return this._patientBaseItem; }
            set { this._patientBaseItem = value; }
        }

        public List<LoadPatientNaewonListInfo> PatientNaewonItem
        {
            get { return this._patientNaewonItem; }
            set { this._patientNaewonItem = value; }
        }

        public PatientInfoLoadPatientNaewonListResult() { }

    }
}