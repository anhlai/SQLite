using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroOUT0101U02GetInsuranceArgs : IContractArgs
	{
		private String _lawNo;

		public String LawNo
		{
			get { return this._lawNo; }
			set { this._lawNo = value; }
		}

		public NuroOUT0101U02GetInsuranceArgs() { }

		public NuroOUT0101U02GetInsuranceArgs(String lawNo)
		{
			this._lawNo = lawNo;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroOUT0101U02GetInsuranceRequest();
		}
	}
}