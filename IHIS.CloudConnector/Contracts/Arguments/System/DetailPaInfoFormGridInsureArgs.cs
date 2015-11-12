using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class DetailPaInfoFormGridInsureArgs : IContractArgs
    {
        private String _patientCode;

        public String PatientCode
        {
            get { return this._patientCode; }
            set { this._patientCode = value; }
        }

        public DetailPaInfoFormGridInsureArgs() { }

        public DetailPaInfoFormGridInsureArgs(String patientCode)
        {
            this._patientCode = patientCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new DetailPaInfoFormGridInsureRequest();
        }
    }

}
