using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL7001Q02LayMonthlyReportArgs : IContractArgs
    {
        private String _fromDate;
        private String _toDate;
        private String _ioGubun;
        private String _uitakCode;

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

        public String UitakCode
        {
            get { return this._uitakCode; }
            set { this._uitakCode = value; }
        }

        public CPL7001Q02LayMonthlyReportArgs() { }

        public CPL7001Q02LayMonthlyReportArgs(String fromDate, String toDate, String ioGubun, String uitakCode)
        {
            this._fromDate = fromDate;
            this._toDate = toDate;
            this._ioGubun = ioGubun;
            this._uitakCode = uitakCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL7001Q02LayMonthlyReportRequest();
        }
    }
}