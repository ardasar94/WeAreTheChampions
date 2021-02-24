using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Teams")]
    public class Team
    {
        public int Id { get; set; }
        [Required]
        public string TeamName { get; set; }
        public ICollection<Player> TeamPlayers { get; set; }
        public ICollection<Color> TeamColors { get; set; }
        public ICollection<Match> TeamMatches { get; set; }
    }
}
