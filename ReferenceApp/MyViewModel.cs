using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Telerik.Windows.Data;
using System.Runtime.CompilerServices;

namespace ScrollIntoViewAsyncMvvm
{
    public class MyViewModel
    {
        public RadObservableCollection<Club> Clubs { get; private set; } = new RadObservableCollection<Club>();


        public MyViewModel()
        {
            //AddClubs();
        }


        public void UpdateClubs()
        {
            AddClubs();
        }
        private static int Index = 0;
        private const int count = 10000;
        private void AddClubs()
        {
            Clubs.SuspendNotifications();

            for (int index = 0; index < count; index++)
            {
                Clubs.Add(new Club(
                    $"Club {Index + index}",
                    new DateTime(1892, 1, 1).AddDays(Index + index),
                    45362 + (Index + index * 5)));
            }
            Index += count;

            Clubs.ResumeNotifications();
        }
    }
}
