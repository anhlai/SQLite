using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG0130U00CautionCodeArgs : IContractArgs
	{
		private String _cautionCode;

		public String CautionCode
		{
			get { return this._cautionCode; }
			set { this._cautionCode = value; }
		}

		public DrgsDRG0130U00CautionCodeArgs() { }

		public DrgsDRG0130U00CautionCodeArgs(String cautionCode)
		{
			this._cautionCode = cautionCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG0130U00CautionCodeRequest();
		}
	}
}