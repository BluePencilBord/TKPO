using System;

namespace PhoneStatePattern
{
    public interface IState
    {
        void Call(Phone phone);
        void Answer(Phone phone);
        void EndCall(Phone phone);
        void Recharge(Phone phone, double amount);
    }

    public class WaitingState : IState
    {
        public void Call(Phone phone)
        {
            if (phone.Balance > 0)
            {
                Console.WriteLine("Телефон звонит...");
                phone.SetState(new CallingState());
            }
            else
            {
                Console.WriteLine("Баланс недостаточен для звонка.");
                phone.SetState(new BlockedState());
            }
        }

        public void Answer(Phone phone)
        {
            Console.WriteLine("Никто не звонит, нельзя ответить.");
        }

        public void EndCall(Phone phone)
        {
            Console.WriteLine("Нет активных вызовов для завершения.");
        }

        public void Recharge(Phone phone, double amount)
        {
            phone.Balance += amount;
            Console.WriteLine($"Баланс пополнен на {amount:F2}. Текущий баланс: {phone.Balance:F2}.");
        }
    }

    public class CallingState : IState
    {
        public void Call(Phone phone)
        {
            Console.WriteLine("Уже идет звонок.");
        }

        public void Answer(Phone phone)
        {
            Console.WriteLine("Разговор начат.");
            phone.SetState(new TalkingState());
        }

        public void EndCall(Phone phone)
        {
            Console.WriteLine("Звонок завершен.");
            phone.SetState(new WaitingState());
        }

        public void Recharge(Phone phone, double amount)
        {
            phone.Balance += amount;
            Console.WriteLine($"Баланс пополнен на {amount:F2}. Текущий баланс: {phone.Balance:F2}.");
        }
    }

    public class TalkingState : IState
    {
        public void Call(Phone phone)
        {
            Console.WriteLine("Нельзя позвонить во время разговора.");
        }

        public void Answer(Phone phone)
        {
            Console.WriteLine("Вы уже разговариваете.");
        }

        public void EndCall(Phone phone)
        {
            Console.WriteLine("Разговор завершен.");
            phone.Balance -= 5;
            Console.WriteLine($"Списано 5 рублей. Текущий баланс: {phone.Balance:F2}.");
            if (phone.Balance < 0)
                phone.SetState(new BlockedState());
            else
                phone.SetState(new WaitingState());
        }

        public void Recharge(Phone phone, double amount)
        {
            phone.Balance += amount;
            Console.WriteLine($"Баланс пополнен на {amount:F2}. Текущий баланс: {phone.Balance:F2}.");
        }
    }

    public class BlockedState : IState
    {
        public void Call(Phone phone)
        {
            Console.WriteLine("Телефон заблокирован. Пополните баланс.");
        }

        public void Answer(Phone phone)
        {
            Console.WriteLine("Телефон заблокирован. Нельзя ответить на звонок.");
        }

        public void EndCall(Phone phone)
        {
            Console.WriteLine("Нет активных вызовов.");
        }

        public void Recharge(Phone phone, double amount)
        {
            phone.Balance += amount;
            Console.WriteLine($"Баланс пополнен на {amount:F2}. Текущий баланс: {phone.Balance:F2}.");
            if (phone.Balance >= 0)
                phone.SetState(new WaitingState());
        }
    }

    public class Phone
    {
        public double Balance { get; set; }
        private IState _state;

        public Phone(double initialBalance)
        {
            Balance = initialBalance;
            _state = Balance < 0 ? new BlockedState() : new WaitingState();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void Call() => _state.Call(this);
        public void Answer() => _state.Answer(this);
        public void EndCall() => _state.EndCall(this);
        public void Recharge(double amount) => _state.Recharge(this, amount);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var phone = new Phone(10);

            phone.Call();
            phone.Answer();
            phone.EndCall();

            phone.Call();
            phone.EndCall();

            phone.Recharge(5);
        }
    }
}