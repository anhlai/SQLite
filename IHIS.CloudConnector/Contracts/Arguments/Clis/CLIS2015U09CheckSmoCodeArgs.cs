using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U09CheckSmoCodeArgs : IContractArgs
    {
        private String _smoCode;

        public String SmoCode
        {
            get { return this._smoCode; }
            set { this._smoCode = value; }
        }

        public CLIS2015U09CheckSmoCodeArgs() { }

        public CLIS2015U09CheckSmoCodeArgs(String smoCode)
        {
            this._smoCode = smoCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U09CheckSmoCodeRequest();
        }
    }
}