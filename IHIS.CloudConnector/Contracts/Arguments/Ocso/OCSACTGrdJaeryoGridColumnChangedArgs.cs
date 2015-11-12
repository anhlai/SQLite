using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCSACTGrdJaeryoGridColumnChangedArgs : IContractArgs
    {
        private String _hangmogCode1;
        private String _hangmogCode2;
        private String _setHangmogCode;

        public String HangmogCode1
        {
            get { return this._hangmogCode1; }
            set { this._hangmogCode1 = value; }
        }

        public String HangmogCode2
        {
            get { return this._hangmogCode2; }
            set { this._hangmogCode2 = value; }
        }

        public String SetHangmogCode
        {
            get { return this._setHangmogCode; }
            set { this._setHangmogCode = value; }
        }

        public OCSACTGrdJaeryoGridColumnChangedArgs() { }

        public OCSACTGrdJaeryoGridColumnChangedArgs(String hangmogCode1, String hangmogCode2, String setHangmogCode)
        {
            this._hangmogCode1 = hangmogCode1;
            this._hangmogCode2 = hangmogCode2;
            this._setHangmogCode = setHangmogCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTGrdJaeryoGridColumnChangedRequest();
        }
    }
}