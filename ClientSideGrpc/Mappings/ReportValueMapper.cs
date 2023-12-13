using AnimalHealth.Application.Models;
using ClientSideGrpc.Views;

namespace ClientSideGrpc.Mappings
{
    public class ReportValueMapper : IMapper<ReportValueModel, ReportValueView>
    {
        public ReportValueModel Map(ReportValueView model) => new()
        {
            Id = model.Id,
            FirstFeature = model.FirstFeature,
            SecondFeature = model.SecondFeature,
            Count = model.Count,    
        };

        public ReportValueView Map(ReportValueModel entity) => new()
        {
            Id = entity.Id,
            FirstFeature = entity.FirstFeature,
            SecondFeature = entity.SecondFeature,
            Count = entity.Count,
        };
    }
}
