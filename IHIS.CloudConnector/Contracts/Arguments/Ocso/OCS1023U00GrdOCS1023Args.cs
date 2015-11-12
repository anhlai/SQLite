using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCS1023U00GrdOCS1023Args : IContractArgs
    {
        private String _genericYn;
        private String _bunho;
        private String _gwa;
        private String _inputTab;

        public String GenericYn
        {
            get { return this._genericYn; }
            set { this._genericYn = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String InputTab
        {
            get { return this._inputTab; }
            set { this._inputTab = value; }
        }

        public OCS1023U00GrdOCS1023Args() { }

        public OCS1023U00GrdOCS1023Args(String genericYn, String bunho, String gwa, String inputTab)
        {
            this._genericYn = genericYn;
            this._bunho = bunho;
            this._gwa = gwa;
            this._inputTab = inputTab;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS1023U00GrdOCS1023Request();
        }
    }
}