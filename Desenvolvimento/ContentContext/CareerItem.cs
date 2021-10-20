using System.Collections.Generic;
using Desenvolvimento.SharedContext;
using Desenvolvimento.NotificationContext;

namespace Desenvolvimento.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            if (course == null)
                AddNotification(new Notification("Course", "Curso invalido"));

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public CareerItem(int order, string title, string description)
        {
            this.Order = order;
            this.Title = title;
            this.Description = description;

        }
        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}