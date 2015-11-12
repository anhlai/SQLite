using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using CPL3010U00LayUrineInfo = IHIS.CloudConnector.Contracts.Models.Cpls.CPL3010U00LayUrineInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3010U00SaveLayUrineArgs : IContractArgs
	{
		private List<CPL3010U00LayUrineInfo> _urineInfo = new List<CPL3010U00LayUrineInfo>();
		private String _userId;

		public List<CPL3010U00LayUrineInfo> UrineInfo
		{
			get { return this._urineInfo; }
			set { this._urineInfo = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public CPL3010U00SaveLayUrineArgs() { }

		public CPL3010U00SaveLayUrineArgs(List<CPL3010U00LayUrineInfo> urineInfo, String userId)
		{
			this._urineInfo = urineInfo;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3010U00SaveLayUrineRequest();
		}
	}
}