using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private readonly List<IDecoration> decorations;

        public DecorationRepository()
        {
            this.decorations = new List<IDecoration>();
        }

        public IReadOnlyCollection<IDecoration> Models
        {
            get
            {
                return this.decorations.ToList();
            }
        }

        public void Add(IDecoration model)
        {
            this.decorations.Add(model);
        }

        public bool Remove(IDecoration model)
        {
            return this.decorations.Remove(model);
        }

        public IDecoration FindByType(string type)
        {
            var decoration = this.decorations.FirstOrDefault(x => x.GetType().Name == type);

            return decoration;
        }

    }
}
