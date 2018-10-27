namespace BinaryGap
{
	class Solution
	{
		public int solution(int N)
		{
			bool isStarted = false;
			int count = 0;
			int maxCount = 0;
			while (N > 0)
			{
				if (N % 2 == 0 && !isStarted)
				{
					N /= 2;
					continue;
				}
				else
				{
					isStarted = true;
					N /= 2;
				}
				if (N % 2 == 0 && isStarted)
				{
					count++;
				}
				else
				{
					maxCount = count > maxCount ? count : maxCount;
					count = 0;
				}
				if (N == 1) break;
			}
			return maxCount;
		}
	}
}
