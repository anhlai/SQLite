using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U06EmrTemplateTypeArgs : IContractArgs
	{

		public OCS2015U06EmrTemplateTypeArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U06EmrTemplateTypeRequest();
		}
	}
}