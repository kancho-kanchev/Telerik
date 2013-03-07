using System;
using System.Collections.Generic;
using System.Text;

internal class GSM
{
	// Field declaration
	public Battery Battery;
	public Display Display;
	private string model;
	private string manufacturer;
	private double? price;
	private string owner;
	private List<Call> callHistory = new List<Call>();

	//Static feeld for IPhone4s
	public static GSM iPhone4s=new GSM("IPhone4s", "Apple");

	// Constructor declaration
	public GSM(string model, string manufacturer)
		: this(model, manufacturer, null, null)
	{
	}

	public GSM(string model, string manufacturer, double? price)
		: this(model, manufacturer, price, null)
	{
	}

	public GSM(string model, string manufacturer, double? price, string owner)
	{
		this.model = model;
		this.manufacturer = manufacturer;
		this.price = price;
		this.owner = owner;
		this.Battery = new Battery();
		this.Display = new Display();
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
			if (value.Length > 0)
			{
				this.model = value;
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}

	public string Manufacturer
	{
		get
		{
			return this.manufacturer;
		}
		set
		{
			if (value.Length > 0)
			{
				this.manufacturer = value;
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}

	public double? Price
	{
		get
		{
			return this.price;
		}
		set
		{
			if (value == null || value >= 0)
			{
				this.price = value;
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}

	public string Owner
	{
		get
		{
			return this.owner;
		}
		set
		{
			if (value == null || value.Length >= 0)
			{
				this.owner = value;
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}

	//override metod
	public override string ToString()
	{
		StringBuilder resultText = new StringBuilder();
		resultText.AppendLine("---Phone Information ---");
		resultText.AppendLine("Model: "+this.model);
		resultText.AppendLine("Manufacturer: "+this.manufacturer);
		resultText.AppendLine("Price: "+this.price.ToString());
		resultText.AppendLine("Owner: "+this.owner);
		resultText.AppendLine("Battery model: " + this.Battery.Model);
		resultText.AppendLine("Battery type: " + this.Battery.Type);
		resultText.AppendLine("Battery stanby: " + this.Battery.HoursStanby);
		resultText.AppendLine("Battery talk: " + this.Battery.HoursTalk);
		resultText.AppendLine("Display resolution: " + this.Display.ResolutionHeight + "x" + this.Display.ResolutionWidth);
		resultText.AppendLine("Display colors: " + this.Display.Colors);
		string result = resultText.ToString();
		return result;
	}
	//metod print
	public void PrintGSMInfo(GSM gsm)
	{
		Console.WriteLine(gsm.ToString());
	}
	//metod clear history
	public void ClearHistory()
	{
		callHistory.Clear();
	}
	//metod add call history
	public void AddCall(DateTime now, string phoneNumber, int durationInSec)
	{
		Call newCall = new Call(now, phoneNumber, durationInSec);
		callHistory.Add(newCall);
	}
	//metod delete entry from call history
	public void DeleteCall(string phoneNumber)
	{
		for (int i = 0; i < callHistory.Count; i++)
		{
			if (callHistory[i].PhoneNumber == phoneNumber)
			{
				callHistory.RemoveAt(i);
				i--;
			}
		}
	}
	//metod for calculating price
	public double CalcPrice(double pricePerMin)
	{
		double time = 0;
		for (int i = 0; i < callHistory.Count; i++)
		{
			time = time + callHistory[i].DurationInSec;
		}

		double price = pricePerMin * (Math.Ceiling(time / 60));
		return price;
	}
	//metod display call history
	public void DisplayCallHistory()
	{
		StringBuilder callHist = new StringBuilder();
		foreach (var call in callHistory)
		{
			callHist.AppendFormat("Number: {0},  Date: {1},  Duration: {2} \n", call.PhoneNumber, call.Date, call.DurationInSec);
		}
		Console.WriteLine(callHist.ToString());
	}

}