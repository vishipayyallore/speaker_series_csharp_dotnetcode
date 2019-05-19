using System.Collections.Generic;

namespace VS2019.Enhanced.Scrollbar.Demo.Models
{

    public class Manager
    {

        public Manager()
        {
            Repotees = new List<string>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public List<string> Repotees { get; set; }

    }

}
