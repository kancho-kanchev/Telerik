using System;

class BitBall
{
	static void Main()
	{
		//16,74, 40, 0,86,0,16, 0,
		// 0, 0,129,73, 6,4,72,16

		int[] topPlayers = { 16, 74, 40, 0, 86, 0, 16, 0 };
		int[] bottomPlayers = { 0, 0, 129, 73, 6, 4, 72, 16 };
		int[] playersBuffer = { 0, 0, 0, 0, 0, 0, 0, 0 };
		int buffer = 0;
		int topScore = 0;
		int bottomScore = 0;
		string text = "";
		//for (int i = 0; i < 8; i++)
		//{
		//	topPlayers[i] = int.Parse(Console.ReadLine());
		//}
		//for (int i = 0; i < 8; i++)
		//{
		//	bottomPlayers[i] = int.Parse(Console.ReadLine());
		//}

		//solution
		for (int i = 0; i < 8; i++)
		{
			buffer = bottomPlayers[i];
			bottomPlayers[i]=(~topPlayers[i] & bottomPlayers[i]);//bottom
			topPlayers[i] = (~buffer & topPlayers[i]);//top
		}


		playersBuffer = topPlayers;
		for (int i = 0; i < 7; i++)
		{
			topPlayers[i + 1] = topPlayers[i + 1] | (~bottomPlayers[i + 1] & topPlayers[i]);
			Console.WriteLine(Convert.ToString(topPlayers[i + 1], 2).PadLeft(8, '0'));
		}
		Console.WriteLine();
		Console.WriteLine(Convert.ToString(topPlayers[7], 2).PadLeft(8, '0'));
		Console.WriteLine();
		topPlayers = playersBuffer;
		for (int i = 7; i > 0; i--)
		{
			bottomPlayers[i - 1] = bottomPlayers[i - 1] | (~topPlayers[i - 1] & bottomPlayers[i]);
			Console.WriteLine(Convert.ToString(bottomPlayers[i - 1], 2).PadLeft(8, '0'));
		}
		Console.WriteLine();
		Console.WriteLine(Convert.ToString(bottomPlayers[0], 2).PadLeft(8, '0'));
		Console.WriteLine();
		text = String.Format("{0}", Convert.ToString(topPlayers[7], 2).PadLeft(8, '0'));
		foreach (char count in text)
		{
			if (count=='1')
			{
				bottomScore++;
			}
		}
		text = String.Format("{0}", Convert.ToString(bottomPlayers[0], 2).PadLeft(8, '0'));
		foreach (char count in text)
		{
			if (count == '1')
			{
				topScore++;
			}
		}
		//print result
		Console.WriteLine("{0}:{1}",topScore,bottomScore);
	}
}