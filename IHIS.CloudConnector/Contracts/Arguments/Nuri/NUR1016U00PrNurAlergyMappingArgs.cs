using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Nuri;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using NUR1016U00GrdNUR1016ListItemInfo = IHIS.CloudConnector.Contracts.Models.Nuri.NUR1016U00GrdNUR1016ListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NUR1016U00PrNurAlergyMappingArgs : IContractArgs
	{
		private List<NUR1016U00GrdNUR1016ListItemInfo> _grdNUR1016List = new List<NUR1016U00GrdNUR1016ListItemInfo>();
		private String _bunho;
		private String _userId;
		private String _tableId;

		public List<NUR1016U00GrdNUR1016ListItemInfo> GrdNUR1016List
		{
			get { return this._grdNUR1016List; }
			set { this._grdNUR1016List = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String TableId
		{
			get { return this._tableId; }
			set { this._tableId = value; }
		}

		public NUR1016U00PrNurAlergyMappingArgs() { }

		public NUR1016U00PrNurAlergyMappingArgs(List<NUR1016U00GrdNUR1016ListItemInfo> grdNUR1016List, String bunho, String userId, String tableId)
		{
			this._grdNUR1016List = grdNUR1016List;
			this._bunho = bunho;
			this._userId = userId;
			this._tableId = tableId;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUR1016U00PrNurAlergyMappingRequest();
		}
	}
}