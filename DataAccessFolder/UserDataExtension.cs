using BlazorLabb.UserClasses;

namespace BlazorLabb.DataAccessFolder
{
    public static class UserDataExtension
    {
        public static List<User> GetAllUsers(this IEnumerable<User> list)
        {
            return list.ToList();
        }
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

                return list.Skip(startIndex).Take(count).ToList();
        }

        public static List<User> SortByID(this IEnumerable<User> list)
        {
            return list.OrderBy(x => x.Id).ToList();
        }

        public static List<User> SortByName(this IEnumerable<User> list)
        {
            return list.OrderBy(x => x.Name).ToList();
        }

        public static List<User> SearchString(this IEnumerable<User> list, string? text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return list.ToList();
            }

            return list.Where(x => x.Name.Contains(text, StringComparison.OrdinalIgnoreCase)
            || x.Email.Contains(text, StringComparison.OrdinalIgnoreCase)
            || x.Company.Name.Contains(text, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
