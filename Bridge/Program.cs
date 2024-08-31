namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectricGoods television = new Television();
            IState onState = new OnState();
            television.State = onState;
            television.MoveToCurrentState();

            IState offState = new OffState();
            television.State = offState;
            television.MoveToCurrentState();

            ElectricGoods dvd = new DVD();
            dvd.State = onState;
            dvd.MoveToCurrentState();

            dvd.State = offState;
            dvd.MoveToCurrentState();
        }
    }
}
