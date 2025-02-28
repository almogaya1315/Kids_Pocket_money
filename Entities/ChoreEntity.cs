using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_Pocket_money.Entities
{
    public class ChoreEntity
    {
        public int Id { get; set; } // Primary key
        public string Name { get; set; }
        public int Points { get; set; }
        public bool IsCompleted { get; set; }
        public int Test { get; set; }
        public ChoreEntity(string name, int points)
        {
            Name = name;
            Points = points;
        }
    }
    //public class ChoresHandling
    //{
    //    public static List<ChoreEntity> ChoresList = new List<ChoreEntity>
    //    {
    //        new ChoreEntity("taking_out_the_trash",1),
    //        new ChoreEntity("cleaning_windows",4),
    //        new ChoreEntity("cleaning_mirrors",2),
    //        new ChoreEntity("washing_floor",10),
    //        new ChoreEntity("washing_car",7),
    //        new ChoreEntity("vacuuming_car",7),
    //        new ChoreEntity("cleaning_room",4),
    //        new ChoreEntity("making_bed",2),
    //        new ChoreEntity("vacuuming_Yard",4),
    //        new ChoreEntity("cleaning_yard",4),
    //        new ChoreEntity("fold_laundry ",4),
    //        new ChoreEntity("hang_laundry",3),
    //        new ChoreEntity("take_off_laundry",2),
    //        new ChoreEntity("washing_dishes",4),
    //        new ChoreEntity("cleaning_counter",2),
    //        new ChoreEntity("drying_dishes",3),

    //    };

    //    public static List<ChoreEntity> GetChoresList()
    //    {
    //        return ChoresList;
    //    }



    //}
}
