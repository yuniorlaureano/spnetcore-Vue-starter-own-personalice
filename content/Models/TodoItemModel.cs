using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vue2Spa.Models
{
    public class TodoItemModel
    {
        public Guid Id { get; set; }

        public string Text { get; set; }

        public bool Completed { get; set; }
    }
}
