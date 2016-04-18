namespace Week14B_Summary_Collections
{
    public class MyGenericClass<T> // generic class
    {
        T item;
        public void Add(T item)
        {
            this.item = item;
        }
        public override string ToString()
        {
            return item.ToString();
        }
    }
}
