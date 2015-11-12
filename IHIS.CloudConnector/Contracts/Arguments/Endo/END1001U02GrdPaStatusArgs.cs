using System;
using IHIS.CloudConnector.Contracts.Models.Endo;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Endo
{
    public class END1001U02GrdPaStatusArgs : IContractArgs
    {
        private String _bunho;
        private String _hospCode;
        private String _hangmogCode;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String HangmogCode
        {
            get { return this._hangmogCode; }
            set { this._hangmogCode = value; }
        }

        public END1001U02GrdPaStatusArgs() { }

        public END1001U02GrdPaStatusArgs(String bunho, String hospCode, String hangmogCode)
        {
            this._bunho = bunho;
            this._hospCode = hospCode;
            this._hangmogCode = hangmogCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.END1001U02GrdPaStatusRequest();
        }
    }
}