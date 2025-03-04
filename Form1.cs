using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GmapGenerator
{
    public partial class Form1 : Form
    {
        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtWidth.Text = "2"; 
            txtHeight.Text = "2"; 
            txtCenterX.Text = "1";
            txtCenterY.Text = "1"; 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.AutoSize = false;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGenerate_Click(object sender, EventArgs e) {
            // Clear previous output
            lblOutput.Text = string.Empty;

            string prefix = txtPrefix.Text;
            int width, height, centerX, centerY;

            // Validate inputs
            if (string.IsNullOrEmpty(prefix) || !int.TryParse(txtWidth.Text, out width) || !int.TryParse(txtHeight.Text, out height) || !int.TryParse(txtCenterX.Text, out centerX) || !int.TryParse(txtCenterY.Text, out centerY)) {
                lblOutput.Text = "Please enter valid numeric values and a prefix.";
                lblOutput.ForeColor = System.Drawing.Color.Tomato;
                return;
            }
            if (width < 2 || height < 2 || centerX < 1 || centerY < 1)
            {
                lblOutput.Text = "The specified map size is too small!";
                lblOutput.ForeColor = System.Drawing.Color.Tomato; 
                return;
            }

            // Create directory for the map files
            try
            {
                Directory.CreateDirectory(prefix);
            }
            catch (Exception ex)
            {
                lblOutput.Text = $"Error creating directory: {ex.Message}";
                lblOutput.ForeColor = System.Drawing.Color.Tomato;
                return;
            }

            // Prepare the GMAP file content
            string gmapContent = $"GRMAP001\nWIDTH {width}\nHEIGHT {height}\nLEVELNAMES\n";

            // Create levels
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    string levelName = $"{prefix}_{GetCoords(x + 1, y + 1)}.nw";
                    gmapContent += $"\"{levelName}\"{(x < width - 1 ? "," : "")}";

                    // Create the level file
                    string levelFilePath = Path.Combine(prefix, levelName);
                    File.WriteAllText(levelFilePath, GetLevelContent(x + 1, y + 1));
                }
                gmapContent += "\n";
            }

            // Finish the GMAP file
            gmapContent += "LEVELNAMESEND\n";
            string gmapFilePath = Path.Combine(prefix, $"{prefix}.gmap");
            File.WriteAllText(gmapFilePath, gmapContent);

            // Success message
            lblOutput.Text = "Gmap created successfully!";
            lblOutput.ForeColor = System.Drawing.Color.LimeGreen;
        }


        // Method to get level coordinates
        private string GetCoords(int x, int y)
        {
            string xs, ys;

            if (x >= int.Parse(txtCenterX.Text))
            {
                xs = (x - int.Parse(txtCenterX.Text)).ToString().PadLeft(2, '0');
            }
            else
            {
                int i = int.Parse(txtCenterX.Text) - x - 1;
                xs = $"{(char)(97 + (i / 26))}{(char)(97 + (i % 26))}";
            }

            if (y >= int.Parse(txtCenterY.Text))
            {
                ys = (y - int.Parse(txtCenterY.Text)).ToString().PadLeft(2, '0');
            }
            else
            {
                int i = int.Parse(txtCenterY.Text) - y - 1;
                ys = $"{(char)(97 + (i / 26))}{(char)(97 + (i % 26))}";
            }

            return $"{xs}-{ys}";
        }

        // Method to get the content of a level file
        private string GetLevelContent(int x, int y)
        {
            string templateFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "template.nw");
    
            // Check if the template file exists
            if (File.Exists(templateFilePath))
            {
                string[] lines = File.ReadAllLines(templateFilePath);
                string links = GetLinks(x, y); 
                string lTemplate = string.Join(Environment.NewLine, lines);
                if (lTemplate.Contains("{LINKS}"))
                {
                    lTemplate = lTemplate.Replace("{LINKS}", links); 
                }
                else
                {
                    lTemplate += Environment.NewLine + links; 
                }

                return lTemplate;
            }
            else
            {
                // Fallback if the template.nw file does not exist in the folder
                string links = GetLinks(x, y);
                string lTemplate = "GLEVNW01" + Environment.NewLine;

                const string fValues = "f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/f/";

                for (int i = 0; i < 64; i++)
                {
                    lTemplate += $"BOARD 0 {i} 64 0 {fValues}" + Environment.NewLine;
                }

                return lTemplate + links;
            }
        }

        // Method to get level links
        private string GetLinks(int x, int y)
        {
            if (!chkAddLinks.Checked)
            {
                return string.Empty;
            }

            string links = string.Empty;
            links += Environment.NewLine;
            if (x > 1)
            {
                links += $"LINK {txtPrefix.Text}_{GetCoords(x - 1, y)}.nw 0 0 1 64 61 playery\n";
            }
            if (x < int.Parse(txtWidth.Text))
            {
                links += $"LINK {txtPrefix.Text}_{GetCoords(x + 1, y)}.nw 63 0 1 64 0 playery\n";
            }
            if (y > 1)
            {
                links += $"LINK {txtPrefix.Text}_{GetCoords(x, y - 1)}.nw 0 0 64 1 playerx 61\n";
            }
            if (y < int.Parse(txtHeight.Text))
            {
                links += $"LINK {txtPrefix.Text}_{GetCoords(x, y + 1)}.nw 0 63 64 1 playerx 0\n";
            }

            return links;
        }
    }
}

