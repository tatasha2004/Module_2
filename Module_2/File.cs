using System;

namespace Module_2
{
    public class File
    {
        public string name { get; set; }
        public string extention { get; set; }
        public string size { get; set; }

        public File(string name, string extention, string size)
        {
            this.name = name;
            this.extention = extention;
            this.size = size;
        }

        public class Text : File
        {
            public string Content;

            public Text(string name, string extention, string size, string content)
                : base(name, extention, size)
            {
                Content = content;
            }

            public void PrintText()
            {
                Console.WriteLine("Text files: \n" + "  " + name + "\n      Extension: " + extention);
                Console.WriteLine("      Size: " + size.Trim(new char[] { ' ', ')' }) + "\n      Content: " + Content);
            }
        }

        public class Image : File
        {
            public string Resolution;

            public Image(string name, string extention, string size, string resolution)
                : base(name, extention, size)
            {
                Resolution = resolution;
            }

            public void PrintImage()
            {
                Console.WriteLine("Images: \n" + "  " + name + "\n      Extension: " + extention);
                Console.WriteLine("      Size: " + size.Trim(new char[] { ' ', ')' }) + "\n     Resolution: " + Resolution);
            }
        }
        public class Movie : Image
        {
            public string Length;

            public Movie(string name, string extention, string size, string resolution, string length)
                : base(name, extention, size, resolution)
            {
                Length = length;
            }
            public void PrintMovie()
            {
                Console.WriteLine("Movies: \n" + "  " + name + "\n     Extension: " + extention);
                Console.WriteLine("      Size: " + size.Trim(new char[] { ' ', ')' }));
                Console.WriteLine("      Resolution: " + Resolution + " \n     Length: " + Length);
            }
        }
    }
}
