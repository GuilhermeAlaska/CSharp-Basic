namespace ACM.BL
{
    public class Customer
    {
        public Customer(int customerId, string emailAdress, string lastName, string firstName)
        {
            CustomerId = customerId;
            EmailAdress = emailAdress;
            LastName = lastName;
            FirstName = firstName;
        }

        public int CustomerId { get; private set; }
        public string EmailAdress { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return LastName + "," + FirstName;
            }
       }

    }
}