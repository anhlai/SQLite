using System;
using ProtoBuf;
using IHIS.CloudConnector.Contracts.Models.Drgs;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0140U00SaveLayoutArgs : IContractArgs
	{
		private String _userId;
		private List<DRG0140U00SaveLayoutInfo> _saveLayoutItem = new List<DRG0140U00SaveLayoutInfo>();

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public List<DRG0140U00SaveLayoutInfo> SaveLayoutItem
		{
			get { return this._saveLayoutItem; }
			set { this._saveLayoutItem = value; }
		}

		public DRG0140U00SaveLayoutArgs() { }

		public DRG0140U00SaveLayoutArgs(String userId, List<DRG0140U00SaveLayoutInfo> saveLayoutItem)
		{
			this._userId = userId;
			this._saveLayoutItem = saveLayoutItem;
		}

		public IExtensible GetRequestInstance()
		{
			return new IHIS.CloudConnector.Messaging.DRG0140U00SaveLayoutRequest();
		}
	}
}