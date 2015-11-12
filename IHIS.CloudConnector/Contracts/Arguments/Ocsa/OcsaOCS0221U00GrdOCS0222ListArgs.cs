using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OcsaOCS0221U00GrdOCS0222ListArgs : IContractArgs
    {
        private String _memb;
        private String _seq;
        private String _hospCode;

        public String Memb
        {
            get { return this._memb; }
            set { this._memb = value; }
        }

        public String Seq
        {
            get { return this._seq; }
            set { this._seq = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OcsaOCS0221U00GrdOCS0222ListArgs() { }

        public OcsaOCS0221U00GrdOCS0222ListArgs(String memb, String seq, String hospCode)
        {
            this._memb = memb;
            this._seq = seq;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OcsaOCS0221U00GrdOCS0222ListRequest();
        }
    }
}