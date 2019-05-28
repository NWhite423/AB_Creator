using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ABCreator
{
    public partial class FormMain : Form
    {

        public static List<String> Logs = new List<string> { };
        public static List<String> Categories = new List<string> { };
        public static string BaseDirectory = String.Empty;

        public void UpdateLog(string entry)
        {
            string logTime = DateTime.Now.ToString("HH:mm:ss");
            string logEntry = String.Format("[{0}]: {1}", logTime, entry);
            Logs.Add(logEntry);
            LblLog.Clear();
            LblLog.Lines = Logs.ToArray();
        }

        public void InitForm(object sender, EventArgs e)
        {
            TxtCADTemplate.Text = Properties.Settings.Default.TemplateFile;
            TxtATTemplate.Text = Properties.Settings.Default.AssetTableFile;

            this.Text = string.Format("AB Directory {0}", Assembly.GetEntryAssembly().GetName().Version);
            #if DEBUG
                this.Text += " [DEBUG]";
            #endif

            if (!String.IsNullOrEmpty(Properties.Settings.Default.TemplateFile))
            {
                TxtCADTemplate.Text = Properties.Settings.Default.TemplateFile;
            }
            if (!String.IsNullOrEmpty(Properties.Settings.Default.AssetTableFile))
            {
                TxtATTemplate.Text = Properties.Settings.Default.AssetTableFile;
            }
        }

        public void DirectorySelection(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Debug.WriteLine(button.Name);
            switch (button.Name)
            {
                case "CmdSelectDirectory":
                    {
                        FolderBrowserDialog dialog = new FolderBrowserDialog();
                        dialog.ShowDialog();
                        if (dialog.Equals(DialogResult.OK) && String.IsNullOrEmpty(dialog.SelectedPath))
                        {
                            MessageBox.Show("Folder specified is not valid or does not exist, plase try again or type in manually.", "Error");
                            return;
                        }
                        TxtDirectory.Text = dialog.SelectedPath;
                        TxtJobName.Text = Path.GetFileNameWithoutExtension(dialog.SelectedPath) + " ";
                        BaseDirectory = TxtJobName.Text;
                        UpdateLog("Directory changed to (" + dialog.SelectedPath + ")");
                        break;
                    }
                case "CmdATSelect":
                case "CmdTemplateSelect":
                    {
                        OpenFileDialog dialog = new OpenFileDialog
                        {
                            CheckPathExists = true,
                            Multiselect = false,
                            Title = "Please select a drawing template file."
                        };
                        if (button.Name.Equals("CmdTemplateSelect"))
                        {
                            if (!String.IsNullOrEmpty(Properties.Settings.Default.TemplateFile))
                            {
                                dialog.FileName = Properties.Settings.Default.TemplateFile;
                            }
                            dialog.Filter = "AutoCAD Drawing|*.dwg|All Files|*.*";
                        } else
                        {
                            if (!String.IsNullOrEmpty(Properties.Settings.Default.AssetTableFile))
                            {
                                dialog.FileName = Properties.Settings.Default.AssetTableFile;
                            }
                            dialog.Filter = "Excel File|*.xlsx;*.xls|All Files|*.*";
                        }
                        dialog.ShowDialog();
                        if (dialog.Equals(DialogResult.OK) && String.IsNullOrEmpty(dialog.FileName))
                        {
                            MessageBox.Show("File specified is not valid or does not exist, plase try again or type in manually.", "Error");
                            return;
                        }
                        if (button.Name.Equals("CmdTemplateSelect"))
                        {
                            TxtCADTemplate.Text = dialog.FileName;
                            Properties.Settings.Default.TemplateFile = dialog.FileName;
                            Properties.Settings.Default.Save();
                            UpdateLog("AutoCAD Template file changed to " + Path.GetFileName(dialog.FileName) + " (" + dialog.FileName + ")");
                        }
                        else
                        {
                            TxtATTemplate.Text = dialog.FileName;
                            Properties.Settings.Default.AssetTableFile = dialog.FileName;
                            Properties.Settings.Default.Save();
                            UpdateLog("Asset Table Template file changed to " + Path.GetFileName(dialog.FileName) + " (" + dialog.FileName + ")");
                        }
                        break;
                    }
            }
        }

        public void AddTypicalItems(object sender, EventArgs e)
        {
            string[] typiacalItems = new string[] {"Foundation Survey", "Water As-Built", "Sanitary Sewer As-Built", "Paving, Grading, and Drainage As-Built" };
            Categories = typiacalItems.ToList();
            if (LBCategories.Items.Count > 0)
            {
                LBCategories.Items.Clear();
            }
            foreach (string item in typiacalItems)
            {
                LBCategories.Items.Add(item);
            }
            UpdateLog("Added typical items to the sub-category list");
        }

        public void AddItemToList(object sender, EventArgs e)
        {
            string entry = TxtABCategoryName.Text;
            if (LBCategories.Items.Contains(entry))
            {
                int index = LBCategories.Items.IndexOf(entry);
                LBCategories.SelectedIndex = index;
                TxtABCategoryName.Text = String.Empty;
                return;
            }
            Categories.Add(entry);
            if (LBCategories.Items.Count > 0)
            {
                LBCategories.Items.Clear();
            }
            foreach (string item in Categories)
            {
                LBCategories.Items.Add(item);
            }
            TxtABCategoryName.Text = String.Empty;
            UpdateLog("Added " + entry + " to the sub-category list");

        }

        public void CategoryKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                AddItemToList(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public void RenameItem(object sender, EventArgs e)
        {
            int index = LBCategories.SelectedIndex;
            string oldValue = LBCategories.GetItemText(LBCategories.Items[index]);
            string newValue = TxtABCategoryName.Text;
            if (String.IsNullOrEmpty(newValue) || index < 0 || oldValue.Equals(newValue) || index > LBCategories.Items.Count - 1)
            {
                return;
            }
            Categories[index] = newValue;
            if (LBCategories.Items.Count > 0)
            {
                LBCategories.Items.Clear();
            }
            foreach (string item in Categories)
            {
                LBCategories.Items.Add(item);
            }
            TxtABCategoryName.Text = String.Empty;
            UpdateLog("Renamed " + oldValue + " to " + newValue);
        }

        public void RemoveItem(object sender, EventArgs e)
        {
            int index = LBCategories.SelectedIndex;
            string value = LBCategories.GetItemText(LBCategories.Items[index]);
            if (index < 0 || index > LBCategories.Items.Count - 1)
            {
                return;
            } 
            Categories.RemoveAt(index);
            if (LBCategories.Items.Count > 0)
            {
                LBCategories.Items.Clear();
            }
            foreach (string item in Categories)
            {
                LBCategories.Items.Add(item);
            }
            UpdateLog("Removed " + value + " from the sub-category list");
        }

        public void CreateFolders(object sender, EventArgs e)
        {
            DialogResult result;
            if (TxtJobName.Text.Equals(BaseDirectory))
            {
                result = MessageBox.Show("The job was not given a name, do you wish to continue?", "Confirm creation without name", MessageBoxButtons.YesNo);
                if (result.Equals(DialogResult.Yes))
                {
                    BaseDirectory = Path.GetFileNameWithoutExtension(TxtDirectory.Text);
                }
                else
                {
                    return;
                }
            }
            BaseDirectory = TxtJobName.Text;

           result = MessageBox.Show("Please confirm the following information\n" +
                "Job Name: " + BaseDirectory + "\n" +
                "AutoCAD template: " + Path.GetFileName(TxtCADTemplate.Text) + "\n" +
                "Asset Table template: " + Path.GetFileName(TxtATTemplate.Text) + "\n" +
                "Folders to create: " + Categories.Count + "\n" +
                "\n" +
                "Is this information correct?", "Confirm Information", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                string directoryBase = TxtDirectory.Text;

                directoryBase = CreateFolder(directoryBase, "As-Built");
                CreateFolder(directoryBase, "AutoCAD");
                CreateFolder(directoryBase, "Excel");
                CreateFolder(directoryBase, "Submittal");
                CreateFolder(directoryBase, "Misc Items");

                string directoryTemp = Path.Combine(directoryBase, "AutoCAD");

                string directorySub;
                CreateFile(directoryTemp, TxtJobName.Text, TxtCADTemplate.Text);
                foreach (string item in Categories)
                {
                    CreateFolder(Path.Combine(directoryBase, "Submittal"), item);
                    directorySub = CreateFolder(directoryTemp, item);
                    CreateFile(directorySub, TxtJobName.Text + " " + item, TxtCADTemplate.Text);
                }
                CreateFile(Path.Combine(directoryBase, "Excel"), TxtJobName.Text + " Asset Table", TxtATTemplate.Text);

                UpdateLog("Folders created by " + System.Security.Principal.WindowsIdentity.GetCurrent().Name);
                File.WriteAllLines(Path.Combine(directoryBase, "log.txt"), Logs);

                result = MessageBox.Show("Creation complete, go to folder?", "Task Complete", MessageBoxButtons.YesNo);
                if (result.Equals(DialogResult.Yes))
                {
                    Process.Start(directoryBase); 
                }
            }
        }

        public string CreateFolder(string path, string name)
        {
            string newPath = Path.Combine(path, name);
            if (String.IsNullOrEmpty(path) || String.IsNullOrEmpty(name))
            {
                UpdateLog("Failed to create " + newPath + ", path is not valid");
                return String.Empty;
            }
            if (Directory.Exists(newPath))
            {
                UpdateLog("Failed to create " + newPath + ", path already exists");
                return String.Empty;
            }
            try
            {
                Directory.CreateDirectory(newPath);
                UpdateLog(newPath + " created successfully");
                return newPath;
            }
            catch (Exception e)
            {
                UpdateLog("Failed to create " + newPath + ", " + e.Message);
                #if DEBUG
                throw e;
                #else
                return String.Empty;
                #endif
            }

        }

        /// <summary>
        /// Copy a file from source to nameed file
        /// </summary>
        /// <param name="path">Base directory</param>
        /// <param name="name">Name to rename the file to</param>
        /// <param name="source">Source file path</param>
        /// <returns></returns>
        public string CreateFile(string path, string name, string source)
        {
            string fileName = Path.Combine(path, name + (Path.GetExtension(source)));
            if (String.IsNullOrEmpty(path) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(source))
            {
                UpdateLog("Failed to create " + fileName + ", path is not valid");
                return String.Empty;
            }
            if (File.Exists(fileName))
            {
                UpdateLog("Failed to create " + fileName + ", file already exists");
                return String.Empty;
            }
            try
            {
                File.Copy(source, fileName);
                UpdateLog(fileName + " created successfully");
                return fileName;
            }
            catch (Exception e)
            {
                UpdateLog("Failed to create " + fileName + ", " + e.Message);
            #if DEBUG
                throw e;
            #else
                return String.Empty;
            #endif
            }
        }

        public FormMain()
        {
            InitializeComponent();
        }

        public void ShowAbout(object sender, EventArgs e)
        {
            AboutBox dialog = new AboutBox();
            dialog.Show();
        }
    }
}
