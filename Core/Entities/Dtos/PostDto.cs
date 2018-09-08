using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Dtos
{
  public   class PostDto:BaseModel
    {
        public string Title { get; set; }

        public string Body { get; set; }

        public string Author { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
