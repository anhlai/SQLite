using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201U99GrdOrderListArgs : IContractArgs
	{
		private String _fBunho;
		private String _fFkocs;
		private String _fReserStatus;
		private String _fFlag;
		private String _fReserGubun;
		private String _fReserPart;

		public String FBunho
		{
			get { return this._fBunho; }
			set { this._fBunho = value; }
		}

		public String FFkocs
		{
			get { return this._fFkocs; }
			set { this._fFkocs = value; }
		}

		public String FReserStatus
		{
			get { return this._fReserStatus; }
			set { this._fReserStatus = value; }
		}

		public String FFlag
		{
			get { return this._fFlag; }
			set { this._fFlag = value; }
		}

		public String FReserGubun
		{
			get { return this._fReserGubun; }
			set { this._fReserGubun = value; }
		}

		public String FReserPart
		{
			get { return this._fReserPart; }
			set { this._fReserPart = value; }
		}

		public SchsSCH0201U99GrdOrderListArgs() { }

		public SchsSCH0201U99GrdOrderListArgs(String fBunho, String fFkocs, String fReserStatus, String fFlag, String fReserGubun, String fReserPart)
		{
			this._fBunho = fBunho;
			this._fFkocs = fFkocs;
			this._fReserStatus = fReserStatus;
			this._fFlag = fFlag;
			this._fReserGubun = fReserGubun;
			this._fReserPart = fReserPart;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201U99GrdOrderListRequest();
		}
	}
}