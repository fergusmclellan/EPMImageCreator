using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace EPMImageCreator
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void item123HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.ShowDialog();
        }
    


    public static void DrawText(String text, Font font, Color textColor, int imageWidth, int imageHeight, String path)
        {
            //set the stringformat flags to rtl
            StringFormat sf = new StringFormat();

            sf.Trimming = StringTrimming.Word;

            //create an image of the correct size
            Image img = new Bitmap(imageWidth, imageHeight);
            Graphics drawing = Graphics.FromImage(img);

            //Adjust for high quality
            /*
            drawing.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            drawing.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            drawing.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            drawing.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            drawing.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            */

            //paint the background
            drawing.Clear(Color.White);

            // draw black border, 2 pixels wide
            drawing.DrawLine(new Pen(Brushes.Black, 2), new Point(1, 1), new Point(1, imageHeight-1));
            drawing.DrawLine(new Pen(Brushes.Black, 2), new Point(1, 1), new Point(imageWidth-1, 1));
            drawing.DrawLine(new Pen(Brushes.Black, 2), new Point(1, imageHeight-1), new Point(imageWidth-1, imageHeight-1));
            drawing.DrawLine(new Pen(Brushes.Black, 2), new Point(imageWidth-1, 1), new Point(imageWidth-1, imageHeight-1));

            //create a brush for the text
            Brush textBrush = new SolidBrush(textColor);

            // set initial starting y coordinate
            int textStartHeight = Globals.BorderPaddingPX;
            int textHeight = Globals.FontHeightSizePX;

            // Create regular expressions to check if a line contains a Target or an item 1,2,3
            Regex TargetPattern = new Regex("[ ]{2,}target", RegexOptions.None);
            Regex ItemPattern = new Regex(@"[ ]{2,}item[ ]\d+[ ]{2,}", RegexOptions.None);

            string[] lines = Regex.Split(text, "\r\n");
            foreach (String line in lines)
            {
                /* Need to draw lines individually, so that can check the line text for "items" or DnD Targets
                 * Those lines are given extra height spacing, so that token text is not squashed/cropped
                 */
                //SizeF textWidth = new SizeF();
                //textWidth = drawing.MeasureString(line, font, imageWidth);
            
                int textWidth = (int)(Math.Ceiling(line.Length * Globals.FontWidthSizePX)) + (2 * Globals.BorderPaddingPX);
                float characterWidthInThisLine = line.Length * Globals.FontWidthSizePX / line.Length;
                Match TargetMatch = TargetPattern.Match(line);
                Match ItemMatch = ItemPattern.Match(line);

                if (TargetMatch.Success || ItemMatch.Success)
                {
                    while (ItemMatch.Success)
                    {

                        int boxYStartPos = textStartHeight + 4;
                        int boxXStartPos = Convert.ToInt32(((ItemMatch.Index + 1) * characterWidthInThisLine) + Globals.BorderPaddingPX);
                        int boxYEndPos = boxYStartPos + Globals.FontHeightSizePX + 7;
                        int boxXEndPos = Convert.ToInt32(((ItemMatch.Index + ItemMatch.Length - 0.6) * characterWidthInThisLine) + Globals.BorderPaddingPX);
                        //MessageBox.Show(string.Format("line length: {0}, X start position: {1}", line.Length, boxXStartPos));

                        // For the "box" around the "item 1" text, draw 4 black lines as a rectangle, 2 pixels wide
                        drawing.DrawLine(new Pen(Brushes.Black, 2), new Point(boxXStartPos, boxYStartPos), new Point(boxXStartPos, boxYEndPos)); // left side
                        drawing.DrawLine(new Pen(Brushes.Black, 2), new Point(boxXEndPos, boxYStartPos), new Point(boxXEndPos, boxYEndPos)); // right side
                        drawing.DrawLine(new Pen(Brushes.Black, 2), new Point(boxXStartPos, boxYStartPos), new Point(boxXEndPos, boxYStartPos)); // top side
                        drawing.DrawLine(new Pen(Brushes.Black, 2), new Point(boxXStartPos, boxYEndPos), new Point(boxXEndPos, boxYEndPos)); // bottom side
                        ItemMatch = ItemMatch.NextMatch();
                    }

                    textStartHeight = textStartHeight + Globals.OptionLinePaddingPX;
                    //drawing.DrawString(line, font, textBrush, new RectangleF(Globals.BorderPaddingPX, textStartHeight, textWidth.Width, textWidth.Height), sf);
                    drawing.DrawString(line, font, textBrush, new RectangleF(Globals.BorderPaddingPX, textStartHeight, textWidth, (Globals.FontHeightSizePX + Globals.LineSpacingPX + 2)), sf);
                    textStartHeight = textStartHeight + Globals.FontHeightSizePX + Globals.LineSpacingPX + Globals.OptionLinePaddingPX;
                }
                else
                {
                    drawing.DrawString(line, font, textBrush, new RectangleF(Globals.BorderPaddingPX, textStartHeight, textWidth, (Globals.FontHeightSizePX + Globals.LineSpacingPX)), sf);
                    textStartHeight = textStartHeight + Globals.FontHeightSizePX + Globals.LineSpacingPX;
                }
            }
           drawing.Save();

           textBrush.Dispose();
           drawing.Dispose();
           img.Save(path, System.Drawing.Imaging.ImageFormat.Png);
           img.Dispose();

       }

       private void createExhibitButton_Click(object sender, EventArgs e)
       {
           // Create Exhibit button pressed

           if (outputFileTextBox.Text == "")
           {
               // The filename for the output file has not been set
               MessageBox.Show("Please select an output file name before creating exhibit.",
                   "No filename",
                   MessageBoxButtons.OK, 
                   MessageBoxIcon.Warning);
           }
           else if (inputCodeTextBox.Text == "")
           {
               // no text has been added for the exhibit
               MessageBox.Show("Please add code text before creating exhibit.",
                   "No Code",
                   MessageBoxButtons.OK, 
                   MessageBoxIcon.Warning);
           }
           else
           {
               string InputText = inputCodeTextBox.Text;
               /*int textWidthPixels;
               textWidthPixels = findLinesAndWidth(text);
               MessageBox.Show(string.Format("Max line length is: {0}", textWidthPixels));*/
                //int maxWidth = 950;
                var ExhibitCode = new CodeText();
                ExhibitCode.OriginalText = InputText;
                ExhibitCode.TargetText = "this is my target text";
                
                //first, create a dummy bitmap just to get a graphics object
                Image img = new Bitmap(1, 1);
                Graphics drawing = Graphics.FromImage(img);
                Font font = new Font("Courier New", Globals.FontHeightSizePX, GraphicsUnit.Pixel);
                //Font font = new Font("Courier New", Globals.FontSizePt, GraphicsUnit.Point); 
                //measure the string to see how big the image needs to be
                SizeF textSize = drawing.MeasureString(ExhibitCode.FinalText, font, Globals.MaxExhibitWidthPX);

                Color textColor = Color.FromName("Black");
                string path = outputFileTextBox.Text;

                // Check expected width and height are below maximum allowed
                ExhibitCode.WidthPixels = (int)(Math.Ceiling((ExhibitCode.MaxLineLength * Globals.FontWidthSizePX)) + (2 * Globals.BorderPaddingPX));
                    
                //ExhibitCode.HeightPixels = Convert.ToInt32(textSize.Height) + (2 * Globals.BorderPaddingPX) + (ExhibitCode.NumberOfItemLines * Globals.OptionLinePaddingPX * 2) + (ExhibitCode.NumberOfTargetLines * Globals.OptionLinePaddingPX * 2);
                ExhibitCode.HeightPixels = (ExhibitCode.NumberOfLines * (Globals.FontHeightSizePX + Globals.LineSpacingPX)) + (2 * Globals.BorderPaddingPX) + (ExhibitCode.NumberOfItemLines * Globals.OptionLinePaddingPX * 2) + (ExhibitCode.NumberOfTargetLines * Globals.OptionLinePaddingPX * 2);
                if (ExhibitCode.WidthPixels > Globals.MaxExhibitWidthPX)
                {
                    // Final image too wide for stem exhibit
                    MessageBox.Show(string.Format("This code is too wide to generate an image equal to or less than {0} pixels.", Globals.MaxExhibitWidthPX),
                        "Too wide",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (ExhibitCode.HeightPixels > Globals.MaxExhibitHeightPX)
                {
                    // Final image too high for stem exhibit
                    MessageBox.Show(string.Format("This code has too many lines to generate an image equal to or less than {0} pixels.", Globals.MaxExhibitHeightPX),
                        "Too high",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    // Create exhibit
                    DrawText(ExhibitCode.FinalText, font, textColor, ExhibitCode.WidthPixels, ExhibitCode.HeightPixels, path);
                    MessageBox.Show(String.Format("Image successfully created as {0}.", path),
                    "Completed!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
        }

        private void createDnDImageButton_Click(object sender, EventArgs e)
        {

            // Create DnD Image button pressed

            if (outputFileTextBox.Text == "")
            {
                // The filename for the output file has not been set
                MessageBox.Show("Please select an output file name before creating exhibit.",
                    "No filename",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (inputDnDCodeTextBox.Text == "")
            {
                // no text has been added for the exhibit
                MessageBox.Show("Please add code text before creating exhibit.",
                    "No Code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                string DnDInputText = inputDnDCodeTextBox.Text;

                var DnDCode = new CodeText();
                DnDCode.OriginalText = DnDInputText;
                DnDCode.TargetText = DnDTargetTextBox.Text;

                //first, create a dummy bitmap just to get a graphics object
                Image img = new Bitmap(1, 1);
                Graphics drawing = Graphics.FromImage(img);
                Font font = new Font("Courier New", Globals.FontHeightSizePX, GraphicsUnit.Pixel);
                //Font font = new Font("Courier New", Globals.FontSizePt, GraphicsUnit.Point); 
                //measure the string to see how big the image needs to be
                SizeF textSize = drawing.MeasureString(DnDCode.FinalText, font, Globals.MaxDnDWidthPX);

                Color textColor = Color.FromName("Black");
                string path = outputFileTextBox.Text;

                // Check expected width and height are below maximum allowed
                DnDCode.WidthPixels = (int)(Math.Ceiling((DnDCode.MaxLineLength * Globals.FontWidthSizePX))+ (2 * Globals.BorderPaddingPX));
                //DnDCode.HeightPixels = Convert.ToInt32(textSize.Height) + (2 * Globals.BorderPaddingPX) + (DnDCode.NumberOfItemLines * Globals.OptionLinePaddingPX * 2) + (DnDCode.NumberOfTargetLines * Globals.OptionLinePaddingPX * 2);
                DnDCode.HeightPixels = (DnDCode.NumberOfLines * (Globals.FontHeightSizePX + Globals.LineSpacingPX)) + (2 * Globals.BorderPaddingPX) + (DnDCode.NumberOfItemLines * Globals.OptionLinePaddingPX * 2) + (DnDCode.NumberOfTargetLines * Globals.OptionLinePaddingPX * 2);
                if (DnDCode.WidthPixels > Globals.MaxDnDWidthPX)
                {
                    // Final image too wide for stem exhibit
                    MessageBox.Show(string.Format("This code is too wide to generate an image equal to or less than {0} pixels.", Globals.MaxDnDWidthPX),
                        "Too wide",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (DnDCode.HeightPixels > Globals.MaxDnDHeightPX)
                {
                    // Final image too high for stem exhibit
                    MessageBox.Show(string.Format("This code has too many lines to generate an image equal to or less than {0} pixels.", Globals.MaxDnDHeightPX),
                        "Too high",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    // Create exhibit
                    DrawText(DnDCode.FinalText, font, textColor, DnDCode.WidthPixels, DnDCode.HeightPixels, path);
                    MessageBox.Show(String.Format("Image successfully created as {0}.", path),
                    "Completed!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
        }


            private void selectOutputFileButton_Click(object sender, EventArgs e)
        {
            // Open file dialog to capture filename to for saving the image
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"C:\temp";
            save.RestoreDirectory = true;
            save.Title = "Select save location file name";
            save.DefaultExt = "png"; 

            //Showing the dialog
            if (save.ShowDialog() == DialogResult.OK)
            {
                outputFileTextBox.Text = save.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void outputFileTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void inputCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            inputCodeTextBox.WordWrap = false;
            int maxTextBoxLines = 36;
            int maxCharacters = 107;
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;

             if (textBox.Text.Split('\n').Length > maxTextBoxLines)
            {
                MessageBox.Show("Too many lines for an exhibit - remove lines from end of text");
            }
            int counter = 0;
            foreach (string line in textBox.Text.Split('\n'))
            {
                counter += 1;
                if (line.Length > maxCharacters)
                {
                    MessageBox.Show(string.Format("Too many characters in line: {0}\n{1}", counter, line));
                    break;
                }
            }

        }

        private void CreateOptionImagesButton_Click(object sender, EventArgs e)
        {
            if (outputFileTextBox.Text == "")
            {
                // The filename for the output file has not been set
                MessageBox.Show("Please select an output file name before creating exhibit.",
                    "No filename",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (option1TextBox.Text == "" && option2TextBox.Text == "")
            {
                // no text has been added for the exhibit
                MessageBox.Show("Please add code text before creating Option Images.",
                    "No Code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                string outputFileName = outputFileTextBox.Text;
                Font font = new Font("Courier New", Globals.FontHeightSizePX, GraphicsUnit.Pixel);
                Color textColor = Color.FromName("Black");

                string option1Text = option1TextBox.Text;
                string option2Text = option2TextBox.Text;
                string option3Text = option3TextBox.Text;
                string option4Text = option4TextBox.Text;
                string option5Text = option5TextBox.Text;

                var option1Code = new CodeText();
                var option2Code = new CodeText();
                var option3Code = new CodeText();
                var option4Code = new CodeText();
                var option5Code = new CodeText();

                option1Code.OriginalText = option1Text + " ";
                option1Code.TargetText = "";
                option2Code.OriginalText = option2Text + " ";
                option2Code.TargetText = "";
                option3Code.OriginalText = option3Text + " ";
                option3Code.TargetText = "";
                option4Code.OriginalText = option4Text + " ";
                option4Code.TargetText = "";
                option5Code.OriginalText = option5Text + " ";
                option5Code.TargetText = "";

                int[] optionWidthArray = { option1Code.MaxLineLength, option2Code.MaxLineLength, option3Code.MaxLineLength, option4Code.MaxLineLength, option5Code.MaxLineLength };
                int maxOptionWidth = optionWidthArray.Max();
                int maxOptionWidthIndex = optionWidthArray.ToList().IndexOf(maxOptionWidth) + 1;
                //MessageBox.Show(String.Format("Max width is {0}, as per Option {1}", maxOptionWidth, maxOptionWidthIndex));

                int[] optionLinesArray = { option1Code.NumberOfLines, option2Code.NumberOfLines, option3Code.NumberOfLines, option4Code.NumberOfLines, option5Code.NumberOfLines };
                int maxOptionLines = optionLinesArray.Max();
                int maxOptionLinesIndex = optionLinesArray.ToList().IndexOf(maxOptionLines) + 1;
                //MessageBox.Show(String.Format("Max num of lines is {0}, as per Option {1}", maxOptionLines, maxOptionLinesIndex));

                int optionWidthPixels = (int)(Math.Ceiling((maxOptionWidth * Globals.FontWidthSizePX)) + (2 * Globals.BorderPaddingPX));
                int optionHeightPixels = (maxOptionLines * (Globals.FontHeightSizePX + Globals.LineSpacingPX)) + (2 * Globals.BorderPaddingPX);
                if (optionWidthPixels > Globals.MaxOptionWidthPX)
                {
                    MessageBox.Show(String.Format("Option text is too wide to fit in image < {0} pixels", Globals.MaxOptionWidthPX));
                }
                else if (optionHeightPixels > Globals.MaxOptionHeightPX)
                {
                    MessageBox.Show(String.Format("Option text has too many lines to fit in image < {0} pixels", Globals.MaxOptionHeightPX));
                }
                else
                {
                    if (option1Text.Length > 0)
                    {
                        string option1OutputFileName = outputFileName.Replace(".png", "_Option_A.png");
                        DrawText(option1Text, font, textColor, optionWidthPixels, optionHeightPixels, option1OutputFileName);
                    }
                    if (option2Text.Length > 0)
                    {
                        string option2OutputFileName = outputFileName.Replace(".png", "_Option_B.png");
                        DrawText(option2Text, font, textColor, optionWidthPixels, optionHeightPixels, option2OutputFileName);
                    }
                    if (option3Text.Length > 0)
                    {
                        string option3OutputFileName = outputFileName.Replace(".png", "_Option_C.png");
                        DrawText(option3Text, font, textColor, optionWidthPixels, optionHeightPixels, option3OutputFileName);
                    }
                    if (option4Text.Length > 0)
                    {
                        string option4OutputFileName = outputFileName.Replace(".png", "_Option_D.png");
                        DrawText(option4Text, font, textColor, optionWidthPixels, optionHeightPixels, option4OutputFileName);
                    }
                    if (option5Text.Length > 0)
                    {
                        string option5OutputFileName = outputFileName.Replace(".png", "_Option_E.png");
                        DrawText(option5Text, font, textColor, optionWidthPixels, optionHeightPixels, option5OutputFileName);
                    }
                    string stemOutputFileName = outputFileName.Replace(".png", "_Option_X.png");
                    MessageBox.Show(String.Format("Option images created and saved with filename format {0} (where X denotes the option)", stemOutputFileName));
                }
            }
        }

        private void inputDnDCodeTextBox_TextChanged(object sender, EventArgs e)
        {

            inputDnDCodeTextBox.WordWrap = false;
            int maxDnDTextBoxLines = 34;
            int maxDnDCharacters = 89;
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;

            if (textBox.Text.Split('\n').Length > maxDnDTextBoxLines)
            {
                MessageBox.Show("Too many lines for a DnD image - remove lines from end of text");
            }
            int counter = 0;
            foreach (string line in textBox.Text.Split('\n'))
            {
                counter += 1;
                if (line.Length > maxDnDCharacters)
                {
                    MessageBox.Show(string.Format("Too many characters in line: {0}\n{1}", counter, line));
                    break;
                }
            }
        }

        private void DnDTargetHelpButton_Click(object sender, EventArgs e)
        {
            DnDTargetHelp dndHf = new DnDTargetHelp();
            dndHf.ShowDialog();
        }
    }
    static class Globals
    {
        /* Note on font sizes - difference between Mac and Windows. 
        Originally images were produced on Mac using Courier New in Python/Pillow, with the font set to 11Pt or 15 Pixels
        Mac and Windows have different historical settings associated with DPI, which seems to mean that the fonts are slightly larger in Pixels on
        Windows compared to Mac. Closest match in terms of character size and spacing which I can find is to use a font height of 14 pixels on Windows.
        Font size = 14 pixels
        text height (which includes the spacing between lines) = 17.61
        text width approx = 9.6 
         */
        public static int FontSizePt = 11; // Font size to be used (in Points)
        public static int FontHeightSizePX = 14; // Font height to be used (in pixels)
        public static float FontWidthSizePX = 8.7f; // Expected font width (in pixels) - if the font height is changed, this value also needs to be updated 
        public static int LineSpacingPX = 2; // Standard space between lines (in pixels)
        public static int BorderPaddingPX = 6; // Extra space around all text to allow for border (in pixels)
        public static int OptionLinePaddingPX = 6; // Extra space between lines which include a DnD target or item 1,2,3 text (in pixels)
        public static int MaxExhibitWidthPX = 950; // Max width for stem exhibits (in pixels)
        public static int MaxExhibitHeightPX = 600; // Max height for stem exhibits (in pixels)
        public static int MaxDnDWidthPX = 785; // Max width for images in DnD area (in pixels)
        public static int MaxDnDHeightPX = 560; // Max height for images in DnD area (in pixels)
        public static int MaxOptionWidthPX = 500; // Max width for options (in pixels)
        public static int MaxOptionHeightPX = 220; // Max height for options (in pixels)
    }
}
