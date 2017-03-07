using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7._0
{
    public partial class ColorPicker : UserControl
    {
        Color[,] defaultColors = {  { Color.Black, Color.DarkGray,  Color.DarkRed, Color.Red,       Color.Orange, Color.Yellow,      Color.Green, Color.DarkTurquoise, Color.RoyalBlue, Color.Purple}, 
                                    { Color.White, Color.LightGray, Color.SandyBrown,   Color.MistyRose, Color.Gold,   Color.LightYellow, Color.Lime,  Color.PaleTurquoise, Color.CadetBlue, Color.Lavender} };
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public ColorRegion PrimaryColor { get; private set; }
        public ColorRegion SecondaryColor { get; private set; }
        public ColorRegion[,] SelectableColours { get; private set; }

        public ColorPicker()
        {
            Rows = 2;
            Columns = 10;
            SelectableColours = new ColorRegion[Rows,Columns];
            //------ Primary and secondary colours -------
            PrimaryColor = new ColorRegion(this, Color.Black,30,30,5,5);
            this.Controls.Add(this.PrimaryColor);
            SecondaryColor = new ColorRegion(this, Color.White,30,30,20,20);
            this.Controls.Add(this.SecondaryColor);
            //------ Selectable colours -------
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    SelectableColours[i,j] = new ColorRegion(this, defaultColors[i,j] , 20, 20, 5 + (25 * i), 60 + (25 * j));
                    this.Controls.Add(SelectableColours[i,j]);
                }
            }
            BorderStyle = BorderStyle.Fixed3D;
            InitializeComponent();
        }
    }

    public class ColorRegion : Panel
    {
        ColorPicker owner;
        public Color Color {
            get
            {
                return BackColor;
            }
            set
            {
                BackColor = value;
            }
        } 
        public ColorRegion(ColorPicker owner, Color col, int width, int height, int top, int left)
        {
            this.owner = owner;
            Color = col;
            Width = width;
            Height = height;
            Top = top;
            Left = left;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Click += new EventHandler(ColorRegionClick);
        }

        private void ColorRegionClick(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                owner.PrimaryColor.Color = this.Color;
            }
            else if(me.Button == MouseButtons.Right)
            {
                owner.SecondaryColor.Color = this.Color;
            }
        }
    }
}
