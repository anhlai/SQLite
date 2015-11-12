using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3020U00FwkResultGetYArgs : IContractArgs
	{
		private String _resultForm;

		public String ResultForm
		{
			get { return this._resultForm; }
			set { this._resultForm = value; }
		}

		public CPL3020U00FwkResultGetYArgs() { }

		public CPL3020U00FwkResultGetYArgs(String resultForm)
		{
			this._resultForm = resultForm;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3020U00FwkResultGetYRequest();
		}
	}
}