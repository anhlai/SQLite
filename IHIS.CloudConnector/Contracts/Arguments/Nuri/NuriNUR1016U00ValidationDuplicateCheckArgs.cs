using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NuriNUR1016U00ValidationDuplicateCheckArgs : IContractArgs
	{
		private String _bunho;
		private String _allergyGubun;
		private String _startDate;

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

		public NuriNUR1016U00ValidationDuplicateCheckArgs() { }

		public NuriNUR1016U00ValidationDuplicateCheckArgs(String bunho, String allergyGubun, String startDate)
		{
			this._bunho = bunho;
			this._allergyGubun = allergyGubun;
			this._startDate = startDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuriNUR1016U00ValidationDuplicateCheckRequest();
		}
	}
}