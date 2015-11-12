using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroRES0102U00SaveScheduleArgs : IContractArgs
    {
        private List<NuroRES0102U00GrdRES0102Info> _gridRes0102SaveItem = new List<NuroRES0102U00GrdRES0102Info>();
        private List<NuroRES0102U00GrdRES0103Info> _gridRes0103SaveItem = new List<NuroRES0102U00GrdRES0103Info>();
        private List<NuroRES0102U00GrdRES0103ResInfo> _gridRes0103RSaveItem = new List<NuroRES0102U00GrdRES0103ResInfo>();
        private List<NuroRES0102U00GridDoctorInfo> _gridDoctorSaveItem = new List<NuroRES0102U00GridDoctorInfo>();
        private String _userId;
        private String _hospCode;

        public List<NuroRES0102U00GrdRES0102Info> GridRes0102SaveItem
        {
            get { return this._gridRes0102SaveItem; }
            set { this._gridRes0102SaveItem = value; }
        }

        public List<NuroRES0102U00GrdRES0103Info> GridRes0103SaveItem
        {
            get { return this._gridRes0103SaveItem; }
            set { this._gridRes0103SaveItem = value; }
        }

        public List<NuroRES0102U00GrdRES0103ResInfo> GridRes0103RSaveItem
        {
            get { return this._gridRes0103RSaveItem; }
            set { this._gridRes0103RSaveItem = value; }
        }

        public List<NuroRES0102U00GridDoctorInfo> GridDoctorSaveItem
        {
            get { return this._gridDoctorSaveItem; }
            set { this._gridDoctorSaveItem = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public NuroRES0102U00SaveScheduleArgs() { }

        public NuroRES0102U00SaveScheduleArgs(List<NuroRES0102U00GrdRES0102Info> gridRes0102SaveItem, List<NuroRES0102U00GrdRES0103Info> gridRes0103SaveItem, List<NuroRES0102U00GrdRES0103ResInfo> gridRes0103RSaveItem, List<NuroRES0102U00GridDoctorInfo> gridDoctorSaveItem, String userId, String hospCode)
        {
            this._gridRes0102SaveItem = gridRes0102SaveItem;
            this._gridRes0103SaveItem = gridRes0103SaveItem;
            this._gridRes0103RSaveItem = gridRes0103RSaveItem;
            this._gridDoctorSaveItem = gridDoctorSaveItem;
            this._userId = userId;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.NuroRES0102U00SaveScheduleRequest();
        }
    }
}