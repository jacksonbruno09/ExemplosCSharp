using System.Collections.Generic;
using Desenvolvimento.SharedContext;

namespace Desenvolvimento.ContentContext
{
    public class Module: Base
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures  { get; set; }     
    }
}