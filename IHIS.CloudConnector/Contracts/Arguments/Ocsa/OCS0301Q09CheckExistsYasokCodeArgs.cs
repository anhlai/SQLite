using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0301Q09CheckExistsYasokCodeArgs : IContractArgs
	{
		private String _yaksokOpenId;
		private String _yasokCode;

		public String YaksokOpenId
		{
			get { return this._yaksokOpenId; }
			set { this._yaksokOpenId = value; }
		}

		public String YasokCode
		{
			get { return this._yasokCode; }
			set { this._yasokCode = value; }
		}

		public OCS0301Q09CheckExistsYasokCodeArgs() { }

		public OCS0301Q09CheckExistsYasokCodeArgs(String yaksokOpenId, String yasokCode)
		{
			this._yaksokOpenId = yaksokOpenId;
			this._yasokCode = yasokCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0301Q09CheckExistsYasokCodeRequest();
		}
	}
}