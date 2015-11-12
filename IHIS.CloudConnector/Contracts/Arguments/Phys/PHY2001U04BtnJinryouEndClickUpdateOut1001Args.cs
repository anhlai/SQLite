using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04BtnJinryouEndClickUpdateOut1001Args : IContractArgs
    {
        private String _naewonYn;
        private String _pkout1001;

        public String NaewonYn
        {
            get { return this._naewonYn; }
            set { this._naewonYn = value; }
        }

        public String Pkout1001
        {
            get { return this._pkout1001; }
            set { this._pkout1001 = value; }
        }

        public PHY2001U04BtnJinryouEndClickUpdateOut1001Args() { }

        public PHY2001U04BtnJinryouEndClickUpdateOut1001Args(String naewonYn, String pkout1001)
        {
            this._naewonYn = naewonYn;
            this._pkout1001 = pkout1001;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04BtnJinryouEndClickUpdateOut1001Request();
        }
    }
}