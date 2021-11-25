using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

/*
 * Access a file - 
 * 
 * fptr = fopen(filename, rwa+)
 * 
 * stream reader/writer
 * 
 * file formats -  JSON - JavaScript Object Notation
 * 
 * similar to xml, (xaml, html, sgml)
 *      eXtensible Markup Language
 * 
 * 
 */


namespace Thurs251400
{
    public partial class MainPage : ContentPage
    {
        const string TEST_DATA = "this is a test, 1,2,3";
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnReadFile_Clicked(object sender, EventArgs e)
        {
            // set the filenames, open the reader, read the text
            string path;
            string fullFileName;

            path = Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData);
            fullFileName = Path.Combine(path, EntryFileName.Text);
            LblFileData.Text = MyUtils.ReadFromFile(fullFileName);
        }

        private void BtnWriteFile_Clicked(object sender, EventArgs e)
        {
            // write to the file
            // path = "C:\Users\dcostello\AppData
            // environment variables $WIN32 $SYSTEM $COMMON
            // LocalApplicationData folder defined for me. Local files stored here
            string path;
            string fullFileName;

            path = Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData);
            // C:\Users\dcostello\AppDatatest.txt
            // C:\Users\dcostello\AppData\test.txt
            // Path is in system.IO
            fullFileName = Path.Combine(path, EntryFileName.Text);
            MyUtils.WriteToFile(fullFileName, TEST_DATA);

        }
    }
}
