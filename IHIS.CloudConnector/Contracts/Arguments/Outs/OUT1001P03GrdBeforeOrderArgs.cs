using System;
using IHIS.CloudConnector.Contracts.Models.Outs;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Outs
{
    public class OUT1001P03GrdBeforeOrderArgs : IContractArgs
    {
        private String _ioGubun;
        private String _bunho;
        private String _naewonKey;

        public String IoGubun
        {
            get { return this._ioGubun; }
            set { this._ioGubun = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String NaewonKey
        {
            get { return this._naewonKey; }
            set { this._naewonKey = value; }
        }

        public OUT1001P03GrdBeforeOrderArgs() { }

        public OUT1001P03GrdBeforeOrderArgs(String ioGubun, String bunho, String naewonKey)
        {
            this._ioGubun = ioGubun;
            this._bunho = bunho;
            this._naewonKey = naewonKey;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OUT1001P03GrdBeforeOrderRequest();
        }
    }
}