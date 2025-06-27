using System.ComponentModel.DataAnnotations;

namespace Railwaiy_Eproject.Models
{
    public class Train
    {
             [Key] // Optional if using naming convention
            public int No_of_Compartments { get; set; }
            public int No_of_Seats { get; set; }   
            public string TrainCode { get; set; }
            public string Train_Name { get; set; }
            public string One_AC { get; set; }
            public string Two_AC { get; set; }
            public string Three_AC { get; set; }
            public string Sleeper { get; set; }

    }
}
