
namespace Examinition.Web.Core.App_Start
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            //Mapper.CreateMap<Exam.Domain.Core.Models.Exam, ExamVM>()
            //             .ForMember(examVM => examVM.Id, expression => expression.MapFrom(entity => entity.Id))
            //             .ForMember(examVM => examVM.Name, expression => expression.MapFrom(entity => entity.Name));
        }
    }
}