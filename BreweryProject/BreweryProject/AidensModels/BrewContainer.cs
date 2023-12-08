using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryProject
{
    public partial class BrewContainer
    {
        public BrewContainer()
        {
            BatchContainers = new HashSet<BatchContainer>();
        }

        public int BrewContainerId { get; set; }
        public string Name { get; set; }
        public int ContainerStatusId { get; set; }
        public int ContainerTypeId { get; set; }
        public int ContainerSizeId { get; set; }

        public virtual ICollection<BatchContainer> BatchContainers { get; set; }
    }
}
