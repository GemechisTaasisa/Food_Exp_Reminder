namespace Food_Exp_Reminder.Model
{
    public class foods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExpiryDate { get; set; }
        public string ReminderDate { get; set; }
        public string ReminderMessage { get; set; }
        public string Email { get; set; }
    }
}
