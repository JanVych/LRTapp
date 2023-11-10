using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LRTapp
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            chart2Dgraph.Series["Line"].Points.AddXY(0, 0);
            chart2Dgraph.Series["Line"].Points.AddXY(2, 2.258);

        }
        public void pointToChart()
        {
            string rintL = Program.patients[Program.currentPatient].MesureDataLeft.CdProperties[4, 1];
            string rintR = Program.patients[Program.currentPatient].MesureDataRight.CdProperties[4, 1];
            if ((rintL == null) || (rintR == null))
            {
                return;
            }
            string rextL = Program.patients[Program.currentPatient].MesureDataLeft.CdProperties[5, 1];
            string rextR = Program.patients[Program.currentPatient].MesureDataRight.CdProperties[5, 1];
            double valuex = Double.Parse(rextL) / Double.Parse(rextR);
            double valuey = Double.Parse(rintL) / Double.Parse(rintR);
            string name = Program.patients[Program.currentPatient].Name;
            chart2Dgraph.Series["Point"].Points.AddXY(valuex ,valuey );
            chart2Dgraph.Series["Point"].Points.Last().Label = name;
        }
    }
}
