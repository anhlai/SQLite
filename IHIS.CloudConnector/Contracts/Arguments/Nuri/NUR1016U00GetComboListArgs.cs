using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
    [Serializable]
	public class NUR1016U00GetComboListArgs : IContractArgs
	{
		private String _codeTypeLayComboSet;

		public String CodeTypeLayComboSet
		{
			get { return this._codeTypeLayComboSet; }
			set { this._codeTypeLayComboSet = value; }
		}

		public NUR1016U00GetComboListArgs() { }

		public NUR1016U00GetComboListArgs(String codeTypeLayComboSet)
		{
			this._codeTypeLayComboSet = codeTypeLayComboSet;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUR1016U00GetComboListRequest();
		}
	}
}