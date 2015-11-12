using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class LoadSearchOrder2RequestInfo
	{
		private String _searchWord;
		private String _gijunDate;
		private String _inputTab;
		private String _wonnaeDrgYn;
		private String _searchCondition;

		public String SearchWord
		{
			get { return this._searchWord; }
			set { this._searchWord = value; }
		}

		public String GijunDate
		{
			get { return this._gijunDate; }
			set { this._gijunDate = value; }
		}

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public String WonnaeDrgYn
		{
			get { return this._wonnaeDrgYn; }
			set { this._wonnaeDrgYn = value; }
		}

		public String SearchCondition
		{
			get { return this._searchCondition; }
			set { this._searchCondition = value; }
		}

		public LoadSearchOrder2RequestInfo() { }

		public LoadSearchOrder2RequestInfo(String searchWord, String gijunDate, String inputTab, String wonnaeDrgYn, String searchCondition)
		{
			this._searchWord = searchWord;
			this._gijunDate = gijunDate;
			this._inputTab = inputTab;
			this._wonnaeDrgYn = wonnaeDrgYn;
			this._searchCondition = searchCondition;
		}

	}
}