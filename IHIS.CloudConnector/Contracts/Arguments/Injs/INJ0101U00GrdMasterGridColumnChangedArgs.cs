using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ0101U00GrdMasterGridColumnChangedArgs : IContractArgs
	{
		private String _codeType;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public INJ0101U00GrdMasterGridColumnChangedArgs() { }

		public INJ0101U00GrdMasterGridColumnChangedArgs(String codeType)
		{
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new INJ0101U00GrdMasterGridColumnChangedRequest();
		}
	}
}