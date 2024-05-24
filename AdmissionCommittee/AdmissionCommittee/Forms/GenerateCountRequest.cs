using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionCommittee.Forms
{
    public partial class GenerateCountRequest : Form
    {
        public GenerateCountRequest()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object _, EventArgs __)
        {
            if (MessageBox.Show($"Сгенерировать {generateCount.Value} записей?", Text, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
