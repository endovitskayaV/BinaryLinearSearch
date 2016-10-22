using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryLinearSearch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        int[] arr;
        bool init = false;

        private void initArray_Btn_Click(object sender, EventArgs e)
        {
            init = true;

            Random rand = new Random();
            arr = new int[10];

            arrayView_Lbl.Visible = true;
            arrayView_Lbl.Text = "";

            for (int i=0; i< arr.Length; i++)
            {
                arr[i] = rand.Next(300);
                arrayView_Lbl.Text += i+1 + ".     " + arr[i] + Environment.NewLine+ Environment.NewLine;
            }

            if (binarySearch_RBtn.Checked)
            {
                arrayView_Lbl.Text = "";
                Array.Sort(arr);
                for (int i = 0; i < arr.Length; i++) arrayView_Lbl.Text += i + 1 + ".     " + arr[i] + Environment.NewLine + Environment.NewLine;
            }
        }

        private void find_Btn_Click(object sender, EventArgs e)
        {
            if (!init) MessageBox.Show("Init array!");
            else
            {
                if (binarySearch_RBtn.Checked) Search.Binary(arr, 0, arr.Length-1, Convert.ToInt32(numericUpDown.Value));

                else  Search.Linear(arr, Convert.ToInt32(numericUpDown.Value));

                count_Lbl.Text = Search.counter.ToString();

                Search.counter = 0;
            }
        }

        private void binarySearch_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (binarySearch_RBtn.Checked)
            {
                if (arr == null) this.initArray_Btn_Click(sender, e);

                else
                    Array.Sort(arr);
                arrayView_Lbl.Text = "";
                for (int i = 0; i < arr.Length; i++) arrayView_Lbl.Text +=i+1+ ".     "+ arr[i] + Environment.NewLine + Environment.NewLine;
                
            }
        }
    }
}
