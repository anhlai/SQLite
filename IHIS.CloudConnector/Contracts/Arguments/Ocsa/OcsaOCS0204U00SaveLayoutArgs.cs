using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OcsaOCS0204U00GrdOCS0204ListInfo = IHIS.CloudConnector.Contracts.Models.Ocsa.OcsaOCS0204U00GrdOCS0204ListInfo;
using OcsaOCS0204U00GrdOCS0205ListInfo = IHIS.CloudConnector.Contracts.Models.Ocsa.OcsaOCS0204U00GrdOCS0205ListInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OcsaOCS0204U00SaveLayoutArgs : IContractArgs
	{
		private List<OcsaOCS0204U00GrdOCS0204ListInfo> _grd0204SaveItem = new List<OcsaOCS0204U00GrdOCS0204ListInfo>();
		private List<OcsaOCS0204U00GrdOCS0205ListInfo> _grd0205SaveItem = new List<OcsaOCS0204U00GrdOCS0205ListInfo>();
		private String _userId;

		public List<OcsaOCS0204U00GrdOCS0204ListInfo> Grd0204SaveItem
		{
			get { return this._grd0204SaveItem; }
			set { this._grd0204SaveItem = value; }
		}

		public List<OcsaOCS0204U00GrdOCS0205ListInfo> Grd0205SaveItem
		{
			get { return this._grd0205SaveItem; }
			set { this._grd0205SaveItem = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public OcsaOCS0204U00SaveLayoutArgs() { }

		public OcsaOCS0204U00SaveLayoutArgs(List<OcsaOCS0204U00GrdOCS0204ListInfo> grd0204SaveItem, List<OcsaOCS0204U00GrdOCS0205ListInfo> grd0205SaveItem, String userId)
		{
			this._grd0204SaveItem = grd0204SaveItem;
			this._grd0205SaveItem = grd0205SaveItem;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsaOCS0204U00SaveLayoutRequest();
		}
	}
}