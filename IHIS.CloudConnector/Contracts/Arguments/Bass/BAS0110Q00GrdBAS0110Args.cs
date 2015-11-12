using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0110Q00GrdBAS0110Args : IContractArgs
	{
		private String _johapGubun;
		private String _searchGubun;
		private String _searchWord;

		public String JohapGubun
		{
			get { return this._johapGubun; }
			set { this._johapGubun = value; }
		}

		public String SearchGubun
		{
			get { return this._searchGubun; }
			set { this._searchGubun = value; }
		}

		public String SearchWord
		{
			get { return this._searchWord; }
			set { this._searchWord = value; }
		}

		public BAS0110Q00GrdBAS0110Args() { }

		public BAS0110Q00GrdBAS0110Args(String johapGubun, String searchGubun, String searchWord)
		{
			this._johapGubun = johapGubun;
			this._searchGubun = searchGubun;
			this._searchWord = searchWord;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0110Q00GrdBAS0110Request();
		}
	}
}