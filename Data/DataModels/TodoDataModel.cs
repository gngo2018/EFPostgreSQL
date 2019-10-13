using System;
namespace TodoData.DataModel
{
    public class TodoDataModel
    {
        public TodoDataModel()
        {
            CreatedOn = DateTime.Now;
            IsCompleted = false;
        }

        public int TodoId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool IsCompleted { get; set; }

    }
}
