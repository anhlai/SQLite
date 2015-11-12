using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201U99GetJundalPartNameArgs : IContractArgs
	{
		private String _ioGubun;
		private String _jundalPart;
		private String _today;

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String JundalPart
		{
			get { return this._jundalPart; }
			set { this._jundalPart = value; }
		}

		public String Today
		{
			get { return this._today; }
			set { this._today = value; }
		}

		public SchsSCH0201U99GetJundalPartNameArgs() { }

		public SchsSCH0201U99GetJundalPartNameArgs(String ioGubun, String jundalPart, String today)
		{
			this._ioGubun = ioGubun;
			this._jundalPart = jundalPart;
			this._today = today;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201U99GetJundalPartNameRequest();
		}
	}
}