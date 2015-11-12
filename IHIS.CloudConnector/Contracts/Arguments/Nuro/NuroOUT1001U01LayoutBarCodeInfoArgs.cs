using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01LayoutBarCodeInfoArgs : IContractArgs
    {
        private String _bunho;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public NuroOUT1001U01LayoutBarCodeInfoArgs() { }

        public NuroOUT1001U01LayoutBarCodeInfoArgs(String bunho)
        {
            this._bunho = bunho;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01BarCodeInfoRequest();
        }
    }
}
