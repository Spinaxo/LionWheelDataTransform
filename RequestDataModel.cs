namespace LionWheelDataTransform
{
    public class RequestDataModel
    {
        public partial class Welcome
        {
            public string Id { get; set; }
            public string Object { get; set; }
            public string Account { get; set; }
            public long ApiVersion { get; set; }
            public long Created { get; set; }
            public bool Livemode { get; set; }
            public Data Data { get; set; }
        }

        public partial class Data
        {
            public string Id { get; set; }
            public string OrderId { get; set; }
            public long IsUnread { get; set; }
            public string StoreId { get; set; }
            public string CustomerId { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            public string UserContactNumber { get; set; }
            public object UserCompanyName { get; set; }
            public object AutomaticDiscount { get; set; }
            public object AutomaticDiscountCode { get; set; }
            public object AutomaticDiscountId { get; set; }
            public string Subtotal { get; set; }
            public string ShippingName { get; set; }
            public string ShippingAmount { get; set; }
            public string TaxAmount { get; set; }
            public object[] TaxMeta { get; set; }
            public object DiscountName { get; set; }
            public string DiscountAmount { get; set; }
            public object SaleId { get; set; }
            public object SaleName { get; set; }
            public object SaleAmount { get; set; }
            public string TotalAmount { get; set; }
            public object SellerChargedName { get; set; }
            public object SellerChargedAmount { get; set; }
            public string CurrencyPaidIn { get; set; }
            public string CurrencyPaidInSymbol { get; set; }
            public string WeightUnit { get; set; }
            public string PaymentTransactionId { get; set; }
            public string PaymentMethodId { get; set; }
            public string PaymentMethodName { get; set; }
            public string RawPaymentMethodName { get; set; }
            public string BillingAddress { get; set; }
            public string ShippingAddress { get; set; }
            public object OrderNotes { get; set; }
            public string StoreEnvironment { get; set; }
            public PaymentPayload PaymentPayload { get; set; }
            public string FulfillmentStatus { get; set; }
            public long IsDraft { get; set; }
            public string InvoiceNumber { get; set; }
            public Uri InvoiceLink { get; set; }
            public Uri SourceUrl { get; set; }
            public object CustomerTaxId { get; set; }
            public string Status { get; set; }
            public object V1Ref { get; set; }
            public object ReviewEmailAt { get; set; }
            public string CartSession { get; set; }
            public long AbandonedEmailsCount { get; set; }
            public object AbandonedAt { get; set; }
            public object DeletedAt { get; set; }
            public DateTimeOffset CreatedAt { get; set; }
            public DateTimeOffset UpdatedAt { get; set; }
            public MetaData MetaData { get; set; }
            public object[] Offers { get; set; }
            public LineItem[] LineItems { get; set; }
            public DataAddress Address { get; set; }
            public Shipping[] Shipping { get; set; }
            public Taxes Taxes { get; set; }
        }

        public partial class DataAddress
        {
            public AddressBilling Billing { get; set; }
            public AddressBilling Shipping { get; set; }
        }

        public partial class AddressBilling
        {
            public long Id { get; set; }
            public string OrderId { get; set; }
            public string Type { get; set; }
            public string UserName { get; set; }
            public string AddressLine1 { get; set; }
            public object AddressLine2 { get; set; }
            public string City { get; set; }
            public long StateId { get; set; }
            public string CountryCode { get; set; }
            public object CountryId { get; set; }
            public string Postcode { get; set; }
            public string ContactNumber { get; set; }
            public object CompanyName { get; set; }
            public long Status { get; set; }
            public object DeletedAt { get; set; }
            public DateTimeOffset CreatedAt { get; set; }
            public object UpdatedAt { get; set; }
            public string CountryName { get; set; }
            public string StateName { get; set; }
            public object StateCode { get; set; }
        }

        public partial class LineItem
        {
            public string Id { get; set; }
            public string OrderId { get; set; }
            public string ItemId { get; set; }
            public string ItemName { get; set; }
            public object ItemSku { get; set; }
            public object ItemSkuId { get; set; }
            public object ItemSkuAttachment { get; set; }
            public object ItemOptions { get; set; }
            public string ItemImage { get; set; }
            public string UnitPrice { get; set; }
            public long Quantity { get; set; }
            public string Weight { get; set; }
            public object ItemTaxMeta { get; set; }
            public object DiscountName { get; set; }
            public object DiscountAmount { get; set; }
            public object SaleAmount { get; set; }
            public object ItemLicenseKey { get; set; }
            public Uri ItemSourceUrl { get; set; }
            public long Status { get; set; }
            public object ReviewedAt { get; set; }
            public object DeletedAt { get; set; }
            public DateTimeOffset CreatedAt { get; set; }
            public object UpdatedAt { get; set; }
            public object ItemVariationSku { get; set; }
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductDescription { get; set; }
            public string ProductPrice { get; set; }
            public object ProductEmailInfo { get; set; }
            public object ProductQuantity { get; set; }
            public long RequireDeliveryOrCollection { get; set; }
            public string ShippingType { get; set; }
            public object MinOrderQuantity { get; set; }
            public object MaxOrderQuantity { get; set; }
            public object Sku { get; set; }
            public Category[] Categories { get; set; }
        }

        public partial class Category
        {
            public string Id { get; set; }
            public string CategoryName { get; set; }
            public string CategorySlug { get; set; }
            public long Status { get; set; }
        }

        public partial class MetaData
        {
            public string Id { get; set; }
            public string OrderId { get; set; }
            public string IpAddress { get; set; }
            public object IpLat { get; set; }
            public object IpLong { get; set; }
            public string IpCountry { get; set; }
            public object IpContinent { get; set; }
            public long Status { get; set; }
            public object DeletedAt { get; set; }
            public DateTimeOffset CreatedAt { get; set; }
            public object UpdatedAt { get; set; }
        }

        public partial class PaymentPayload
        {
            public string Amount { get; set; }
            public string Currency { get; set; }
            public object CustomerId { get; set; }
            public string Livemode { get; set; }
            public object ReceiptUrl { get; set; }
            public PaymentPayloadBilling Billing { get; set; }
            public PaymentPayloadBilling Shipping { get; set; }
            public PaymentMethod PaymentMethod { get; set; }
        }

        public partial class PaymentPayloadBilling
        {
            public BillingAddress Address { get; set; }
            public string Email { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
        }

        public partial class BillingAddress
        {
            public string City { get; set; }
            public string Country { get; set; }
            public string Line1 { get; set; }
            public string PostalCode { get; set; }
            public string State { get; set; }
        }

        public partial class PaymentMethod
        {
            public string Type { get; set; }
        }

        public partial class Shipping
        {
            public long Id { get; set; }
            public string OrderId { get; set; }
            public object ItemId { get; set; }
            public string ShippingName { get; set; }
            public string PriceType { get; set; }
            public string BasePrice { get; set; }
            public object WeightMultiple { get; set; }
            public long Status { get; set; }
            public object DeletedAt { get; set; }
            public DateTimeOffset CreatedAt { get; set; }
            public object UpdatedAt { get; set; }
        }

        public partial class Taxes
        {
            public object[] Inclusive { get; set; }
            public object[] Exclusive { get; set; }
        }
    }
}
