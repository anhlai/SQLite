using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NuriNUR1016U00UpdateNur1016Args : IContractArgs
	{
		private String _userId;
		private String _pknur1016;
		private String _bunho;
		private String _allergyGubun;
		private String _allergyInfo;
		private String _startDate;
		private String _endDate;
		private String _endSayu;
		private String _inputText;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String Pknur1016
		{
			get { return this._pknur1016; }
			set { this._pknur1016 = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String AllergyGubun
		{
			get { return this._allergyGubun; }
			set { this._allergyGubun = value; }
		}

		public String AllergyInfo
		{
			get { return this._allergyInfo; }
			set { this._allergyInfo = value; }
		}

		public String StartDate
		{
			get { return this._startDate; }
			set { this._startDate = value; }
		}

		public String EndDate
		{
			get { return this._endDate; }
			set { this._endDate = value; }
		}

		public String EndSayu
		{
			get { return this._endSayu; }
			set { this._endSayu = value; }
		}

		public String InputText
		{
			get { return this._inputText; }
			set { this._inputText = value; }
		}

		public NuriNUR1016U00UpdateNur1016Args() { }

		public NuriNUR1016U00UpdateNur1016Args(String userId, String pknur1016, String bunho, String allergyGubun, String allergyInfo, String startDate, String endDate, String endSayu, String inputText)
		{
			this._userId = userId;
			this._pknur1016 = pknur1016;
			this._bunho = bunho;
			this._allergyGubun = allergyGubun;
			this._allergyInfo = allergyInfo;
			this._startDate = startDate;
			this._endDate = endDate;
			this._endSayu = endSayu;
			this._inputText = inputText;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuriNUR1016U00UpdateNur1016Request();
		}
	}
}