using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0301U00GrdOCS0301Args : IContractArgs
    {
        private String _memb;
        private String _fkocs0300Seq;
        private String _hospCode;

        public String Memb
        {
            get { return this._memb; }
            set { this._memb = value; }
        }

        public String Fkocs0300Seq
        {
            get { return this._fkocs0300Seq; }
            set { this._fkocs0300Seq = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0301U00GrdOCS0301Args() { }

        public OCS0301U00GrdOCS0301Args(String memb, String fkocs0300Seq, String hospCode)
        {
            this._memb = memb;
            this._fkocs0300Seq = fkocs0300Seq;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0301U00GrdOCS0301Request();
        }
    }
}