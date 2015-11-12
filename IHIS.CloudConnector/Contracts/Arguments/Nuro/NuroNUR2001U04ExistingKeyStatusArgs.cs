using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroNUR2001U04ExistingKeyStatusArgs : IContractArgs
    {
        private string _pkout1001;

        public string Pkout1001
        {
            get { return _pkout1001; }
            set { _pkout1001 = value; }
        }

        public NuroNUR2001U04ExistingKeyStatusArgs(string pkout1001)
        {
            _pkout1001 = pkout1001;
        }

        public NuroNUR2001U04ExistingKeyStatusArgs()
        {
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroNUR2001U04ExistingKeyStatusRequest();
        }
    }
}
