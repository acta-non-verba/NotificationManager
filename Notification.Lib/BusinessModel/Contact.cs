namespace Notification.Lib.BusinessModel
{
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public long Mobile{ get; set; }

        public Contact(string name,string email,long mobile)
        {
            Name=name;
            Email=email;
            Mobile=mobile;
        }

    }
}