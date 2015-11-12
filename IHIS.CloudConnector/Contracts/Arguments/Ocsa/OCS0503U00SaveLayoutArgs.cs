using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OCS0503U00gridOSC0503ListInfo = IHIS.CloudConnector.Contracts.Models.Ocsa.OCS0503U00gridOSC0503ListInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0503U00SaveLayoutArgs : IContractArgs
	{
		private List<OCS0503U00gridOSC0503ListInfo> _grdOcs0503Item = new List<OCS0503U00gridOSC0503ListInfo>();
		private String _userId;

		public List<OCS0503U00gridOSC0503ListInfo> GrdOcs0503Item
		{
			get { return this._grdOcs0503Item; }
			set { this._grdOcs0503Item = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public OCS0503U00SaveLayoutArgs() { }

		public OCS0503U00SaveLayoutArgs(List<OCS0503U00gridOSC0503ListInfo> grdOcs0503Item, String userId)
		{
			this._grdOcs0503Item = grdOcs0503Item;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0503U00SaveLayoutRequest();
		}
	}
}