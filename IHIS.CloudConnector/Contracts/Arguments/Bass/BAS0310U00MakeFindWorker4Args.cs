using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0310U00MakeFindWorker4Args : IContractArgs
	{
		private String _codeType;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public BAS0310U00MakeFindWorker4Args() { }

		public BAS0310U00MakeFindWorker4Args(String codeType)
		{
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0310U00MakeFindWorker4Request();
		}
	}
}