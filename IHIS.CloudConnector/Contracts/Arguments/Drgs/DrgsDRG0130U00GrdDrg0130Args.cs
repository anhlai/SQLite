using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG0130U00GrdDrg0130Args : IContractArgs
	{
		private String _cautionCode;

		public String CautionCode
		{
			get { return this._cautionCode; }
			set { this._cautionCode = value; }
		}

		public DrgsDRG0130U00GrdDrg0130Args() { }

		public DrgsDRG0130U00GrdDrg0130Args(String cautionCode)
		{
			this._cautionCode = cautionCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG0130U00GrdDrg0130Request();
		}
	}
}