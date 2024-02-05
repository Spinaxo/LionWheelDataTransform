using System.Text.RegularExpressions;

namespace LionWheelDataTransform.Controllers
{
    public class TransformationMethods
    {
        public static RequestDataModel TransformData(RequestDataModel requestData)
        {
            return requestData;
        }

        public static (string, string) SeparateAddress(string address)
        {
            // Regular expression to match the street number at the beginning of the address
            var regex = new Regex(@"^\d+\s+");
            var match = regex.Match(address);

            if (match.Success)
            {
                string streetNumber = match.Value.Trim(); // Trim to remove any extra whitespace
                string streetName = address.Substring(match.Length).Trim(); // Get the rest of the address as street name
                return (streetNumber, streetName);
            }
            else
            {
                // Handle cases where no street number is found
                return (string.Empty, address);
            }
        }
    }
}
