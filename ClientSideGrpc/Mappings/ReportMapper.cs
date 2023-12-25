using AnimalHealth.Application.Models;
using ClientSideGrpc.Views;
using Google.Protobuf.WellKnownTypes;

namespace ClientSideGrpc.Mappings
{
    public class ReportMapper : IMapper<ReportModel, ReportView>
    {
        private readonly IMapper<UserModel, UserView> _userMapper;
        private readonly IMapper<ReportValueModel, ReportValueView> _reportValueMapper;

        public ReportMapper(IMapper<UserModel, UserView> userMapper,
            IMapper<ReportValueModel, ReportValueView> reportValueMapper)
        {
            _userMapper = userMapper;
            _reportValueMapper = reportValueMapper;
        }

        public ReportModel Map(ReportView model)
        {
            var report = new ReportModel
            {
                Id = model.Id,
                ChangeDate = model.ChangeDate.ToLocalTime().ToTimestamp(),
                StateName = model.StateName,
                AdditionalChanger = _userMapper.Map(model.AdditionalChanger),
                Changer = _userMapper.Map(model.Changer),
                Type = model.Type,
            };
            report.Values.AddRange(model.Values.Select(x => _reportValueMapper.Map(x)));
            return report;
        }

        public ReportView Map(ReportModel entity)
        {
            var report = new ReportView
            {
                Id = entity.Id,
                ChangeDate = entity.ChangeDate.ToDateTime().ToLocalTime(),
                Changer = _userMapper.Map(entity.Changer),
                AdditionalChanger = _userMapper.Map(entity.AdditionalChanger),
                StateName= entity.StateName,
                Type = entity.Type,
            };
            if (entity.Values == null)
                report.Values = new List<ReportValueView>();
            else report.Values.AddRange(entity.Values.Select(x => _reportValueMapper.Map(x)));
            return report;
        }
    }
}
