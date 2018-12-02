using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apiary_Assistant.Services
{
    public static class ReminderService
    {
        private static int CurrentMonth = DateTime.Now.Month;

        public static IEnumerable<string> GetReminders()
        {
            var reminders = new List<string>();

            if (CurrentMonth <= 3 || CurrentMonth >= 10)
            {
                reminders.Add("Check food stores");
                reminders.Add("Entrances are free of snow");
                reminders.Add("Quilt boxes are dry(if wet add more ventilation)");
            }
            return reminders;
        }

    }

}
