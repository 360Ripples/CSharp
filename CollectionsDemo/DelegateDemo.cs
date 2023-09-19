using static CollectionsDemo.TaxCalculateDelegateDemo;

namespace CollectionsDemo
{
    public class TaxCalculateDelegateDemo
    {
        // Example of a call back function using delegate
        public delegate void EmailDelegate(double tax);
        public delegate void SMSDelegate(double tax);
        public void CalculateTax(double taxableAmount, float taxRate, EmailDelegate del1, SMSDelegate del2)
        {
            Console.WriteLine("Business process is invoked");
            double taxAmount = taxRate * taxableAmount / 100;
            Console.WriteLine("Calculated Tax Amount {0}", taxAmount);
            // Once the tax is calculated we need to send the tax amount
            // to the customer over email and SMS. The sending email/sms
            // will be done by the caller of the function.
            del1(taxAmount);
            del2(taxAmount);
        }

    }

    public class Customer
    {
        public void demo(double taxableAmount, float taxRate)
        {
            EmailDelegate t = new EmailDelegate(sendEmail);
            SMSDelegate s = new SMSDelegate(sendSMS);
            TaxCalculateDelegateDemo d = new TaxCalculateDelegateDemo();
            d.CalculateTax(taxableAmount, taxRate, t, s); // Assume this is a assynchronous call

        }

        public void sendSMS(double tax)
        {
            Console.WriteLine("Sms sent");
        }
        public void sendEmail(double tax)
        {
            Console.WriteLine("Email sent");
        }
    }
}
