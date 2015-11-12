using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0120U00GrdDrg0120Item1Args : IContractArgs
	{
		private String _bunryu1;

		public String Bunryu1
		{
			get { return this._bunryu1; }
			set { this._bunryu1 = value; }
		}

		public DRG0120U00GrdDrg0120Item1Args() { }

		public DRG0120U00GrdDrg0120Item1Args(String bunryu1)
		{
			this._bunryu1 = bunryu1;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG0120U00GrdDrg0120Item1Request();
		}
	}
}