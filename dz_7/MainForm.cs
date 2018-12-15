using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz_7
{
    public partial class MainForm : Form
    {
        public Stacks remember = new Stacks();
        // паблик стэк
        public MainForm()
        {

            InitializeComponent();

        }

        private void OnPlusOneClick(object sender, EventArgs e)
        {
            // добавляем в стэк значение
            remember.Add(int.Parse(NumberBox.Text));
            NumberBox.Text = Logic.Plus(NumberBox.Text);
            // прибавляем +1
            Counter.Text = (int.Parse(Counter.Text) + 1).ToString();
            if (int.Parse(NumberBox.Text) == int.Parse(Number.Text)) Final.Text = "Отлично! Вы сделали это!";
            if (int.Parse(NumberBox.Text) > 1_000_000) Final.Text = "Проигрыш";
            // проверка на выполнение
        }

        private void OnMulti2Click(object sender, EventArgs e)
        {
            // добавляем в стэк значение
            remember.Add(int.Parse(NumberBox.Text));
            // 
            NumberBox.Text = Logic.Multi2(NumberBox.Text);
            // умножаем на 2
            Counter.Text = (int.Parse(Counter.Text) + 1).ToString();

            if (int.Parse(NumberBox.Text) == int.Parse(Number.Text)) Final.Text = "Отлично! Вы сделали это!";
            if (int.Parse(NumberBox.Text) > 1_000_000) Final.Text = "Проигрыш";
            // проверка на выполнение
        }

        private void OnResetClick(object sender, EventArgs e)
        {
            NumberBox.Text = Logic.Reset(NumberBox.Text);
            // сбрасываем в ноль значение
            Counter.Text = (0).ToString();
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            if (NumberBox.Text != "0")
            {
                //чтобы не бороться с исключениями внутри стэка, проще на этом этапе проверку на 0 сделать, т.к. пользователь 0 никак не получит
                NumberBox.Text = remember[remember.ElementsCount - 1].ToString();
                // вытягиваем из стэка значение
                remember.DellLast();
                // удаляем это значение
            }

        }

        private void OnMainFormLoad(object sender, EventArgs e)
        {
            //генерируем число
            Random rnd = new Random();
            Number.Text = rnd.Next(1, 1_000_000).ToString();
        }

        private void OnFormClosedClick(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
