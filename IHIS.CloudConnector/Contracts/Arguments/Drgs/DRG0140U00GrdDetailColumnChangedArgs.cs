using System;
using ProtoBuf;
using IHIS.CloudConnector.Contracts.Models.Drgs;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0140U00GrdDetailColumnChangedArgs : IContractArgs
	{
		private String _changedValue;
		private List<DRG0140U00GrdColumnChangedInfo> _gdcItem = new List<DRG0140U00GrdColumnChangedInfo>();

		public String ChangedValue
		{
			get { return this._changedValue; }
			set { this._changedValue = value; }
		}

		public List<DRG0140U00GrdColumnChangedInfo> GdcItem
		{
			get { return this._gdcItem; }
			set { this._gdcItem = value; }
		}

		public DRG0140U00GrdDetailColumnChangedArgs() { }

		public DRG0140U00GrdDetailColumnChangedArgs(String changedValue, List<DRG0140U00GrdColumnChangedInfo> gdcItem)
		{
			this._changedValue = changedValue;
			this._gdcItem = gdcItem;
		}

		public IExtensible GetRequestInstance()
		{
			return new IHIS.CloudConnector.Messaging.DRG0140U00GrdDetailColumnChangedRequest();
		}
	}
}