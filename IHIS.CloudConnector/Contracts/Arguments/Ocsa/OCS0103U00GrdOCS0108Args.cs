using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U00GrdOCS0108Args : IContractArgs
    {
        private String _hangmogCode;
        private String _hangmogStartDate;
        private String _hospCode;

        public String HangmogCode
        {
            get { return this._hangmogCode; }
            set { this._hangmogCode = value; }
        }

        public String HangmogStartDate
        {
            get { return this._hangmogStartDate; }
            set { this._hangmogStartDate = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0103U00GrdOCS0108Args() { }

        public OCS0103U00GrdOCS0108Args(String hangmogCode, String hangmogStartDate, String hospCode)
        {
            this._hangmogCode = hangmogCode;
            this._hangmogStartDate = hangmogStartDate;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U00GrdOCS0108Request();
        }
    }
}