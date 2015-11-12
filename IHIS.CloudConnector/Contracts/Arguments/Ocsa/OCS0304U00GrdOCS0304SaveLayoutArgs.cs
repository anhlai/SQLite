using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OcsaOCS0304U00GrdOCS0304ListInfo = IHIS.CloudConnector.Contracts.Models.Ocsa.OcsaOCS0304U00GrdOCS0304ListInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0304U00GrdOCS0304SaveLayoutArgs : IContractArgs
	{
		private String _userId;
		private List<OcsaOCS0304U00GrdOCS0304ListInfo> _grdOcs0304List = new List<OcsaOCS0304U00GrdOCS0304ListInfo>();

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public List<OcsaOCS0304U00GrdOCS0304ListInfo> GrdOcs0304List
		{
			get { return this._grdOcs0304List; }
			set { this._grdOcs0304List = value; }
		}

		public OCS0304U00GrdOCS0304SaveLayoutArgs() { }

		public OCS0304U00GrdOCS0304SaveLayoutArgs(String userId, List<OcsaOCS0304U00GrdOCS0304ListInfo> grdOcs0304List)
		{
			this._userId = userId;
			this._grdOcs0304List = grdOcs0304List;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0304U00GrdOCS0304SaveLayoutRequest();
		}
	}
}