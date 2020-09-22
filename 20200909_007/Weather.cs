class Weather
{
    public string Hour { get; set; }
    public string Temp { get; set; }
    public string WfKor { get; set; }
    public string WdKor { get; set; }

    public override string ToString()
    {
        return string.Format($"{Hour}시\t{Temp}℃\t{WfKor}\t{WdKor}풍");
    }
}

