using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0000Q00ScreenOpenUpdateArgs : IContractArgs
	{
		private String _userId;
		private String _doctor;
		private String _bunho;
		private String _jundalTable;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String JundalTable
		{
			get { return this._jundalTable; }
			set { this._jundalTable = value; }
		}

		public CPL0000Q00ScreenOpenUpdateArgs() { }

		public CPL0000Q00ScreenOpenUpdateArgs(String userId, String doctor, String bunho, String jundalTable)
		{
			this._userId = userId;
			this._doctor = doctor;
			this._bunho = bunho;
			this._jundalTable = jundalTable;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0000Q00ScreenOpenUpdateRequest();
		}
	}
}