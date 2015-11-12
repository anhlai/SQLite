using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ1001U01LayCommonArgs : IContractArgs
	{
		private String _userId;
		private String _hospCode;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public INJ1001U01LayCommonArgs() { }

		public INJ1001U01LayCommonArgs(String userId, String hospCode)
		{
			this._userId = userId;
			this._hospCode = hospCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new INJ1001U01LayCommonRequest();
		}
	}
}