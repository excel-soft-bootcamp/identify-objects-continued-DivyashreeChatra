using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class StudentInfo
    {
        //state private
        private string id;
        private string name;
        private string marks;

        //Behaviours,public interface/Mutators
        //message passing(callling a method/method Invocation)
        public string GetId()
        {
            return this.id;
        }
        public void SetId(string value)
        {
            this.id= value;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string value)
        {
            this.name = value;
        }
        public string GetMarks()
        {
            return this.marks;
        }
        public void SetMarks(string value)
        {
            this.marks = value;
        }
    }
}
