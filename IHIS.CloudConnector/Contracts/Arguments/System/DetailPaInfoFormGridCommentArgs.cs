using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class DetailPaInfoFormGridCommentArgs : IContractArgs
    {
        private String _patientCode;

        public String PatientCode
        {
            get { return this._patientCode; }
            set { this._patientCode = value; }
        }

        public DetailPaInfoFormGridCommentArgs() { }

        public DetailPaInfoFormGridCommentArgs(String patientCode)
        {
            this._patientCode = patientCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new DetailPaInfoFormGridCommentRequest();
        }
    }

}
