using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NuriNUR1016U00UpdateCancelStatusArgs : IContractArgs
	{
		private String _userId;
		private String _pknur1016;
		private String _bunho;
		private String _allergyGubun;
		private String _startDate;

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

		public String StartDate
		{
			get { return this._startDate; }
			set { this._startDate = value; }
		}

		public NuriNUR1016U00UpdateCancelStatusArgs() { }

		public NuriNUR1016U00UpdateCancelStatusArgs(String userId, String pknur1016, String bunho, String allergyGubun, String startDate)
		{
			this._userId = userId;
			this._pknur1016 = pknur1016;
			this._bunho = bunho;
			this._allergyGubun = allergyGubun;
			this._startDate = startDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuriNUR1016U00UpdateCancelStatusRequest();
		}
	}
}