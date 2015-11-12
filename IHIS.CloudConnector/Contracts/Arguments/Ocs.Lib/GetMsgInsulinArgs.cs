using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class GetMsgInsulinArgs : IContractArgs
	{
		private String _directGubun;
		private String _hangmogCode;

		public String DirectGubun
		{
			get { return this._directGubun; }
			set { this._directGubun = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public GetMsgInsulinArgs() { }

		public GetMsgInsulinArgs(String directGubun, String hangmogCode)
		{
			this._directGubun = directGubun;
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new GetMsgInsulinRequest();
		}
	}
}