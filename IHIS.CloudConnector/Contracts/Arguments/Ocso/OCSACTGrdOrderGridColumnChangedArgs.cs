using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCSACTGrdOrderGridColumnChangedArgs : IContractArgs
    {
        private String _userId;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public OCSACTGrdOrderGridColumnChangedArgs() { }

        public OCSACTGrdOrderGridColumnChangedArgs(String userId)
        {
            this._userId = userId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTGrdOrderGridColumnChangedRequest();
        }
    }
}