using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCSAOCS0270Q00CboDoctorGradeArgs : IContractArgs
	{

		public OCSAOCS0270Q00CboDoctorGradeArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCSAOCS0270Q00CboDoctorGradeRequest();
		}
	}
}