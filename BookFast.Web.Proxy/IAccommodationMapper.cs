﻿using System.Collections.Generic;
using BookFast.Web.Contracts.Models;
using BookFast.Facility.Client.Models;

namespace BookFast.Web.Proxy
{
    public interface IAccommodationMapper
    {
        Accommodation MapFrom(AccommodationRepresentation accommodation);
        List<Accommodation> MapFrom(IList<AccommodationRepresentation> accommodations);
        AccommodationData MapFrom(AccommodationDetails details);
    }
}