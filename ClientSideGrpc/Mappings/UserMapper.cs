using AnimalHealth.Application.Models;
using ClientSideGrpc.Views;

namespace ClientSideGrpc.Mappings
{
    public class UserMapper : IMapper<UserModel, UserView>
    {
        public UserModel Map(UserView model) => new()
        {
            Id = model.Id,
            Name = model.Name,
        };

        public UserView Map(UserModel entity) => new()
        {
            Id = entity.Id,
            Name = entity.Name,
        };
    }
}