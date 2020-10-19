using System;
using System.Text.RegularExpressions;

namespace EPMImageCreator
{
    class CodeText
    {
        public string OriginalText { get; set; }
        public string TargetText { get; set; }
        public int WidthPixels { get; set; }
        public int HeightPixels { get; set; }
        //RegexOptions options = RegexOptions.None;
        Regex TargetPattern = new Regex("[ ]{2,}target[ ]{2,}", RegexOptions.None);
        Regex ItemPattern = new Regex(@"[ ]{2,}item[ ]\d+[ ]{2,}", RegexOptions.None);
        public int NumberOfTargetLines
        {
            get
            {
                int TargetLines = 0;
                foreach (string line in OriginalText.Split('\n'))
                {
                    Match TargetMatch = TargetPattern.Match(line);
                    if (TargetMatch.Success)
                    {
                        TargetLines += 1;
                    }
                }
                return TargetLines;
            }
        }

        public int NumberOfItemLines
        {
            get
            {
                int ItemLines = 0;
                foreach (string line in OriginalText.Split('\n'))
                {
                    Match ItemMatch = ItemPattern.Match(line);
                    if (ItemMatch.Success)
                    {
                        ItemLines += 1;
                    }
                }
                return ItemLines;
            }
        }

        public bool HasTargets = false;
        public bool HasItems = false;
        public string FinalText { get { return GetFinalText(); } }

        private string GetFinalText()
        {
            int TargetLength = this.TargetText.Length;

            int PaddingTextLength = Math.Max(0, (TargetLength - 5));
            string PaddingText = new String('_', PaddingTextLength);
            string TargetReplacementText = "  target" + PaddingText + "  ";
            string ReplacedText = TargetPattern.Replace(this.OriginalText, TargetReplacementText);
            return ReplacedText;
        }

        public int NumberOfLines
        {
            get
            {
                return FinalText.Split('\n').Length;
            }
        }
        public int MaxLineLength
        {
            get
            {
                int MaxLength = 0;
                foreach (string line in FinalText.Split('\n'))
                {
                    if (line.Length > MaxLength)
                    {
                        MaxLength = line.Length;
                    }
                }
                return MaxLength;
            }
        }
    }
}