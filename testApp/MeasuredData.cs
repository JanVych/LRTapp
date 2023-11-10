using System;

namespace LRTapp
{
    class MeasuredData
    {
        public string MesureIPhACSV { get; private set; }
        public string MesureCdP { get; private set; }
        public string[] Frequency { get; private set; }
        public string[] Impedance { get; private set; }
        public string[] PhaseAngle { get; private set; }
        public string[] Resistance { get; private set; }
        public string[] Reactance { get; private set; }
        public string[,] CdProperties { get; private set; }

        public MeasuredData()
        {
            Frequency = new string[50];
            Impedance = new string[50];
            PhaseAngle = new string[50];
            Resistance = new string[50];
            Reactance = new string[50];
            CdProperties = new string[9,2];
            MesureIPhACSV = "";
            MesureCdP = "";
        }

        static public double ToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }
        public void AddDataIphA(string inputData)
        {
            string[] data;
            string[] line;
            double impedance;
            double phaseAngle;
            double num;
            int i = 0;

            MesureIPhACSV = inputData;
            data = inputData.Split('\n');
            foreach(string ln in data)
            {
                line = ln.Split('\t');
                Frequency[i] = line[0];
                Impedance[i] = line[1];
                PhaseAngle[i] = line[2];
                impedance = Double.Parse(line[1]);
                phaseAngle = Double.Parse(line[2]);
                num = Math.Round(impedance * Math.Cos(ToRadians(phaseAngle)), 2);
                Resistance[i] = num.ToString();
                num = Math.Round(impedance * Math.Sin(ToRadians(phaseAngle)), 2);
                Reactance[i] = num.ToString();
                i++;
            }
        }
        public void AddDataCd(string inputData)
        {
            MesureCdP = inputData;
            string[] line;
            string[] data;
            int i = 0;
            data = inputData.Split('\n');

            foreach (string ln in data)
            {
                line = ln.Split(' ');
                CdProperties[i,0]=line[0];
                CdProperties[i, 1] = line[2];
                i++;
            }
        }
        public string ReturnCSV(char delm)
        {
            string data = MesureIPhACSV.Replace('\t', delm) + "\n\n";
            for (int i = 0; i<9; i++)
            {
                data += CdProperties[i, 0] + delm + CdProperties[i, 1] + "\n";
            }
            data += "\n";
            return data;
        }
        
    }
}
