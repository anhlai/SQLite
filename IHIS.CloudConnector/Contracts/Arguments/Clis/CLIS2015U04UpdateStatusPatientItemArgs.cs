using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U04UpdateStatusPatientItemArgs : IContractArgs
    {
        private List<CLIS2015U04GetPatientStatusListItemInfo> _patientStatus = new List<CLIS2015U04GetPatientStatusListItemInfo>();

        public List<CLIS2015U04GetPatientStatusListItemInfo> PatientStatus
        {
            get { return this._patientStatus; }
            set { this._patientStatus = value; }
        }

        public CLIS2015U04UpdateStatusPatientItemArgs() { }

        public CLIS2015U04UpdateStatusPatientItemArgs(List<CLIS2015U04GetPatientStatusListItemInfo> patientStatus)
        {
            this._patientStatus = patientStatus;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U04UpdateStatusPatientItemRequest();
        }
    }
}