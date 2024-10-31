﻿using System.Collections.Generic;

namespace BlazorLabb
{
	public static class UserDataExtension
	{
		public static List<User> GetFilteredUsers(this IEnumerable<User> list, int startIndex, int count)
		{
			if (startIndex < 0 || startIndex >= list.Count())
			{
				throw new ArgumentOutOfRangeException(nameof(startIndex));
			}

			if (count < 0 || startIndex + count > list.Count())
			{
				throw new ArgumentOutOfRangeException(nameof(count));
			}

			if (startIndex == 0)
			{
				return list.Take(count).ToList();
			}
			else
			{
				return list.Skip(startIndex).Take(count).ToList();
			}
		}
	}
}
