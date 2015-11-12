using System;
using IHIS.CloudConnector.Contracts.Models.Outs;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Outs
{
    public class OUT1001P03GrdBeforeJubsuArgs : IContractArgs
    {
        private String _ioGubun;
        private String _bunho;
        private String _pkout1001;

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

        public String Pkout1001
        {
            get { return this._pkout1001; }
            set { this._pkout1001 = value; }
        }

        public OUT1001P03GrdBeforeJubsuArgs() { }

        public OUT1001P03GrdBeforeJubsuArgs(String ioGubun, String bunho, String pkout1001)
        {
            this._ioGubun = ioGubun;
            this._bunho = bunho;
            this._pkout1001 = pkout1001;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OUT1001P03GrdBeforeJubsuRequest();
        }
    }
}