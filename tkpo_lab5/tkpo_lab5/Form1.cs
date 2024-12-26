using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkpo_lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public interface IState
        {
            string Call(Phone phone);
            string Answer(Phone phone);
            string EndCall(Phone phone);
            string Recharge(Phone phone, double amount);
        }

        public class WaitingState : IState
        {
            public string Call(Phone phone)
            {
                if (phone.Balance > 0)
                {
                    phone.SetState(new CallingState());
                    return "Телефон звонит...";
                }
                else
                {
                    phone.SetState(new BlockedState());
                    return "Баланс недостаточен для звонка.";
                }
            }

            public string Answer(Phone phone)
            {
                return "Никто не звонит, нельзя ответить.";
            }

            public string EndCall(Phone phone)
            {
                return "Нет активных вызовов для завершения.";
            }

            public string Recharge(Phone phone, double amount)
            {
                phone.Balance += amount;
                return $"Баланс пополнен на {amount:F2}. \nТекущий баланс: {phone.Balance:F2}.";
            }
        }

        public class CallingState : IState
        {
            public string Call(Phone phone)
            {
                return "Уже идет звонок.";
            }

            public string Answer(Phone phone)
            {
                phone.SetState(new TalkingState());
                return "Разговор начат.";
            }

            public string EndCall(Phone phone)
            {
                phone.SetState(new WaitingState());
                return "Звонок завершен.";
            }

            public string Recharge(Phone phone, double amount)
            {
                phone.Balance += amount;
                return $"Баланс пополнен на {amount:F2}. \nТекущий баланс: {phone.Balance:F2}.";
            }
        }

        public class TalkingState : IState
        {
            public string Call(Phone phone)
            {
                return "Нельзя позвонить во время разговора.";
            }

            public string Answer(Phone phone)
            {
                return "Вы уже разговариваете.";
            }

            public string EndCall(Phone phone)
            {
                phone.Balance -= 5;
                if (phone.Balance < 0)
                    phone.SetState(new BlockedState());
                else
                    phone.SetState(new WaitingState());
                return $"Разговор завершен.\nСписано 5 рублей. Текущий баланс: {phone.Balance:F2}.";
            }

            public string Recharge(Phone phone, double amount)
            {
                phone.Balance += amount;
                return $"Баланс пополнен на {amount:F2}. \nТекущий баланс: {phone.Balance:F2}.";
            }
        }

        public class BlockedState : IState
        {
            public string Call(Phone phone)
            {
                return "Телефон заблокирован. Пополните баланс.";
            }

            public string Answer(Phone phone)
            {
                return "Телефон заблокирован. Нельзя ответить на звонок.";
            }

            public string EndCall(Phone phone)
            {
                return "Нет активных вызовов.";
            }

            public string Recharge(Phone phone, double amount)
            {
                phone.Balance += amount;
                if (phone.Balance >= 0)
                    phone.SetState(new WaitingState());
                return $"Баланс пополнен на {amount:F2}. \nТекущий баланс: {phone.Balance:F2}.";
            }
        }

        public class Phone
        {
            public double Balance { get; set; }
            private IState _state;

            public Phone(double initialBalance)
            {
                Balance = initialBalance;
                if (Balance < 0)
                    _state = new BlockedState();
                else
                    _state = new WaitingState();
            }

            public void SetState(IState state)
            {
                _state = state;
            }

            public string GetStateName()
            {
                return _state.GetType().Name;
            }

            public string Call() => _state.Call(this);
            public string Answer() => _state.Answer(this);
            public string EndCall() => _state.EndCall(this);
            public string Recharge(double amount) => _state.Recharge(this, amount);
        }

        Phone phone = new Phone(10);

        private void Form1_Load(object sender, EventArgs e)
        {
            this.labelBalance.Text = phone.Balance.ToString();
            this.labelState.Text = phone.GetStateName();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.listBox1.Items.Add(phone.Recharge(Convert.ToDouble(this.textBox1.Text)));
            }
            catch 
            {
                MessageBox.Show("Неверно введено число");
            }
            this.labelState.Text = phone.GetStateName();
            this.labelBalance.Text = phone.Balance.ToString();
        }

        private void buttonCall_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(phone.Call());
            this.labelState.Text = phone.GetStateName();
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(phone.Answer());
            this.labelState.Text = phone.GetStateName();
        }

        private void buttonEndCall_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(phone.EndCall());
            this.labelState.Text = phone.GetStateName();
            this.labelBalance.Text = phone.Balance.ToString();
        }
    }
}