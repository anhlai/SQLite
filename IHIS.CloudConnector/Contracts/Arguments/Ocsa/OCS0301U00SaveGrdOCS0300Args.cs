using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OCS0301U00MembGrdInfo = IHIS.CloudConnector.Contracts.Models.Ocsa.OCS0301U00MembGrdInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class OCS0301U00SaveGrdOCS0300Args : IContractArgs
	{
		private List<OCS0301U00MembGrdInfo> _grdOCS0300Info = new List<OCS0301U00MembGrdInfo>();
		private String _userId;

		public List<OCS0301U00MembGrdInfo> GrdOCS0300Info
		{
			get { return this._grdOCS0300Info; }
			set { this._grdOCS0300Info = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public OCS0301U00SaveGrdOCS0300Args() { }

		public OCS0301U00SaveGrdOCS0300Args(List<OCS0301U00MembGrdInfo> grdOCS0300Info, String userId)
		{
			this._grdOCS0300Info = grdOCS0300Info;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0301U00SaveGrdOCS0300Request();
		}
	}
}