using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OUTSANGQ00IsEnableSangCodeArgs : IContractArgs
    {
        private String _pkoutsang;
        private String _bunho;

        public String Pkoutsang
        {
            get { return this._pkoutsang; }
            set { this._pkoutsang = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public OUTSANGQ00IsEnableSangCodeArgs() { }

        public OUTSANGQ00IsEnableSangCodeArgs(String pkoutsang, String bunho)
        {
            this._pkoutsang = pkoutsang;
            this._bunho = bunho;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OUTSANGQ00IsEnableSangCodeRequest();
        }
    }
}