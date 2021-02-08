
namespace Laufzeitfehler
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtEingabe1 = new System.Windows.Forms.TextBox();
			this.txtEingabe2 = new System.Windows.Forms.TextBox();
			this.lblAusgabe = new System.Windows.Forms.Label();
			this.btnRechnen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtEingabe1
			// 
			this.txtEingabe1.Location = new System.Drawing.Point(12, 12);
			this.txtEingabe1.Name = "txtEingabe1";
			this.txtEingabe1.Size = new System.Drawing.Size(100, 20);
			this.txtEingabe1.TabIndex = 0;
			// 
			// txtEingabe2
			// 
			this.txtEingabe2.Location = new System.Drawing.Point(12, 38);
			this.txtEingabe2.Name = "txtEingabe2";
			this.txtEingabe2.Size = new System.Drawing.Size(100, 20);
			this.txtEingabe2.TabIndex = 1;
			// 
			// lblAusgabe
			// 
			this.lblAusgabe.AutoSize = true;
			this.lblAusgabe.Location = new System.Drawing.Point(12, 65);
			this.lblAusgabe.Name = "lblAusgabe";
			this.lblAusgabe.Size = new System.Drawing.Size(35, 13);
			this.lblAusgabe.TabIndex = 2;
			this.lblAusgabe.Text = "label1";
			// 
			// btnRechnen
			// 
			this.btnRechnen.Location = new System.Drawing.Point(178, 12);
			this.btnRechnen.Name = "btnRechnen";
			this.btnRechnen.Size = new System.Drawing.Size(75, 23);
			this.btnRechnen.TabIndex = 3;
			this.btnRechnen.Text = "Rechnen";
			this.btnRechnen.UseVisualStyleBackColor = true;
			this.btnRechnen.Click += new System.EventHandler(this.btnRechnen_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 85);
			this.Controls.Add(this.btnRechnen);
			this.Controls.Add(this.lblAusgabe);
			this.Controls.Add(this.txtEingabe2);
			this.Controls.Add(this.txtEingabe1);
			this.Name = "Form1";
			this.Text = "Laufzeitfehler";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEingabe1;
		private System.Windows.Forms.TextBox txtEingabe2;
		private System.Windows.Forms.Label lblAusgabe;
		private System.Windows.Forms.Button btnRechnen;
	}
}

