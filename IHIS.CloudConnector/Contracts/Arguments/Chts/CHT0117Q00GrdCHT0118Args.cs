using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
	public class CHT0117Q00GrdCHT0118Args : IContractArgs
	{
		private String _gubun;
		private String _buwi;
		private String _buwiName;

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String Buwi
		{
			get { return this._buwi; }
			set { this._buwi = value; }
		}

		public String BuwiName
		{
			get { return this._buwiName; }
			set { this._buwiName = value; }
		}

		public CHT0117Q00GrdCHT0118Args() { }

		public CHT0117Q00GrdCHT0118Args(String gubun, String buwi, String buwiName)
		{
			this._gubun = gubun;
			this._buwi = buwi;
			this._buwiName = buwiName;
		}

		public IExtensible GetRequestInstance()
		{
			return new CHT0117Q00GrdCHT0118Request();
		}
	}
}