using System.Text.RegularExpressions;

namespace LionWheelDataTransform.Controllers
{
    public class TransformationMethods
    {
        public static TransformedDataModel.Body TransformData(RequestDataModel.Welcome requestData)
        {
            var transformedData = new TransformedDataModel.Body()
            {
                // Example of direct mapping
                OriginalOrderId = requestData.Id,

                // Example of nested object mapping
                SourceCity = requestData.Data.Address.Billing.City,
                SourceStreet = requestData.Data.Address.Billing.AddressLine1,

                // ... similar mappings for other fields

                LineItems = requestData.Data.LineItems.Select(li => new TransformedDataModel.LineItem
                {
                    Name = li.ItemName,
                    Quantity = li.Quantity,
                    Price = li.UnitPrice
                }).ToArray(),

                // ... additional mappings
            };

            return transformedData;
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
