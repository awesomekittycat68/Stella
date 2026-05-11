using System.Text;

namespace Stella
{
    public static class Random
    {
        private static readonly System.Random _random = new();

        public static int RandomInt(int range0, int range1)
        {
            int result = _random.Next(range0, range1);
            return result;
        }

        public static long RandomLong(long range0, long range1)
        {
            long result = _random.NextInt64(range0, range1);
            return result;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+-=[]{}|;:',.<>?/~`";
            StringBuilder sb = new();

            for (int i = 0; i < length; i++)
            {
                int index = _random.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
    }
}
