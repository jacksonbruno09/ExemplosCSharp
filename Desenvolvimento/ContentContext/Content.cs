using System;
using Desenvolvimento.SharedContext;

namespace Desenvolvimento.ContentContext
{
    public abstract class Content : Base
    {
        public Content(string title , string url)
        {
            //Id = new Guid(); //SPOFF
            Title = title;
            Url = url;
        }

        //public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        
    }
}