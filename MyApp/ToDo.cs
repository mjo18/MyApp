using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class ToDo
    {
        private string name;
        private string description;
        private DateTime deadline;
        private bool iscomplete;
        public string Name
        {
            get 
            { 
                return name; 
            }
            set
            {
                if (name != value)
                {
                    name = value;
                }
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (description != value)
                    description = value;
            }
        }
        public DateTime Deadline
        {
            get
            {
                return deadline;
            }
            set
            {
                if (deadline != value)
                    deadline = value;
            }
        }

        public bool IsComplete
        {
            get
            {
                return iscomplete;

            }
            set
            {
                if (iscomplete != value)
                    iscomplete = value;
            }
        }

        public override string ToString()
        {
            return $"{Description} Completed: {IsComplete}";
        }

    }
}
