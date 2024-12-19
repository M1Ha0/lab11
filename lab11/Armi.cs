using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Armi
    {
        public string Vid { get; set; }
        private int numberArmi;
        public int NumberArmi
        {
            get => numberArmi;
            set
            {
                if (value >= 0) numberArmi = value;
            }
        }
        private int numberBal;
        public int NumberBal
        {
            get => numberBal;
            set { if (value >= 0) numberBal = value; }
        }
        public Armi(string fio, int numberOfBattles, int numberWins)
        {
            Vid = fio;
            NumberArmi = numberOfBattles;
            NumberBal = numberWins;
        }

        public virtual double GetQuality()
        {
            return (double)(0.3 * NumberArmi) + (0.7 * NumberBal);
        }

        public override string? ToString()
        {
            return $"Вид армии:{Vid}, численность армии:{NumberArmi} тыс.ч.," +
                $" вооруженность армии:{NumberBal} б. Коэффициент:{GetQuality()}";
        }
    }
}
