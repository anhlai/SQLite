using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OcsaOCS0304U00GrdOCS0306ListInfo = IHIS.CloudConnector.Contracts.Models.Ocsa.OcsaOCS0304U00GrdOCS0306ListInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0304U00GrdOCS0306SaveLayoutArgs : IContractArgs
	{
		private String _userId;
		private List<OcsaOCS0304U00GrdOCS0306ListInfo> _grdOcs0306List = new List<OcsaOCS0304U00GrdOCS0306ListInfo>();

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public List<OcsaOCS0304U00GrdOCS0306ListInfo> GrdOcs0306List
		{
			get { return this._grdOcs0306List; }
			set { this._grdOcs0306List = value; }
		}

		public OCS0304U00GrdOCS0306SaveLayoutArgs() { }

		public OCS0304U00GrdOCS0306SaveLayoutArgs(String userId, List<OcsaOCS0304U00GrdOCS0306ListInfo> grdOcs0306List)
		{
			this._userId = userId;
			this._grdOcs0306List = grdOcs0306List;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0304U00GrdOCS0306SaveLayoutRequest();
		}
	}
}