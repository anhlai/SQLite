using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U17IsJundalTableArgs : IContractArgs
	{
		private String _hangmogCode;
		private String _ioGubun;
		private String _jundalTable;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String JundalTable
		{
			get { return this._jundalTable; }
			set { this._jundalTable = value; }
		}

		public OCS0103U17IsJundalTableArgs() { }

		public OCS0103U17IsJundalTableArgs(String hangmogCode, String ioGubun, String jundalTable)
		{
			this._hangmogCode = hangmogCode;
			this._ioGubun = ioGubun;
			this._jundalTable = jundalTable;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U17IsJundalTableRequest();
		}
	}
}