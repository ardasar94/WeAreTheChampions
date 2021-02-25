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
        public Team()
        {
            TeamPlayers = new HashSet<Player>();
            TeamColors = new HashSet<TeamColor>();
            Team1Matches = new HashSet<Match>();
            Team2Matches = new HashSet<Match>();
        }
        public int Id { get; set; }
        [Required]
        public string TeamName { get; set; }
        public ICollection<Player> TeamPlayers { get; set; }
        public ICollection<TeamColor> TeamColors { get; set; }
        public ICollection<Match> Team1Matches { get; set; }
        public ICollection<Match> Team2Matches { get; set; }

        public override string ToString()
        {
            return TeamName;
        }
    }
}
