using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuts
{
	public class NUT0001U00Grd0002Args : IContractArgs
	{
		private String _fknut0001;

		public String Fknut0001
		{
			get { return this._fknut0001; }
			set { this._fknut0001 = value; }
		}

		public NUT0001U00Grd0002Args() { }

		public NUT0001U00Grd0002Args(String fknut0001)
		{
			this._fknut0001 = fknut0001;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUT0001U00Grd0002Request();
		}
	}
}