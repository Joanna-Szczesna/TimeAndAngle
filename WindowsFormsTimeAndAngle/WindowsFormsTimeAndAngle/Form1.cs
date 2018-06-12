using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTimeAndAngle
{
    public partial class Form1 : Form, INotifyPropertyChanged
    {
        public Form1()
        {
            InitializeComponent();
            angleLabel.DataBindings.Add(new Binding("Text", this, "Foo"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userInputTextBox_TextChanged(object sender, EventArgs e)
        {
            string userInput = userInputTextBox.Text;
            Logic.CountAngle(userInput);
            angleLabel.Text = Logic.CountAngle(userInput);
        }
    
        protected virtual void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
         public event PropertyChangedEventHandler PropertyChanged;


        
    }
    





}
