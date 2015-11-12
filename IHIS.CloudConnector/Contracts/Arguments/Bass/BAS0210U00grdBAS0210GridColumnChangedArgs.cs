using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0210U00grdBAS0210GridColumnChangedArgs : IContractArgs
	{
		private String _code;
		private String _colName;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public String ColName
		{
			get { return this._colName; }
			set { this._colName = value; }
		}

		public BAS0210U00grdBAS0210GridColumnChangedArgs() { }

		public BAS0210U00grdBAS0210GridColumnChangedArgs(String code, String colName)
		{
			this._code = code;
			this._colName = colName;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0210U00grdBAS0210GridColumnChangedRequest();
		}
	}
}