using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01GetOut1001SeqArgs : IContractArgs
    {

        public NuroOUT1001U01GetOut1001SeqArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01GetOut1001SeqRequest();
        }
    }
}
