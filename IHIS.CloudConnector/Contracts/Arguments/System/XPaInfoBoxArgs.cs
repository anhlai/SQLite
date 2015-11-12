using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class XPaInfoBoxArgs : IContractArgs
    {
        private String patientCode;

        public XPaInfoBoxArgs(string patientCode)
        {
            this.patientCode = patientCode;
        }

        public String PatientCode
        {
            get { return this.patientCode; }
            set { this.patientCode = value; }
        }

        public IExtensible GetRequestInstance()
        {
            return new XPaInfoBoxRequest();
        }
    }
}