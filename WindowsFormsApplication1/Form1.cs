using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// The class with Game of Life
    /// </summary>
    public partial class Form1 : Form
    {
        //Helps to give the grid a positon
        int x;
        int y;

        //The height and the width of the grid
        float height;
        float width;
        
        //number of rows and columns
        int rowCells = 0;
        int columnCells = 0;

        //The pen and the brush for drawing
        Pen pen;
        Brush brush;

        //The position of a cell
        float cellPosX;
        float cellPosY;

        //The width and height of a cell
        float cellWidth;
        float cellHeight;

        //Tells if cell is alive or not
        bool alive;

        //BMIN, BMAX, SMIN and SMAX
        int bMin;
        int bMax;
        int sMin;
        int sMax;

        //2d array tahat will take all the cells
        Cell[,] cells;
        
        /// <summary>
        /// Creates the form with the Game of Life
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;

            //Gives the color to the pen and brush
            pen = new Pen(Color.Blue);
            brush = new SolidBrush(Color.Red);

            //give x an y a value
            x = 10;
            y = 75;

            //sets the position of the grid
            width = ClientSize.Width - (x + (x*x));
            height = ClientSize.Height - (y + y);

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        /// <summary>
        /// makes sure that everything is in place when you resize the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            //change the grid size
            width = ClientSize.Width - (x + (x*x));
            height = ClientSize.Height - (y + y);
            UpdateCells();
            
            //change all the buttons position
            btnPaint.Location = new System.Drawing.Point(ClientSize.Width - (10 + btnPaint.Width), 10 );
            btnRand.Location = new System.Drawing.Point(ClientSize.Width - (10 + btnRand.Width), 40 );
            btnNext.Location = new System.Drawing.Point(ClientSize.Width - (10 + btnNext.Width), 95);
            btnStart.Location = new System.Drawing.Point(ClientSize.Width - (10 + btnStart.Width), 124);
            btnStop.Location = new System.Drawing.Point(ClientSize.Width - (10 + btnStop.Width), 153);
            btnClear.Location = new System.Drawing.Point(ClientSize.Width - (10 + btnStop.Width), 183);
            trackBar.Location = new System.Drawing.Point(10, ClientSize.Height - 40);
            label7.Location = new System.Drawing.Point(10, ClientSize.Height - 60);
            genPerSec.Location = new System.Drawing.Point(240, ClientSize.Height - 65);
            Invalidate();
            

        }

        /// <summary>
        /// Paints the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //draws a rectangle around the grid
            e.Graphics.DrawRectangle(pen, x, y, width, height);

            //Goes trought all the cells, fills the cells array, and paint them out
            for (int i = 0; i < rowCells; i++)
            {
                for (int j = 0; j < columnCells; j++)
                {
                    Cell cell1 = cells[i, j];
                    
                    if (cells[i, j].Alive)
                    {
                        e.Graphics.FillRectangle(brush, cell1.CellPosX, cell1.CellPosY, cell1.Width, cell1.Height);
                    }
                    else
                    {  
                        e.Graphics.DrawRectangle(pen, cell1.CellPosX, cell1.CellPosY, cell1.Width, cell1.Height);
                    }
                }
            }
        }

        /// <summary>
        /// Updates the cell information
        /// </summary>
        public void UpdateCells()
        {
            //finds the new cell height and width
            cellWidth = width / columnCells;
            cellHeight = height / rowCells;

            //goes through all the cells and updates there information
            for (int i = 0; i < rowCells; i++)
            {

                for (int j = 0; j < columnCells; j++)
                {           
                    cells[i, j].Width = cellWidth;
                    cells[i, j].Height = cellHeight;
                    cells[i, j].CellPosX = cellPosX;
                    cells[i, j].CellPosY = cellPosY;
                    cellPosX += cellWidth;
                }
                cellPosY = cellPosY + cellHeight;
                cellPosX = x;
            }
            cellPosX = x;
            cellPosY = y;
        }

        /// <summary>
        /// Fills the cell when clicked on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //becomes true when you've found the cell
            bool hit = false;

            //goes through all the cells to find the one you clicked
            for (int i = 0; i < rowCells && !hit; i++)
            {

                for (int j = 0; j < columnCells && !hit; j++)
                {
                    if (cells[i,j].CellArea().Contains(e.X, e.Y))
                    {
                        //Makes the cell alive if its not, and kill it if it is alive
                        if (cells[i, j].Alive)
                        {
                            cells[i, j].Alive = false;
                            hit = true;
                        }
                        else
                        {
                            cells[i, j].Alive = true;
                            hit = true;
                        }
                        
                        
                    }
                }
            }
            Invalidate();
        }

        /// <summary>
        /// Makes random cells alive
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRand_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            
            //goes through all the cells, and make some of them alive randomly
            for (int i = 0; i < rowCells; i++)
            {

                for (int j = 0; j < columnCells; j++)
                {
                    
                    int randNum = rand.Next(10);
                    if(randNum == 1)
                    {
                        cells[i, j].Alive = true;
                    }
                    else
                    {
                        cells[i, j].Alive = false;
                    }
                   
                }
            }
            Invalidate();
        }

        /// <summary>
        /// Paints the grid with information from user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPaint_Click(object sender, EventArgs e)
        {
            //Makes some buttons enable
            btnStart.Enabled = true;
            btnNext.Enabled = true;
            btnRand.Enabled = true;
            btnClear.Enabled = true;

            // takes the information about numer of rows and columns, and gives the cells array a size
            rowCells = (int)rowCount.Value;
            columnCells = (int)columnCount.Value;
            cells = new Cell[rowCells, columnCells];

            //gives BMIN, BMAX, SMIN, SMAX values that the user have decided
            bMin = (int)bMinCount.Value;
            bMax = (int)bMaxCount.Value;
            sMin = (int)sMinCount.Value;
            sMax = (int)sMaxCount.Value;

            //Calculates the width and height of each cell
            cellWidth = width / columnCells;
            cellHeight = height / rowCells;

            //gives the first cell a position
            cellPosX = x;
            cellPosY = y;

            // no cells are alive when you paint the grid
            alive = false;
            
            //Creats all the cells and put them in the cells array
            for (int i = 0; i < rowCells; i++)
            {

                for (int j = 0; j < columnCells; j++)
                {

                    Cell cell = new Cell(cellWidth, cellHeight, alive, cellPosX, cellPosY);
                    cells[i, j] = cell;
                    cellPosX = cellPosX + cellWidth;
                }
                cellPosY = cellPosY + cellHeight;
                cellPosX = x;
            }
            cellPosX = x;
            cellPosY = y;

            Invalidate();
        }

        /// <summary>
        /// creats the next generation
        /// </summary>
        public void Generation()
        {
            //counts the number of neighbors
            int numNeighbor = 0;

            //An array of which cells are alive or not
            bool[,] updatedCells = new bool[rowCells, columnCells];

            //goes through all the cells and deccides which is alive or not
            for (int i = 0; i < rowCells; i++)
            {
                for (int j = 0; j < columnCells; j++)
                {                    
                    //Checks how many neighbors is alive
                    if (cells[i, mod((j - 1), columnCells)].Alive)
                        numNeighbor++;
                    if (cells[mod((i - 1), rowCells), mod((j - 1), columnCells)].Alive)
                        numNeighbor++;
                    if (cells[mod((i - 1), rowCells), j].Alive)
                        numNeighbor++;
                    if (cells[mod((i - 1), rowCells), mod((j + 1), columnCells)].Alive)
                        numNeighbor++;
                    if (cells[i, mod((j + 1), columnCells)].Alive)
                        numNeighbor++;
                    if (cells[mod((i + 1), rowCells), mod((j + 1), columnCells)].Alive)
                        numNeighbor++;
                    if (cells[mod((i + 1), rowCells), j].Alive)
                        numNeighbor++;
                    if (cells[mod((i + 1), rowCells), mod((j - 1), columnCells)].Alive)
                        numNeighbor++;

                    //see if a cell should die or become alive
                    if (cells[i, j].Alive)
                    {
                        if (numNeighbor < sMin || numNeighbor > sMax)
                        {
                            updatedCells[i, j] = false;
                        }
                        else
                        {
                            updatedCells[i, j] = true;
                        }
                            
                    }
                    else
                    {
                        if (numNeighbor >= bMin && numNeighbor <= bMax)
                        {
                            updatedCells[i, j] = true;
                        }
                        else
                        {
                            updatedCells[i, j] = false;
                        }
                            
                    }

                    numNeighbor = 0;
                }                
            }

            //update the cells to alive or not
            for (int i = 0; i < rowCells; i++)
            {
                for (int j = 0; j < columnCells; j++)
                {
                    cells[i, j].Alive = updatedCells[i, j];
                }
            }
            
        }

        /// <summary>
        /// Since "%" dosen't work with negative numbers in c#, so does the modulo manually 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int mod(int x, int y)
        {
            int r = x % y;
            return r < 0 ? r + y : r;
        }

        /// <summary>
        /// Showes the next generation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            Generation();
            Invalidate();
        }

        /// <summary>
        /// a timer to show all the next generations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            Generation();
            Invalidate();
        }

        /// <summary>
        /// starts the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            btnStop.Enabled = true;
        }

        /// <summary>
        /// stops the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        /// <summary>
        /// sets the interval of the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genPerSec_ValueChanged(object sender, EventArgs e)
        {
            trackBar.Value = (int)genPerSec.Value;
            timer.Interval = 1000 / (int)genPerSec.Value;
        }

        /// <summary>
        /// sets the interval of the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            genPerSec.Value = trackBar.Value;
            timer.Interval = 1000 / trackBar.Value;

        }

        /// <summary>
        /// Clear the grid so no cells are alive
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rowCells; i++)
            {
                for (int j = 0; j < columnCells; j++)
                {
                    cells[i, j].Alive = false;
                }
            }
            Invalidate();
        }


    }
}
