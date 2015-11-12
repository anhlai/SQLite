using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
    [Serializable]
	public class NUR1017U00GetComboListArgs : IContractArgs
	{
		private String _codeTypeXEditGridCell1;
		private String _codeTypeXEditGridCell5;
		private String _codeTypeXEditGridCell6;
		private String _codeTypeLayComboSet;

		public String CodeTypeXEditGridCell1
		{
			get { return this._codeTypeXEditGridCell1; }
			set { this._codeTypeXEditGridCell1 = value; }
		}

		public String CodeTypeXEditGridCell5
		{
			get { return this._codeTypeXEditGridCell5; }
			set { this._codeTypeXEditGridCell5 = value; }
		}

		public String CodeTypeXEditGridCell6
		{
			get { return this._codeTypeXEditGridCell6; }
			set { this._codeTypeXEditGridCell6 = value; }
		}

		public String CodeTypeLayComboSet
		{
			get { return this._codeTypeLayComboSet; }
			set { this._codeTypeLayComboSet = value; }
		}

		public NUR1017U00GetComboListArgs() { }

		public NUR1017U00GetComboListArgs(String codeTypeXEditGridCell1, String codeTypeXEditGridCell5, String codeTypeXEditGridCell6, String codeTypeLayComboSet)
		{
			this._codeTypeXEditGridCell1 = codeTypeXEditGridCell1;
			this._codeTypeXEditGridCell5 = codeTypeXEditGridCell5;
			this._codeTypeXEditGridCell6 = codeTypeXEditGridCell6;
			this._codeTypeLayComboSet = codeTypeLayComboSet;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUR1017U00GetComboListRequest();
		}
	}
}