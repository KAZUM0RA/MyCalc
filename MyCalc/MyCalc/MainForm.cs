using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCalc.Properties;

namespace MyCalc
{
    public partial class MainForm : Form
    {

        private string[] _buttonNames =
        {
            "←", "CE", "C", "±", "√", "7", "8", "9", "/", "%", "4", "5",
            "6", "*", "1/x", "1", "2", "3", "-", "=", "0", ",", "+",
        };

        private List<Button> _buttons = new List<Button>();
        private int _bitDepth = 8; //8 разрядный калькулятор
        private string _currentOperation = ""; // текущая операция
        private string _leftOperand = ""; //левый операнд выражения
        private string _rightOperand = ""; //правый операнд выражения
        private Tools _tools = null;

        public MainForm()
        {
            InitializeComponent();
            InitButtons();
        }

        private void InitButtons()
        {
            int ind = 0;
            int posX = 3;
            int posY = 118;
            int stepX = 61;
            int stepY = 46;

            foreach (var oneButtName in _buttonNames)
            {
                Button tmp = new Button();

                tmp.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                tmp.Size = new System.Drawing.Size(55, 40);
                tmp.UseVisualStyleBackColor = true;
                tmp.Text = oneButtName;

                tmp.TabIndex = ind + 6;
                tmp.Location = new Point(posX, posY);
                this.Controls.Add(tmp);
                _buttons.Add(tmp);
                tmp.Click += Button_Click;
                ind++;

                posX += stepX;
                if (ind % 5 == 0)
                {
                    posY += stepY;
                    posX = 3;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "0":
                {
                    if (_currentOperation.Length == 0) //заполянем левый операнд
                    {
                        if (_leftOperand.Length < _bitDepth)
                        {
                            _leftOperand += "0";
                            textBox_Result.Text = _leftOperand;
                        }

                        break;
                    }
                    else //заполянем правый операнд
                    {
                        if (_rightOperand.Length < _bitDepth)
                        {
                            _rightOperand += "0";
                            textBox_Result.Text = _rightOperand;
                        }

                        break;
                    }

                    break;
                }
                case "1":
                {
                    if (_currentOperation.Length == 0) //заполянем левый операнд
                    {
                        if (_leftOperand.Length < _bitDepth)
                        {
                            _leftOperand += "1";
                            textBox_Result.Text = _leftOperand;
                        }

                        break;
                    }
                    else //заполянем правый операнд
                    {
                        if (_rightOperand.Length < _bitDepth)
                        {
                            _rightOperand += "1";
                            textBox_Result.Text = _rightOperand;
                        }

                        break;
                    }

                    break;
                }
                case "2":
                {
                    if (_currentOperation.Length == 0) //заполянем левый операнд
                    {
                        if (_leftOperand.Length < _bitDepth)
                        {
                            _leftOperand += "2";
                            textBox_Result.Text = _leftOperand;
                        }

                        break;
                    }
                    else //заполянем правый операнд
                    {
                        if (_rightOperand.Length < _bitDepth)
                        {
                            _rightOperand += "2";
                            textBox_Result.Text = _rightOperand;
                        }

                        break;
                    }

                    break;
                }
                case "3":
                {
                    if (_currentOperation.Length == 0) //заполянем левый операнд
                    {
                        if (_leftOperand.Length < _bitDepth)
                        {
                            _leftOperand += "3";
                            textBox_Result.Text = _leftOperand;
                        }

                        break;
                    }
                    else //заполянем правый операнд
                    {
                        if (_rightOperand.Length < _bitDepth)
                        {
                            _rightOperand += "3";
                            textBox_Result.Text = _rightOperand;
                        }

                        break;
                    }

                    break;
                }
                case "4":
                {
                    if (_currentOperation.Length == 0) //заполянем левый операнд
                    {
                        if (_leftOperand.Length < _bitDepth)
                        {
                            _leftOperand += "4";
                            textBox_Result.Text = _leftOperand;
                        }

                        break;
                    }
                    else //заполянем правый операнд
                    {
                        if (_rightOperand.Length < _bitDepth)
                        {
                            _rightOperand += "4";
                            textBox_Result.Text = _rightOperand;
                        }

                        break;
                    }

                    break;
                }
                case "5":
                {
                    if (_currentOperation.Length == 0) //заполянем левый операнд
                    {
                        if (_leftOperand.Length < _bitDepth)
                        {
                            _leftOperand += "5";
                            textBox_Result.Text = _leftOperand;
                        }

                        break;
                    }
                    else //заполянем правый операнд
                    {
                        if (_rightOperand.Length < _bitDepth)
                        {
                            _rightOperand += "5";
                            textBox_Result.Text = _rightOperand;
                        }

                        break;
                    }

                    break;
                }
                case "6":
                {
                    if (_currentOperation.Length == 0) //заполянем левый операнд
                    {
                        if (_leftOperand.Length < _bitDepth)
                        {
                            _leftOperand += "6";
                            textBox_Result.Text = _leftOperand;
                        }

                        break;
                    }
                    else //заполянем правый операнд
                    {
                        if (_rightOperand.Length < _bitDepth)
                        {
                            _rightOperand += "6";
                            textBox_Result.Text = _rightOperand;
                        }

                        break;
                    }

                    break;
                }
                case "7":
                {
                    if (_currentOperation.Length == 0) //заполянем левый операнд
                    {
                        if (_leftOperand.Length < _bitDepth)
                        {
                            _leftOperand += "7";
                            textBox_Result.Text = _leftOperand;
                        }

                        break;
                    }
                    else //заполянем правый операнд
                    {
                        if (_rightOperand.Length < _bitDepth)
                        {
                            _rightOperand += "7";
                            textBox_Result.Text = _rightOperand;
                        }

                        break;
                    }

                    break;
                }
                case "8":
                {
                    if (_currentOperation.Length == 0) //заполянем левый операнд
                    {
                        if (_leftOperand.Length < _bitDepth)
                        {
                            _leftOperand += "8";
                            textBox_Result.Text = _leftOperand;
                        }

                        break;
                    }
                    else //заполянем правый операнд
                    {
                        if (_rightOperand.Length < _bitDepth)
                        {
                            _rightOperand += "8";
                            textBox_Result.Text = _rightOperand;
                        }

                        break;
                    }

                    break;
                }
                case "9":
                {

                    if (_currentOperation.Length == 0) //заполянем левый операнд
                    {
                        if (_leftOperand.Length < _bitDepth)
                        {
                            _leftOperand += "9";
                            textBox_Result.Text = _leftOperand;
                        }

                        break;
                    }
                    else //заполянем правый операнд
                    {
                        if (_rightOperand.Length < _bitDepth)
                        {
                            _rightOperand += "9";
                            textBox_Result.Text = _rightOperand;
                        }
                    }

                    break;
                }
                case ",":
                {

                    if (_currentOperation.Length == 0) //заполянем левый операнд
                    {
                        if (_leftOperand.Length < _bitDepth)
                        {
                            _leftOperand += ",";
                            textBox_Result.Text = _leftOperand;
                        }

                        break;
                    }
                    else //заполянем правый операнд
                    {
                        if (_rightOperand.Length < _bitDepth)
                        {
                            _rightOperand += ",";
                            textBox_Result.Text = _rightOperand;
                        }
                    }

                    break;
                }
                case "+":
                {
                    _currentOperation = "+";
                    textBox_Result.Text = "";
                    break;
                }
                case "-":
                {
                    _currentOperation = "-";
                    textBox_Result.Text = "";
                    break;
                }
                case "/":
                {
                    _currentOperation = "/";
                    textBox_Result.Text = "";
                    break;
                }
                case "*":
                {
                    _currentOperation = "*";
                    textBox_Result.Text = "";
                    break;
                }
                case "√":
                {
                    double lOper = double.Parse(_leftOperand);
                    textBox_Result.Text = (Math.Sqrt(lOper)).ToString();
                    break;
                }
                case "←":
                {
                    if (_rightOperand.Length > 0)
                    {
                        _rightOperand = _rightOperand.Remove(_rightOperand.Length - 1);
                        textBox_Result.Text = _rightOperand;

                    }
                    else if(_leftOperand.Length > 0)
                    {
                        _leftOperand = _leftOperand.Remove(_leftOperand.Length - 1);
                        textBox_Result.Text = _leftOperand;
                    }
                    break;
                }
                case "C":
                {
                    textBox_Result.Clear();
                    _leftOperand = "";
                    _rightOperand = "";
                    _currentOperation = "";
                    break;
                }
                case "CE":
                {
                    textBox_Result.Clear();
                    _leftOperand = "";
                    _rightOperand = "";
                    _currentOperation = "";
                    break;
                }
                case "%":
                {
                    double lOper = double.Parse(_leftOperand);
                    double rOper = double.Parse(_rightOperand);
                    textBox_Result.Text = (lOper*(rOper/100)).ToString();
                    break;
                }
                case "±":
                {
                    if (!string.IsNullOrEmpty(_rightOperand))
                    {
                        double currentValue = double.Parse(_rightOperand);
                        _rightOperand = (-currentValue).ToString();
                        textBox_Result.Text = _rightOperand;
                    }
                    else if (!string.IsNullOrEmpty(_leftOperand))
                    {
                        double currentValue = double.Parse(_leftOperand);
                        _leftOperand = (-currentValue).ToString();
                        textBox_Result.Text = _leftOperand;
                    }
                   break;
                }
                case "1/x":
                {
                    if (!string.IsNullOrEmpty(_rightOperand))
                    {
                        double currentValue = double.Parse(_rightOperand);
                        if (currentValue != 0)
                        {
                            _rightOperand = (1 / currentValue).ToString();
                            textBox_Result.Text = _rightOperand;
                        }
                      
                    }
                    else if (!string.IsNullOrEmpty(_leftOperand))
                    {
                        double currentValue = double.Parse(_leftOperand);
                        if (currentValue != 0)
                        {
                            _leftOperand = (1 / currentValue).ToString();
                            textBox_Result.Text = _leftOperand;
                        }
                        
                    }
                    break;
                }
                case "=":
                {
                    switch (_currentOperation)
                    {
                        case "+":
                        {
                            double lOper = double.Parse(_leftOperand);
                            double rOper = double.Parse(_rightOperand);
                            textBox_Result.Text = (lOper + rOper).ToString();
                            break;
                        }
                        case "-":
                        {
                            double lOper = double.Parse(_leftOperand);
                            double rOper = double.Parse(_rightOperand);
                            textBox_Result.Text = (lOper - rOper).ToString();
                            break;
                        }
                        case "*":
                        {
                            double lOper = double.Parse(_leftOperand);
                            double rOper = double.Parse(_rightOperand);
                            textBox_Result.Text = (lOper * rOper).ToString();
                            break;
                        }
                        case "/":
                        {
                            double lOper = double.Parse(_leftOperand);
                            double rOper = double.Parse(_rightOperand);
                            textBox_Result.Text = (lOper / rOper).ToString();
                            break;
                        }
                    }
                    break;
                }
            }

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_tools == null)
            {
                _tools = new Tools(this);
            }

            _tools.Location = new Point(
                this.Location.X + this.Size.Width - 12,
                this.Location.Y
            );
            _tools.Show();
        }

        public void ChangeBackgroundColor(Color color)
        {
            this.BackColor = color;
        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(
                this.Size.Width * 2,
                this.Size.Height
                );
            обычныйToolStripMenuItem.Checked = false;
            инженерныйToolStripMenuItem.Checked = true;
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(
                this.Size.Width / 2,
                this.Size.Height
            );
            инженерныйToolStripMenuItem.Checked = false;
            обычныйToolStripMenuItem.Checked = true;
        }
    }
}