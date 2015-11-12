using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroNuroOUT0101U02GetGaeinArgs : IContractArgs
	{
		private String _johap;
		private String _gaein;

		public String Johap
		{
			get { return this._johap; }
			set { this._johap = value; }
		}

		public String Gaein
		{
			get { return this._gaein; }
			set { this._gaein = value; }
		}

		public NuroNuroOUT0101U02GetGaeinArgs() { }

		public NuroNuroOUT0101U02GetGaeinArgs(String johap, String gaein)
		{
			this._johap = johap;
			this._gaein = gaein;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroNuroOUT0101U02GetGaeinRequest();
		}
	}
}