using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U04GetProtocolListByPatientItemArgs : IContractArgs
    {
        private String _patientCode;

        public String PatientCode
        {
            get { return this._patientCode; }
            set { this._patientCode = value; }
        }

        public CLIS2015U04GetProtocolListByPatientItemArgs() { }

        public CLIS2015U04GetProtocolListByPatientItemArgs(String patientCode)
        {
            this._patientCode = patientCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U04GetProtocolListByPatientItemRequest();
        }
    }
}