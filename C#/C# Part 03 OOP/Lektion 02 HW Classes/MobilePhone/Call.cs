using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//It should contain date, time, dialed phone number and duration (in seconds).
	class Call
	{
		private DateTime date;
		private string phoneNumber;
		private int durationInSec;
		// Constructor declaration
		public Call(DateTime date, string phoneNumber, int durationInSec)
		{
			this.date = date;
			this.phoneNumber = phoneNumber;
			this.durationInSec = durationInSec;
		}

		public DateTime Date
		{
			get
			{
				return this.date;
			}

			set
			{
				this.date = value;
			}
		}

		public string PhoneNumber
		{
			get
			{
				return this.phoneNumber;
			}

			set
			{
				this.phoneNumber = value;
			}
		}

		public int DurationInSec
		{
			get
			{
				return this.durationInSec;
			}
			set
			{
				this.durationInSec = value;
			}
		}
	}
