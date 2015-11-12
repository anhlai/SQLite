using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0106U00GrdGroupArgs : IContractArgs
    {
        private String _hangmogCode;
        private String _gumsaName;

        public String HangmogCode
        {
            get { return this._hangmogCode; }
            set { this._hangmogCode = value; }
        }

        public String GumsaName
        {
            get { return this._gumsaName; }
            set { this._gumsaName = value; }
        }

        public CPL0106U00GrdGroupArgs() { }

        public CPL0106U00GrdGroupArgs(String hangmogCode, String gumsaName)
        {
            this._hangmogCode = hangmogCode;
            this._gumsaName = gumsaName;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0106U00GrdGroupRequest();
        }
    }
}