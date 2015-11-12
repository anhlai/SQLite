using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ1001U01FormJusaBedLayHosilListArgs : IContractArgs
	{
		private String _hospCode;

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public INJ1001U01FormJusaBedLayHosilListArgs() { }

		public INJ1001U01FormJusaBedLayHosilListArgs(String hospCode)
		{
			this._hospCode = hospCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new INJ1001U01FormJusaBedLayHosilListRequest();
		}
	}
}