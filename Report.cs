namespace Practice
{
    interface IPrintable
    {
        public abstract void Print();
    }
    interface ISerializable
    {
        public void Save();
    }
    class Report : IPrintable, ISerializable
    {
        string title, content, filename;

        public Report(string title,string content,string filename)
        {
            this.title = title;
            this.content = content;
            this.filename = filename;
        }

        public void Print()
        {
            Console.WriteLine($"title::{title}\ncontent::{content}");
        }
        public void Save()
        {
            File.WriteAllText(filename, content);
            Console.WriteLine($"report is saves in {filename}");
        }
    }
}
