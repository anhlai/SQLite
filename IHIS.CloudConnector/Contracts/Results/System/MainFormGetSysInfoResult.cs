using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.System
{
    public class MainFormGetSysInfoResult : AbstractContractResult
    {
        private List<MainFormGetMainMenuItemInfo> _sysInfoItem = new List<MainFormGetMainMenuItemInfo>();

        public List<MainFormGetMainMenuItemInfo> SysInfoItem
        {
            get { return this._sysInfoItem; }
            set { this._sysInfoItem = value; }
        }

        public MainFormGetSysInfoResult() { }

    }
}