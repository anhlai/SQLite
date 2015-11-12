using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroManagePatientArgs : IContractArgs
    {
        public string _patientCode;

        public NuroManagePatientArgs()
        {
        }

        public NuroManagePatientArgs(string patientCode)
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
            return  new NuroManagePatientRequest();
        }
    }
}
