using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0108U00grdOCS0103Args : IContractArgs
    {
        private String _hangmogNameInx;
        private String _slipCode;
        private String _hospCode;

        public String HangmogNameInx
        {
            get { return this._hangmogNameInx; }
            set { this._hangmogNameInx = value; }
        }

        public String SlipCode
        {
            get { return this._slipCode; }
            set { this._slipCode = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0108U00grdOCS0103Args() { }

        public OCS0108U00grdOCS0103Args(String hangmogNameInx, String slipCode, String hospCode)
        {
            this._hangmogNameInx = hangmogNameInx;
            this._slipCode = slipCode;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0108U00grdOCS0103Request();
        }
    }
}