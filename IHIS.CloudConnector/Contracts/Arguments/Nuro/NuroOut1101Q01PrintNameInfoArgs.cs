using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOut1101Q01PrintNameInfoArgs : IContractArgs
    {
        public NuroOut1101Q01PrintNameInfoArgs()
        {
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1101Q01PrintNameInfoRequest();
        }
    }
}