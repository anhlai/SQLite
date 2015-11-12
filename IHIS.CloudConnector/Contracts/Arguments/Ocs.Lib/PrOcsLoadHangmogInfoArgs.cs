using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class PrOcsLoadHangmogInfoArgs : IContractArgs
	{
		private String _appDate;
		private String _inputPart;
		private String _inputGwa;
		private String _hangmogCode;
		private String _inputTab;

		public String AppDate
		{
			get { return this._appDate; }
			set { this._appDate = value; }
		}

		public String InputPart
		{
			get { return this._inputPart; }
			set { this._inputPart = value; }
		}

		public String InputGwa
		{
			get { return this._inputGwa; }
			set { this._inputGwa = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public PrOcsLoadHangmogInfoArgs() { }

		public PrOcsLoadHangmogInfoArgs(String appDate, String inputPart, String inputGwa, String hangmogCode, String inputTab)
		{
			this._appDate = appDate;
			this._inputPart = inputPart;
			this._inputGwa = inputGwa;
			this._hangmogCode = hangmogCode;
			this._inputTab = inputTab;
		}

		public IExtensible GetRequestInstance()
		{
			return new PrOcsLoadHangmogInfoRequest();
		}
	}
}