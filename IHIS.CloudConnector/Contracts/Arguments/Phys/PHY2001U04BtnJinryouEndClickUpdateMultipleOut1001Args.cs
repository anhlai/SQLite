using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04BtnJinryouEndClickUpdateMultipleOut1001Args : IContractArgs
    {
        private List<PHY2001U04BtnJinryouEndClickUpdateMultipleOut1001Info> _pkout1001LstItem = new List<PHY2001U04BtnJinryouEndClickUpdateMultipleOut1001Info>();

        public List<PHY2001U04BtnJinryouEndClickUpdateMultipleOut1001Info> Pkout1001LstItem
        {
            get { return this._pkout1001LstItem; }
            set { this._pkout1001LstItem = value; }
        }

        public PHY2001U04BtnJinryouEndClickUpdateMultipleOut1001Args() { }

        public PHY2001U04BtnJinryouEndClickUpdateMultipleOut1001Args(List<PHY2001U04BtnJinryouEndClickUpdateMultipleOut1001Info> pkout1001LstItem)
        {
            this._pkout1001LstItem = pkout1001LstItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04BtnJinryouEndClickUpdateMultipleOut1001Request();
        }
    }
}