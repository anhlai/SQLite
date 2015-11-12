using System;
using IHIS.CloudConnector.Contracts.Models.Pfes;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Pfes
{
    public class PFE7001Q01LayDailyReportArgs : IContractArgs
    {
        private String _kensaDate;
        private String _ioGubun;
        private String _partCode;

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

        public String PartCode
        {
            get { return this._partCode; }
            set { this._partCode = value; }
        }

        public PFE7001Q01LayDailyReportArgs() { }

        public PFE7001Q01LayDailyReportArgs(String kensaDate, String ioGubun, String partCode)
        {
            this._kensaDate = kensaDate;
            this._ioGubun = ioGubun;
            this._partCode = partCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PFE7001Q01LayDailyReportRequest();
        }
    }
}