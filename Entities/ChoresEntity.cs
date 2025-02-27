using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_Pocket_money.Entities
{
    public class ChoresEntity
    {
        public int Id { get; set; } // Primary key
        public string Name { get; set; }
        public int Points { get; set; }
        public bool IsCompleted { get; set; }
        public int Test { get; set; }
        public ChoresEntity(string name, int points)
        {
            Name = name;
            Points = points;
        }
    }
    public class ChoresHandling
    {
        public static List<ChoresEntity> ChoresList = new List<ChoresEntity>
        {
            new ChoresEntity("taking_out_the_trash",1),
            new ChoresEntity("cleaning_windows",4),
            new ChoresEntity("cleaning_mirrors",2),
            new ChoresEntity("washing_floor",10),
            new ChoresEntity("washing_car",7),
            new ChoresEntity("vacuuming_car",7),
            new ChoresEntity("cleaning_room",4),
            new ChoresEntity("making_bed",2),
            new ChoresEntity("vacuuming_Yard",4),
            new ChoresEntity("cleaning_yard",4),
            new ChoresEntity("fold_laundry ",4),
            new ChoresEntity("hang_laundry",3),
            new ChoresEntity("take_off_laundry",2),
            new ChoresEntity("washing_dishes",4),
            new ChoresEntity("cleaning_counter",2),
            new ChoresEntity("drying_dishes",3),

        };

        public static List<ChoresEntity> GetChoresList()
        {
            return ChoresList;
        }



    }
}
