using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Lesson.Models
{
    public class Boat: IMovable
    {
        public string Name { get; set; }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
