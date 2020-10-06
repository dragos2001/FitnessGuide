using System;
using Exercises;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessGuide
{
    public partial class CaliGuide : Form
    {
        

       
        public CaliGuide()
        {
            InitializeComponent();
            
        }

        private void beginnerbutton_Click(object sender, EventArgs e)
        {
            listview1.Items.Clear();
            listview1.Groups.Clear();
            ListViewGroup fullbody = new ListViewGroup("Full body");
            listview1.Groups.Add(fullbody);

            List<Exercise> plan = new List<Exercise>();
        
            plan.Add(new Exercise { Name = "Pushups", Frequency = 8, Sets = 3 });
            plan.Add(new Exercise { Name = "Australian Pullups", Frequency = 10, Sets = 3 });
            plan.Add(new Exercise { Name = " Pullups", Frequency = 4, Sets = 3 });
            plan.Add(new Exercise { Name = "Asisted one leg squat", Frequency = 5, Sets = 5 });
            plan.Add(new Exercise { Name = "Calf raises", Frequency = 15, Sets = 3 });
            plan.Add(new Exercise { Name = "Crunches", Frequency = 12, Sets = 3 });
            foreach(var item in plan)
            { var lvi = new ListViewItem(new[] { item.Name, item.Frequency.ToString(), item.Sets.ToString() },fullbody);
                listview1.Items.Add(lvi);
            }

        }

        private void intermediatebutton_Click(object sender, EventArgs e)
        {
            listview1.Items.Clear();
            listview1.Groups.Clear();
            List<Exercise> plan2 = new List<Exercise>();

            ListViewGroup fullbody = new ListViewGroup("Full body");
                listview1.Groups.Add(fullbody);
            plan2.Add(new Exercise { Name = "Pushups", Frequency = 12, Sets = 3 });
            plan2.Add(new Exercise { Name = "Dips", Frequency = 10, Sets = 3 });
            plan2.Add(new Exercise { Name = " Pullups", Frequency = 10, Sets = 3 });
            plan2.Add(new Exercise { Name = " Chinups", Frequency = 10, Sets = 3 });
            plan2.Add(new Exercise { Name =    " one leg squat", Frequency = 5, Sets = 5 });
            plan2.Add(new Exercise { Name = "Calf raises", Frequency = 8, Sets = 3 });
            plan2.Add(new Exercise { Name = "Dead hang legs raises", Frequency = 12, Sets = 3 });
            foreach (var item in plan2)
            {
                var cul = new ListViewItem(new[] { item.Name, item.Frequency.ToString(), item.Sets.ToString() },fullbody);
                listview1.Items.Add(cul);
            }
        }

        private void advancedbutton_Click(object sender, EventArgs e)
        {
            listview1.Items.Clear();
            listview1.Groups.Clear();
            ListViewGroup pushandlegs = new ListViewGroup ("Push and legs");
            ListViewGroup pullandcore = new ListViewGroup("Pull and core");
            listview1.Groups.Add(pushandlegs);
            listview1.Groups.Add(pullandcore);

            List<Exercise> plan3 = new List<Exercise>();

            plan3.Add(new Exercise { Name = "Pushups", Frequency = 20, Sets = 3, });
            plan3.Add(new Exercise { Name = "Dips", Frequency = 15, Sets = 3 });
            plan3.Add(new Exercise { Name = " Deep pushups", Frequency = 15, Sets = 3 });
            plan3.Add(new Exercise { Name = " One leg squat", Frequency = 10, Sets = 5 });
            plan3.Add(new Exercise { Name = "One leg calf raises", Frequency = 10, Sets = 3 });
            foreach (var item in plan3)
            {
                var hil = new ListViewItem(new[] { item.Name, item.Frequency.ToString(), item.Sets.ToString() }, pushandlegs);
                listview1.Items.Add(hil);
            }
            plan3 = new List<Exercise>();
            plan3.Add(new Exercise { Name = " Pullups", Frequency = 15, Sets = 3 });
            plan3.Add(new Exercise { Name = " Chinups", Frequency = 15, Sets = 3 });
            plan3.Add(new Exercise { Name = "Frontleaver raises", Frequency = 7, Sets = 3 });
            plan3.Add(new Exercise { Name = "Skin theb cat", Frequency = 7, Sets = 3 });
            plan3.Add(new Exercise { Name = "Dead hang legs raises", Frequency = 15, Sets = 3 });
           
            foreach (var item in plan3)
            {
                var hil = new ListViewItem(new[] { item.Name, item.Frequency.ToString(), item.Sets.ToString()},pullandcore);
                listview1.Items.Add(hil);
            }

        }

        
    }
}
