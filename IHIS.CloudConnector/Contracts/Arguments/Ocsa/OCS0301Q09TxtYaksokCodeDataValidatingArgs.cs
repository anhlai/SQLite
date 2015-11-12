using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0301Q09TxtYaksokCodeDataValidatingArgs : IContractArgs
	{
		private String _yaksokOpenId;
		private String _yaksokCode;

		public String YaksokOpenId
		{
			get { return this._yaksokOpenId; }
			set { this._yaksokOpenId = value; }
		}

		public String YaksokCode
		{
			get { return this._yaksokCode; }
			set { this._yaksokCode = value; }
		}

		public OCS0301Q09TxtYaksokCodeDataValidatingArgs() { }

		public OCS0301Q09TxtYaksokCodeDataValidatingArgs(String yaksokOpenId, String yaksokCode)
		{
			this._yaksokOpenId = yaksokOpenId;
			this._yaksokCode = yaksokCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0301Q09TxtYaksokCodeDataValidatingRequest();
		}
	}
}