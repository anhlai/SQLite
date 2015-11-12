using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OcsaOCS0304U00GrdOCS0305ListInfo = IHIS.CloudConnector.Contracts.Models.Ocsa.OcsaOCS0304U00GrdOCS0305ListInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0304U00GrdOCS0305SaveLayoutArgs : IContractArgs
	{
		private String _userId;
		private List<OcsaOCS0304U00GrdOCS0305ListInfo> _grdOcs0305List = new List<OcsaOCS0304U00GrdOCS0305ListInfo>();

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public List<OcsaOCS0304U00GrdOCS0305ListInfo> GrdOcs0305List
		{
			get { return this._grdOcs0305List; }
			set { this._grdOcs0305List = value; }
		}

		public OCS0304U00GrdOCS0305SaveLayoutArgs() { }

		public OCS0304U00GrdOCS0305SaveLayoutArgs(String userId, List<OcsaOCS0304U00GrdOCS0305ListInfo> grdOcs0305List)
		{
			this._userId = userId;
			this._grdOcs0305List = grdOcs0305List;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0304U00GrdOCS0305SaveLayoutRequest();
		}
	}
}