using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0101U04GrdMasterGridColumnChangedArgs : IContractArgs
	{
		private String _masterCheck;
		private String _codeType;
		private String _colId;

		public String MasterCheck
		{
			get { return this._masterCheck; }
			set { this._masterCheck = value; }
		}

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public String ColId
		{
			get { return this._colId; }
			set { this._colId = value; }
		}

		public BAS0101U04GrdMasterGridColumnChangedArgs() { }

		public BAS0101U04GrdMasterGridColumnChangedArgs(String masterCheck, String codeType, String colId)
		{
			this._masterCheck = masterCheck;
			this._codeType = codeType;
			this._colId = colId;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0101U04GrdMasterGridColumnChangedRequest();
		}
	}
}