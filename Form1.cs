using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace NVGNotes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			ActualFont = new Font(defaultFont, defaultFontSize);
		}

		public string defaultFont = "Albert Sans";
		public int defaultFontSize = 10;
		public FontStyle defaultFontStyle = FontStyle.Regular;
		public Font ActualFont { get; set; }

		private void clearButton_Click(object sender, EventArgs e)
		{
			textBox.Text = string.Empty;
		}

		private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			textBox.Text = string.Empty;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			FontFamily defaultFontFamily = new FontFamily(defaultFont);
			textBox.Font = new Font(defaultFontFamily, defaultFontSize, defaultFontStyle);
		}

		private void boldButton_Click(object sender, EventArgs e)
		{
			defaultFontStyle = FontStyle.Bold;
			FontFamily defaultFontFamily = new FontFamily(defaultFont);
			textBox.Font = new Font(defaultFontFamily, defaultFontSize, defaultFontStyle);
		}

		private void italicButton_Click(object sender, EventArgs e)
		{
			defaultFontStyle = FontStyle.Italic;
			FontFamily defaultFontFamily = new FontFamily(defaultFont);
			textBox.Font = new Font(defaultFontFamily, defaultFontSize, defaultFontStyle);
		}

		private void boldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			defaultFontStyle = FontStyle.Bold;
			FontFamily defaultFontFamily = new FontFamily(defaultFont);
			textBox.Font = new Font(defaultFontFamily, defaultFontSize, defaultFontStyle);
		}

		private void italicToolStripMenuItem_Click(object sender, EventArgs e)
		{
			defaultFontStyle = FontStyle.Italic;
			FontFamily defaultFontFamily = new FontFamily(defaultFont);
			textBox.Font = new Font(defaultFontFamily, defaultFontSize, defaultFontStyle);
		}

		private void underlineBTN_Click(object sender, EventArgs e)
		{
			defaultFontStyle = FontStyle.Underline;
			FontFamily defaultFontFamily = new FontFamily(defaultFont);
			textBox.Font = new Font(defaultFontFamily, defaultFontSize, defaultFontStyle);
		}

		private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			defaultFontStyle = FontStyle.Underline;
			FontFamily defaultFontFamily = new FontFamily(defaultFont);
			textBox.Font = new Font(defaultFontFamily, defaultFontSize, defaultFontStyle);
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			defaultFontStyle = FontStyle.Regular;
			FontFamily defaultFontFamily = new FontFamily(defaultFont);
			textBox.Font = new Font(defaultFontFamily, defaultFontSize, defaultFontStyle);
		}

		private void fontSize_ValueChanged(object sender, EventArgs e)
		{
			defaultFontSize = Convert.ToInt32(Math.Round(fontSize.Value, 0));
			FontFamily defaultFontFamily = new FontFamily(defaultFont);
			textBox.Font = new Font(defaultFontFamily, defaultFontSize, defaultFontStyle);
		}


		private void aboutNVGNotesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.Show();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFile = new SaveFileDialog();

			// Set the initial directory and file name filter
			saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

			// Show the save file dialog and check if the user clicked the "OK" button
			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				// Get the selected file name
				string fileName = saveFile.FileName;

				try
				{
					// Save the contents of the textBox to the selected file
					File.WriteAllText(fileName, textBox.Text);

					MessageBox.Show("File saved successfully!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error saving file: " + ex.Message);
				}
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			// Set the initial directory and file name filter
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

			// Show the open file dialog and check if the user clicked the "OK" button
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Get the selected file name
				string fileName = openFileDialog.FileName;

				try
				{
					// Read the contents of the selected file
					string fileContents = File.ReadAllText(fileName);

					// Display the file contents in the textBox
					textBox.Text = fileContents;

					MessageBox.Show("File opened successfully!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error opening file: " + ex.Message);
				}
			}
		}

		private void printToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PrintDialog printDialog = new PrintDialog();

			// Set the PrintDocument instance for the print dialog
			PrintDocument printDocument = new PrintDocument();
			printDialog.Document = printDocument;

			// Show the print dialog and check if the user clicked the "OK" button
			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				// Set the PrintPage event handler for the PrintDocument
				printDocument.PrintPage += PrintDocument_PrintPage;

				// Start the printing process
				printDocument.Print();
			}
		}
		private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			// Get the text from the textBox control
			string textToPrint = textBox.Text;

			// Create a font and calculate the size of the text
			Font font = new Font(defaultFont, defaultFontSize, defaultFontStyle);
			SizeF textSize = e.Graphics.MeasureString(textToPrint, font);

			// Calculate the printable area of the page
			RectangleF printArea = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);

			// Print the text within the printable area
			e.Graphics.DrawString(textToPrint, font, Brushes.Black, printArea);

			// Check if there are more pages to print
			e.HasMorePages = false;
		}
	}
}