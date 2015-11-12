using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRGOCSCHKPreSmallCodeDataValidatingArgs : IContractArgs
	{
		private String _code;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public DRGOCSCHKPreSmallCodeDataValidatingArgs() { }

		public DRGOCSCHKPreSmallCodeDataValidatingArgs(String code)
		{
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRGOCSCHKPreSmallCodeDataValidatingRequest();
		}
	}
}