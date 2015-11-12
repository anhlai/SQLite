using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201U99ReserTimeChkArgs : IContractArgs
	{
		private String _bunho;
		private String _reserDate;
		private String _reserTime;
		private String _pksch0201;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String ReserDate
		{
			get { return this._reserDate; }
			set { this._reserDate = value; }
		}

		public String ReserTime
		{
			get { return this._reserTime; }
			set { this._reserTime = value; }
		}

		public String Pksch0201
		{
			get { return this._pksch0201; }
			set { this._pksch0201 = value; }
		}

		public SchsSCH0201U99ReserTimeChkArgs() { }

		public SchsSCH0201U99ReserTimeChkArgs(String bunho, String reserDate, String reserTime, String pksch0201)
		{
			this._bunho = bunho;
			this._reserDate = reserDate;
			this._reserTime = reserTime;
			this._pksch0201 = pksch0201;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201U99ReserTimeChkRequest();
		}
	}
}