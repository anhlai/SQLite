using System;
using IHIS.CloudConnector.Contracts.Models.Endo;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Endo
{
    public class END1001U02BtnQueryArgs : IContractArgs
    {
        private String _fkocs;
        private String _hospCode;
        private String _bunho;
        private String _hangmogCode;

        public String Fkocs
        {
            get { return this._fkocs; }
            set { this._fkocs = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String HangmogCode
        {
            get { return this._hangmogCode; }
            set { this._hangmogCode = value; }
        }

        public END1001U02BtnQueryArgs() { }

        public END1001U02BtnQueryArgs(String fkocs, String hospCode, String bunho, String hangmogCode)
        {
            this._fkocs = fkocs;
            this._hospCode = hospCode;
            this._bunho = bunho;
            this._hangmogCode = hangmogCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.END1001U02BtnQueryRequest();
        }
    }
}