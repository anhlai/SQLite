using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04FnPhyDupJubsuGubunArgs : IContractArgs
    {
        private String _jubsuGubun;
        private String _bunho;
        private String _gwa;
        private String _naewonDate;

        public String JubsuGubun
        {
            get { return this._jubsuGubun; }
            set { this._jubsuGubun = value; }
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

        public String NaewonDate
        {
            get { return this._naewonDate; }
            set { this._naewonDate = value; }
        }

        public PHY2001U04FnPhyDupJubsuGubunArgs() { }

        public PHY2001U04FnPhyDupJubsuGubunArgs(String jubsuGubun, String bunho, String gwa, String naewonDate)
        {
            this._jubsuGubun = jubsuGubun;
            this._bunho = bunho;
            this._gwa = gwa;
            this._naewonDate = naewonDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04FnPhyDupJubsuGubunRequest();
        }
    }
}