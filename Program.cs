List<Page> Pages = new List<Page>();


Page page1 = new Page("min første side");
Page page2 = new Page("Min side 2");
Page page3 = new Page("Min side 3");

Pages.Add(page1);
Pages.Add(page2);
Pages.Add(page3);

foreach (var item in Pages)
{
    item.Read();
}

Chapter Chapter1 = new Chapter("kapitel1");
Chapter1.Pages = Pages;
Chapter Chapter2 = new Chapter("kapitel2", Pages);

Chapter1.Read();
Chapter2.Read();

List<Chapter> Chapter3 = new List<Chapter>();
Chapter.Add(Chapter1);
Chapter.Add(Chapter2);

Book mybook = new Book("programming notes");

Book.Start();

//pause
Console.ReadLine();