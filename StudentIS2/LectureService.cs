using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentIS2
{
    public class LectureService
    {
        public void CreateLecture(Lecture lecture)
        {

            var context = new StudentIS2Context();
            
            context.Lectures.Add(lecture);
            context.SaveChanges();
        }

        
    }
}
