using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using INJ1002U01GrdOrderListItemInfo = IHIS.CloudConnector.Contracts.Models.Injs.INJ1002U01GrdOrderListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ1002U01SaveLayoutArgs : IContractArgs
	{
		private List<INJ1002U01GrdOrderListItemInfo> _grdOrderInfo = new List<INJ1002U01GrdOrderListItemInfo>();

		public List<INJ1002U01GrdOrderListItemInfo> GrdOrderInfo
		{
			get { return this._grdOrderInfo; }
			set { this._grdOrderInfo = value; }
		}

		public INJ1002U01SaveLayoutArgs() { }

		public INJ1002U01SaveLayoutArgs(List<INJ1002U01GrdOrderListItemInfo> grdOrderInfo)
		{
			this._grdOrderInfo = grdOrderInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new INJ1002U01SaveLayoutRequest();
		}
	}
}