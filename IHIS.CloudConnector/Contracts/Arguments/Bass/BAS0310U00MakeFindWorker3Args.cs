using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0310U00MakeFindWorker3Args : IContractArgs
	{
		private String _find;

		public String Find
		{
			get { return this._find; }
			set { this._find = value; }
		}

		public BAS0310U00MakeFindWorker3Args() { }

		public BAS0310U00MakeFindWorker3Args(String find)
		{
			this._find = find;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0310U00MakeFindWorker3Request();
		}
	}
}