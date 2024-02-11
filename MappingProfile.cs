namespace LionWheelDataTransform
{
using AutoMapper;
using LionWheelDataTransform.Models;
using LionWheelDataTransform.Models.Request;
using LionWheelDataTransform.Models.Transformed;
using System;

public class LionWheelMappingProfile : Profile
{
    public LionWheelMappingProfile()
    {
        CreateMap<RequestDataModel, TransformedDataModel>()
            .ForPath(dest => dest.Body.OriginalOrderId, opt => opt.MapFrom(src => src.Id))
            .ForPath(dest => dest.Body.Notes, opt => opt.MapFrom(src => src.Data.OrderNotes))
            .ForPath(dest => dest.Body.PickupAt, opt => opt.MapFrom(src => src.Data.CreatedAt.ToString("o"))) // ISO 8601 format

            .ForPath(dest => dest.Body.SourceCity, opt => opt.MapFrom(src => src.Data.Address.Shipping.City))
            .ForPath(dest => dest.Body.SourceStreet, opt => opt.MapFrom(src => src.Data.Address.Shipping.AddressLine1))
            .ForPath(dest => dest.Body.SourceEmail, opt => opt.MapFrom(src => src.Data.Email))
            .ForPath(dest => dest.Body.SourcePhone, opt => opt.MapFrom(src => src.Data.UserContactNumber))
            .ForPath(dest => dest.Body.SourceRecipientName, opt => opt.MapFrom(src => src.Data.UserName))

            .ForPath(dest => dest.Body.LineItems, opt => opt.MapFrom(src => src.Data.LineItems));

        // Adjusting the mapping for line items as per provided structure
        CreateMap<LionWheelDataTransform.Models.Request.LineItem, LionWheelDataTransform.Models.Transformed.LineItem>()
            .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.ItemName))
            .ForPath(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
            .ForPath(dest => dest.Price, opt => opt.MapFrom(src => src.UnitPrice));
    }
}

}
