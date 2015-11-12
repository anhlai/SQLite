using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroOUT0101U02GetBirthDayArgs : IContractArgs
	{
		private String _sysDate;
		private String _birth;

		public String SysDate
		{
			get { return this._sysDate; }
			set { this._sysDate = value; }
		}

		public String Birth
		{
			get { return this._birth; }
			set { this._birth = value; }
		}

		public NuroOUT0101U02GetBirthDayArgs() { }

		public NuroOUT0101U02GetBirthDayArgs(String sysDate, String birth)
		{
			this._sysDate = sysDate;
			this._birth = birth;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroOUT0101U02GetBirthDayRequest();
		}
	}
}