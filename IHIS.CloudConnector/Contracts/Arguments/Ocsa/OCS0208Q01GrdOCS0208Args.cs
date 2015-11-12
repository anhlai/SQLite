using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0208Q01GrdOCS0208Args : IContractArgs
	{
		private String _doctor;

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public OCS0208Q01GrdOCS0208Args() { }

		public OCS0208Q01GrdOCS0208Args(String doctor)
		{
			this._doctor = doctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0208Q01GrdOCS0208Request();
		}
	}
}