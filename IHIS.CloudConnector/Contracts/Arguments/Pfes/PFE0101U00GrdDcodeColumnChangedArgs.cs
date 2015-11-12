using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Pfes
{
	public class PFE0101U00GrdDcodeColumnChangedArgs : IContractArgs
	{
		private String _rowState;
		private String _colName;
		private String _codeType;
		private String _code;
		private Boolean _mCodeType;

		public String RowState
		{
			get { return this._rowState; }
			set { this._rowState = value; }
		}

		public String ColName
		{
			get { return this._colName; }
			set { this._colName = value; }
		}

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public Boolean MCodeType
		{
			get { return this._mCodeType; }
			set { this._mCodeType = value; }
		}

		public PFE0101U00GrdDcodeColumnChangedArgs() { }

		public PFE0101U00GrdDcodeColumnChangedArgs(String rowState, String colName, String codeType, String code, Boolean mCodeType)
		{
			this._rowState = rowState;
			this._colName = colName;
			this._codeType = codeType;
			this._code = code;
			this._mCodeType = mCodeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new PFE0101U00GrdDcodeColumnChangedRequest();
		}
	}
}