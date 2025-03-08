namespace LibrarySpace
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Isbn { get; set; }
        public Book()
        {
            Title = "anonymous";
            Author = "anonymous";
            Isbn = -1; 
        }
        public Book(string title,string author)
        {
            Title = title;
            Author = author;
            Isbn = -1;
        }
        public Book(string title, string author,int isbn)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
        }

        public void showBookDetails()
        {
            Console.WriteLine("Name=" + Title + "\nAuthor=" + Author + "\nISBN=" + Isbn+"\n");
            
        }
    }
}