using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrmDirectory1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            /*
            CreateDirectory(String)
            Creates all directories and subdirectories in the specified path unless they already exist.
            */

            // Specify the directory you want to manipulate.
            string path = @"c:\MyDir";

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    MessageBox.Show("That path exists already.");
                    return;
                }

                // Try to create the directory.
                // Directory.CreateDirectory(path);
                DirectoryInfo di = Directory.CreateDirectory(path);
                MessageBox.Show("The directory was created successfully at "+ Directory.GetCreationTime(path));
              //  Directory.Delete(path);
                // Delete the directory.
                di.Delete();
                MessageBox.Show("The directory was deleted successfully.");
            }
            catch (Exception er)
            {
                MessageBox.Show("The process failed: " + er.ToString());
            }
            finally { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete(String)
            //Deletes an empty directory from a specified path.
            //This directory must be writable and empty.
            string subPath = @"C:\NewDirectory\NewSubDirectory";

            try
            {
                Directory.CreateDirectory(subPath);
                Directory.Delete(subPath);

                bool directoryExists = Directory.Exists(@"C:\NewDirectory");
                bool subDirectoryExists = Directory.Exists(subPath);

                MessageBox.Show("top - level directory exists: " + directoryExists);
                MessageBox.Show("sub-directory exists: " + subDirectoryExists);

            }
            catch (Exception er)
            {
                MessageBox.Show("The process failed: " + er.Message);
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            /*
            Directory.Move(String, String) Method
            Moves a file or a directory and its contents to a new location.
            public static void Move (string sourceDirName, string destDirName);
            */
            string sourceDirectory = @"C:\source";
            string destinationDirectory = @"C:\destination";
            Directory.CreateDirectory(sourceDirectory);
            Directory.CreateDirectory(destinationDirectory);


            try
            {
                Directory.Move(sourceDirectory, destinationDirectory);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnGetDirectories_Click(object sender, EventArgs e)
        {

            /*
            Directory.GetDirectories Method
            Returns a string array containing the names of the subdirectories in the specified directory.            
            */
            try
            {
                string output = "";
                string[] dirs = Directory.GetDirectories(@"c:\source");                
                MessageBox.Show(@"The number of directories in c:\source is " + dirs.Length);                
                foreach (string dir in dirs)
                {
                    output += dir + "\n";                    
                }
                MessageBox.Show(output);


                output = "";
                dirs = Directory.GetDirectories(@"c:\source", "a*", SearchOption.TopDirectoryOnly);
                //0dirs = Directory.GetDirectories(@"c:\source","*", SearchOption.AllDirectories);
                MessageBox.Show("The number of directories starting with a is " + dirs.Length);
                foreach (string dir in dirs)
                {
                    output += dir + "\n";
                }
                MessageBox.Show(output);
            }
            catch (Exception er)
            {
                MessageBox.Show("The process failed: " + er.ToString());
            }

        }

        private void btnGetFiles_Click(object sender, EventArgs e)
        {
            /*
            Directory.GetFiles Method
            Returns a string array containing the names of the files in the specified directory.
            */
            string output = "";
            string targetDirectory = @"c:\source";
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                output += fileName + "\n";

            MessageBox.Show(output);

            targetDirectory = @"c:\source";
            output = "";
            output += "Creation Time: " + Directory.GetCreationTime(targetDirectory)+"\n";
            output += "Last Access Time: " + Directory.GetLastAccessTime(targetDirectory) + "\n";
            output += "Last Write Time: " + Directory.GetLastWriteTime(targetDirectory) + "\n";
            MessageBox.Show(output);
        }

        private void btnCreateInfo_Click(object sender, EventArgs e)
        {
            //Use the DirectoryInfo class for typical operations such as copying,
            //moving, renaming, creating, and deleting directories.

            // Specify the directories you want to manipulate.
            DirectoryInfo di = new DirectoryInfo(@"c:\MyDir");
            try
            {
                // Determine whether the directory exists.
                if (di.Exists)
                {
                    // Indicate that the directory already exists.
                    MessageBox.Show("That path exists already.");                    
                    return;
                }

                // Try to create the directory.
                di.Create();
                MessageBox.Show("The directory was created successfully.");                

                // Delete the directory.
                di.Delete();
                MessageBox.Show("The directory was deleted successfully.");
            }
            catch (Exception er)
            {
                MessageBox.Show("The process failed: " + er.ToString());
            }
            finally { }
        }

        private void btnCopyAll_Click(object sender, EventArgs e)
        {
            string sourceDirectory = @"c:\sourceDirectory";
            string targetDirectory = @"c:\targetDirectory";

            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);
            diSource.Create();
            diTarget.Create();

            CopyAll(diSource, diTarget);
            MessageBox.Show("Copy operation performed.");
        }
        public void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }

            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo di1 in source.GetDirectories())
            {
                DirectoryInfo next1 =
                    target.CreateSubdirectory(di1.Name);
                CopyAll(di1, next1);
            }
        }

        private void btnMoveTo_Click(object sender, EventArgs e)
        {
            //Moves a DirectoryInfo instance and its contents to a new path.

            // Make a reference to a directory.
            DirectoryInfo di = new DirectoryInfo(@"c:\TempDir");

            // Create the directory only if it does not already exist.
            if (di.Exists == false)
                di.Create();

            // Create a subdirectory in the directory just created.
            DirectoryInfo dis = di.CreateSubdirectory("SubDir");

            // Move the main directory. Note that the contents move with the directory.
            if (Directory.Exists("NewTempDir") == false)
                Directory.CreateDirectory(@"c:\NewTempDir");
                di.MoveTo(@"c:\NewTempDir");

            try
            {
                // Attempt to delete the subdirectory. Note that because it has been
                // moved, an exception is thrown.
                dis.Delete(true);
            }
            catch (Exception)
            {
                // Handle this exception in some way, such as with the following code:
                MessageBox.Show("That directory does not exist.");
            }
        }

        private void btnGetDirectoriesInfo_Click(object sender, EventArgs e)
        {
            //GetDirectories()
            //Returns the subdirectories of the current directory.

            string output = "";
            // Make a reference to a directory.
            DirectoryInfo di = new DirectoryInfo("c:\\");

            // Get a reference to each directory in that directory.
            DirectoryInfo[] diArr = di.GetDirectories();

            // Display the names of the directories.
            foreach (DirectoryInfo dri in diArr)
                output += dri.Name + "\n";

            MessageBox.Show(output);
        }

        private void btnGetFilesInfo_Click(object sender, EventArgs e)
        {
            //DirectoryInfo.GetFiles Method
            //Returns a file list from the current directory.
            string output = "";
            DirectoryInfo di = Directory.CreateDirectory(@"C:\myFiles");
            //  FileInfo[] diarr = di.GetFiles();
            //foreach (FileInfo fi in diarr)
            //{
            //    output += fi.Name + "\n";
            //}we can also use this instead of what we wrote bellow
            Console.WriteLine("No search pattern returns:");
            foreach (var fi in di.GetFiles())
            {
                output += fi.Name + "\n";
            }
            MessageBox.Show(output, "No search pattern returns:");

            output = "";
            Console.WriteLine("Search pattern *2* returns:");
            foreach (var fi in di.GetFiles("*2*"))
            {
                output += fi.Name + "\n";
            }
            MessageBox.Show(output, "Search pattern *2* returns:");

            output = "";
            foreach (var fi in di.GetFiles("test?.txt"))
            {
                output += fi.Name + "\n";
            }
            MessageBox.Show(output, "Search pattern test?.txt returns:");

            output = "";
            foreach (var fi in di.GetFiles("*", SearchOption.AllDirectories))
            {
                output += fi.Name + "\n";
            }
            MessageBox.Show(output, "Search pattern AllDirectories returns:");


        }
    }
}
/*
Difference
Directory class is a static class which can be used to create, move, enumerate directories
and sub directories. The DirectoryInfo class is also served for the same purpose like Directory class
where its members are instance members as opposed to Directory class.
The main difference between the two lies in when we can use these classes.
Directory class can be used when we want to a simple folder operation at once.
For example, you need to delete the folder and get away.
But, the DirectoryInfo class is associated with a folder and provides you all the operations
that can be done on the folder.
The DirectoryInfo class accepts a path as parameter when instantiating and
provides you everything on the folder. You can create subdirectories, move, enumerate etc.

Directory Class Usage

        string path = "c:\myTest";
        //Create Directory
        Directory.CreateDirectory(path);
        //Delete Directory
        Directory.Delete(path);
 
        If you see the above code, we need to give the path the folder every time
        we do an operation on a folder. Thus, we can use this for single operation on a folder.

 
DirectoryInfo Class Usage
        string path = "c:\myTest";
        DirectoryInfo dirinfo = new DirectoryInfo(path);
        //Create Directory
        dirinfo.Create();
        //Delete Directory
        dirinfo.Delete();
        If you see the above code, we create a DirectoryInfo object with a folder and
        can perform series of operation on that folder like delete, creating sub directories, etc.
*/
