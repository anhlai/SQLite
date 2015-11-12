using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class LoadOftenUsedInfo
	{
		private String _membGubun;
		private String _memb;
		private String _orderGubun;
		private String _wonnaeDrgYn;
		private String _searchWord;

		public String MembGubun
		{
			get { return this._membGubun; }
			set { this._membGubun = value; }
		}

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public String OrderGubun
		{
			get { return this._orderGubun; }
			set { this._orderGubun = value; }
		}

		public String WonnaeDrgYn
		{
			get { return this._wonnaeDrgYn; }
			set { this._wonnaeDrgYn = value; }
		}

		public String SearchWord
		{
			get { return this._searchWord; }
			set { this._searchWord = value; }
		}

		public LoadOftenUsedInfo() { }

		public LoadOftenUsedInfo(String membGubun, String memb, String orderGubun, String wonnaeDrgYn, String searchWord)
		{
			this._membGubun = membGubun;
			this._memb = memb;
			this._orderGubun = orderGubun;
			this._wonnaeDrgYn = wonnaeDrgYn;
			this._searchWord = searchWord;
		}

	}
}