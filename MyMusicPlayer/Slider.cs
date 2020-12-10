using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    public enum SliderStyle
    {
        Circle,
        Square,
        Indicator
    }

    public partial class Slider : Control
    {
        Rectangle foreRect;
        Rectangle backRect;
        Rectangle setRect;

        Color backgroundColor = Color.White;
        Color finishedColor = Color.Gray;
        Color setRectColor = Color.Black;
        Color fontColor = Color.Black;
        SliderStyle sliderStyle = SliderStyle.Circle;

        Point originPoint;
        Point originsetRectPoint;
        bool setRectDown = false;
        protected EventHandler OnValueChanged;

        double maximum = 100;
        double minimum = 0;
        double myValue = 0;

        bool showPercent;
        float fontSize = 9;
        FontFamily myFontFamily = new FontFamily("宋体");

        [Category("General"), Description("Show Percent Tag"), Browsable(true)]
        public bool ShowPercentTag
        {
            get { return showPercent; }
            set
            {
                showPercent = value;
                Invalidate();
            }
        }
        [Category("General"), Description("Control's Maximum"), Browsable(true)]
        public double Maximum
        {
            get { return maximum; }
            set
            {
                maximum = value;
                Invalidate();
            }
        }
        [Category("General"), Description("Control's Minimum"), Browsable(true)]
        public double Minimum
        {
            get { return minimum; }
            set
            {
                minimum = value;
                Invalidate();
            }
        }

        [Category("General"), Description("Control's FontSize"), Browsable(true)]
        public float FontSize
        {
            get { return fontSize; }
            set
            {
                this.fontSize = value;
                Invalidate();
            }
        }

        [Category("General"), Description("Control's FontFamily"), Browsable(true)]
        public FontFamily MyFontFamily
        {
            get { return myFontFamily; }
            set
            {
                this.myFontFamily = value;
                Invalidate();
            }
        }

        [Category("Color"), Browsable(true)]
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                this.backgroundColor = value;
                Invalidate();
            }
        }

        [Category("Color"), Browsable(true)]
        public Color FinishedColor
        {
            get { return finishedColor; }
            set
            {
                this.finishedColor = value;
                Invalidate();
            }
        }

        [Category("Color"), Browsable(true)]
        public Color SetRectColor
        {
            get { return setRectColor; }
            set
            {
                this.setRectColor = value;
                Invalidate();
            }
        }

        [Category("Appearance"), Browsable(true)]
        public SliderStyle SliderStyle
        {
            get { return sliderStyle; }
            set
            {
                this.sliderStyle = value;
                Invalidate();
            }
        }

        [Category("Color"), Browsable(true)]
        public Color FontColor
        {
            get { return fontColor; }
            set
            {
                this.fontColor = value;
                Invalidate();
            }
        }

        [Category("Color"), Browsable(true)]
        public Color BorderColor
        {
            get { return fontColor; }
            set
            {
                this.fontColor = value;
                Invalidate();
            }
        }

        [Category("General"), Description("Control's Width"), Browsable(true)]
        public new int Width
        {
            get { return base.Width; }
            set
            {
                base.Width = value;
                foreRect.X = backRect.X = base.Width / 20;
                backRect.Width = base.Width * 9 / 10;
                foreRect.Width = (int)(myValue / maximum * backRect.Width);
                setRect.X = (int)(myValue / maximum * (backRect.Width - backRect.Height) + foreRect.X);

                Invalidate();
            }
        }
        [Category("General"), Description("Control's Height"), Browsable(true)]
        public new int Height
        {
            get { return base.Height; }
            set
            {
                base.Height = value;
                foreRect.Height = backRect.Height = setRect.Height = setRect.Width = base.Height / 3;
                foreRect.Y = backRect.Y = setRect.Y = base.Height / 3;
                Invalidate();
            }
        }

        public event EventHandler ValueChanged
        {
            add
            {
                if (OnValueChanged != null)
                {
                    foreach (Delegate d in OnValueChanged.GetInvocationList())
                    {
                        if (object.ReferenceEquals(d, value)) { return; }
                    }
                }
                OnValueChanged = (EventHandler)Delegate.Combine(OnValueChanged, value);
            }
            remove
            {
                OnValueChanged = (EventHandler)Delegate.Remove(OnValueChanged, value);
            }
        }

        [Category("General"), Description("Control's Value"), Browsable(true)]
        public double Value
        {
            get 
            { 
                return myValue; 
            }
            set
            {
                myValue = value;

                if (Maximum == Minimum)
                {
                    myValue = minimum;
                }

                //if (myValue < Minimum)
                //    throw new ArgumentException("小于最小值");
                //if (myValue > Maximum)
                //    throw new ArgumentException("超过最大值");

                foreRect.Width = (int)(myValue / maximum * backRect.Width);
                var x = (int)(myValue / maximum * (backRect.Width - backRect.Height) + backRect.X);
                setRect.X = x > 0 ? x : 0;

                if ((myValue - maximum) > 0)
                {
                    foreRect.Width = backRect.Width;
                    setRect.X = backRect.Width - backRect.Height + backRect.X;
                }

                //如果添加了响应函数,则执行该函数
                if (OnValueChanged != null)
                {
                    OnValueChanged(this, EventArgs.Empty);
                }

                Invalidate();
            }
        }

        public Slider()
        {
            InitializeComponent();
            this.MouseDown += (sender,e)=> {
                if (setRect.Contains(e.Location))
                {
                    this.originPoint = e.Location;
                    originsetRectPoint = this.setRect.Location;
                    this.setRectDown = true;
                }
            };
            this.MouseMove += (sender,e)=> {
                if (setRectDown)
                {
                    SetSetRect(e);
                }
            };
            this.MouseUp += (sender,e)=> { setRectDown = false; };
            this.MouseClick += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    SetSetRect(e);
                }
            };
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawRect(e.Graphics);
            DrawText(e.Graphics);
        }

        private void DrawRect(Graphics e)
        {
            Pen pen = new Pen(this.finishedColor);

            e.FillRectangle(new SolidBrush(this.backgroundColor), backRect);
            e.DrawRectangle(new Pen(backgroundColor), backRect);

            e.FillRectangle(new SolidBrush(this.finishedColor), foreRect);
            e.DrawRectangle(new Pen(backgroundColor), foreRect);

            if (sliderStyle==SliderStyle.Square)
            {
                e.FillRectangle(new SolidBrush(this.setRectColor), setRect);
                e.DrawRectangle(new Pen(setRectColor), setRect);
            }

            if (sliderStyle==SliderStyle.Indicator)
            {
                // Create points that define polygon.
                PointF point1 = new PointF(setRect.X, setRect.Y);
                PointF point2 = new PointF(setRect.X, setRect.Y + setRect.Height);
                PointF point3 = new PointF(setRect.Width + setRect.X, setRect.Y + setRect.Height);
                PointF point4 = new PointF(setRect.Width + setRect.X, setRect.Y);
                PointF point5 = new PointF(setRect.X + setRect.Width / 2.0F, setRect.Y - setRect.Width / 2.0F);
                PointF[] curvePoints = { point1, point2, point3, point4, point5 };
                e.FillPolygon(new SolidBrush(this.setRectColor), curvePoints);
                e.DrawPolygon(new Pen(setRectColor), curvePoints);
            }

            if (sliderStyle==SliderStyle.Circle)
            {
                e.SmoothingMode = SmoothingMode.AntiAlias;
                e.FillEllipse(new SolidBrush(this.setRectColor), setRect.X - setRect.Width / 2.0F, setRect.Y - setRect.Height / 2.0F, setRect.Height * 2, setRect.Height * 2);//画填充椭圆的bai方法，x坐标du、y坐标、宽、高，
            }
        }
        private void DrawText(Graphics e)
        {
            if (showPercent)
            {
                Point point = new Point();
                point.X = this.backRect.X + this.backRect.Width * 3 / 7;
                point.Y = this.backRect.Y + this.backRect.Height / 3;

                SolidBrush brush = new SolidBrush(fontColor);
                Font font = new Font(myFontFamily, this.fontSize);
                string percent = ((int)this.myValue).ToString() + "%";

                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                e.DrawString(percent, font, brush, backRect, format);
            }

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Width = Width;
            this.Height = Height;
            Invalidate();
        }

        private void SetSetRect(MouseEventArgs e)
        {
            int dd = e.Location.X - originPoint.X;

            double percent = (double)(originsetRectPoint.X + dd - this.backRect.X) / (this.backRect.Width - this.backRect.Height);
            if (percent < 0)
            {
                this.Value = minimum;
                this.foreRect.Width = 0;
                this.setRect.X = backRect.X;
            }
            else if (percent > 1)
            {
                this.Value = maximum;
                this.foreRect.Width = this.backRect.Width;
                this.setRect.X = backRect.X + backRect.Width - backRect.Height;
            }
            else
            {
                this.Value = percent * maximum;
                this.foreRect.Width = (int)(percent * this.backRect.Width);
                this.setRect.X = originsetRectPoint.X + dd;
            }
            Invalidate();
        }
    }
}
