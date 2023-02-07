using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System;

namespace CourseProject
{
    public partial class FormMain : Form
    {
        Graphics graphics;
        List<Point> points = new List<Point>(); // Исходный набор точек.
        List<Point> pointsCopy = new List<Point>(); // Копия исходного набора точек для отрисовки точек.
        List<Point> stack = new List<Point>();
        int iter = 2; // Необходимо для корректного обхода точек при пошаговой работе алгоритма.
        bool isFirstStep = true; // Необходимо для корректного начала пошаговой работы алгоритма.

        public FormMain()
        {
            InitializeComponent();

            graphics = pictureBox_Drawing.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Делает линии между точками плавными.
        }

        void pictureBox_Drawing_MouseDown(object sender, MouseEventArgs e)
        {
            // Не отрисовывать и не добавлять в список повторяющиеся точки.
            if (!points.Contains(new Point(e.X, e.Y)))
            {
                points.Add(new Point(e.X, e.Y));
                graphics.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, 5, 5); // Отрисовать нажатую точку на форме.
                label_CountPoints.Text = "Количество точек: " + points.Count().ToString();
            }
            if (points.Count() >= 3) button_BuildShell.Enabled = true;
        }

        void pictureBox_Drawing_MouseMove(object sender, MouseEventArgs e)
        {
            labelX.Text = "X: " + e.X;
            labelY.Text = "Y: " + e.Y;
        }

        void SelectStep(int step)
        {
            switch (step)
            {
                case 1: // Начальный шаг.
                    label_CountPoints.Text = "Количество точек: 0";
                    button_NextStep.Text = "Начать алгоритм по шагам";
                    textBox_Info.Text = "Для начала работы работы нарисуйте минимум три точки на панели рисования. Затем нажмите на кнопку 'Начать алгоритм по шагам' или 'Построить выпуклую оболочку'" + Environment.NewLine + "В случае необходимости перерисовать точки, нажмите на кнопку 'Очистить холст'";
                    break;

                case 2: // Работа алгоритма.
                    textBox_Info.Text = "Нажимайте на кнопку 'Следующий шаг', чтобы увидеть следующий шаг работы алгоритма." + Environment.NewLine + "В случае необходимости перерисовать точки, нажмите на кнопку 'Очистить холст'";
                    button_NextStep.Text = "Следующий шаг";
                    break;

                case 3: // Конец работы.
                    textBox_Info.Text = "Работа алгоритма завершена. Построена выпуклая оболочка." + Environment.NewLine + "Нажмите на кнопку 'Очистить холст', чтобы заново рисовать точки";
                    button_NextStep.Text = "Начать алгоритм по шагам";
                    isFirstStep = true;
                    break;
            }
        }

        void button_Clean_Click(object sender, System.EventArgs e)
        {
            graphics.Clear(pictureBox_Drawing.BackColor);
            points.Clear();
            button_NextStep.Enabled = true;
            SelectStep(1);
        }

        void button_BuildShell_Click(object sender, System.EventArgs e)
        {
            if (points.Count() < 3 || points.Count() > 1000)
            {
                MessageBox.Show("Для работы алгоритма требуется не менее 3-х и не более 1000 точек.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            graphics.Clear(pictureBox_Drawing.BackColor);
            pointsCopy.Clear();
            pointsCopy.AddRange(points);
            DrawUserPoints();
            DrawShell(Graham(points));
        }

        List<Point> Graham(List<Point> points)
        {
            // Отсортировать все точки по X. Если есть точки с одинаковыми X, сортируем и по Y.
            points = points.OrderBy(p => p.X).ThenBy(p => p.Y).ToList();

            // Сортировка точек по возрастанию правого поворота.
            for (var i = 1; i < points.Count(); i++)
            {
                var j = i;
                while (j > 1 && !IsRightTurn(points[0], points[j - 1], points[j]))
                {
                    var temp = points[j];
                    points[j] = points[j - 1];
                    points[j - 1] = temp;
                    j--;
                }
            }

            List<Point> stack = new List<Point>(points.Take(2));
            for (var i = 2; i < points.Count(); i++)
            {
                stack.Add(points[i]);
                while (stack.Count() >= 3 && IsRightTurn(stack[stack.Count() - 1], stack[stack.Count() - 2], stack[stack.Count() - 3]))
                    stack.RemoveAt(stack.Count() - 2);
            }
            SelectStep(3);
            return stack;
        }

        bool IsRightTurn(Point a, Point b, Point c) => (b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - a.X) < 0;

        void DrawUserPoints()
        {
            for (var i = 0; i < pointsCopy.Count(); i++)
                graphics.FillEllipse(new SolidBrush(Color.Black), pointsCopy[i].X, pointsCopy[i].Y, 5, 5);
        }

        void DrawShell(List<Point> points)
        {
            for (var i = 0; i < points.Count() - 1; i++)
                graphics.DrawLine(new Pen(Color.Black, 5), points[i], points[i + 1]);
            graphics.DrawLine(new Pen(Color.Black, 5), points[0], points[points.Count() - 1]);
        }

        void FormMain_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = MessageBox.Show("Вы действительно хотите выйти из программы?", "Завершение программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No;

        void button_NextStep_Click(object sender, EventArgs e)
        {
            if (isFirstStep) // Первый шаг алогритма
            {
                if (points.Count() < 3 || points.Count() > 1000)
                {
                    MessageBox.Show("Для работы алгоритма требуется не менее 3-х и не более 1000 точек.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                isFirstStep = false;
                SelectStep(2);
                graphics.Clear(pictureBox_Drawing.BackColor);
                pointsCopy.Clear();
                pointsCopy.AddRange(points);
                DrawUserPoints();

                // Отсортировать все точки по X. Если есть точки с одинаковыми X, сортируем и по Y.
                points = points.OrderBy(p => p.X).ThenBy(p => p.Y).ToList();

                // Сортировка точек по возрастанию правого поворота.
                for (var i = 1; i < points.Count(); i++)
                {
                    var j = i;
                    while (j > 1 && !IsRightTurn(points[0], points[j - 1], points[j]))
                    {
                        var temp = points[j];
                        points[j] = points[j - 1];
                        points[j - 1] = temp;
                        j--;
                    }
                }

                stack = new List<Point>(points.Take(2));

                graphics.DrawLine(new Pen(Color.Red, 3), stack[0], stack[1]); // Нарисовать линию между первой и второй точкой.
            }
            else
            {
                if (iter < points.Count())
                {
                    stack.Add(points[iter++]);
                    graphics.DrawLine(new Pen(Color.Red, 3), stack[stack.Count() - 1], stack[stack.Count() - 2]); // Нарисовать линию без исключённой точкой.
                    while (stack.Count() >= 3 && IsRightTurn(stack[stack.Count() - 1], stack[stack.Count() - 2], stack[stack.Count() - 3]))
                    {
                        stack.RemoveAt(stack.Count() - 2);
                        graphics.DrawLine(new Pen(Color.Blue, 3), stack[stack.Count() - 1], stack[stack.Count() - 2]); // Нарисовать линию с исключённой точкой.
                    }
                    SelectStep(2);
                }
                else if (iter == points.Count())
                {
                    iter++;
                    graphics.DrawLine(new Pen(Color.Red, 3), stack[0], stack[stack.Count() - 1]); // Нарисовать линию между первой и последней точкой.
                }
                else
                {
                    iter = 2;
                    DrawShell(stack);
                    SelectStep(3);
                    isFirstStep = true;
                    button_NextStep.Enabled = false;
                    button_BuildShell.Enabled = false;
                }      
            }
        }
    }
}