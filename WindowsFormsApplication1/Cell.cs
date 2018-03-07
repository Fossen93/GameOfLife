using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Cell
    {
        private float width;
        private float height;

        private bool alive;

        private float cellPosX;
        private float cellPosY;

        public Cell()
        {

        }

        public Cell (float width, float height, bool alive, float cellPosX, float CellPosY)
        {
            this.width = width;
            this.height = height;
            this.alive = alive;
            this.cellPosX = cellPosX;
            this.cellPosY = CellPosY;
        }

        public Rectangle CellArea()
        {
            Rectangle rect = new Rectangle((int)cellPosX, (int)cellPosY, (int)width, (int)height);
            return rect;
        }

        public float Width
        {
            get{return this.width;}
            set{this.width = value;}
        }

        public float Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public bool Alive
        {
            get { return this.alive; }
            set { this.alive = value; }
        }

        public float CellPosX
        {
            get { return this.cellPosX; }
            set { this.cellPosX = value; }
        }

        public float CellPosY
        {
            get { return this.cellPosY; }
            set { this.cellPosY = value; }
        }
    }
}
