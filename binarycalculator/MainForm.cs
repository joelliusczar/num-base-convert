using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace binary_calculator
{//namespace
    public partial class MainForm : Form
    {//class

        #region "set up"

        //private const int LIST_BIN = 0;
        //private const int LIST_OCT = 1;
        //private const int LIST_DEC = 2;
        //private const int LIST_HEX = 3;

        private int dataType = 0;
        private int nextNumBase = 10;
        private int currentNumBase = 10;
        

        private int sizeToUse;
        private bool editable = true;

        private int exponenet = 0;

       // private  int[] trueNumBase= {BinCalc.NUMBASE_BIN, BinCalc.NUMBASE_OCT, 
                                       // BinCalc.NUMBASE_DEC, BinCalc.NUMBASE_HEX };

        public int dataSize
        {//property size
            get {return sizeToUse;}
            set 
            {//set
                sizeToUse = value;
            }//set
        }//property size

        public MainForm()
        {//MainForm
            InitializeComponent();
            sizeToUse = 8;
            //comboBoxNumBase.SelectedIndex = LIST_DEC;
           
        }//MainForm

        #endregion

        #region "Numbase menu items"

        private void binaryBase2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeMenuChecksNumBase(binaryBase2ToolStripMenuItem);
            currentNumBase = nextNumBase;
            nextNumBase = BinCalc.NUMBASE_BIN;
            binButtonSwitch(); //changes which gui buttons are enabled

            dataSize = (int)numericUpDown1.Value;
            exponenet = (int)numericUpDownExponent.Value;
            textBox1.Text = ProcessCalculatorInput.processInputToBeConverted(textBox1.Text, dataType,
            currentNumBase, nextNumBase, dataSize, exponenet);
        }

        private void octalBase8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeMenuChecksNumBase(octalBase8ToolStripMenuItem);
            currentNumBase = nextNumBase;
            nextNumBase = BinCalc.NUMBASE_OCT;
            octButtonSwitch(); //changes what gui buttons are enabled

            dataSize = (int)numericUpDown1.Value;
            exponenet = (int)numericUpDownExponent.Value;
            textBox1.Text = ProcessCalculatorInput.processInputToBeConverted(textBox1.Text, dataType,
            currentNumBase, nextNumBase, dataSize, exponenet);
        }

        private void decimalBase10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeMenuChecksNumBase(decimalBase10ToolStripMenuItem);
            currentNumBase = nextNumBase;
            nextNumBase = BinCalc.NUMBASE_DEC;
            decButtonSwitch(); //changes what gui buttons are enabled

            dataSize = (int)numericUpDown1.Value;
            exponenet = (int)numericUpDownExponent.Value;
            textBox1.Text = ProcessCalculatorInput.processInputToBeConverted(textBox1.Text, dataType,
            currentNumBase, nextNumBase, dataSize, exponenet);
        }

        private void hexidecimalBase16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeMenuChecksNumBase(hexidecimalBase16ToolStripMenuItem);
            currentNumBase = nextNumBase;
            nextNumBase = BinCalc.NUMBASE_HEX;
            hexButtonSwitch(); //changes what gui buttons are enabled

            dataSize = (int)numericUpDown1.Value;
            exponenet = (int)numericUpDownExponent.Value;
            textBox1.Text = ProcessCalculatorInput.processInputToBeConverted(textBox1.Text, dataType,
            currentNumBase, nextNumBase, dataSize, exponenet);
        }
            
        #endregion

        #region "Menu items"
        private void unsignedIntergersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeMenuChecksDataType(unsignedIntergersToolStripMenuItem);
            changeMenuChecksNumBase(decimalBase10ToolStripMenuItem);
            currentNumBase = BinCalc.NUMBASE_DEC;
            dataType = BinCalc.DATATYPE_UNSIGNED;
            buttonNeg.Enabled = false;
            buttonPoint.Enabled = false;
            textBox1.Text = "";
            numericUpDown1.Enabled = true;
            numericUpDown1.Visible = true;
            numericUpDown1.Value = 8;
            numericUpDownExponent.Enabled = false;
            numericUpDownExponent.Visible = false;
            labelExp.Visible = false;
            labelSize.Text = "Data Size";
        }

        private void signedIntegersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeMenuChecksDataType(signedIntegersToolStripMenuItem);
            changeMenuChecksNumBase(decimalBase10ToolStripMenuItem);
            currentNumBase = BinCalc.NUMBASE_DEC;
            dataType = BinCalc.DATATYPE_SIGNED;
            buttonNeg.Enabled = true;
            buttonPoint.Enabled = false;
            textBox1.Text = "";
            numericUpDown1.Enabled = true;
            numericUpDown1.Visible = true;
            numericUpDown1.Value = 8;
            numericUpDownExponent.Enabled = false;
            numericUpDownExponent.Visible = false;
            labelExp.Visible = false;

            labelSize.Text = "Data Size";
        }

        private void floatNonIEEE754ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeMenuChecksDataType(floatNonIEEE754ToolStripMenuItem);
            changeMenuChecksNumBase(decimalBase10ToolStripMenuItem);
            currentNumBase = BinCalc.NUMBASE_DEC;
            dataType = BinCalc.DATATYPE_FRACTION;
            buttonNeg.Enabled = false;
            buttonPoint.Enabled = true;
            textBox1.Text = "";
            numericUpDown1.Enabled = true;
            numericUpDown1.Visible = true;
            numericUpDown1.Value = 8;
            numericUpDownExponent.Enabled = false;
            numericUpDownExponent.Visible = false;
            labelExp.Visible = false;
            labelSize.Text = "Data Size";
        }

        private void floatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeMenuChecksDataType(floatToolStripMenuItem);
            changeMenuChecksNumBase(decimalBase10ToolStripMenuItem);
            currentNumBase = BinCalc.NUMBASE_DEC;
            dataType = BinCalc.DATATYPE_FLOAT;
            buttonNeg.Enabled = true;
            buttonPoint.Enabled = true;
            textBox1.Text = "";
            numericUpDown1.Enabled = true;
            numericUpDown1.Visible = true;
            numericUpDown1.Value = 23;
            numericUpDownExponent.Enabled = true;
            numericUpDownExponent.Visible = true;
            numericUpDownExponent.Value = 8;
            labelExp.Visible = true;
            //octalBase8ToolStripMenuItem.Enabled = false;
            labelSize.Text = "Significand bit amount";
        }

        private void doubleFloatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeMenuChecksDataType(doubleFloatToolStripMenuItem);
            changeMenuChecksNumBase(decimalBase10ToolStripMenuItem);
            currentNumBase = BinCalc.NUMBASE_DEC;
            dataType = BinCalc.DATATYPE_FLOAT;
            buttonNeg.Enabled = true;
            buttonPoint.Enabled = true;
            textBox1.Text = "";
            numericUpDown1.Enabled = true;
            numericUpDown1.Visible = true;
            numericUpDown1.Value = 52;
            numericUpDownExponent.Enabled = true;
            numericUpDownExponent.Visible = true;
            numericUpDownExponent.Value = 11;
            labelExp.Visible = true;
            //octalBase8ToolStripMenuItem.Enabled = false;
            labelSize.Text = "Significand bit amount";
        }

        

        #endregion

        #region "form controls"


        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(editable)
             textBox1.Text = ProcessCalculatorInput.checkUserInput(e, dataType, currentNumBase, textBox1.Text);
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            //clears the calculator screen
            textBox1.Text = "";
        }


        #endregion

        #region "numeric up down code"

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataSize = (int)numericUpDown1.Value;
        }        

        private void numericUpDownExponent_ValueChanged(object sender, EventArgs e)
        {
            exponenet = (int)numericUpDownExponent.Value;
        }



        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            numericUpDown1.ReadOnly = false;
            numericUpDownExponent.ReadOnly = true;
            editable = false;
        }

        private void numericUpDownExponent_Click(object sender, EventArgs e)
        {
            numericUpDown1.ReadOnly = true;
            numericUpDownExponent.ReadOnly = false;
            editable = false;
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            numericUpDown1.ReadOnly = true;
            numericUpDownExponent.ReadOnly = true;
            editable = true;
        }

        #endregion

        #region "keypad"

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, '1');
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, '2');
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, '3');
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, '4');
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, '5');
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, '6');
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, '7');
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, '8');
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, '9');
        }

        private void buttonNumA_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, 'A');
        }

        private void buttonNumB_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, 'B');
        }

        private void buttonNumC_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, 'C');
        }

        private void buttonNumD_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, 'D');
        }

        private void buttonNumE_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, 'E');
        }

        private void buttonNumF_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, 'F');
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, '0');
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf('.') == -1)
                textBox1.Text = string.Concat(textBox1.Text, '.');
        }

        private void buttonNeg_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                textBox1.Text = string.Concat(textBox1.Text, '-');
        }


        #endregion        

        #region "helpers"

        private void changeMenuChecksDataType(ToolStripMenuItem dataTypeOption)
        {
            
            ToolStripItemCollection menuCollection = dataTypeToolStripMenuItem.DropDownItems;

            for (int i = 0; i < menuCollection.Count; i++)
            {
                ToolStripMenuItem temp = (ToolStripMenuItem)menuCollection[i];
                temp.Checked = false;
            }
            dataTypeOption.Checked = true;
            
        }

        private void changeMenuChecksNumBase(ToolStripMenuItem dataTypeOption)
        {

            ToolStripItemCollection menuCollection = numberBasesToolStripMenuItem.DropDownItems;

            for (int i = 0; i < menuCollection.Count; i++)
            {
                ToolStripMenuItem temp = (ToolStripMenuItem)menuCollection[i];
                temp.Checked = false;
            }
            dataTypeOption.Checked = true;

        }

        private void binButtonSwitch()
        {
            buttonNum2.Enabled = false;
            buttonNum3.Enabled = false;
            buttonNum4.Enabled = false;
            buttonNum5.Enabled = false;
            buttonNum6.Enabled = false;
            buttonNum7.Enabled = false;
            buttonNum8.Enabled = false;
            buttonNum9.Enabled = false;
            buttonNumA.Enabled = false;
            buttonNumB.Enabled = false;
            buttonNumC.Enabled = false;
            buttonNumD.Enabled = false;
            buttonNumE.Enabled = false;
            buttonNumF.Enabled = false;

            buttonPoint.Enabled = false;
            buttonNeg.Enabled = false;
     
        }

        private void octButtonSwitch()
        {
            buttonNum2.Enabled = true;
            buttonNum3.Enabled = true;
            buttonNum4.Enabled = true;
            buttonNum5.Enabled = true;
            buttonNum6.Enabled = true;
            buttonNum7.Enabled = true;
            buttonNum8.Enabled = false;
            buttonNum9.Enabled = false;
            buttonNumA.Enabled = false;
            buttonNumB.Enabled = false;
            buttonNumC.Enabled = false;
            buttonNumD.Enabled = false;
            buttonNumE.Enabled = false;
            buttonNumF.Enabled = false;

            buttonPoint.Enabled = false;
            buttonNeg.Enabled = false;

        }

        private void decButtonSwitch()
        {
            buttonNum2.Enabled = true;
            buttonNum3.Enabled = true;
            buttonNum4.Enabled = true;
            buttonNum5.Enabled = true;
            buttonNum6.Enabled = true;
            buttonNum7.Enabled = true;
            buttonNum8.Enabled = true;
            buttonNum9.Enabled = true;
            buttonNumA.Enabled = false;
            buttonNumB.Enabled = false;
            buttonNumC.Enabled = false;
            buttonNumD.Enabled = false;
            buttonNumE.Enabled = false;
            buttonNumF.Enabled = false;

            if (dataType == BinCalc.DATATYPE_UNSIGNED)
            {
                buttonPoint.Enabled = false;
                buttonNeg.Enabled = false;
            }
            else if (dataType == BinCalc.DATATYPE_SIGNED)
            {
                buttonPoint.Enabled = false;
                buttonNeg.Enabled = true;
            }
            else if (dataType == BinCalc.DATATYPE_FRACTION)
            {
                buttonPoint.Enabled = true;
                buttonNeg.Enabled = false;
            }
            else if (dataType == BinCalc.DATATYPE_FLOAT)
            {
                buttonPoint.Enabled = true;
                buttonNeg.Enabled = true;
            }

        }

        private void hexButtonSwitch()
        {
            buttonNum2.Enabled = true;
            buttonNum3.Enabled = true;
            buttonNum4.Enabled = true;
            buttonNum5.Enabled = true;
            buttonNum6.Enabled = true;
            buttonNum7.Enabled = true;
            buttonNum8.Enabled = true;
            buttonNum9.Enabled = true;
            buttonNumA.Enabled = true;
            buttonNumB.Enabled = true;
            buttonNumC.Enabled = true;
            buttonNumD.Enabled = true;
            buttonNumE.Enabled = true;
            buttonNumF.Enabled = true;

            buttonPoint.Enabled = false;
            buttonNeg.Enabled = false;

        }





        #endregion


    }//class
}//namespace
