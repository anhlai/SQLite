using System;
using IHIS.CloudConnector.Contracts.Models.Pfes;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Pfes
{
    public class PFE7001Q02LayMonthlyReportArgs : IContractArgs
    {
        private String _fromDate;
        private String _toDate;
        private String _ioGubun;
        private String _partCode;

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

        public String IoGubun
        {
            get { return this._ioGubun; }
            set { this._ioGubun = value; }
        }

        public String PartCode
        {
            get { return this._partCode; }
            set { this._partCode = value; }
        }

        public PFE7001Q02LayMonthlyReportArgs() { }

        public PFE7001Q02LayMonthlyReportArgs(String fromDate, String toDate, String ioGubun, String partCode)
        {
            this._fromDate = fromDate;
            this._toDate = toDate;
            this._ioGubun = ioGubun;
            this._partCode = partCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PFE7001Q02LayMonthlyReportRequest();
        }
    }
}