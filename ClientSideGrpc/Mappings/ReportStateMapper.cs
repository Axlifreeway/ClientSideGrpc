using AnimalHealth.Application.Models;
using ClientSideGrpc.Views;
using Google.Protobuf.WellKnownTypes;

namespace ClientSideGrpc.Mappings
{
    public class ReportStateMapper : IMapper<ReportStateModel, ReportStateView>
    {
        private readonly IMapper<UserModel, UserView> _userMapper;

        public ReportStateMapper(IMapper<UserModel, UserView> userMapper)
        {
            _userMapper = userMapper;
        }

        public ReportStateModel Map(ReportStateView model) => new()
        {            
            Name = model.Name,
            ChangeDate = model.DateChange.ToLocalTime().ToTimestamp(),
            Changer = _userMapper.Map(model.Changer),
        };


        public ReportStateView Map(ReportStateModel entity) => new()
        {
            Name = entity.Name,
            Changer = _userMapper.Map(entity.Changer),
            DateChange = entity.ChangeDate.ToDateTime().ToLocalTime(),
        };
    }
}
