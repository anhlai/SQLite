using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0301U00GrdOCS0300Args : IContractArgs
    {
        private String _memb;
        private String _inputTab;
        private String _hospCode;

        public String Memb
        {
            get { return this._memb; }
            set { this._memb = value; }
        }

        public String InputTab
        {
            get { return this._inputTab; }
            set { this._inputTab = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0301U00GrdOCS0300Args() { }

        public OCS0301U00GrdOCS0300Args(String memb, String inputTab, String hospCode)
        {
            this._memb = memb;
            this._inputTab = inputTab;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0301U00GrdOCS0300Request();
        }
    }
}