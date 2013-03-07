using System;

internal class Battery
{
	public enum batterryType
	{
		LiIon, NiMH, NiCd
	}

	// Field declaration
	private string model;

	private batterryType? type=null;
	private int? hoursStanby;
	private int? hoursTalk;

	// Constructor declaration
	public Battery()
		: this(null, null, null, null)
	{
	}
	public Battery(string model):this (model,null,null,null)
	{
	}

	public Battery(string model, batterryType? type):this(model,type,null,null)
	{
	}

	public Battery(string model, batterryType? type, int? hoursStanby, int? hoursTalk)
	{
		this.model = model;
		this.type = type;
		this.hoursStanby = hoursStanby;
		this.hoursTalk = hoursTalk;
	}

	//Properties
	public string Model
	{
		get
		{
			return this.model;
		}
		set
		{
			if (value.Length >= 0)
			{
				this.model = value;
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}

	public batterryType? Type
	{
		get
		{
			return this.type;
		}
		set
		{
			if (value >= 0)
			{
				this.type = value;
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}

	public int? HoursStanby
	{
		get
		{
			return this.hoursStanby;
		}
		set
		{
			if (value == null || value >= 0)
			{
				this.hoursStanby = value;
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}

	public int? HoursTalk
	{
		get
		{
			return this.hoursTalk;
		}
		set
		{
			if (value == null || value >= 0)
			{
				this.hoursTalk = value;
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}
}