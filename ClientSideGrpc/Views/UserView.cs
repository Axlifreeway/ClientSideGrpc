
namespace ClientSideGrpc.Views
{
    public class UserView
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        
        public UserView() { }

        public override string ToString()
        {
            return Name;
        }
    }
}
