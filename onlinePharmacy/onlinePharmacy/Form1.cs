using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace onlinePharmacy
{
    public partial class Form1 : Form
    {

        int numberOfSelectedSymptoms = 0;
        int indexOfHighest = 0;
        List<string> symptomsList = new List<string>();
        List<string> dataList = new List<string>();
        public Form1()
        {
            InitializeComponent();
            lblDescription.Visible = false;
            lblMedicine.Visible = false;
            label5.Visible = false;
            btnNo.Visible = false;
            btnYes.Visible = false;


            //READ FROM FILE==================================================
            using (var reader = new StreamReader("MOCK_DATA.csv"))
                
            {
                
                while (!reader.EndOfStream)
                {
                    string oneLine = reader.ReadLine();
                    int numberOfSymptomps = 0;
                    string findAllSyptomps = findSymptomps(oneLine, 4);

                    dataList.Add(oneLine);
                    symptomsList.Add(findAllSyptomps);
                    
                    
                    //FIND SYMPTOMS IN ONE lINE======================
                    for (int x = 0; x < findAllSyptomps.Length; x++)
                    {
                        if (findAllSyptomps.Substring(x, 1) == ".")
                        {
                            numberOfSymptomps++;
                        }
                    }

                    //ADD SYMPTOMS IN A COMBO BOX===========================
                    for (int x = 0; x < numberOfSymptomps; x++)
                    {
                        cmbSymptoms.Items.Add(findAllSyptomps.Substring(0, findAllSyptomps.IndexOf(".")));
                        findAllSyptomps = findAllSyptomps.Remove(0, findAllSyptomps.IndexOf(".") + 1);
                    }
                }

            }
            
        }

        String findSymptomps(string dataLine, int columnNumber)
        {
            string wholeString = dataLine + ",hjfhgf,", newWord = "";

            for (int x = 0; x < columnNumber; x++)
            {
                newWord = dataLine.Substring(0, dataLine.IndexOf(','));
                dataLine = dataLine.Remove(0, dataLine.IndexOf(',') + 1);

            }
            return newWord;
        }
        private void cmbSymptoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSymptoms.SelectedItem!=null )
            {
                string symptom = cmbSymptoms.SelectedItem.ToString();
                bool alreadySelected = false;
                numberOfSelectedSymptoms = lstSymptoms.Items.Count;

                for (int x = 0; x < numberOfSelectedSymptoms; x++) {
                    if (symptom == lstSymptoms.Items[x].ToString())
                    {
                        alreadySelected = true;
                        
                    }
                }
                if(!alreadySelected)
                    lstSymptoms.Items.Add(symptom);

            }
        }

        private void lstSymptoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstSymptoms.SelectedItem!= null)
            {
                int removeSymptom = lstSymptoms.SelectedIndex;

                lstSymptoms.Items.RemoveAt(removeSymptom);

            }
        }

        private void submitSymptoms_Click(object sender, EventArgs e)
        {

            numberOfSelectedSymptoms = lstSymptoms.Items.Count;
            int highestMatch = 0;

            List<int> matchInARow = new List<int>();

            for (int x = 0; x < numberOfSelectedSymptoms; x++)
            {

                foreach (string value in symptomsList)
                {
                    int currentMatch = 0;
                    int symptompsIn1Line = 0;
                    string i = value + ".";

                    for (int y = 0; y < i.Length; y++)
                    {

                        if (i.Substring(y, 1) == ".")
                        {
                            symptompsIn1Line++;

                        }
                    }

                    for (int y = 0; y < symptompsIn1Line; y++)
                    {
                        int theIndex = i.IndexOf('.');


                        if (lstSymptoms.Items[x].ToString() == i.Substring(0, theIndex))
                        {
                            currentMatch++;

                        }
                        if (y != symptompsIn1Line - 2)
                            i = i.Remove(0, theIndex + 1);


                    }
                    matchInARow.Add(currentMatch);


                }

            }
            //FIND THE ROW WITH THE HIGHEST MATCH===========================================
            foreach (int count in matchInARow)
            {
                if (count > highestMatch)
                {
                    highestMatch = count;
                    indexOfHighest = matchInARow.IndexOf(count);

                }

            }

            //SHOW THE ILLNESS ASSOCIATED WITH HIGHEST SYMPTOMS=================================
            String message1 = "You have syptoms of ", message2 = " Can we recommend medicine for you?";
            String disease = findSymptomps(dataList[indexOfHighest], 2);

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message1 + disease + Environment.NewLine + message2, "OnlinePharmacy", buttons);
            if (result == DialogResult.Yes)
            {
                lblMedicine.Visible = true;
                lblDescription.Visible = true;
                label5.Visible = true;
                btnNo.Visible = true;
                btnYes.Visible = true;

                lblDescription.Text = disease + Environment.NewLine + findSymptomps(dataList[indexOfHighest], 3);
                lblMedicine.Text = "You can use " + findSymptomps(dataList[indexOfHighest].Replace(" ", string.Empty), 5)+" to treat it";

            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can contact " + findSymptomps(dataList[indexOfHighest], 6) + Environment.NewLine +
                findSymptomps(dataList[indexOfHighest], 7)) ;//+ Environment.NewLine + findSymptomps(dataList[indexOfHighest], 8)) ;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            lblDescription.Visible = false;
            lblMedicine.Visible = false;
            label5.Visible = false;
            btnNo.Visible = false;
            btnYes.Visible = false;
        }
    }
}
