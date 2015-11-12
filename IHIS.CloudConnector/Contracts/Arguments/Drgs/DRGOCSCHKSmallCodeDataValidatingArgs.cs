using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRGOCSCHKSmallCodeDataValidatingArgs : IContractArgs
	{
		private String _code1;

		public String Code1
		{
			get { return this._code1; }
			set { this._code1 = value; }
		}

		public DRGOCSCHKSmallCodeDataValidatingArgs() { }

		public DRGOCSCHKSmallCodeDataValidatingArgs(String code1)
		{
			this._code1 = code1;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRGOCSCHKSmallCodeDataValidatingRequest();
		}
	}
}