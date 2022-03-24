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
        private Notebook myNotebook;
        private DataTable allFriendsData;

        public Notebook MyNotebook
        {
            get 
            {
                return myNotebook;
            }
            private set 
            { 

            }
        }

        public NotifyerForm()
        {
            InitializeComponent();
            myNotebook = new Notebook();
            allFriendsData = new DataTable();
            allFriendsData.Columns.Add("name");
            allFriendsData.Columns.Add("birthdate");
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

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            GenerateFriends(1000);
        }

        public void GenerateFriends(int friendCount)
        {
            DataForGenerateFriends friendsGenerator = new DataForGenerateFriends();

            for (int i = 0; i < friendCount; i++)
            {
                string name = friendsGenerator.GetRandomName();
                DateTime dt = friendsGenerator.GetRandomBirthdate(friendCount);
                bool isAdded = myNotebook.AddFriend(name, dt);
                if (!isAdded)
                {
                    i--;
                    continue;
                }
                allFriendsData.Rows.Add(name, dt.ToString("dd.MMM.yyyy"));
            }

            allFriendsTable.DataSource = allFriendsData;
        }

        private void notifyDay_ValueChanged(object sender, EventArgs e)
        {
            dayLabel.Text = ChangeDayText(Convert.ToInt32(notifyDay.Value));
        }

        private void todayDate_ValueChanged(object sender, EventArgs e)
        {
            DataTable closestBirthdays = new DataTable();
            int notifyDayCount = Convert.ToInt32(notifyDay.Value);
            DateTime todayDateTime = todayDate.Value;

            for (int i = 0; i < allFriendsData.Columns.Count; i++)
            {
                closestBirthdays.Columns.Add(allFriendsData.Columns[i]);
            }
        }
    }
}
