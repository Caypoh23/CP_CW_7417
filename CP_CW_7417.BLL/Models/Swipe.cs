using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CP_CW_7417.BLL.Models
{
    [DataContract]
    public class Swipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DataMember]
        public string IPAddress { get; set; }

        [DataMember]
        public int PersonId { get; set; }
        [DataMember]
        public DateTime SwipeDateTime { get; set; }
        [DataMember]
        public string SwipeDirection { get; set; }

        public Swipe(string ipAddress, string[] data)
        {
            IPAddress = ipAddress;
            PersonId = int.Parse(data[0]);
            SwipeDateTime = DateTime.Parse(data[1]);
            SwipeDirection = data[2];
        }

        public Swipe()
        {

        }
    }
}
