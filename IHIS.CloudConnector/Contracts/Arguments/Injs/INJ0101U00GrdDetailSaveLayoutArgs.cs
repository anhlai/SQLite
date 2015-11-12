using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using INJ0101U00GrdDetailInfo = IHIS.CloudConnector.Contracts.Models.Injs.INJ0101U00GrdDetailInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ0101U00GrdDetailSaveLayoutArgs : IContractArgs
	{
		private String _userId;
		private List<INJ0101U00GrdDetailInfo> _grdList = new List<INJ0101U00GrdDetailInfo>();

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public List<INJ0101U00GrdDetailInfo> GrdList
		{
			get { return this._grdList; }
			set { this._grdList = value; }
		}

		public INJ0101U00GrdDetailSaveLayoutArgs() { }

		public INJ0101U00GrdDetailSaveLayoutArgs(String userId, List<INJ0101U00GrdDetailInfo> grdList)
		{
			this._userId = userId;
			this._grdList = grdList;
		}

		public IExtensible GetRequestInstance()
		{
			return new INJ0101U00GrdDetailSaveLayoutRequest();
		}
	}
}