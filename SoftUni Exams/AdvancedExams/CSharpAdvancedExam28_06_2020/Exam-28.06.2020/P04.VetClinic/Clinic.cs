namespace VetClinic
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Clinic
    {
        private List<Pet> data;
        public Clinic()
        {
            this.data = new List<Pet>();
        }

        public Clinic(int capacity)
            : this()
        {
            this.Capacity = capacity;
        }

        public int Capacity { get; set; }
        public int Count { get { return this.data.Count; } }

        public void Add(Pet pet)
        {
            if (this.Capacity > this.data.Count)
            {
                this.data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet pet = this.data.FirstOrDefault(p => p.Name == name);

            if (pet == null)
            {
                return false;
            }

            this.data.Remove(pet);

            return true;
        }

        public Pet GetPet(string name, string owner)
        {
            Pet pet = this.data.FirstOrDefault(p => p.Name == name && p.Owner == owner);

            return pet;
        }

        public Pet GetOldestPet()
        {
            int oldestPet = 0;

            foreach (Pet currentPet in this.data)
            {
                if (oldestPet < currentPet.Age)
                {
                    oldestPet = currentPet.Age;
                }
            }

            Pet pet = this.data.FirstOrDefault(p => p.Age == oldestPet);

            return pet;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("The clinic has the following patients:");

            foreach (Pet pet in this.data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
