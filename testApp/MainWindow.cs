using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace LRTapp
{
    
    public partial class mainWindow : Form
    {
        bool mouseDown;
        private Point offset;
        public static int oioi;
        public mainWindow()
        {
            InitializeComponent();
            userControl31.ButtonConfirmClick += userControl13_ButtonConfirmClick;
            progressBar1.Maximum = 530;
            Program.client = new Client();
            Program.patients = new List<PatientData> {};
            Program.currentPatient = -1;
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
            userControl31.BringToFront();
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try { Program.client.Connect(); }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Connection error","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.client.SendMessage("b");
            Thread.Sleep(200);
            changeBatteryStatus(Program.client.ReadLine());
            buttonConnect.Enabled = false;
            buttonDisconnect.Enabled = true;
            buttonMeasureL.Enabled = true;
            buttonMeasureR.Enabled = true;
        }
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            labelBattery.Text = "";
            Program.client.Disconnect();
            buttonDisconnect.Enabled = false;
            buttonConnect.Enabled = true;
            buttonMeasureL.Enabled = false;
            buttonMeasureR.Enabled = false;
        }
        private void buttonMeasureR_Click(object sender, EventArgs e)
        {
            if (Program.currentPatient == -1)
            {
                MessageBox.Show("Create new patient first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Mesure("P");
        }
        private void buttonMeasureL_Click(object sender, EventArgs e)
        {
            if (Program.currentPatient == -1)
            {
                MessageBox.Show("Create new patient first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Mesure("L");
        }
        private async void Mesure(string type)
        {
            string dataMesure= "";
            string dataC = "";
            string line;
            int time = 0;
            int lineCount = 0;
            disableButtons();
            Program.client.ClearStream();
            Program.client.SendMessage(type);
            while(true)
            {
                await Task.Delay(10);
                time++;
                //userControl31.addTextTextBoxNote(time.ToString()+ "---" + lineCount.ToString());
                line = Program.client.ReadLine();
                if (line !=null)
                {
                    lineCount++;
                    if (lineCount > 2 && lineCount < 52)
                    {
                        dataMesure += line + "\n";
                    }
                    if (lineCount == 52)
                    {
                        dataMesure += line;
                        Program.client.SendMessage("c");
                    }
                    if (lineCount > 52 && lineCount < 61 )
                    {
                        dataC += line+ "\n";
                    }
                    if (lineCount == 61)
                    {
                        dataC += line;
                        Program.client.SendMessage("b");
                    }
                    if (lineCount == 62)
                    {
                        changeBatteryStatus(line);
                        //userControl31.addTextTextBoxNote(dataMesure + "\n-------------\n" + dataC + "\n----");
                        time = 0;
                        progressBar1.Value = 530;
                        break;
                    }
                }
                if (progressBar1.Value < 530) 
                    progressBar1.Value++; 
                if (time > 2000) 
                    break;
            }
            if (time > 2000)
            {
                //userControl31.addTextTextBoxNote(dataMesure + "-------------" + dataC);
                MessageBox.Show("Time out, device not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar1.Value = 0;
                return;
            }
            await Task.Delay(100);
            if (type == "P")
            {
                Program.patients[Program.currentPatient].MesureDataRight.AddDataIphA(dataMesure);
                Program.patients[Program.currentPatient].MesureDataRight.AddDataCd(dataC);
            }
            else
            {
                Program.patients[Program.currentPatient].MesureDataLeft.AddDataIphA(dataMesure);
                Program.patients[Program.currentPatient].MesureDataLeft.AddDataCd(dataC);
            }
            await Task.Delay(100);
            userControl11.UpdateData();
            userControl21.pointToChart();
            progressBar1.Value = 0;
            enableButtons();
        }

        private void buttonSaveCSV_Click(object sender, EventArgs e)
        {
            string path;
            saveFileDialog1.FileName = Program.patients[Program.currentPatient].Name;
            saveFileDialog1.Filter = "CSV files (*.csv)|* .csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(File.Create(path));
                sw.WriteLine("Name;" + Program.patients[Program.currentPatient].Name);
                sw.WriteLine("Dominant Hand;" + Program.patients[Program.currentPatient].DominantHand);
                sw.WriteLine("Gender;" + Program.patients[Program.currentPatient].Gender);
                sw.WriteLine("Age;" + Program.patients[Program.currentPatient].Age);
                sw.WriteLine("Height;" + Program.patients[Program.currentPatient].Height);
                sw.WriteLine("Weight;" + Program.patients[Program.currentPatient].Weight);
                sw.WriteLine("Note;" + Program.patients[Program.currentPatient].Note);
                sw.Write("\n");
                sw.Write(Program.patients[Program.currentPatient].MesureDataLeft.ReturnCSV(';'));
                sw.Write(Program.patients[Program.currentPatient].MesureDataRight.ReturnCSV(';'));
                sw.Close();
            }
        }
        private void dataGridViewPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            object val = dataGridViewPatients[1, e.RowIndex].Value;
            Program.currentPatient = int.Parse(val.ToString());
            userControl11.UpdateData();
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
            userControl31.BringToFront();
        }
        private void changeBatteryStatus(string bat)
        {
            labelBattery.Visible = true;
            labelBattery.Text = "Battery: " + bat + " %";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Program.client.Disconnect();
            Thread.Sleep(50);
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void buttonMeasureUC_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void buttonBCompositionUC_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void disableButtons()
        {
            buttonDisconnect.Enabled = false;
            buttonMeasureL.Enabled = false;
            buttonMeasureR.Enabled = false;
            buttonSaveCSV.Enabled = false;
            buttonNew.Enabled = false;
        }
        private void enableButtons()
        {
            buttonDisconnect.Enabled = true;
            buttonMeasureL.Enabled = true;
            buttonMeasureR.Enabled = true;
            buttonSaveCSV.Enabled = true;
            buttonNew.Enabled = true;
        }
        private void userControl13_ButtonConfirmClick(object sender, EventArgs e)
        {
            string name = userControl31.textBoxNameText();
            string dominantHand = userControl31.comboBoxDominantHText();
            string gender = userControl31.comboBoxGenderText();
            string weight = userControl31.textBoxWeightText();
            string height = userControl31.textBoxHeightText();
            string age = userControl31.textBoxAgeText();
            string note = userControl31.textBoxNoteText();
            Program.patients.Add(new PatientData(name,dominantHand,gender,age,height,weight, note));
            Program.currentPatient++;
            dataGridViewPatients.Rows.Add(name, Program.patients.Count - 1);
            dataGridViewPatients.ClearSelection();
            dataGridViewPatients.Rows[Program.currentPatient].Selected = true;
            userControl11.UpdateData();
            userControl31.clearText();
            userControl21.Hide();
            userControl31.Hide();
            userControl11.Show();
            userControl11.BringToFront();
        }
    }
}
