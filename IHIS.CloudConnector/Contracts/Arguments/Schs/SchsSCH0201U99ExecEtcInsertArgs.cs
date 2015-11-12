using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201U99ExecEtcInsertArgs : IContractArgs
	{
		private String _iBunho;
		private String _iJundalTable;
		private String _iJundalPart;
		private String _iHangmogCode;
		private String _iUserId;

		public String IBunho
		{
			get { return this._iBunho; }
			set { this._iBunho = value; }
		}

		public String IJundalTable
		{
			get { return this._iJundalTable; }
			set { this._iJundalTable = value; }
		}

		public String IJundalPart
		{
			get { return this._iJundalPart; }
			set { this._iJundalPart = value; }
		}

		public String IHangmogCode
		{
			get { return this._iHangmogCode; }
			set { this._iHangmogCode = value; }
		}

		public String IUserId
		{
			get { return this._iUserId; }
			set { this._iUserId = value; }
		}

		public SchsSCH0201U99ExecEtcInsertArgs() { }

		public SchsSCH0201U99ExecEtcInsertArgs(String iBunho, String iJundalTable, String iJundalPart, String iHangmogCode, String iUserId)
		{
			this._iBunho = iBunho;
			this._iJundalTable = iJundalTable;
			this._iJundalPart = iJundalPart;
			this._iHangmogCode = iHangmogCode;
			this._iUserId = iUserId;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201U99ExecEtcInsertRequest();
		}
	}
}