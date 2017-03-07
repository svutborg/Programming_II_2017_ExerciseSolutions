using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7._0
{
    struct DrawTool
    {
        public enum Tools { Freehand, Line, Rectangle, Ellipse }
        public enum Fill { None, Solid }
        public ToolStripComboBox ToolSelector { get; set; }
        public ToolStripComboBox FillSelector { get; set; }

        public DrawTool(ToolStripComboBox toolSelectionCombobox, ToolStripComboBox fillSelectionCombobox)
        {
            ToolSelector = toolSelectionCombobox;
            ToolSelector.Items.AddRange(Enum.GetNames(typeof(Tools)));
            FillSelector = fillSelectionCombobox;
            FillSelector.Items.AddRange(Enum.GetNames(typeof(Fill)));
        }

        public void Draw(Graphics plane, DrawMode dm)
        {
            Draw(plane, dm.Pen, dm.Start, dm.Stop);
        }

        public void Draw(Graphics plane, Pen p, Point start, Point stop)
        {
            switch ((Tools)ToolSelector.SelectedIndex)
            {
                case Tools.Freehand:
                    plane.DrawLine(p, start, stop);
                    break;
                case Tools.Line:
                    plane.DrawLine(p, start, stop);
                    break;
                case Tools.Rectangle:
                    switch((Fill)FillSelector.SelectedIndex)
                    {
                        case Fill.None:
                            plane.DrawRectangle(
                            p,
                            Math.Min(start.X, stop.X),
                            Math.Min(start.Y, stop.Y),
                            Math.Abs(stop.X - start.X),
                            Math.Abs(stop.Y - start.Y)
                            );
                            break;
                        case Fill.Solid:
                            plane.FillRectangle(
                            p.Brush,
                            Math.Min(start.X, stop.X),
                            Math.Min(start.Y, stop.Y),
                            Math.Abs(stop.X - start.X),
                            Math.Abs(stop.Y - start.Y)
                            );
                            break;
                        default:
                            break;
                    }
                    break;
                case Tools.Ellipse:
                    switch ((Fill)FillSelector.SelectedIndex)
                    {
                        case Fill.None:
                            plane.DrawEllipse(
                                p,
                                new Rectangle(
                                    Math.Min(start.X, stop.X),
                                    Math.Min(start.Y, stop.Y),
                                    Math.Abs(stop.X - start.X),
                                    Math.Abs(stop.Y - start.Y)
                                )
                            );
                            break;
                        case Fill.Solid:
                            plane.FillEllipse(
                                p.Brush,
                                new Rectangle(
                                    Math.Min(start.X, stop.X),
                                    Math.Min(start.Y, stop.Y),
                                    Math.Abs(stop.X - start.X),
                                    Math.Abs(stop.Y - start.Y)
                                )
                            );
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
    struct DrawMode
    {
        public Point Start { get; set; }
        public Point Stop { get; set; }
        public bool Down { get; set; }
        public Pen Pen { get; set; }
        private ColorRegion CR;

        public DrawMode(ColorRegion cr)
        {
            Start = new Point();
            Stop = new Point();
            Down = false;
            Pen = new Pen(cr.Color);
            CR = cr;
            CR.BackColorChanged += CR_BackColorChanged;
        }

        private void CR_BackColorChanged(object sender, EventArgs e)
        {
            Pen.Color = CR.Color;
        }
    }
    public partial class MainForm : Form
    {
        DrawMode primaryMouseDown, secondaryMouseDown;        
        DrawTool drawTool;
        Bitmap renderImage, finalImage;
        public NumericUpDown StrokeWidthSelector { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            StrokeWidthSelector = new NumericUpDown()
            {
                Value = 1,
                Minimum = 1,
                Height = 30
            };
            StrokeWidthSelector.BorderStyle = BorderStyle.FixedSingle;
            ToolStripControlHost TC = new ToolStripControlHost(StrokeWidthSelector);
            TopToolStrip.Items.Insert(4,TC);

            primaryMouseDown = new DrawMode(colorPicker.PrimaryColor);
            secondaryMouseDown = new DrawMode(colorPicker.SecondaryColor);
            drawTool = new DrawTool(ToolSelectToolStripComboBox, FillSelectToolStripComboBox);
            drawTool.ToolSelector.SelectedIndex = (int)DrawTool.Tools.Line;
            drawTool.FillSelector.SelectedIndex = (int)DrawTool.Fill.None;

            renderImage = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
            finalImage = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
            MainPictureBox.Image = finalImage;


            StrokeWidthSelector.ValueChanged += StrokeWidthSelector_ValueChanged;
        }

        private void StrokeWidthSelector_ValueChanged(object sender, EventArgs e)
        {
            primaryMouseDown.Pen.Width = Convert.ToSingle(StrokeWidthSelector.Value);
            secondaryMouseDown.Pen.Width = Convert.ToSingle(StrokeWidthSelector.Value);
        }

        private void MainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                primaryMouseDown.Start = e.Location;
                primaryMouseDown.Down = true;
            }
            else if(e.Button == MouseButtons.Right)
            {
                secondaryMouseDown.Start = e.Location;
                secondaryMouseDown.Down = true;
            }
        }

        private void FlowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            ToolPanel.Width = flowLayoutPanel1.Width - colorPicker.Width - 15;
        }

        private void MainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics drawPlane = Graphics.FromImage(finalImage);
            if (e.Button == MouseButtons.Left)
            {
                primaryMouseDown.Stop = e.Location;
                primaryMouseDown.Down = false;
                drawTool.Draw(drawPlane, primaryMouseDown);
            }
            else if (e.Button == MouseButtons.Right)
            {
                secondaryMouseDown.Stop = e.Location;
                secondaryMouseDown.Down = false;
                drawTool.Draw(drawPlane, secondaryMouseDown);
            }
            MainPictureBox.Image = finalImage;
            drawPlane.Dispose();    
        }

        private void MainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics renderPlane;
            renderImage = new Bitmap(finalImage);
            if ((DrawTool.Tools)drawTool.ToolSelector.SelectedIndex == DrawTool.Tools.Freehand)
            {
                renderPlane = Graphics.FromImage(finalImage);
            }
            else
            {
                renderPlane = Graphics.FromImage(renderImage);
            }
            if (primaryMouseDown.Down)
            {
                drawTool.Draw(renderPlane, primaryMouseDown.Pen, primaryMouseDown.Start, e.Location);
            }
            if (secondaryMouseDown.Down)
            {
                drawTool.Draw(renderPlane, secondaryMouseDown.Pen, secondaryMouseDown.Start, e.Location);
            }
            if ((DrawTool.Tools)drawTool.ToolSelector.SelectedIndex == DrawTool.Tools.Freehand)
            {
                primaryMouseDown.Start = e.Location;
                secondaryMouseDown.Start = e.Location;
            }
            MainPictureBox.Image = renderImage;
            renderPlane.Dispose();
        }
    }
}