using System;
using ProtoBuf;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U10SaveLayoutArgs : IContractArgs
	{
		private List<OCS0103U10SaveLayoutInfo> _saveLayoutItem = new List<OCS0103U10SaveLayoutInfo>();
		private List<PrOcsInterfaceInsertInfo> _interfaceInsertItem = new List<PrOcsInterfaceInsertInfo>();
		private String _bunho;
		private String _orderDate;

		public List<OCS0103U10SaveLayoutInfo> SaveLayoutItem
		{
			get { return this._saveLayoutItem; }
			set { this._saveLayoutItem = value; }
		}

		public List<PrOcsInterfaceInsertInfo> InterfaceInsertItem
		{
			get { return this._interfaceInsertItem; }
			set { this._interfaceInsertItem = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public OCS0103U10SaveLayoutArgs() { }

		public OCS0103U10SaveLayoutArgs(List<OCS0103U10SaveLayoutInfo> saveLayoutItem, List<PrOcsInterfaceInsertInfo> interfaceInsertItem, String bunho, String orderDate)
		{
			this._saveLayoutItem = saveLayoutItem;
			this._interfaceInsertItem = interfaceInsertItem;
			this._bunho = bunho;
			this._orderDate = orderDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new IHIS.CloudConnector.Messaging.OCS0103U10SaveLayoutRequest();
		}
	}
}