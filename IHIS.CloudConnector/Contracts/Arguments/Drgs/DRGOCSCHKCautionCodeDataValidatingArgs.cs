using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRGOCSCHKCautionCodeDataValidatingArgs : IContractArgs
	{
		private String _cautionCode;

		public String CautionCode
		{
			get { return this._cautionCode; }
			set { this._cautionCode = value; }
		}

		public DRGOCSCHKCautionCodeDataValidatingArgs() { }

		public DRGOCSCHKCautionCodeDataValidatingArgs(String cautionCode)
		{
			this._cautionCode = cautionCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRGOCSCHKCautionCodeDataValidatingRequest();
		}
	}
}