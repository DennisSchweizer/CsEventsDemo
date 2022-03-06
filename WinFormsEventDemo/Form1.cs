using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEventDemo
{
    public partial class Form1 : Form
    {

        public static event EventHandler<EventArgs> EventByHandler;
        public static int counter { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
            EventByHandler += Program_EventByHandler;
        }

        private void Program_EventByHandler(object sender, EventArgs e)
        {
            button1.Text = $"Pressed {counter} time(s)!";
            counter++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           EventByHandler?.Invoke(null,EventArgs.Empty);
        }
    }
}
