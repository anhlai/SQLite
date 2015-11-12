using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0102U01GrdMasterCheckArgs : IContractArgs
	{
		private String _codeType;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public DRG0102U01GrdMasterCheckArgs() { }

		public DRG0102U01GrdMasterCheckArgs(String codeType)
		{
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG0102U01GrdMasterCheckRequest();
		}
	}
}