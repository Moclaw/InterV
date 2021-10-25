using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper { 

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cellSize = 20;

        int columnCount = 20;
        int rowCount = 20;

        int mineNum = 40;

        Color defColor = Color.Empty;
        Color safeColor = Color.LightGray;
        Color warColor = Color.White;

        private void Form1_Load(object sender, EventArgs e)
        {
            bommer.DefaultCellStyle.NullValue = "";
            bommer.ColumnCount = columnCount;
            bommer.RowCount = rowCount+1; 
            for (int i = 0; i < columnCount; i++) {
                bommer.Columns[i].Width = cellSize;
            }
            for (int i = 0; i < rowCount+1; i++)
            {
                bommer.Rows[i].Height= cellSize;
            }

 
            bommer.ColumnHeadersVisible = false;
            bommer.RowHeadersVisible = false;
 
            bommer.AllowDrop = false;
            bommer.AllowUserToAddRows = false;
            bommer.AllowUserToResizeColumns = false;
            bommer.AllowUserToResizeRows = false;

            swapMine();
        }

        private void bommer_SelectionChanged(object sender, EventArgs e)
        {
            bommer.ClearSelection();
        }
        
        private void bommer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bommer[e.ColumnIndex, e.RowIndex].Style.BackColor == warColor)
            {
                for(int i = 0; i < columnCount; i++)
                    for(int j = 0; j < rowCount; j++)
                        if(bommer[i, j].Style.BackColor == warColor)
                            bommer[i, j].Style.BackColor = Color.Red;
                MessageBox.Show("Game Over");
            }
            else {
                paint(e.ColumnIndex, e.RowIndex);
                for(int i = 0; i < columnCount; i++)
                    for(int j = 0; j < rowCount; j++)
                        if (bommer[i, j].Style.BackColor == defColor)
                            return;
               
                MessageBox.Show("You Win!");
                
            }
            
            if (MessageBox.Show("Play Again?", "You Lose", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                reset();
            }
            else {
                Application.Exit();
            }
        }

        private void paint(int col, int row)
        {
            int war = 0;
       
            if (col != 0 && row != 0 && bommer[col - 1, row - 1].Style.BackColor == warColor) war++; 
            if (col != 0 && row != rowCount - 1 && bommer[col - 1, row + 1].Style.BackColor == warColor) war++; 
            if (col != columnCount - 1 && row != 0 && bommer[col + 1, row - 1].Style.BackColor == warColor) war++; 
            if (col != columnCount - 1 && row != rowCount - 1 && bommer[col + 1, row + 1].Style.BackColor == warColor) war++; 
            if (col != 0 && bommer[col - 1, row].Style.BackColor == warColor) war++; 
            if (row != 0 && bommer[col, row - 1].Style.BackColor == warColor) war++; 
            if (col != columnCount - 1 && bommer[col + 1, row].Style.BackColor == warColor) war++; 
            if (row != rowCount - 1 && bommer[col, row + 1].Style.BackColor == warColor) war++; 

            bommer[col, row].Value = (war==0 ? "" : war.ToString());
            bommer[col, row].Style.BackColor = safeColor;
            
         
            if (war == 0)
            {
                if (col != 0 && bommer[col - 1, row].Style.BackColor == defColor) paint(col - 1, row);                                   
                if (col != 0 && row != 0 && bommer[col - 1, row - 1].Style.BackColor == defColor) paint(col - 1, row - 1);                 
                if (row != 0 && bommer[col, row - 1].Style.BackColor == defColor) paint(col, row - 1);                                
                if (col != columnCount - 1 && row != 0 && bommer[col + 1, row - 1].Style.BackColor == defColor) paint(col + 1, row - 1);     
                if (col != columnCount - 1 && bommer[col + 1, row].Style.BackColor == defColor) paint(col + 1, row);                         
                if (col != columnCount - 1 && row != rowCount - 1 && bommer[col + 1, row + 1].Style.BackColor == defColor) paint(col + 1, row + 1); 
                if (row != rowCount - 1 && bommer[col, row + 1].Style.BackColor == defColor) paint(col, row + 1);                           
                if (col != 0 && row != rowCount - 1 && bommer[col - 1, row + 1].Style.BackColor == defColor) paint(col - 1, row + 1);          
            }
            
        }


        void swapMine()
        {
            Random rand = new Random(System.DateTime.Now.Ticks.GetHashCode()); 
            for(int i = 0; i < mineNum; i++)
            {
                int cTmp = rand.Next(0, columnCount);
                int rTmp = rand.Next(0, rowCount);
                if (bommer[cTmp, rTmp].Style.BackColor == warColor)
                {
                    i--;
                    continue;
                }
                bommer[cTmp, rTmp].Style.BackColor = warColor;
            }
        }
        
        private void bommer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (bommer[e.ColumnIndex, e.RowIndex].Value != null && bommer[e.ColumnIndex, e.RowIndex].Value.ToString().Equals("X"))
                {
                    bommer[e.ColumnIndex, e.RowIndex].Value = "";
                }
                else if (bommer[e.ColumnIndex, e.RowIndex].Value == null ||  bommer[e.ColumnIndex, e.RowIndex].Value.ToString().Equals(""))
                {
                    bommer[e.ColumnIndex, e.RowIndex].Value = "X";
                }
            }
        }

        private void reset()
        {
            for (int i = 0; i < columnCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    bommer[i, j].Style.BackColor = defColor;
                    bommer[i, j].Value = "";
                }
            }
            swapMine();
        }
    }
    }