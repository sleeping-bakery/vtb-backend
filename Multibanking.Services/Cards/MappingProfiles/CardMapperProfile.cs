using AutoMapper;
using Multibanking.Contracts.Card;
using Multibanking.Entities.Cards;

namespace Multibanking.Services.Cards.MappingProfiles;

public class CardMapperProfile : Profile
{
    public CardMapperProfile()
    {
        CreateMap<CardCreateDto, Card>();
        CreateMap<Card, CardReadDto>();
    }
}