using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CSharp_Sprint2.Models
{
    public class DocumentModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public long value { get; set; }
        [Required]
        public String documentType { get; set; }
        [Required]
        [StringLength(10)]
        public String document { get; set; }
        public bool currentState { get; set; }
    }
}
