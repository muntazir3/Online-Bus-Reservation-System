using System.ComponentModel.DataAnnotations;
namespace Railwaiy_Eproject.Models
{
    public class Scheduling
    {
        [Key] // Optional if using naming convention
        public string StartStation { get; set; }
        public string EndStation { get; set; }
        public string IntermediateStation { get; set; }
        public string TotalDistance { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureTime { get; set; }
        public string Train_Id { get; set; }

    }

}
