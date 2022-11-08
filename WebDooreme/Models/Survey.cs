using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    public partial class Survey
    {
        [Column("SurveyID")]
        public int SurveyId { get; set; }
        [StringLength(50)]
        public string SurveyName { get; set; }
        [StringLength(50)]
        public string SurveyQuestion1 { get; set; }
        [StringLength(50)]
        public string SurveyQuestion2 { get; set; }
        [StringLength(50)]
        public string SurveyQuestion3 { get; set; }
        [StringLength(50)]
        public string SurveyQuestion4 { get; set; }
        [StringLength(50)]
        public string SurveyQuestion5 { get; set; }
        public bool? Status { get; set; }
    }
}
