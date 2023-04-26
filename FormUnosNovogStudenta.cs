using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadSaViseFormi
{
    public partial class FormUnosNovogStudenta : Form
    {
        private Student student1;
        internal Student Student1 { get => student1; set => student1 = value; }

        public FormUnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            Student1 = new Student(textBoxIme.Text, textBoxPrezime.Text, comboBoxSmjer.Text,
                                            textBoxBrojIndeksa.Text, dateTimePickerDatumRodjenja.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
