using System;
using System.Windows.Forms;
using System.Xml;

namespace XMLFileHandling
{
    public partial class Form1 : Form
    {
        // Constructor
        public Form1()
        {
            InitializeComponent();
        }

        // Button click event to load the XML file and display its content
        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            // Create a new XmlDocument object
            XmlDocument xmlDoc = new XmlDocument();
            
            try
            {
                // Load the XML file
                xmlDoc.Load("data.xml");

                // Clear the TextBox or ListBox to display new data
                txtDisplay.Clear();  // Assuming you are using a TextBox (or ListBox, depending on your design)

                // Get the root element ("Students")
                XmlNodeList studentNodes = xmlDoc.GetElementsByTagName("Student");

                // Loop through each Student node and display the data
                foreach (XmlNode student in studentNodes)
                {
                    // Extract data for each student
                    string regNo = student["RegNo"]?.InnerText ?? "N/A";
                    string name = student["Name"]?.InnerText ?? "N/A";
                    string age = student["Age"]?.InnerText ?? "N/A";
                    string className = student["Class"]?.InnerText ?? "N/A";

                    // Display the values in the TextBox
                    txtDisplay.AppendText($"RegNo: {regNo}\n");
                    txtDisplay.AppendText($"Name: {name}\n");
                    txtDisplay.AppendText($"Age: {age}\n");
                    txtDisplay.AppendText($"Class: {className}\n");
                    txtDisplay.AppendText("----------------------------\n");
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show($"Error loading XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
