using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class OUT0101U04TxtZipCode2DataValidatingArgs : IContractArgs
	{
		private String _zipCode1;
		private String _zipCode2;

		public String ZipCode1
		{
			get { return this._zipCode1; }
			set { this._zipCode1 = value; }
		}

		public String ZipCode2
		{
			get { return this._zipCode2; }
			set { this._zipCode2 = value; }
		}

		public OUT0101U04TxtZipCode2DataValidatingArgs() { }

		public OUT0101U04TxtZipCode2DataValidatingArgs(String zipCode1, String zipCode2)
		{
			this._zipCode1 = zipCode1;
			this._zipCode2 = zipCode2;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUT0101U04TxtZipCode2DataValidatingRequest();
		}
	}
}