class Book
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Book(string _Name, int _Price)
    {
        Name = _Name;
        Price = _Price;
    }
}