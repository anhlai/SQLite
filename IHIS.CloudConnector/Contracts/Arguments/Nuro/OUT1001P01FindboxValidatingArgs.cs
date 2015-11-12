using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class OUT1001P01FindboxValidatingArgs : IContractArgs
	{
		private String _startDate;
		private String _find1;
		private String _gwa;
		private String _controlName;

		public String StartDate
		{
			get { return this._startDate; }
			set { this._startDate = value; }
		}

		public String Find1
		{
			get { return this._find1; }
			set { this._find1 = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String ControlName
		{
			get { return this._controlName; }
			set { this._controlName = value; }
		}

		public OUT1001P01FindboxValidatingArgs() { }

		public OUT1001P01FindboxValidatingArgs(String startDate, String find1, String gwa, String controlName)
		{
			this._startDate = startDate;
			this._find1 = find1;
			this._gwa = gwa;
			this._controlName = controlName;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUT1001P01FindboxValidatingRequest();
		}
	}
}