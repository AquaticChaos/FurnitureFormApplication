#pragma warning disable SYSLIB0011 //This is to temporarily suppress the warning of BinaryFormatter's obsolete status

using Prog3Start;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms.Design;
using System.Xml;
using System.Xml.Serialization;

namespace Prog2Start
{
    public partial class FurnitureForm : Form
    {
        public FurnitureForm()
        {
            InitializeComponent();
            furnitures = new List<Furniture>();
        }

        private List<Furniture> furnitures;

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the starting point for Program 3. Customize the message for your program.", "Program 3 About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void couchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CouchForm toCreate = new CouchForm();
            toCreate.ShowDialog();
            if (toCreate.DialogResult == DialogResult.OK)
            {
                string[] labels = new string[3];
                labels[0] = "Couch";
                labels[1] = toCreate.CreatedCouch.Weight.ToString();
                labels[2] = toCreate.CreatedCouch.Category.ToString();
                ListViewItem cItem = new ListViewItem(labels);
                furnitureListView.Items.Add(cItem);
                furnitures.Add(toCreate.CreatedCouch);
                toCreate.Dispose();
            }
        }

        private void deskChairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeskChairForm toCreate = new DeskChairForm();
            toCreate.ShowDialog();
            if (toCreate.DialogResult == DialogResult.OK)
            {
                string[] labels = new string[3];
                labels[0] = "Desk Chair";
                labels[1] = toCreate.CreatedChair.Weight.ToString();
                labels[2] = toCreate.CreatedChair.Category.ToString();
                ListViewItem dItem = new ListViewItem(labels);
                furnitureListView.Items.Add(dItem);
                furnitures.Add(toCreate.CreatedChair);
                toCreate.Dispose();
            }
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (furnitureListView.SelectedIndices.Count > 0)
            {
                int index = furnitureListView.SelectedIndices[0];
                MessageBox.Show(furnitures[index].ToString(), "Furniture Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show and modify save file dialog box
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save File";
            saveFile.DefaultExt = ".bin";
            saveFile.Filter = "Binary File|*.bin";

            //Grab the dialogresult once it closes
            DialogResult result = saveFile.ShowDialog();
            if (result == DialogResult.OK) //Did the user click OK?
            {
                //Grab the file name and location for saving, set up binary formatter
                string fileToSave = saveFile.FileName;
                BinaryFormatter binForm = new BinaryFormatter();

                using (FileStream stream = new FileStream(fileToSave, FileMode.Create))
                {
                    //Set position of file stream to start of file, serialize list of furnitures, then close stream
                    stream.Position = 0;
                    binForm.Serialize(stream, furnitures);
                    stream.Close();
                }
            } else
            {
                //User clicked cancel or the top-right X, show message about cancellation
                MessageBox.Show("Action cancelled");
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Boolean to check if it's okay to begin loading process
            bool validFile;

            if(furnitures.Count > 0 || furnitureListView.Items.Count > 0)
            {//Does either the listView or the list of Furniture contain anything?
                DialogResult overrideResult = MessageBox.Show("Are you sure you wish to override the current list?\nThis will erase the contents!", "Overwrite Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(overrideResult == DialogResult.Yes) { //Ask user if they wish to override both
                    //Clear both for loading, set boolean to true
                    validFile = true;
                    furnitures.Clear();
                    furnitureListView.Items.Clear();
                } 
                else { 
                    //Boolean set to false, prevent loading, show message box about cancellation
                    validFile = false;
                    MessageBox.Show("Action cancelled");
                }
            } else {validFile = true;  //Listview and list are already empty, ready for loading}

            if(validFile == true)
            {//If both ListView and furniture list are empty, show and modify open dialog box
                OpenFileDialog loadFile = new OpenFileDialog();
                loadFile.Title = "Load File";
                loadFile.DefaultExt = ".bin";
                loadFile.Filter = "Binary File|*.bin";

                //Grab dialog result of dialog box
                DialogResult result = loadFile.ShowDialog();
                if (result == DialogResult.OK)
                { //If user clicked OK, setup file name/location and binary formatter
                    string fileToLoad = loadFile.FileName;
                    BinaryFormatter binForm = new BinaryFormatter();
                    FileStream stream = new FileStream(fileToLoad, FileMode.Create);
                    try
                    {//Attempt to load the .bin info, populating both the furniture list and ListView then closing stream when done
                        using (stream)
                        {
                            stream.Position = 0;
                            furnitures = (List<Furniture>)binForm.Deserialize(stream);
                            foreach (Furniture furn in furnitures)
                            {
                                string[] labels = new string[3];
                                labels[0] = furn.GetType().ToString();
                                labels[1] = furn.Weight.ToString();
                                labels[2] = furn.Category.ToString();
                                ListViewItem cItem = new ListViewItem(labels);
                                furnitureListView.Items.Add(cItem);
                            }
                            stream.Close();
                        }
                    } catch
                    { //Something went wrong. Show message box about error, close stream just in case.
                        using (stream) {
                            MessageBox.Show("An error has occured with attempting to load the file.\nPlease select the correct bin file and try again.");
                            stream.Close(); 
                        }
                    }
                }
                else
                {//User clicked cancel or the top-right X, show message about cancellation
                    MessageBox.Show("Action cancelled");
                }
            }
        }
    }
}
}

#pragma warning restore SYSLIB0011 //This is to un-suppress the warning of BinaryFormatter's obsolete status
