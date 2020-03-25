using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace LakoparkProjekt
{
    public partial class StatForm : Form
    {
        ArrayList stat;

        public StatForm(ArrayList stat)
        {
            InitializeComponent();
            this.stat = stat;
        }

        private void StatForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < stat.Count; i++)
            {
                lbStatisztika.Items.Add(stat[i]);
            }

        }
    }
}
