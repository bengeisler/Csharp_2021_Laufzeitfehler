using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laufzeitfehler
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnRechnen_Click(object sender, EventArgs e)
		{
			int x, y, z;

			// "Gesicherte Umgebung" 
			try
			{
				// Zahlen aus Textfeldern einlesen und umwandeln
				x = Convert.ToInt32(txtEingabe1.Text);
				y = Convert.ToInt32(txtEingabe2.Text);

				// Division durchführen
				z = x / y;

				// Ergebnis ausgeben
				lblAusgabe.Text = "Ergebnis: " + z;
			}
			// Spezielle Ausnahme: Formatierung falsch
			catch	(FormatException ex)
			{
				lblAusgabe.Text = "Fehler: falsches Eingabeformat";
			}
			// Spezielle Ausnahme: Division durch 0
			catch (DivideByZeroException ex)
			{
				lblAusgabe.Text = "Fehler: Division durch 0.";
			}
			// Ausnahme auffangen: Ausnahme allgemein
			catch (Exception ex)
			{
				// Fehlermeldung zur Anzeige bringen
				lblAusgabe.Text = "Fehler: " + ex.Message;
			}
		}
	}
}
