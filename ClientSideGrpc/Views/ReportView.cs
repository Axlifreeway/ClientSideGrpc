using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClientSideGrpc.Views
{
    public class ReportView
    {
        public int Id { get; set; }

        [DisplayName("Тип")]
        public string Type { get; set; }
        [Browsable(false)]
        public DateTime ChangeDate { get; set; }
        [Browsable(false)]
        public UserView Changer { get; set; }
        [Browsable(false)]
        public UserView AdditionalChanger { get; set; }

        [DisplayName("Состояние")]
        public string StateName { get; set; }

        public List<ReportValueView> Values { get; set; } = new List<ReportValueView>();

        public ReportView() { } 
    }
}
