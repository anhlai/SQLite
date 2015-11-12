using System;
using IHIS.CloudConnector.Contracts.Models.Outs;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Outs
{
    public class OUT1001P03GrdAfterJubsuArgs : IContractArgs
    {
        private String _ioGubun;
        private String _bunho;

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

        public OUT1001P03GrdAfterJubsuArgs() { }

        public OUT1001P03GrdAfterJubsuArgs(String ioGubun, String bunho)
        {
            this._ioGubun = ioGubun;
            this._bunho = bunho;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OUT1001P03GrdAfterJubsuRequest();
        }
    }
}