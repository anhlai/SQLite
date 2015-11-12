using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using Ocs0131U01Grd0131ListItemInfo = IHIS.CloudConnector.Contracts.Models.Ocsa.Ocs0131U01Grd0131ListItemInfo;
using Ocs0131U01Grd0132ListItemInfo = IHIS.CloudConnector.Contracts.Models.Ocsa.Ocs0131U01Grd0132ListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class Ocs0131U01SaveLayoutArgs : IContractArgs
	{
		private List<Ocs0131U01Grd0131ListItemInfo> _grd0131Item = new List<Ocs0131U01Grd0131ListItemInfo>();
		private List<Ocs0131U01Grd0132ListItemInfo> _grd0132Item = new List<Ocs0131U01Grd0132ListItemInfo>();
		private String _userId;

		public List<Ocs0131U01Grd0131ListItemInfo> Grd0131Item
		{
			get { return this._grd0131Item; }
			set { this._grd0131Item = value; }
		}

		public List<Ocs0131U01Grd0132ListItemInfo> Grd0132Item
		{
			get { return this._grd0132Item; }
			set { this._grd0132Item = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public Ocs0131U01SaveLayoutArgs() { }

		public Ocs0131U01SaveLayoutArgs(List<Ocs0131U01Grd0131ListItemInfo> grd0131Item, List<Ocs0131U01Grd0132ListItemInfo> grd0132Item, String userId)
		{
			this._grd0131Item = grd0131Item;
			this._grd0132Item = grd0132Item;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new Ocs0131U01SaveLayoutRequest();
		}
	}
}