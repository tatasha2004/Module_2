using System;

namespace Module_2
{
   class Programm
    { 
        static void Main(string[] args)
        {
            String input = @"Text: file.txt(6B); Some string content
Image: img.bmp(19MB); 1920х1080
Text:data.txt(12B); Another string
Text:data1.txt(7B); Yet another string
Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m";

            var text = new Parse(input);
            string[] filesData = text.SplitFile();

            for (int i = 0; i < filesData.Length; i++)
            {
                var splitFile = filesData[i].Split(':', '.', '(', ';');

                if (splitFile[0] == "Text")
                {
                    File.Text textFile = new File.Text(splitFile[1], splitFile[2], splitFile[3], splitFile[4]);
                    textFile.PrintText();
                }
                else if (splitFile[0] == "Image")
                {
                    File.Image imageFile = new File.Image(splitFile[1], splitFile[2], splitFile[3], splitFile[4]);
                    imageFile.PrintImage();
                }

                else if (splitFile[0] == "Movie")
                {
                    File.Movie movieFile = new File.Movie(splitFile[1], splitFile[2], splitFile[3], splitFile[4], splitFile[5]);
                    movieFile.PrintMovie();
                }
            }
            Console.ReadLine();
        }
    }
}
