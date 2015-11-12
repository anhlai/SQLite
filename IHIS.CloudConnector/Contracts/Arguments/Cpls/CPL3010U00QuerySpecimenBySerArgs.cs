using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3010U00QuerySpecimenBySerArgs : IContractArgs
	{
		private String _specimenSer;

		public String SpecimenSer
		{
			get { return this._specimenSer; }
			set { this._specimenSer = value; }
		}

		public CPL3010U00QuerySpecimenBySerArgs() { }

		public CPL3010U00QuerySpecimenBySerArgs(String specimenSer)
		{
			this._specimenSer = specimenSer;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3010U00QuerySpecimenBySerRequest();
		}
	}
}