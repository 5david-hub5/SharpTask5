using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5
{
    public partial class Form1 : Form
    {
        private List<IFurniture> furnitureList = new List<IFurniture>();
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            int weight = int.Parse(weightTextBox.Text);
            string material = materialTextBox.Text;
            int height = int.Parse(heightTextBox.Text);
            int numShelves = int.Parse(numShelvesTextBox.Text);
            string color = colorTextBox.Text;
            Bookshelf bookshelf = new Bookshelf(weight, material, height, numShelves, color);

            // Добавить новый объект в список furnitureList и в furnitureListBox
            furnitureList.Add(bookshelf);
            l.Items.Add(bookshelf);

            // Установить выделение на новом объекте и обновить свойства в propertyGrid
            l.SelectedItem = bookshelf;
            propertyGrid.SelectedObject = bookshelf;

            // Очистить значения в текстовых полях
            weightTextBox.Text = "";
            materialTextBox.Text = "";
            heightTextBox.Text = "";
            numShelvesTextBox.Text = "";
            colorTextBox.Text = "";
        }
        
        private void removeButton_Click(object sender, EventArgs e)
        {
            // Получить выбранный объект в списке furnitureListBox
            IFurniture selectedFurniture = l.SelectedItem as IFurniture;

            // Если объект выбран, то удалить его из списка и обновить propertyGrid
            if (selectedFurniture != null)
            {
                furnitureList.Remove(selectedFurniture);
                l.Items.Remove(selectedFurniture);
                propertyGrid.SelectedObject = null;
            }
        }
        
        private void furnitureListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получить выбранный объект в списке furnitureListBox
            IFurniture selectedFurniture = l.SelectedItem as IFurniture;

            // Если объект выбран, то обновить свойства в propertyGrid
            if (selectedFurniture != null)
            {
                propertyGrid.SelectedObject = selectedFurniture;
            }
            else
            {
                propertyGrid.SelectedObject = null;
            }
        }

        
    }
}