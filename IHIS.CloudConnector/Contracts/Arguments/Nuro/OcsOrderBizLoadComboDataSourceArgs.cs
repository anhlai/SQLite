using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class OcsOrderBizLoadComboDataSourceArgs : IContractArgs
	{
		private String _aColName;
		private String _aArgu1;
		private String _aArgu2;
		private String _aArgu3;

		public String AColName
		{
			get { return this._aColName; }
			set { this._aColName = value; }
		}

		public String AArgu1
		{
			get { return this._aArgu1; }
			set { this._aArgu1 = value; }
		}

		public String AArgu2
		{
			get { return this._aArgu2; }
			set { this._aArgu2 = value; }
		}

		public String AArgu3
		{
			get { return this._aArgu3; }
			set { this._aArgu3 = value; }
		}

		public OcsOrderBizLoadComboDataSourceArgs() { }

		public OcsOrderBizLoadComboDataSourceArgs(String aColName, String aArgu1, String aArgu2, String aArgu3)
		{
			this._aColName = aColName;
			this._aArgu1 = aArgu1;
			this._aArgu2 = aArgu2;
			this._aArgu3 = aArgu3;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsOrderBizLoadComboDataSourceRequest();
		}
	}
}