using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OUTSANGU00InitializeArgs : IContractArgs
	{
		private String _bunho;
		private String _gwa;
		private String _ioGubun;
		private String _allSangYn;
		private String _gijunDate;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String AllSangYn
		{
			get { return this._allSangYn; }
			set { this._allSangYn = value; }
		}

		public String GijunDate
		{
			get { return this._gijunDate; }
			set { this._gijunDate = value; }
		}

		public OUTSANGU00InitializeArgs() { }

		public OUTSANGU00InitializeArgs(String bunho, String gwa, String ioGubun, String allSangYn, String gijunDate)
		{
			this._bunho = bunho;
			this._gwa = gwa;
			this._ioGubun = ioGubun;
			this._allSangYn = allSangYn;
			this._gijunDate = gijunDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUTSANGU00InitializeRequest();
		}
	}
}