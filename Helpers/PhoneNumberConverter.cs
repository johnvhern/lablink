using PhoneNumbers;

namespace lablink.app.Helpers
{
    public static class PhoneNumberConverter
    {
        public static string FormatNumber(string mobileNumber)
        {
            var phoneNumberUtil = PhoneNumberUtil.GetInstance();
            var phoneNumber = phoneNumberUtil.Parse(mobileNumber, "PH");
            var formattedPhoneNumber = phoneNumberUtil.Format(phoneNumber, PhoneNumberFormat.E164);

            return formattedPhoneNumber;
        }

        public static bool IsValidMobileNumber(string mobileNumber)
        {
            var phoneNumberUtil = PhoneNumberUtil.GetInstance();
            var phoneNumber = phoneNumberUtil.Parse(mobileNumber, "PH");
            var isValid = phoneNumberUtil.IsValidNumber(phoneNumber);

            return isValid;
        }
    }
}
