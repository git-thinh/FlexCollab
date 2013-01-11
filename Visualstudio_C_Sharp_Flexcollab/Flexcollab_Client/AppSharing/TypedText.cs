using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WebMeeting
{
	/// <summary>
	/// Summary description for TypedText.
	/// </summary>
	public class TypedText : System.Windows.Forms.Form
	{
		public System.Windows.Forms.TextBox textBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TypedText()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 8);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(392, 64);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "typedText";
			// 
			// TypedText
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(408, 78);
			this.Controls.Add(this.textBox1);
			this.Name = "TypedText";
			this.Text = "TypedText";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
