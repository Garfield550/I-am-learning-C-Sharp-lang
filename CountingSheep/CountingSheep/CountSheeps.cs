using System.Linq;

namespace CountingSheep
{
    public class CountSheeps
    {
        public static int Count(bool[] sheeps) => sheeps.Count(b => b);
    }
}
