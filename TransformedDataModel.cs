namespace LionWheelDataTransform
{
    public class TransformedDataModel {
        public partial class Welcome
        {
            public string Method { get; set; }
            public object[] Header { get; set; }
            public Body Body { get; set; }
        }

        public partial class Body
        {
            public string PickupAt { get; set; }
            public long CompanyId { get; set; }
            public string Notes { get; set; }
            public string OriginalOrderId { get; set; }
            public string SourceCity { get; set; }
            public string SourceStreet { get; set; }
            public string SourceNumber { get; set; }
            public string SourceZipCode { get; set; }
            public string SourceFloor { get; set; }
            public string SourceApartment { get; set; }
            public string SourceNotes { get; set; }
            public string SourceRecipientName { get; set; }
            public string SourcePhone { get; set; }
            public string SourceEmail { get; set; }
            public string SourceLatitude { get; set; }
            public string SourceLongitude { get; set; }
            public string DestinationCity { get; set; }
            public string DestinationStreet { get; set; }
            public string DestinationNumber { get; set; }
            public string DestinationZipCode { get; set; }
            public string DestinationFloor { get; set; }
            public string DestinationApartment { get; set; }
            public string DestinationNotes { get; set; }
            public string DestinationRecipientName { get; set; }
            public string DestinationPhone { get; set; }
            public string DestinationPhone2 { get; set; }
            public string DestinationEmail { get; set; }
            public string DestinationLatitude { get; set; }
            public string DestinationLongitude { get; set; }
            public string DeliveryMethod { get; set; }
            public string Greeting { get; set; }
            public string GifterName { get; set; }
            public string GifterPhone { get; set; }
            public bool IsRoundtrip { get; set; }
            public long PackagesQuantity { get; set; }
            public long MoneyCollect { get; set; }
            public bool IsSelfPickup { get; set; }
            public string Earliest { get; set; }
            public string Latest { get; set; }
            public LineItem[] LineItems { get; set; }
            public long Urgency { get; set; }
            public string DriverId { get; set; }
        }

        public partial class LineItem
        {
            public string Name { get; set; }
            public long Quantity { get; set; }
            public string Price { get; set; }
        }
    }
}
