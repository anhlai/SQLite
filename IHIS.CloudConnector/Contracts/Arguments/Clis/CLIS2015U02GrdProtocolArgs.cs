using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U02GrdProtocolArgs : IContractArgs
    {
        private String _protocolCode;
        private String _protocolName;
        private String _fromDate;
        private String _toDate;
        private String _protocolStatus;
        private String _patientCode;

        public String ProtocolCode
        {
            get { return this._protocolCode; }
            set { this._protocolCode = value; }
        }

        public String ProtocolName
        {
            get { return this._protocolName; }
            set { this._protocolName = value; }
        }

        public String FromDate
        {
            get { return this._fromDate; }
            set { this._fromDate = value; }
        }

        public String ToDate
        {
            get { return this._toDate; }
            set { this._toDate = value; }
        }

        public String ProtocolStatus
        {
            get { return this._protocolStatus; }
            set { this._protocolStatus = value; }
        }

        public String PatientCode
        {
            get { return this._patientCode; }
            set { this._patientCode = value; }
        }

        public CLIS2015U02GrdProtocolArgs() { }

        public CLIS2015U02GrdProtocolArgs(String protocolCode, String protocolName, String fromDate, String toDate, String protocolStatus, String patientCode)
        {
            this._protocolCode = protocolCode;
            this._protocolName = protocolName;
            this._fromDate = fromDate;
            this._toDate = toDate;
            this._protocolStatus = protocolStatus;
            this._patientCode = patientCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U02GrdProtocolRequest();
        }
    }
}