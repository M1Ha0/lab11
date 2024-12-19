using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class ArmiP:Armi
    {
        private int numberMounth;
        public int NumberMounth
        {
            get => numberMounth;
            set
            {
                if (value >= 0 && value <= NumberArmi)
                    numberMounth = value;
            }
        }
        public ArmiP(string vid, int numberArmi, int numberBal, int _numberMounth) : base(vid, numberArmi, numberBal)
        {
            NumberMounth = _numberMounth;
        }

        public override double GetQuality()
        {
            return base.GetQuality() * (NumberMounth + 1);
        }

        public override string? ToString()
        {
            return $"Вид армии:{Vid}, численость армии:{NumberArmi} тыс.ч.," +
                $" вооруженность армии:{NumberBal} б." +
                $" опыт:{NumberMounth} м. Коэффициент:{GetQuality()}";
        }
    }
}
