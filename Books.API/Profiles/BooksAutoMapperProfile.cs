using AutoMapper;

namespace Books.API.Profiles
{
    public class BooksAutoMapperProfile : Profile
    {
        public BooksAutoMapperProfile()
        {
            CreateMap<Entities.Book, Models.Book>()
                .ForMember(dest => dest.Author, opt => opt.MapFrom(
                    src => $"{src.Author.FirstName} {src.Author.LastName}"));
        }
    }
}
