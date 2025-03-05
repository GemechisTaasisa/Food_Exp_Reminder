using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Food_Exp_Reminder.Model;

namespace Food_Exp_Reminder.Data
{
    public class Food_Exp_ReminderContext : DbContext
    {
        public Food_Exp_ReminderContext (DbContextOptions<Food_Exp_ReminderContext> options)
            : base(options)
        {
        }

        public DbSet<Food_Exp_Reminder.Model.foods> foods { get; set; } = default!;
    }
}
