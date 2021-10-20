using System.Collections.Generic;

namespace Desenvolvimento.ContentContext
{
    public class Career : Content
    {
        public Career(string title , string url):base(title,url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }


        //retorna a quantidade de intens de uma lisata 
        /* //Modo comum         
        public int TotalCourses
        {
            get
            {
                return Items.Count;
            }
        } */

        //utilizando expression body
        public int TotalCourses => Items.Count;
               
        
    }
}