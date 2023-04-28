using System;
using System.Windows.Forms;

namespace task5
{
    public abstract class Closet : IFurniture
    {
        public int Weight { get; set; }
        public string Material { get; set; }
        public int Height { get; set; }

        public Closet(int weight, string material, int height)
        {
            Weight = weight;
            Material = material;
            Height = height;
        }

        public virtual void Move()
        {
            MessageBox.Show("The closet is now in a new location");
        }

        public virtual void Clean()
        {
            MessageBox.Show("The closet is now clean");
        }

        public abstract void Store();
    }
}