using System;
using ProtoBuf;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0301Q09SetUserCheckBoxArgs : IContractArgs
	{
		private String _memb;
		private String _gwa;
		private LoadColumnCodeNameInfo _gwaAllName;
		private LoadColumnCodeNameInfo _gwaDoctorName;
		private LoadColumnCodeNameInfo _userIdName;

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public LoadColumnCodeNameInfo GwaAllName
		{
			get { return this._gwaAllName; }
			set { this._gwaAllName = value; }
		}

		public LoadColumnCodeNameInfo GwaDoctorName
		{
			get { return this._gwaDoctorName; }
			set { this._gwaDoctorName = value; }
		}

		public LoadColumnCodeNameInfo UserIdName
		{
			get { return this._userIdName; }
			set { this._userIdName = value; }
		}

		public OCS0301Q09SetUserCheckBoxArgs() { }

		public OCS0301Q09SetUserCheckBoxArgs(String memb, String gwa, LoadColumnCodeNameInfo gwaAllName, LoadColumnCodeNameInfo gwaDoctorName, LoadColumnCodeNameInfo userIdName)
		{
			this._memb = memb;
			this._gwa = gwa;
			this._gwaAllName = gwaAllName;
			this._gwaDoctorName = gwaDoctorName;
			this._userIdName = userIdName;
		}

		public IExtensible GetRequestInstance()
		{
			return new IHIS.CloudConnector.Messaging.OCS0301Q09SetUserCheckBoxRequest();
		}
	}
}