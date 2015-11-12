using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NuriNUR7001U00InsertNUR7001Args : IContractArgs
	{
		private String _userId;
		private String _bunho;
		private String _measureDate;
		private String _newSeq;
		private String _height;
		private String _weight;
		private String _bpFrom;
		private String _bpTo;
		private String _bodyHeat;
		private String _pulse;
		private String _spo2;
		private String _measureTime;
		private String _breath;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String MeasureDate
		{
			get { return this._measureDate; }
			set { this._measureDate = value; }
		}

		public String NewSeq
		{
			get { return this._newSeq; }
			set { this._newSeq = value; }
		}

		public String Height
		{
			get { return this._height; }
			set { this._height = value; }
		}

		public String Weight
		{
			get { return this._weight; }
			set { this._weight = value; }
		}

		public String BpFrom
		{
			get { return this._bpFrom; }
			set { this._bpFrom = value; }
		}

		public String BpTo
		{
			get { return this._bpTo; }
			set { this._bpTo = value; }
		}

		public String BodyHeat
		{
			get { return this._bodyHeat; }
			set { this._bodyHeat = value; }
		}

		public String Pulse
		{
			get { return this._pulse; }
			set { this._pulse = value; }
		}

		public String Spo2
		{
			get { return this._spo2; }
			set { this._spo2 = value; }
		}

		public String MeasureTime
		{
			get { return this._measureTime; }
			set { this._measureTime = value; }
		}

		public String Breath
		{
			get { return this._breath; }
			set { this._breath = value; }
		}

		public NuriNUR7001U00InsertNUR7001Args() { }

		public NuriNUR7001U00InsertNUR7001Args(String userId, String bunho, String measureDate, String newSeq, String height, String weight, String bpFrom, String bpTo, String bodyHeat, String pulse, String spo2, String measureTime, String breath)
		{
			this._userId = userId;
			this._bunho = bunho;
			this._measureDate = measureDate;
			this._newSeq = newSeq;
			this._height = height;
			this._weight = weight;
			this._bpFrom = bpFrom;
			this._bpTo = bpTo;
			this._bodyHeat = bodyHeat;
			this._pulse = pulse;
			this._spo2 = spo2;
			this._measureTime = measureTime;
			this._breath = breath;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuriNUR7001U00InsertNUR7001Request();
		}
	}
}