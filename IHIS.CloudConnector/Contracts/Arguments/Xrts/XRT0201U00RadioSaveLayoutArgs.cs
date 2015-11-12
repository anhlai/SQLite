using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using XRT0201U00GrdRadioListItemInfo = IHIS.CloudConnector.Contracts.Models.Xrts.XRT0201U00GrdRadioListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0201U00RadioSaveLayoutArgs : IContractArgs
	{
		private List<XRT0201U00GrdRadioListItemInfo> _grdRadioListItemInfo = new List<XRT0201U00GrdRadioListItemInfo>();
		private String _userId;

		public List<XRT0201U00GrdRadioListItemInfo> GrdRadioListItemInfo
		{
			get { return this._grdRadioListItemInfo; }
			set { this._grdRadioListItemInfo = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public XRT0201U00RadioSaveLayoutArgs() { }

		public XRT0201U00RadioSaveLayoutArgs(List<XRT0201U00GrdRadioListItemInfo> grdRadioListItemInfo, String userId)
		{
			this._grdRadioListItemInfo = grdRadioListItemInfo;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new XRT0201U00RadioSaveLayoutRequest();
		}
	}
}