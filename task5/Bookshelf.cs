using System;
using System.Windows.Forms;

namespace task5
{
    public class Bookshelf : Closet
    {
        public int NumShelves { get; set; }
        public string Color { get; set; }

        public Bookshelf(int weight, string material, int height, int numShelves, string color)
            : base(weight, material, height)
        {
            NumShelves = numShelves;
            Color = color;
        }

        public override void Store()
        {
            MessageBox.Show("The books are now stored on the bookshelf");
        }

        public void Read()
        {
            MessageBox.Show("You are now reading a book from the bookshelf");
        }
    }
}