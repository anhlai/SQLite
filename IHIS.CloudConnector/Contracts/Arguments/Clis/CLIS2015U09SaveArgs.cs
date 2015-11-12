using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U09SaveArgs : IContractArgs
    {
        private List<CLIS2015U09ItemInfo> _dt = new List<CLIS2015U09ItemInfo>();

        public List<CLIS2015U09ItemInfo> Dt
        {
            get { return this._dt; }
            set { this._dt = value; }
        }

        public CLIS2015U09SaveArgs() { }

        public CLIS2015U09SaveArgs(List<CLIS2015U09ItemInfo> dt)
        {
            this._dt = dt;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U09SaveRequest();
        }
    }
}