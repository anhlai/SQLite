using System;
using ProtoBuf;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Drgs;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0140U00GrdMasterColumnChangedArgs : IContractArgs
	{
		private String _changedValue;
		private List<DRG0140U00GrdColumnChangedInfo> _gmcItem = new List<DRG0140U00GrdColumnChangedInfo>();

		public String ChangedValue
		{
			get { return this._changedValue; }
			set { this._changedValue = value; }
		}

		public List<DRG0140U00GrdColumnChangedInfo> GmcItem
		{
			get { return this._gmcItem; }
			set { this._gmcItem = value; }
		}

		public DRG0140U00GrdMasterColumnChangedArgs() { }

		public DRG0140U00GrdMasterColumnChangedArgs(String changedValue, List<DRG0140U00GrdColumnChangedInfo> gmcItem)
		{
			this._changedValue = changedValue;
			this._gmcItem = gmcItem;
		}

		public IExtensible GetRequestInstance()
		{
			return new IHIS.CloudConnector.Messaging.DRG0140U00GrdMasterColumnChangedRequest();
		}
	}
}