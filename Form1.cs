using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinyxPainter
{
    public partial class MainForm : Form
    {
        #region 定义变量
        Graphics graphics;          //画板
        Bitmap paintImg;            //绘画图像
        int pWidth;                 //图像宽度
        int pHeight;                //图像高度
        bool isPainting=false;      //判断是否正在画图
        int startXPos;              //画图的起始坐标
        int startYPos;              //画图的起始坐标
        Btns btn = Btns.Pencil;     //当前操作
        Color drawColor=Color.Black;//笔刷颜色
        float drawWidth = 2f;       //笔刷粗细

        enum Btns
        {
            Pencil,
            Line,
            Circle,
            Rectangle,
            Eraser
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pWidth = Painter.Width;
            pHeight = Painter.Height;

            //创建一个空白画布
            paintImg = new Bitmap(pWidth, pHeight);
            graphics = Graphics.FromImage(paintImg);
            graphics.Clear(Color.White);
            Painter.Image = paintImg;
        }

        private void Painter_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isPainting = true;
                startXPos = e.X;
                startYPos = e.Y;
               
            }
        }

        private void Painter_MouseMove(object sender, MouseEventArgs e)
        {
            if(isPainting)
            {
                #region 绘制临时图像
                Graphics currGra = Graphics.FromImage(paintImg);
                Pen pen = new Pen(drawColor, drawWidth);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                currGra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //抗锯齿
                if (btn == Btns.Pencil||btn==Btns.Eraser) //自由绘制类型
                {
                    switch (btn)
                    {
                        case Btns.Pencil:
                            currGra.DrawLine(pen, startXPos, startYPos, e.X, e.Y);                          
                            break;
                        case Btns.Eraser:
                            pen.Color = Color.White;
                            pen.Width = 30f;
                            currGra.DrawLine(pen, startXPos, startYPos, e.X, e.Y);
                            pen.Color = drawColor;
                            pen.Width = drawWidth;
                            break;
                    }
                    startXPos = e.X;
                    startYPos = e.Y;
                    //自由类型 可以直接将临时图像存入画板
                    Painter.Image = paintImg; 
                }
                else if(btn==Btns.Line||btn==Btns.Circle||btn==Btns.Rectangle) //图形绘制类型
                {
                    //创建一个临时的图片来绘制
                    Bitmap tempImg = new Bitmap(pWidth, pHeight);
                    tempImg = (Bitmap)paintImg.Clone();
                    currGra = Graphics.FromImage(tempImg);

                    switch (btn)
                    {
                        case Btns.Line:                            
                            currGra.DrawLine(pen, startXPos, startYPos, e.X, e.Y);
                            break;
                        case Btns.Circle:
                            currGra.DrawEllipse(pen, startXPos, startYPos, e.X - startXPos, e.Y - startYPos);
                            break;
                        case Btns.Rectangle:
                            if (e.X < startXPos)
                            {
                                if(e.Y < startYPos) currGra.DrawRectangle(pen, e.X, e.Y, startXPos - e.X, startYPos - e.Y);                               
                                else currGra.DrawRectangle(pen, e.X, startYPos, startXPos - e.X, e.Y - startYPos);
                            }
                            else
                            {
                                if(e.Y < startYPos) currGra.DrawRectangle(pen, startXPos, e.Y, e.X - startXPos, startYPos - e.Y);
                                else currGra.DrawRectangle(pen, startXPos, startYPos, e.X - startXPos, e.Y - startYPos);
                            }
                            break;
                    }
                    //将Painter视图的图像设置为这个临时图像                      
                    Painter.Image = tempImg;
                }            
                currGra.Dispose();
                #endregion
            }
        }

        private void Painter_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isPainting = false;

                #region 画最后一笔
                Graphics currGra = Graphics.FromImage(paintImg);
                Pen pen = new Pen(drawColor, drawWidth);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                currGra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //抗锯齿

                switch (btn)
                {
                    case Btns.Line:                       
                        currGra.DrawLine(pen, startXPos, startYPos, e.X, e.Y);                      
                        break;
                    case Btns.Circle:
                        currGra.DrawEllipse(pen, startXPos, startYPos, e.X - startXPos, e.Y - startYPos);
                        break;
                    case Btns.Rectangle:
                        if (e.X < startXPos)
                        {
                            if (e.Y < startYPos) currGra.DrawRectangle(pen, e.X, e.Y, startXPos - e.X, startYPos - e.Y);
                            else currGra.DrawRectangle(pen, e.X, startYPos, startXPos - e.X, e.Y - startYPos);
                        }
                        else
                        {
                            if (e.Y < startYPos) currGra.DrawRectangle(pen, startXPos, e.Y, e.X - startXPos, startYPos - e.Y);
                            else currGra.DrawRectangle(pen, startXPos, startYPos, e.X - startXPos, e.Y - startYPos);
                        }
                        break;
                    default:
                        break;
                }
                Painter.Image = paintImg;
                #endregion

                startXPos = 0;
                startYPos = 0;
            }
        }

        #region 基础操作按钮

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                paintImg = (Bitmap)Image.FromFile(openFileDialog.FileName);
                Painter.Image = paintImg;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                paintImg.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Graphics currGra = Graphics.FromImage(paintImg);
            currGra.Clear(Color.White);
            Painter.Image = paintImg;
            currGra.Dispose();
        }

        #endregion

        #region 枚举当前笔刷
        private void PencilBtn_Click(object sender, EventArgs e)
        {
            btn = Btns.Pencil;
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            btn = Btns.Line;
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            btn = Btns.Circle;
        }

        private void RectBtn_Click(object sender, EventArgs e)
        {
            btn = Btns.Rectangle;
        }
        
        private void EraserBtn_Click(object sender, EventArgs e)
        {
            btn = Btns.Eraser;
        }
        #endregion

        #region 更改笔刷样式
        private void ColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            colorDialog.Color = drawColor;
            if(colorDialog.ShowDialog()==DialogResult.OK)
            {
                drawColor = colorDialog.Color;
                ColorBtn.BackColor = colorDialog.Color;
            }
        }

        private void WidthBtn_Click(object sender, EventArgs e)
        {
            float width = (float)Convert.ToInt32(WidthText.Text);
            if (width != 0) drawWidth = width;
        }

        #endregion

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
