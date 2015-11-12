using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U00GrdOCS0103Args : IContractArgs
    {
        private String _slipCode;
        private String _hangmogInx;
        private String _slipGubun;
        private String _usedYn;
        private String _wonnaeYn;
        private String _hospCode;
        private String _pageNumber;
        private String _offset;

        public String SlipCode
        {
            get { return this._slipCode; }
            set { this._slipCode = value; }
        }

        public String HangmogInx
        {
            get { return this._hangmogInx; }
            set { this._hangmogInx = value; }
        }

        public String SlipGubun
        {
            get { return this._slipGubun; }
            set { this._slipGubun = value; }
        }

        public String UsedYn
        {
            get { return this._usedYn; }
            set { this._usedYn = value; }
        }

        public String WonnaeYn
        {
            get { return this._wonnaeYn; }
            set { this._wonnaeYn = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String PageNumber
        {
            get { return this._pageNumber; }
            set { this._pageNumber = value; }
        }

        public String Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        public OCS0103U00GrdOCS0103Args() { }

        public OCS0103U00GrdOCS0103Args(String slipCode, String hangmogInx, String slipGubun, String usedYn, String wonnaeYn, String hospCode, String pageNumber, String offset)
        {
            this._slipCode = slipCode;
            this._hangmogInx = hangmogInx;
            this._slipGubun = slipGubun;
            this._usedYn = usedYn;
            this._wonnaeYn = wonnaeYn;
            this._hospCode = hospCode;
            this._pageNumber = pageNumber;
            this._offset = offset;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U00GrdOCS0103Request();
        }
    }
}