using System.ComponentModel.DataAnnotations;

namespace HttpEchoRequest.Models
{
   public class PostModel
   {
      [Required]
      public string Text { get; set; }
   }
}
