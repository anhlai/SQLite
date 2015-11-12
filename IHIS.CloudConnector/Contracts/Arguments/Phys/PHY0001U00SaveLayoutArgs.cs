using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using PHY0001U00GrdOCS0132Info = IHIS.CloudConnector.Contracts.Models.Phys.PHY0001U00GrdOCS0132Info;
using PHY0001U00GrdRehaSinryouryouCodeInfo = IHIS.CloudConnector.Contracts.Models.Phys.PHY0001U00GrdRehaSinryouryouCodeInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY0001U00SaveLayoutArgs : IContractArgs
    {
        private List<PHY0001U00GrdRehaSinryouryouCodeInfo> _grdRehaInfo = new List<PHY0001U00GrdRehaSinryouryouCodeInfo>();
        private List<PHY0001U00GrdOCS0132Info> _grdOcsInfo = new List<PHY0001U00GrdOCS0132Info>();

        public List<PHY0001U00GrdRehaSinryouryouCodeInfo> GrdRehaInfo
        {
            get { return this._grdRehaInfo; }
            set { this._grdRehaInfo = value; }
        }

        public List<PHY0001U00GrdOCS0132Info> GrdOcsInfo
        {
            get { return this._grdOcsInfo; }
            set { this._grdOcsInfo = value; }
        }

        public PHY0001U00SaveLayoutArgs() { }

        public PHY0001U00SaveLayoutArgs(List<PHY0001U00GrdRehaSinryouryouCodeInfo> grdRehaInfo, List<PHY0001U00GrdOCS0132Info> grdOcsInfo)
        {
            this._grdRehaInfo = grdRehaInfo;
            this._grdOcsInfo = grdOcsInfo;
        }

        public IExtensible GetRequestInstance()
        {
            return new PHY0001U00SaveLayoutRequest();
        }
    }
}