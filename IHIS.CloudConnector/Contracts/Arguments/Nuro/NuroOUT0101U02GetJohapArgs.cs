using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroOUT0101U02GetJohapArgs : IContractArgs
	{
		private String _johap;
		private String _date;

		public String Johap
		{
			get { return this._johap; }
			set { this._johap = value; }
		}

		public String Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public NuroOUT0101U02GetJohapArgs() { }

		public NuroOUT0101U02GetJohapArgs(String johap, String date)
		{
			this._johap = johap;
			this._date = date;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroOUT0101U02GetJohapRequest();
		}
	}
}