using AnimalHealth.Application.Models;
using ClientSideGrpc.Views;
using Google.Protobuf.WellKnownTypes;

namespace ClientSideGrpc.Mappings
{
    public class ReportMapper : IMapper<ReportModel, ReportView>
    {
        private readonly IMapper<UserModel, UserView> _userMapper;
        private readonly IMapper<ReportStateModel, ReportStateView> _stateMapper;
        private readonly IMapper<ReportValueModel, ReportValueView> _reportValueMapper;

        public ReportMapper(IMapper<UserModel, UserView> userMapper,
            IMapper<ReportStateModel, ReportStateView> stateMapper,
            IMapper<ReportValueModel, ReportValueView> reportValueMapper)
        {
            _userMapper = userMapper;
            _stateMapper = stateMapper;
            _reportValueMapper = reportValueMapper;
        }

        public ReportModel Map(ReportView model)
        {
            var report = new ReportModel
            {
                Id = model.Id,
                CreateDate = model.CreateDate.ToLocalTime().ToTimestamp(),
                UserCreator = _userMapper.Map(model.Creator),
                State = _stateMapper.Map(model.State),
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
                CreateDate = entity.CreateDate.ToDateTime().ToLocalTime(),
                Creator = _userMapper.Map(entity.UserCreator),
                State = _stateMapper.Map(entity.State),
                Type = entity.Type,
            };
            if (entity.Values == null)
                report.Values = new List<ReportValueView>();
            else report.Values.AddRange(entity.Values.Select(x => _reportValueMapper.Map(x)));
            return report;
        }
    }
}
