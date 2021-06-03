using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace BeeSimulator
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        World world;
        private DateTime start = DateTime.Now;
        private DateTime end;
        private int frameRuns = 0;
        FieldForm fieldForm = new FieldForm();
        HiveForm hiveForm = new HiveForm();
        
       // private BeeMessage MessageSender;
        public Form1()
        {
            InitializeComponent();
            world = new World(new BeeMessage(SendMessage));
            timer1.Interval = 50;
            timer1.Tick += new EventHandler(RunFrame);
            timer1.Enabled = false;
            UpdateStats(new TimeSpan());
            hiveForm.Show(this);
            fieldForm.Show(this);
        }

        
        private void UpdateStats(TimeSpan frameDuration)
        {
            textBees.Text = world.Bees.Count.ToString();
            textFlowers.Text = world.Flowers.Count.ToString();
            textTotalHoney.Text = String.Format("{0:f3}", world.Hive.Honey);
            double nectar = 0;
            foreach (Flower flower in world.Flowers)
            {
                nectar += flower.Nectar;
            }
            textTotalNectar.Text = String.Format("{0:f3}", nectar);
            textFramesRun.Text = frameRuns.ToString();
            double milliseconds = frameDuration.TotalMilliseconds;
            if (milliseconds!= 0.0) 
            {
                textFrameRate.Text = String.Format("{0:f0} ({1:f1}ms)", 1000 / milliseconds, milliseconds);
            }
            else
            {
                textFrameRate.Text = "N/A";
            }

        }
        private void RunFrame(object sender, EventArgs eventArgs)
        {
            frameRuns++;
            world.Go(random);
            end = DateTime.Now;
            TimeSpan frameDuration = end - start;
            start = end;
            UpdateStats(frameDuration);
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStripbtn_StartSim_Click(object sender, EventArgs e)
        {
            
            if (toolStripbtn_StartSim.Text == "Start Simulation")
            {
                toolStripbtn_StartSim.Text = "Pause Simulation";
                timer1.Enabled = true;
                timer1.Start();
               
            }
            else if (toolStripbtn_StartSim.Text == "Pause Simulation")
            {
                toolStripbtn_StartSim.Text = "Resume Simulation";
                timer1.Stop();
            }
            else
            {
                toolStripbtn_StartSim.Text = "Pause Simulation";
                timer1.Start();
            }
            
            
        }

        private void toolStripbtn_Reset_Click(object sender, EventArgs e)
        {
            frameRuns = 0;
            timer1.Enabled = false;
            world = new World(new BeeMessage(SendMessage));
            UpdateStats(new TimeSpan());
            toolStripbtn_StartSim.Text = "Start Simulation";
            BeeStatistic.Items.Clear();
        }
        private void SendMessage(int ID, string Message)
        {
            toolStripSimStatus.Text = "Bee #" + ID + " " + Message;
            var beeGroups =
                from bee in world.Bees
                group bee by bee.CurrentState into beeGroup
                orderby beeGroup.Key
                select beeGroup;
            BeeStatistic.Items.Clear();
            foreach (var group in beeGroups)
            {
                string s;
                if (group.Count() == 1)
                {
                    s = "";
                }
                else
                {
                    s = "s";
                }
                BeeStatistic.Items.Add(group.Key.ToString() + ":-----> " +  group.Count() + " bee" + s);
                if (group.Key == BeeState.Idle && group.Count() == world.Bees.Count() && frameRuns >0)
                {
                    BeeStatistic.Items.Add("Simulation ended: all bees are idle");
                    toolStripSimStatus.Text = "Simulation ended";
                    toolStripbtn_StartSim.Text = "Start Simulation";
                    timer1.Enabled = false;
                }
            }
        }

        private void toolStripSavebtn_Click(object sender, EventArgs e)
        {
            bool enabled = timer1.Enabled;
            if (enabled)
                timer1.Stop();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\Users\funn1\source\repos\BeeSimulator\Serialized_Info";
            saveFileDialog.Filter = "Simulator Files (*.bees)|*.bees";
            saveFileDialog.Title = "Choose a file to save current simulation";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    using (Stream output = File.OpenWrite(saveFileDialog.FileName))
                    {
                        bf.Serialize(output, world);
                        bf.Serialize(output, frameRuns);
                    }
                }
                catch( Exception ex)
                {
                    MessageBox.Show("Unable to save a simulator file\r\n" + ex.Message, 
                        "BeeSimulator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (enabled)
                timer1.Start();
        }

        private void toolStripOpenbtn_Click(object sender, EventArgs e)
        {
            World currentworld = this.world;
            int currentFrameRuns = this.frameRuns;

            bool enabled = timer1.Enabled;
            if (enabled)
                timer1.Stop();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\funn1\source\repos\BeeSimulator\Serialized_Info";
            openFileDialog.Filter = "Simulator Files (*.bees)|*.bees";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Title = "Choose a file to open!";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    using (Stream input = File.OpenRead(openFileDialog.FileName))
                    {
                        world = (World)bf.Deserialize(input);
                        frameRuns = (int)bf.Deserialize(input);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unable to open a BeeSimulator file " + ex.Message, "Simulator Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    world = currentworld;
                    frameRuns = currentFrameRuns;
                }
            }
            world.Hive.MessageSender = new BeeMessage(SendMessage);
            foreach (Bee bee in world.Bees)
            {
                bee.MessageSender = new BeeMessage(SendMessage);
            }
            if (enabled)
                timer1.Start();
        }
    }
}
