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

namespace CW5_Bonus
{
    public partial class Form1 : Form
    {
        static int TrianglePtsNum = 3;
        static int Dimension = 2;
        int count = 0;
        int[,] recordRbtn = new int[TrianglePtsNum, Dimension];
        RadioButton[,] rbtnArr = null;
        GroupBox[,] gbxArr = null;

        public Form1()
        {
            InitializeComponent();
            InitializeComponentByUser();
        }

        TextBox[,] txtRowColArr = new TextBox[TrianglePtsNum, Dimension];
        TextBox[,] txtXYArr = new TextBox[TrianglePtsNum, Dimension];
        private void InitializeComponentByUser()  //==============
        {
            for (int i = 0; i < TrianglePtsNum; i++)
            {
                for (int k = 0; k < Dimension; k++)
                {
                    txtRowColArr[i, k] = new TextBox();
                    txtRowColArr[i, k].Location = new System.Drawing.Point(20 + 83 * k, 70 + 46 * i);
                    txtRowColArr[i, k].Size = new System.Drawing.Size(58, 22);
                    gbxCoord.Controls.Add(txtRowColArr[i, k]);  // Add
                }
            }

            for (int i = 0; i < TrianglePtsNum; i++)
            {
                for (int k = 0; k < Dimension; k++)
                {
                    txtXYArr[i, k] = new TextBox();
                    txtXYArr[i, k].Location = new System.Drawing.Point(200 + 83 * k, 70 + 46 * i);
                    txtXYArr[i, k].Size = new System.Drawing.Size(58, 22);
                    txtXYArr[i, k].Enabled = false;
                    gbxCoord.Controls.Add(txtXYArr[i, k]);  // Add
                }
            }

            //default "Radio Button record" to -1
            ResetRadioButtonRecord();

        }//end  InitializeComponentByUser

        // Creat PinBoard=============
        private void btnCreatPinBoard_Click(object sender, EventArgs e)
        {
            count = 0; //Reset count
            int RowNum = int.Parse(txtRows.Text);
            int ColNum = int.Parse(txtCols.Text);
            int Xintrvl = int.Parse(txtXInterval.Text);
            int Yintrvl = int.Parse(txtYInterval.Text);
            
            if (rbtnArr != null && gbxArr != null)
            {
                foreach (RadioButton EleRbtnArr in rbtnArr)
                    EleRbtnArr.Dispose();
                foreach (GroupBox EleGbxArr in gbxArr)
                    EleGbxArr.Dispose();
            }
            
            gbxArr = new GroupBox[RowNum, ColNum];
            rbtnArr = new RadioButton[RowNum, ColNum];
            for (int i = 0; i < RowNum; i++)
            {
                for (int k = 0; k < ColNum; k++)
                {
                    rbtnArr[i, k] = new System.Windows.Forms.RadioButton(); 
                    rbtnArr[i, k].Location = new System.Drawing.Point(4, 10);  //radoBtn location 不變
                    rbtnArr[i, k].Name = "rbtn" + (k * RowNum + i).ToString();   //
                    rbtnArr[i, k].Size = new System.Drawing.Size(14, 13);
                    rbtnArr[i, k].CheckedChanged += new System.EventHandler(this.rbtn_checked);

                    gbxArr[i, k] = new System.Windows.Forms.GroupBox();
                    gbxArr[i, k].Location = new System.Drawing.Point(10 + k* Xintrvl*16, 10 + i*Yintrvl*16);   //
                    gbxArr[i, k].Name = "gbxRbtn" + (k * RowNum + i).ToString();  //
                    gbxArr[i, k].Size = new System.Drawing.Size(20, 26);
                    // Add
                    gbxArr[i, k].Controls.Add(rbtnArr[i, k]); 
                    gbxPinBoard.Controls.Add(gbxArr[i, k]); 
                }
            }

            ClearTxtBox();
            ResetRadioButtonRecord();
        }//end // Creat PinBoard

        // Radio Button Checked=============
        private void rbtn_checked(object sender, EventArgs e)
        {
            if (count >= TrianglePtsNum)  //Reset count;
                count = 0;

            int RowNum = int.Parse(txtRows.Text);
            int ColNum = int.Parse(txtCols.Text);
            int Xintrvl = int.Parse(txtXInterval.Text);
            int Yintrvl = int.Parse(txtYInterval.Text);
            int rcrdChecked = 0;

            for (int i = 0; i < RowNum; i++)  // + "count<3" ?
            {
                for (int k = 0; k < ColNum; k++)
                {
                    if (rbtnArr[i, k].Checked)
                    {
                        // prevent "repeat dispay"
                        for (int j = 0; j < TrianglePtsNum; j++)
                        {
                            if (recordRbtn[j, 0] == i && recordRbtn[j, 1] == k)
                                rcrdChecked = 1;
                        }
                        if (rcrdChecked == 1)
                        {
                            rcrdChecked = 0;   // !!!Always Forgot Reset!!!
                            continue;
                        }
                        //record checked RadioBtn
                        recordRbtn[count, 0] = i;
                        recordRbtn[count, 1] = k;

                        //display
                        txtRowColArr[count, 0].Text = i.ToString();
                        txtRowColArr[count, 1].Text = k.ToString();
                        txtXYArr[count, 0].Text = (k * Xintrvl).ToString();
                        txtXYArr[count, 1].Text = (i * Yintrvl).ToString();
                        count++;
                    }
                }
            }

            // disable other RadioBtn
            if (count >= TrianglePtsNum)
            {
                for (int i = 0; i < RowNum; i++)
                {
                    for (int k = 0; k < ColNum; k++)
                    {
                        rbtnArr[i, k].Enabled = false;
                        gbxArr[i, k].Enabled = false;
                    }
                }
            }

        }//end // Radio Button Checked

        // Reset Btn =============
        private void BtnReset_Click(object sender, EventArgs e)
        {
            count = 0;  //Reset count

            int RowNum = int.Parse(txtRows.Text);
            int ColNum = int.Parse(txtCols.Text);
            for (int i = 0; i < RowNum; i++)
            {
                for (int k = 0; k < ColNum; k++)
                {
                    rbtnArr[i, k].Enabled = true;
                    gbxArr[i, k].Enabled = true;
                    if (rbtnArr[i, k].Checked)
                    {
                        rbtnArr[i, k].Checked = false;
                    }
                }
            }
            ClearTxtBox();
            ResetRadioButtonRecord();

        }//end // Reset Btn

        // Calculate Triangle Property =============
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtTriMessage.Text = "";
            Triangle tri = new Triangle();
            for (int i = 0; i < TrianglePtsNum; i++)
            {
                for (int k = 0; k < Dimension; k++)
                {
                    tri.ptArr[i].Coord[k] = Double.Parse(txtXYArr[i,k].Text);
                }
            }

            if (tri.isValid())
            {
                if (tri.isRight())
                    txtTriMessage.Text = "直角三角形!\r\n";
                else if (tri.isAcute())
                    txtTriMessage.Text = "銳角三角形!\r\n";
                else
                    txtTriMessage.Text = "鈍角三角形!\r\n";

                txtTriMessage.Text += "Area = " + tri.Area().ToString() + "\r\n";
                txtTriMessage.Text += "Perimeter = " + tri.Perimeter().ToString();
            }
            else
            {
                txtTriMessage.Text = "此非三角形!";
            }
        }//end // Calculate Triangle Property

        // Clear Triangle message =============
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTriMessage.Text = "";
        }

        // clear TextBox
        private void ClearTxtBox()
        {
            for (int i = 0; i < TrianglePtsNum; i++)
            {
                for (int k = 0; k < Dimension; k++)
                {
                    txtRowColArr[i, k].Text = "";
                    txtXYArr[i, k].Text = "";
                    txtTriMessage.Text = "";
                }
            }
        }//end // clear TextBox

        // =============
        private void ResetRadioButtonRecord()  
        {
            // Reset Radio Button record
            for (int i = 0; i < TrianglePtsNum; i++)
            {
                for (int k = 0; k < Dimension; k++)
                {
                    recordRbtn[i, k] = -1;
                }
            }
        }//end // Reset Radio Button record

    }
}
