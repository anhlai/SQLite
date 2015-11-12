using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0118U00GrdOCS0118Args : IContractArgs
    {
        private String _hangmogNameInx;

        public String HangmogNameInx
        {
            get { return this._hangmogNameInx; }
            set { this._hangmogNameInx = value; }
        }

        public OCS0118U00GrdOCS0118Args() { }

        public OCS0118U00GrdOCS0118Args(String hangmogNameInx)
        {
            this._hangmogNameInx = hangmogNameInx;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0118U00GrdOCS0118Request();
        }
    }
}