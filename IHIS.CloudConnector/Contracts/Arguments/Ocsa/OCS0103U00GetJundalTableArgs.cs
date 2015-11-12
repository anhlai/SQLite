using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U00GetJundalTableArgs : IContractArgs
    {
        private String _jundalPart;
        private String _startDate;
        private String _ioGubun;
        private String _hospCode;

        public String JundalPart
        {
            get { return this._jundalPart; }
            set { this._jundalPart = value; }
        }

        public String StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        public String IoGubun
        {
            get { return this._ioGubun; }
            set { this._ioGubun = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0103U00GetJundalTableArgs() { }

        public OCS0103U00GetJundalTableArgs(String jundalPart, String startDate, String ioGubun, String hospCode)
        {
            this._jundalPart = jundalPart;
            this._startDate = startDate;
            this._ioGubun = ioGubun;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U00GetJundalTableRequest();
        }
    }
}