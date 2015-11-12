using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0803U00grdOCS0804Args : IContractArgs
    {
        private String _patStatusGr;

        public String PatStatusGr
        {
            get { return this._patStatusGr; }
            set { this._patStatusGr = value; }
        }

        public OCS0803U00grdOCS0804Args() { }

        public OCS0803U00grdOCS0804Args(String patStatusGr)
        {
            this._patStatusGr = patStatusGr;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0803U00grdOCS0804Request();
        }
    }
}