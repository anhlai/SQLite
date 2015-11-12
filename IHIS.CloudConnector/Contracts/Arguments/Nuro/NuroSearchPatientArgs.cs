using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroSearchPatientArgs : IContractArgs
    {
        private string _patientCode;

        public NuroSearchPatientArgs(string patientCode)
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
            return new NuroSearchPatientInfoRequest();
        }
    }
}
