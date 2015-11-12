using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOutOrderStatusArgs : IContractArgs
    {
        private string _commingDate;
        private string _deparmentCode;
        private string _patientCode;

        public NuroOutOrderStatusArgs()
        {
        }

        public NuroOutOrderStatusArgs(string commingDate, string deparmentCode, string patientCode)
        {
            _commingDate = commingDate;
            _deparmentCode = deparmentCode;
            _patientCode = patientCode;
        }

        public string CommingDate
        {
            get { return _commingDate; }
            set { _commingDate = value; }
        }

        public string DeparmentCode
        {
            get { return _deparmentCode; }
            set { _deparmentCode = value; }
        }

        public string PatientCode
        {
            get { return _patientCode; }
            set { _patientCode = value; }
        }

        public IExtensible GetRequestInstance()
        {
           return new NuroOutOrderStatusRequest();
        }
    }
}
