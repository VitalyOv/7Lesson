using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Lesson.Models
{
    public class Car: IMovable
    {
        public int Number { get; set; }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
