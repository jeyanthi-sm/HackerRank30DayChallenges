

//Write MyBook class
 class MyBook:Book
{
    int price;
    internal MyBook(string t, string a,int p):base(t,a)
    {
       this.price = p;
    }
    public override void display()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
    
}

