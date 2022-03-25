using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
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
            private set { }
        }

        public NotifyerForm()
        {
            InitializeComponent();
            myNotebook = new Notebook();
            allFriendsData = new DataTable();
            allFriendsData.Columns.Add("ФИО");
            allFriendsData.Columns.Add("День рождения");
            allFriendsData.Columns.Add("Удалить");
        }

        internal static DateTime DateToPast(DateTime birthDate, DateTime todayDate)
        {
            return todayDate.AddYears(-(todayDate.Year - birthDate.Year));
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

        internal static int CompareDates(DateTime birthDate, DateTime todayDate)
        {
            return birthDate.Subtract(todayDate).Days;
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            GenerateFriends(1000);
        }

        public void GenerateFriends(int friendCount)
        {
            for (int i = 0; i < friendCount; i++)
            {
                string name = FriendsGenerator.GetRandomName();
                DateTime dt = FriendsGenerator.GetRandomBirthdate(friendCount);
                bool isAdded = myNotebook.AddFriend(name, dt);
                if (!isAdded)
                {
                    i--;
                    continue;
                }
                allFriendsData.Rows.Add(name, dt.ToString("dd MMM yyyy"), "X");
            }

            allFriendsTable.DataSource = allFriendsData;
            allFriendsTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            allFriendsTable.Sort(allFriendsTable.Columns[0], ListSortDirection.Ascending);

            todayDate_ValueChanged(todayDate, new EventArgs());
        }

        private void notifyDay_ValueChanged(object sender, EventArgs e)
        {
            dayLabel.Text = ChangeDayText(Convert.ToInt32(notifyDay.Value));
            todayDate_ValueChanged(todayDate, new EventArgs());
        }

        private void todayDate_ValueChanged(object sender, EventArgs e)
        {
            DataTable closestBirthdays = new DataTable();
            int notifyDayCount = Convert.ToInt32(notifyDay.Value);
            DateTime todayDateTime = todayDate.Value.Date;

            closestBirthdays.Columns.Add("ФИО");
            closestBirthdays.Columns.Add("День рождения");
            closestBirthdays.Columns.Add("До дня рождения");
            

            for (int i = 0; i < myNotebook.Friends.Count; i++)
            {
                DateTime todayDateTimeInPast = DateToPast(myNotebook.Friends[i].GetBirthDate(), todayDateTime);

                int dateSub = CompareDates(myNotebook.Friends[i].GetBirthDate(), todayDateTimeInPast);

                if (dateSub < 0)
                    continue;

                if (dateSub <= notifyDayCount)
                {
                    closestBirthdays.Rows.Add(myNotebook.Friends[i].GetName(), myNotebook.Friends[i].GetBirthDate().ToString("dd MMM yyyy"), dateSub.ToString() + " " + ChangeDayText(dateSub));
                }
            }

            closeBirthdaysTable.DataSource = closestBirthdays;

            closeBirthdaysTable.Sort(closeBirthdaysTable.Columns[closeBirthdaysTable.Columns.Count - 1], ListSortDirection.Ascending);
            closeBirthdaysTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void allFriendsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell currentCell = allFriendsTable.CurrentCell;

            if (currentCell.ColumnIndex == allFriendsTable.Columns.Count - 1)
            {
                string friendName = allFriendsTable.Rows[currentCell.RowIndex].Cells[0].Value.ToString();

                string ddt = allFriendsTable.Rows[currentCell.RowIndex].Cells[1].Value.ToString();

                DateTime friendBirthDate = DateTime.Parse(ddt);
                myNotebook.DeleteFriend(friendName, friendBirthDate);

                allFriendsTable.Rows.RemoveAt(currentCell.RowIndex);
                allFriendsData = (DataTable) allFriendsTable.DataSource;
                todayDate_ValueChanged(todayDate, new EventArgs());
            }
        }
    }
}
