using System.Runtime.CompilerServices;
using TaskObj;
namespace TaskManager
{
    public partial class Form1 : Form
    {

        private int nbrTask = 0;
        private int nbrCompletedTask = 0;
        private List<Tache> tasks = new List<Tache>();

        public Form1()
        {
            InitializeComponent();
            FormLoad();
        }
        private void FormLoad ()
        {
            pictureBox1.Select();
            label3.Text = $"Task Completed: {nbrCompletedTask} / {nbrTask}";
            foreach (Control p in panel3.Controls)
            {
                p.Click += (e, s) =>
                {
                    panel1.Select();
                };
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Select();

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            panel1.Select();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tasks.Add(new Tache(textBox1.Text));
            // Creating and setting the label 
            Label mylab = new Label();
            mylab.Text = "GeeksforGeeks";
            mylab.Location = new Point(222, 90);
            mylab.AutoSize = true;
            mylab.Font = new Font("Calibri", 18);
            mylab.ForeColor = Color.Green;
            mylab.Padding = new Padding(6);

            // Adding this control to the form 
            this.Controls.Clear();
            this.Controls.Add(mylab);
            InitializeComponent();
            FormLoad();
            ResumeLayout();
            panel1.ResumeLayout();
            panel3.ResumeLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
namespace TaskObj
{
    public class Tache
    {
        private int x = 50 ;
        private const int y = 20;
        public Label label8 { get; protected set; }
        public Tache(string name)
        {
            label8 = new Label();
            label8.Text = name;
            label8.Location = new Point(x, y);
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 18);
            label8.ForeColor = Color.Black;
            label8.Padding = new Padding(6);
        }
    }

}
