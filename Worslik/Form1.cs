namespace Worslik
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(txtX1.Text);
            double y1 = Convert.ToDouble(txtY1.Text);
            double x2 = Convert.ToDouble(txtX2.Text);
            double y2 = Convert.ToDouble(txtY2.Text);
            double x3 = Convert.ToDouble(txtX3.Text);
            double y3 = Convert.ToDouble(txtY3.Text);
            
            string triangleType = cmbTriangleType.SelectedItem.ToString();

            Triangle uchburchak = null;
            switch (triangleType)
            {
                case "T_UTCHANG":
                    uchburchak = new T_UTCHANG(x1, y1, x2, y2, x3, y3);
                    break;
                case "TT_TRIANGLE":
                    uchburchak = new TT_TRIANGLE(x1, y1, x2, y2, x3, y3);
                    break;
                case "TY_TRIANGLE":
                    uchburchak = new TY_TRIANGLE(x1, y1, x2, y2, x3, y3);
                    break;
                default:
                    uchburchak = new Triangle(x1, y1, x2, y2, x3, y3);
                    break;
            }

            lblType.Text = uchburchak.Type();
            lblArea.Text = uchburchak.Yuzi().ToString();
            lblPerimeter.Text = uchburchak.Perimeter().ToString();
        }


        public class Triangle
        {
            protected double X1 { get; set; }
            protected double Y1 { get; set; }
            protected double X2 { get; set; }
            protected double Y2 { get; set; }
            protected double X3 { get; set; }
            protected double Y3 { get; set; }

            public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
            {
                X1 = x1;
                Y1 = y1;
                X2 = x2;
                Y2 = y2;
                X3 = x3;
                Y3 = y3;
            }

            public virtual string Type()
            {
                double a = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
                double b = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
                double c = Math.Sqrt(Math.Pow(X1 - X3, 2) + Math.Pow(Y1 - Y3, 2));

                if (a == b && b == c && a == c)
                {
                    return "Teng tomonli uchburchak";
                }
                else if (a == b || a == c || b == c)
                {
                    return "teng yonli uchburchak";
                }
                else if ((a * a + b * b) == c * c || (a * a + c * c) == b * b || (b * b + c * c) == a * a)
                {
                    return "to‘g‘riburchakli uchburchak ";
                }
                else
                {
                    return "Bunaqa uchburchak yuq";
                }

            }

            public virtual double Yuzi()
            {
                double a = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
                double b = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
                double c = Math.Sqrt(Math.Pow(X1 - X3, 2) + Math.Pow(Y1 - Y3, 2));
                double Perimeter = (a + b + c) / 2;
                return Math.Sqrt(Perimeter * (Perimeter - a) * (Perimeter - b) * (Perimeter - c));
            }

            public virtual double Perimeter()
            {
                double a = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
                double b = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
                double c = Math.Sqrt(Math.Pow(X1 - X3, 2) + Math.Pow(Y1 - Y3, 2));
                return a + b + c;
            }
        }

        public class T_UTCHANG : Triangle
        {
            public T_UTCHANG(double x1, double y1, double x2, double y2, double x3, double y3)
                : base(x1, y1, x2, y2, x3, y3)
            {
            }

            public override double Yuzi()
            {
                double a = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
                double b = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
                double c = Math.Sqrt(Math.Pow(X1 - X3, 2) + Math.Pow(Y1 - Y3, 2));

                if (a * a + b * b == c * c)
                {
                    return a * b / 2;
                }
                else
                {
                     return base.Yuzi();
                }
            }
        }

        public class TT_TRIANGLE : Triangle
        {
            public TT_TRIANGLE(double x1, double y1, double x2, double y2, double x3, double y3)
                : base(x1, y1, x2, y2, x3, y3)
            {
            }

            public override double Yuzi()
            {
                double a = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
                double b = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
                double c = Math.Sqrt(Math.Pow(X1 - X3, 2) + Math.Pow(Y1 - Y3, 2));

                if (a == b && b == c && a == c)
                {
                    return a * a * 3 / 4;
                }
                else
                {
                    return base.Yuzi();
                }
            }
        }

        public class TY_TRIANGLE : Triangle
        {
            public TY_TRIANGLE(double x1, double y1, double x2, double y2, double x3, double y3)
                : base(x1, y1, x2, y2, x3, y3)
            {
            }

            public override string Type()
            {
                return "Teng yonli uchburchak";
            }

            public override double Yuzi()
            {
                double a = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
                double b = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
                double c = Math.Sqrt(Math.Pow(X1 - X3, 2) + Math.Pow(Y1 - Y3, 2));

                if (a == b || a == c || b == c)
                {
                    return Math.Sqrt(a * b - c * c) * c / 2;
                }
                else
                {
                    return base.Yuzi();
                }
            }
        }

        private void sal_Click(object sender, EventArgs e)
        {

        }

    }
}
