using System;
using ProtoBuf;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class PrOcsInterfaceInsertArgs : IContractArgs
	{
		private List<PrOcsInterfaceInsertInfo> _infoItem = new List<PrOcsInterfaceInsertInfo>();

		public List<PrOcsInterfaceInsertInfo> InfoItem
		{
			get { return this._infoItem; }
			set { this._infoItem = value; }
		}

		public PrOcsInterfaceInsertArgs() { }

		public PrOcsInterfaceInsertArgs(List<PrOcsInterfaceInsertInfo> infoItem)
		{
			this._infoItem = infoItem;
		}

		public IExtensible GetRequestInstance()
		{
			return new IHIS.CloudConnector.Messaging.PrOcsInterfaceInsertRequest();
		}
	}
}