using System.Drawing;
using System.Windows.Forms;

namespace SPO_laba_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form form1 = new Form();
         
        protected override void OnKeyDown(KeyEventArgs e)
        {

            Keys keysmod = Control.ModifierKeys;
            if (e.Alt)
            {
                if (e.KeyCode == Keys.K)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Enabled = true;
                    label2.Visible = false;
                }
            }

            //-------------------------  Верх  ------------
            if (e.KeyCode == Keys.Up)
            {
                int y = 10;
                label1.Text = "Верх";
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - y);
                
                if (pictureBox1.Location.Y < -170)
                {
                    int up_Y;
                    
                    form1.Size = new Size(form1.Size.Width, form1.Size.Height);
                    up_Y = form1.Size.Height + 150;

                    pictureBox1.Location = new Point(pictureBox1.Location.X, up_Y);
                }

            }

            //-------------------------  Вниз  ------------
            if (e.KeyCode == Keys.Down)
            {
                int y = 10;
                label1.Text = "Вниз";
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + y);

                form1.Size = new Size(form1.Size.Width, form1.Size.Height);
                if (pictureBox1.Location.Y > (form1.Size.Height+140))
                {
                    int dn_Y = -175;

                    pictureBox1.Location = new Point(pictureBox1.Location.X, dn_Y);
                }
            }
            
            // ------------------------  Влево  <<------------
            if (e.KeyCode == Keys.Left)
            {
                int x = 10;
                label1.Text = "Влево";
                pictureBox1.Location = new Point(pictureBox1.Location.X - x, pictureBox1.Location.Y);

                if (pictureBox1.Location.X < -170)
                {
                    int left_X;
                    form1.Size = new Size(form1.Size.Width, form1.Size.Height);
                    left_X = form1.Size.Width + 200;
                    pictureBox1.Location = new Point(left_X, pictureBox1.Location.Y);
                }

            }

            // ------------------------  Вправо  ------------>>
            if (e.KeyCode == Keys.Right)
            {
                int x = 10;
                label1.Text = "Вправо";
                pictureBox1.Location = new Point(pictureBox1.Location.X + x, pictureBox1.Location.Y);

                form1.Size = new Size(form1.Size.Width, form1.Size.Height);
                if (pictureBox1.Location.X > (form1.Size.Width + 205))
                {
                    int left_X = -175;

                    pictureBox1.Location = new Point(left_X, pictureBox1.Location.Y);
                }
            }
        }
    }
}
