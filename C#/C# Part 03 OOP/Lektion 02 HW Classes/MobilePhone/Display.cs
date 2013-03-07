using System;

internal class Display
{
	// Field declaration
	private int? resolutionWidth;

	private int? resolutionHeight;
	private int? colors;

	// Constructor declaration
	public Display()
		: this(null, null, null)
	{
	}

	public Display(int? resolutionWidth, int? resolutionHeight)
		: this(resolutionWidth, resolutionHeight, null)
	{
	}

	public Display(int? resolutionWidth, int? resolutionHeight, int? colors)
	{
		this.resolutionWidth = resolutionWidth;
		this.resolutionHeight = resolutionHeight;
		this.colors = colors;
	}

	//Properties
	public int? ResolutionWidth
	{
		get
		{
			return this.resolutionWidth;
		}
		set
		{
			if (value == null || value >= 0)
			{
				this.resolutionWidth = value;
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}

	public int? ResolutionHeight
	{
		get
		{
			return this.resolutionHeight;
		}
		set
		{
			if (value == null || value >= 0)
			{
				this.resolutionHeight = value;
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}

	public int? Colors
	{
		get
		{
			return this.colors;
		}
		set
		{
			if (value == null || value >= 0)
			{
				this.colors = value;
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}
}