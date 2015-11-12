using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class HIOcsCheckJundalPartLoadJaeryoJundalArgs : IContractArgs
	{
		private String _ioGubun;
		private String _hangmogCode;
		private String _jundalTable;
		private String _jundalPart;
		private String _orderDate;
		private String _inputPart;

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String JundalTable
		{
			get { return this._jundalTable; }
			set { this._jundalTable = value; }
		}

		public String JundalPart
		{
			get { return this._jundalPart; }
			set { this._jundalPart = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public String InputPart
		{
			get { return this._inputPart; }
			set { this._inputPart = value; }
		}

		public HIOcsCheckJundalPartLoadJaeryoJundalArgs() { }

		public HIOcsCheckJundalPartLoadJaeryoJundalArgs(String ioGubun, String hangmogCode, String jundalTable, String jundalPart, String orderDate, String inputPart)
		{
			this._ioGubun = ioGubun;
			this._hangmogCode = hangmogCode;
			this._jundalTable = jundalTable;
			this._jundalPart = jundalPart;
			this._orderDate = orderDate;
			this._inputPart = inputPart;
		}

		public IExtensible GetRequestInstance()
		{
			return new HIOcsCheckJundalPartLoadJaeryoJundalRequest();
		}
	}
}