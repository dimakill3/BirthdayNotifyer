using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayNotifyer
{
    public partial class NotifyerForm : Form
    {
        public NotifyerForm()
        {
            InitializeComponent();
        }

        internal static string ChangeDayText(int inputNum)
        {

            inputNum = Math.Abs(inputNum);

            inputNum %= 100;

            if (inputNum >= 5 && inputNum <= 20)
                return "дней";

            inputNum %= 10;

            if (inputNum == 1)
                return "день";

            if (inputNum >= 2 && inputNum <= 4)
                return "дня";

            return "дней";
        }
    }
}
