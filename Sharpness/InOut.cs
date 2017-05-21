using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sharpness
{
    public class InOut
    {
        /**
        var dialog = new System.Windows.Forms.FolderBrowserDialog();
        System.Windows.Forms.DialogResult result = dialog.ShowDialog();
        System.Diagnostics.Debug.WriteLine("XXXXXXXXXXX\n" + result + "\nXXXXXXXXXXXXX");
        public static string sourcePath = @Console.ReadLine();
        public static string sourcePath = folderBrowserDialog1.ShowDialog();
        var dialog = new FolderBrowserDialog();
        var dialog = new System.Windows.Forms.FolderBrowserDialog();
        System.Windows.Forms.DialogResult result = dialog.ShowDialog();
        System.Diagnostics.Debug.WriteLine("XXXXXXXXXXX\n" + result + "\nXXXXXXXXXXXXX");
        */

        /// <summary> input your path withour quotes </summary>
        /// the path to the project base folder
        public static string sourcePath = @Console.ReadLine();

        ///  name of the project folder
        public static string sourceFolder = Regex.Match(sourcePath, "\\\\(?:.(?!\\\\))+$").Value;

        /// path to the output base folder
        public static string outFolder =
            sourcePath.Substring(0, sourcePath.Length - sourceFolder.Length) + sourceFolder + @"_to_CS\";

        public static String[] allfiles;

        public void PrintFiles()
        {
            System.Diagnostics.Debug.WriteLine("sourcePath:\n" + sourcePath + "\n");
            System.Diagnostics.Debug.WriteLine("outFolder:\n" + outFolder + "\n");
            (new System.IO.FileInfo(outFolder)).Directory.Create();
            allfiles = System.IO.Directory.GetFiles(sourcePath, "*.m", System.IO.SearchOption.AllDirectories);

            //var pattern = sourceFolder.Substring(1);
            //var options = RegexOptions.None;
            //var regex = new Regex(pattern, options, TimeSpan.FromMilliseconds(1000));
            //var replacement = outFolder.Substring(sourcePath.Length - sourceFolder.Length + 1, outFolder.Length - sourcePath.Length + sourceFolder.Length - 2);
            //for (int i = 0; i < allfiles.Length; i++)
            //{
            //    allfiles[i] = regex.Replace(allfiles[i], replacement);
            //}
            foreach (string s in allfiles)
            {
                System.Diagnostics.Debug.WriteLine(s);///.substring(sourcepath.length + 1));
            }
            //System.IO.File.AppendAllLines(outFolder + "test.txt", allfiles2);

            foreach (string s in allfiles)
            {
                System.Diagnostics.Debug.WriteLine(s);
                string[] tempString = Regex.Split(s.Substring(sourcePath.Length + 1), "\\\\[^\\\\]+$", RegexOptions.Singleline);    // returns tupels with [0]=path [1]=filename(actually empty)
                string outFile = outFolder + tempString[0] + "\\"; //s.Substring(sourcePath.Length + 1);
                (new System.IO.FileInfo(outFile)).Directory.Create();
                System.Diagnostics.Debug.WriteLine(outFolder);
                System.Diagnostics.Debug.WriteLine(s);//.Substring(sourcePath.Length + 1));
                System.Diagnostics.Debug.WriteLine(outFile);
                System.Diagnostics.Debug.WriteLine("...");
                /// <summary> input your desired file and output path (params: inputFile, outputPath, null ) </summary>
                new SharpnessParser().TransformFile(s, outFile, null);
            }
        }

    }
}
