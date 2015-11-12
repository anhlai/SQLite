using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL7001Q01LayDailyReportArgs : IContractArgs
    {
        private String _kensaDate;
        private String _ioGubun;
        private String _uitakCode;

        public String KensaDate
        {
            get { return this._kensaDate; }
            set { this._kensaDate = value; }
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

        public CPL7001Q01LayDailyReportArgs() { }

        public CPL7001Q01LayDailyReportArgs(String kensaDate, String ioGubun, String uitakCode)
        {
            this._kensaDate = kensaDate;
            this._ioGubun = ioGubun;
            this._uitakCode = uitakCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL7001Q01LayDailyReportRequest();
        }
    }
}