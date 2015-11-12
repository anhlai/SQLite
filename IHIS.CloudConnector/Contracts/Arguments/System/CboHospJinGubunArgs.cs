using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class CboHospJinGubunArgs : IContractArgs
	{
		private String _codeType;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public CboHospJinGubunArgs() { }

		public CboHospJinGubunArgs(String codeType)
		{
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new CboHospJinGubunRequest();
		}
	}
}