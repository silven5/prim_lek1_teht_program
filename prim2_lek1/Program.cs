// See https://aka.ms/new-console-template for more information
using prim2_lek1;
// Це структура її дані знаходяться у стеці
State state1 = new State();
// А це клвс в стеці є посилання на адресу в кучі
//всі дані зберігаються саме у кучі
Country country1 = new Country();

Console.ReadKey();
struct State
{
    Boolean state;
    Country country=new Country();

    public State()
    {
    }
}
