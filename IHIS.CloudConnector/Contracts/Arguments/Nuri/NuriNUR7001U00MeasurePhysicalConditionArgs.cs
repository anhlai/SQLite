using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NuriNUR7001U00MeasurePhysicalConditionArgs : IContractArgs
	{
		private String _bunho;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public NuriNUR7001U00MeasurePhysicalConditionArgs() { }

		public NuriNUR7001U00MeasurePhysicalConditionArgs(String bunho)
		{
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuriNUR7001U00MeasurePhysicalConditionRequest();
		}
	}
}