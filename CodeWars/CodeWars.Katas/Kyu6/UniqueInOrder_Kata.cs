namespace CodeWars.Katas.Kyu6
{
    public class UniqueInOrder_Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) =>
            iterable.Where((value, index) => index == 0 || !Equals(value, iterable.ElementAt(index - 1)));
    }
}
