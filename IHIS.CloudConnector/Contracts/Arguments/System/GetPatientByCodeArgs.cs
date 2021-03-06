using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class GetPatientByCodeArgs : IContractArgs
    {
        private string _patientCode;

        public GetPatientByCodeArgs()
        {
        }

        public GetPatientByCodeArgs(string patientCode)
        {
            _patientCode = patientCode;
        }

        public string PatientCode
        {
            get { return _patientCode; }
            set { _patientCode = value; }
        }

        public IExtensible GetRequestInstance()
        {
            return new GetPatientByCodeRequest();
        }
    }
}
