using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OCS0150Q00GridOCS0150Info = IHIS.CloudConnector.Contracts.Models.Ocsa.OCS0150Q00GridOCS0150Info;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0150Q00SaveLayoutForGridOCS0150Args : IContractArgs
	{
		private List<OCS0150Q00GridOCS0150Info> _gridOcs0150Info = new List<OCS0150Q00GridOCS0150Info>();
		private String _userId;

		public List<OCS0150Q00GridOCS0150Info> GridOcs0150Info
		{
			get { return this._gridOcs0150Info; }
			set { this._gridOcs0150Info = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public OCS0150Q00SaveLayoutForGridOCS0150Args() { }

		public OCS0150Q00SaveLayoutForGridOCS0150Args(List<OCS0150Q00GridOCS0150Info> gridOcs0150Info, String userId)
		{
			this._gridOcs0150Info = gridOcs0150Info;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0150Q00SaveLayoutForGridOCS0150Request();
		}
	}
}