using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_7155_10_04_450
{
    partial class Form1
    {         
        public void setElementsVisibility()
        {
            List<CheckBox> checkBoxes = new List<CheckBox>() { checkBoxUPR4A, checkBoxUPR3A, checkBoxUPR2A, checkBoxUPR1A, checkBoxPW_ENA, checkBoxCLK_ENA, checkBoxCLKPA,
                                        checkBoxY4PA,  checkBoxY3PA, checkBoxY2PA, checkBoxY1PA, checkBoxUPR4B, checkBoxUPR3B, checkBoxUPR2B, checkBoxUPR1B, checkBoxPW_ENB,
                                        checkBoxCLK_ENB, checkBoxCLKPB, checkBoxY4PB, checkBoxY3PB, checkBoxY2PB, checkBoxY1PB, checkBoxDSPDP6, checkBoxDSPDP5, checkBoxDSPDP4,
                                        checkBoxDSPDP3, checkBoxDSPDP2, checkBoxDSPDP1, checkBoxDSPDOP4, checkBoxDSPDOP3, checkBoxDSPDOP2, checkBoxDSPDOP1, checkBoxIO_TV5S, checkBoxIO_TV3S,
                                        checkBoxIO_TV4S, checkBoxIO_TV2S, checkBoxIO_TV1S, checkBoxIO_TV0S, checkBoxIO_TV7S, checkBoxIO_TV6S,/* checkBoxINV2, checkBoxINV1,*/ checkBox12,
                                        /*checkBoxINV0,*/ checkBox11, checkBoxDIR2, checkBoxDIR1, checkBoxDIR0, checkBox3, checkBox13, checkBox2, checkBoxTV2S_TV3S, checkBoxDA9_DA10 };

            List<RadioButton> radioButtons = new List<RadioButton>() { radioButtonDD2, radioButtonDD8, radioButtonDD9 };

            List<Button> buttons = new List<Button>() { buttonSend, buttonReset };

            List<GroupBox> groupBoxes = new List<GroupBox>() { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox8 };

            List<Label> labels = new List<Label>() { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, labelChip };

            checkBoxes.ForEach(n => n.Enabled = true);
            radioButtons.ForEach(n => n.Enabled = true);
            buttons.ForEach(n => n.Enabled = true);
            groupBoxes.ForEach(n => n.Enabled = true);
            labels.ForEach(n => { n.Enabled = true; n.Visible = true; });
            setTrackBarLabels();
        }

        public void setTrackBarLabels()
        {
            List<Label> labels = new List<Label>() { label13, label14, label15, label16, label17, label18, label19, label20, label21, label22 };
            labels.ForEach(n => n.Enabled = true);
        }

        public void resetTrackBarLabels()
        {
            List<Label> labels = new List<Label>() { label13, label14, label15, label16, label17, label18, label19, label20, label21, label22 };
            labels.ForEach(n => n.Enabled = false);
        }

        private void resetLabels()
        {
            List<Label> labels = new List<Label>() { label1, label2, label3, label4, label5, label6, label7, 
                                                            label8, label9, label10, label11, label12, labelChip };

            foreach(Label label in labels)
            {
                label.BackColor = SystemColors.AppWorkspace;
                label.ForeColor = SystemColors.AppWorkspace;
                label.Text = "ERROR";
            }          
        }

        private void resetCheckBoxes()
        {
            List<CheckBox> checkBoxes = new List<CheckBox>() { checkBoxUPR4A, checkBoxUPR3A, checkBoxUPR2A, checkBoxUPR1A, checkBoxPW_ENA, checkBoxCLK_ENA, checkBoxCLKPA,
                                        checkBoxY4PA,  checkBoxY3PA, checkBoxY2PA, checkBoxY1PA, checkBoxUPR4B, checkBoxUPR3B, checkBoxUPR2B, checkBoxUPR1B, checkBoxPW_ENB,
                                        checkBoxCLK_ENB, checkBoxCLKPB, checkBoxY4PB, checkBoxY3PB, checkBoxY2PB, checkBoxY1PB, checkBoxDSPDP6, checkBoxDSPDP5, checkBoxDSPDP4,
                                        checkBoxDSPDP3, checkBoxDSPDP2, checkBoxDSPDP1, checkBoxDSPDOP4, checkBoxDSPDOP3, checkBoxDSPDOP2, checkBoxDSPDOP1, checkBoxIO_TV5S, checkBoxIO_TV3S,
                                        checkBoxIO_TV4S, checkBoxIO_TV2S, checkBoxIO_TV1S, checkBoxIO_TV0S, checkBoxIO_TV7S, checkBoxIO_TV6S, checkBoxINV2, checkBoxINV1, checkBox12,
                                        checkBoxINV0, checkBox11, checkBoxDIR2, checkBoxDIR1, checkBoxDIR0, checkBox3, checkBox13, checkBox2, checkBoxTV2S_TV3S, checkBoxDA9_DA10 };

            checkBoxes.ForEach(n => n.Checked = false);

        }

        private void resetRadioButtons()
        {
            List<RadioButton> radioButtons = new List<RadioButton>() { radioButtonSawtooth, radioButtonTV, radioButtonDD2, radioButtonDD8, radioButtonDD9 };
            radioButtons.ForEach(n => n.Checked = false);
            comboBox1.Enabled = false;
            comboBox1.SelectedItem = null;
        }

        public void resetAllElements()
        {
            resetLabels();
            resetCheckBoxes();
            resetRadioButtons();
            trackBar1.Value = 0;
            trackBar1.Enabled = false;
            List<Label> labels = new List<Label>() { label13, label14, label15, label16, label17, label18, label19, label20, label21, label22 };
            labels.ForEach(n => n.Enabled = false);
        }
    }
}
