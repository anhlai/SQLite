using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NUR0101U01GrdMasterGridColumnChangedArgs : IContractArgs
	{
		private String _codeType;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public NUR0101U01GrdMasterGridColumnChangedArgs() { }

		public NUR0101U01GrdMasterGridColumnChangedArgs(String codeType)
		{
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUR0101U01GrdMasterGridColumnChangedRequest();
		}
	}
}