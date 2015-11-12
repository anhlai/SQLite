using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NUR1017U00LayValidationDupchkArgs : IContractArgs
	{
		private String _infeCode;
		private String _bunho;
		private String _startDate;

		public String InfeCode
		{
			get { return this._infeCode; }
			set { this._infeCode = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String StartDate
		{
			get { return this._startDate; }
			set { this._startDate = value; }
		}

		public NUR1017U00LayValidationDupchkArgs() { }

		public NUR1017U00LayValidationDupchkArgs(String infeCode, String bunho, String startDate)
		{
			this._infeCode = infeCode;
			this._bunho = bunho;
			this._startDate = startDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUR1017U00LayValidationDupchkRequest();
		}
	}
}