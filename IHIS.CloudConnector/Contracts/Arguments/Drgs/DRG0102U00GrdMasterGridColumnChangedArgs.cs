using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0102U00GrdMasterGridColumnChangedArgs : IContractArgs
	{
		private String _codeType;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public DRG0102U00GrdMasterGridColumnChangedArgs() { }

		public DRG0102U00GrdMasterGridColumnChangedArgs(String codeType)
		{
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG0102U00GrdMasterGridColumnChangedRequest();
		}
	}
}