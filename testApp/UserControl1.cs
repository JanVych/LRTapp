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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            chartResRea.Series["Right"].Points.AddXY(0, 0);
        }
        public void DataToTable(string type)
        {
            MeasuredData dataR;
            MeasuredData dataL;
            string[] frequency;
            string[,] proph;
            dataR = Program.patients[Program.currentPatient].MesureDataRight;
            dataL = Program.patients[Program.currentPatient].MesureDataLeft;
            if (type == "P")
                frequency = dataR.Frequency;
            else
                frequency = dataL.Frequency;
            if (type == "P")
                proph = dataR.CdProperties;
            else
                proph = dataL.CdProperties;

            dataGridViewMesure.Rows.Clear();
            dataGridViewCd.Rows.Clear();

            for (int i = 0; i < 50; i++)
            {
                dataGridViewMesure.Rows.Add(frequency[i], dataL.Impedance[i], dataR.Impedance[i], dataL.PhaseAngle[i], dataR.PhaseAngle[i],
                                            dataL.Resistance[i], dataR.Resistance[i], dataL.Reactance[i], dataR.Reactance[i]);
            }
            for (int i = 0; i < 9; i++)
            {
                dataGridViewCd.Rows.Add(proph[i, 0], dataL.CdProperties[i, 1], dataR.CdProperties[i, 1]);
            }
        }
        public void DataToChart()
        {
            string reactance;
            string resistance;
            chartResRea.Series["Right"].Points.Clear();
            chartResRea.Series["Left"].Points.Clear();

            for (int i = 0; i < 50; i++)
            {
                resistance = Program.patients[Program.currentPatient].MesureDataRight.Resistance[i];
                reactance = Program.patients[Program.currentPatient].MesureDataRight.Reactance[i];
                if (!(resistance == null))
                    chartResRea.Series["Right"].Points.AddXY(Double.Parse(resistance), Double.Parse(reactance));

                resistance = Program.patients[Program.currentPatient].MesureDataLeft.Resistance[i];
                reactance = Program.patients[Program.currentPatient].MesureDataLeft.Reactance[i];
                if (!(resistance == null))
                    chartResRea.Series["Left"].Points.AddXY(Double.Parse(resistance), Double.Parse(reactance));
            }
        }
        public void BCDataToTable()
        {
            string rintL = Program.patients[Program.currentPatient].MesureDataLeft.CdProperties[4, 1];
            string rintR = Program.patients[Program.currentPatient].MesureDataRight.CdProperties[4, 1];
            if ((rintL == null) || (rintR == null))
            {
                dataGridViewBCData.Rows.Clear();
                return;
            }
            string rextL = Program.patients[Program.currentPatient].MesureDataLeft.CdProperties[5, 1];
            string rextR = Program.patients[Program.currentPatient].MesureDataRight.CdProperties[5, 1];
            string cmL = Program.patients[Program.currentPatient].MesureDataLeft.CdProperties[6, 1];
            string cmR = Program.patients[Program.currentPatient].MesureDataRight.CdProperties[6, 1];
            double LDex;
            double SDex;
            string lDexAffected;
            string sDexAffected;

            if (Program.patients[Program.currentPatient].DominantHand == "right")
            {
                lDexAffected = "right";
                sDexAffected = "left";
                LDex = 10 * (Double.Parse(rextL) / Double.Parse(rextR) - 1.037) / 0.102;
                SDex = 10 * (Double.Parse(rintL) / Double.Parse(rintR) - 1.037) / 0.102;
                if (LDex < 0)
                {
                    lDexAffected = "left";
                    LDex = 10 * (Double.Parse(rextR) / Double.Parse(rextL) - 0.964) / 0.102;
                }
                    
                if (SDex < 0)
                {
                    sDexAffected = "right";
                    SDex = 10 * (Double.Parse(rintR) / Double.Parse(rintL) - 0.964) / 0.102;
                }
            }   
            else
            {
                lDexAffected = "right";
                sDexAffected = "left";
                LDex = 10 * (Double.Parse(rextL) / Double.Parse(rextR) - 0.964) / 0.102;
                SDex = 10 * (Double.Parse(rintL) / Double.Parse(rintR) - 0.964) / 0.102;
                if (LDex < 0)
                {
                    lDexAffected = "left";
                    LDex = 10 * (Double.Parse(rextR) / Double.Parse(rextL) - 1.037) / 0.102;
                }
                    
                if (SDex < 0)
                {
                    sDexAffected = "right";
                    SDex = 10 * (Double.Parse(rintR) / Double.Parse(rintL) - 1.037) / 0.102;
                }
                    
            }
            dataGridViewBCData.Rows.Clear();
            dataGridViewBCData.Rows.Add("Rext L / Rext R", Math.Round(Double.Parse(rextL)/Double.Parse(rextR), 3));
            dataGridViewBCData.Rows.Add("Rint L / Rint R", Math.Round(Double.Parse(rintL) / Double.Parse(rintR), 3));
            dataGridViewBCData.Rows.Add("Cm L / Cm R", Math.Round(Double.Parse(cmL) / Double.Parse(cmR), 3));
            dataGridViewBCData.Rows.Add("L-Dex", ((int)LDex).ToString() + "  (affected: " + lDexAffected + ")");
            dataGridViewBCData.Rows.Add("S-Dex", ((int)SDex).ToString() + "  (affected: " + sDexAffected + ")");
        }
        public void UpdateData()
        {
            if (Program.patients[Program.currentPatient].MesureDataRight.Frequency[0] != null)
                DataToTable("P");
            else if (Program.patients[Program.currentPatient].MesureDataLeft.Frequency[0] != null)
                DataToTable("L");
            else
                DataToTable("P");
            DataToChart();
            BCDataToTable();
        }
    }
}
