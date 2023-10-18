using Newtonsoft.Json;

Goods Goods = new Goods(200, false, 1, "Strawberryjam", 2);
Strawberryjam Strawberryjam = new Strawberryjam(200, false, 1, "Strawberryjam", 2);
Dumplings Dumplings = new Dumplings(300, true, 2, "Dumplings", 4);
List<Goods> goods = new List<Goods>();
goods.Add(Goods);
goods.Add(Strawberryjam);
goods.Add(Dumplings);

//foreach (Goods c in goods)
//{
    string json = JsonConvert.SerializeObject(c);
    Console.WriteLine(json);
//}
//Goods = Goods.OrderByDescending(p => p.weight).ToList();

//Console.WriteLine("Отсортированный список продуктов по весу (от большего к меньшему):");
//foreach (Goods in goods)
//{
 //   Console.WriteLine($"Цена:{goods.prise},Хрупкий: {goods.producthardness},Объем:Название:{goods.} Вес:");
//}

class Goods
{
    public int prise;
    public bool producthardness;
    public double volume;
    public string name;
    public int weight;

    public Goods(int prise, bool producthardness, double volume, string name, int weight)
    {
        this.prise = prise;
        this.weight = weight;
        this.producthardness = producthardness;
        this.volume = volume;
        this.name = name;
    }

    internal object OrderByDescending(Func<object, object> value)
    {
        throw new NotImplementedException();
    }
}

class Strawberryjam : Goods
{
    public Strawberryjam(int prise, bool producthardness, double volume, string name, int weight) : base(prise, producthardness, volume, name, weight)
    {

    }
}


class Dumplings : Goods
{
    public Dumplings(int prise, bool producthardness, double volume, string name, int weight) : base(prise, producthardness, volume, name, weight)
    {

    }
}
