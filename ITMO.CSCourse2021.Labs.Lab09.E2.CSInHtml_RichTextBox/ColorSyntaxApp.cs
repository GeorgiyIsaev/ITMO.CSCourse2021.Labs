namespace ColourSyntax
{
	using System;
    using System.IO;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
	using CSharp;

    public class ColorSyntaxApp : System.Windows.Forms.Form
    {
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button1;

        public ColorSyntaxApp()
        {
            InitializeComponent();
        }

        /*
		public override void Dispose()
        {
            base.Dispose();
        }
		*/

        private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.DetectUrls = false;
			this.richTextBox1.Font = new System.Drawing.Font("Courier New", 10F);
			this.richTextBox1.Location = new System.Drawing.Point(16, 56);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(560, 392);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			this.richTextBox1.WordWrap = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(136, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 16);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "Open File";
			this.button1.Click += new System.EventHandler(this.OpenFile);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(136, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Current File";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "C# Files (*.cs)|*.cs|All Files (*.*)|*.*";
			this.openFileDialog1.Title = "OpenC Sharp File";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// ColorSyntaxApp
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 461);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.textBox1,
																		  this.richTextBox1,
																		  this.button1});
			this.Name = "ColorSyntaxApp";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		protected void OpenFile (object sender, System.EventArgs e)
		{
			openFileDialog1.ShowDialog();			
		}

		protected void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string fileName = openFileDialog1.FileName;
			this.textBox1.Text = new FileInfo(fileName).Name;
			StreamReader reader = new StreamReader(fileName);
			try {
				SourceFile source = new SourceFile(fileName);           
				ITokenVisitor visitor = new ColorTokenVisitor(this.richTextBox1);
				source.Accept(visitor);
			}
			finally  {
				reader.Close();
			}
		}

        [STAThread]
        public static void Main(string[] args) 
        {
            Application.Run(new ColorSyntaxApp());
        }
    }
}