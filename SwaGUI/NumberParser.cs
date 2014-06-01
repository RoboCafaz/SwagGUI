using System;
using System.Drawing;
using System.Text.RegularExpressions;
using Tesseract;

namespace SwagGUI
{
    internal class NumberParser
    {
        private static TesseractEngine engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);

        public static int ParseNumber(Bitmap bmp)
        {
            int num = -1;

            try
            {
                using (Page page = engine.Process(bmp))
                {
                    String text = page.GetText();
                    if (text != null)
                    {
                        text = Regex.Replace(text, "[^0-9]", "");
                        if (text.Length > 0)
                        {
                            num = int.Parse(text);
                            Console.WriteLine("Text: {0}", num);
                        }
                    }
                }
            }
            catch (Exception e)
            {
            }

            return num;
        }
    }
}