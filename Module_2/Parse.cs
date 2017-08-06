using System;

namespace Module_2
{
    public class Parse
    {
        public string Input;
        private string[] filesData;

        public Parse(string input)
        {
            Input = input;
        }

        public string[] SplitFile()
        {
            string[] filesData = Input.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return filesData;
        }

        //public void Print()
        //{
        //    for (int i = 0; i < filesData.Length; i++)
        //    {
        //        var splitFile = filesData[i].Split(':', '.', '(', ';');

        //        if (splitFile[0] == "Text")
        //        {
        //            File.Text textFile = new File.Text(splitFile[1], splitFile[2], splitFile[3], splitFile[4]);
        //            textFile.PrintText();
        //        }
        //        if (splitFile[0] == "Image")
        //        {
        //            File.Image imageFile = new File.Image(splitFile[1], splitFile[2], splitFile[3], splitFile[4]);
        //            imageFile.PrintImage();
        //        }

        //        if (splitFile[0] == "Movie")
        //        {
        //            File.Movie movieFile = new File.Movie(splitFile[1], splitFile[2], splitFile[3], splitFile[4], splitFile[5]);
        //            movieFile.PrintMovie();
        //        }
        //    }
        //}
    }
}
