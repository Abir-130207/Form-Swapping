using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Panel_Swap : Form
    {
        int temp;
        Student[] s = new Student[4];
        Point a = new Point(81, 42);
        Point b = new Point(423, 42);
        Point c = new Point(81, 257);
        Point d = new Point(423, 257);
        Point tempo = new Point(0, 0);
      
        public Panel_Swap()
        {
            InitializeComponent();

        }

        public void setStudent(Student[] sp)
        {
            this.s = sp;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 1;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            if (panel1.Location.X > 0 && panel1.Location.Y > 219 && panel1.Location.X < 362 && panel1.Location.Y < 461)
            {
                if (panel2.Location.X == 81 && panel2.Location.Y == 257)
                {
                    panel1.Location = b;
                    panel2.Location = a;

                    tempo = a;
                    a = b;
                    b = tempo;
                }
                if (panel3.Location.X == 81 && panel3.Location.Y == 257)
                {
                    panel1.Location = c;
                    panel3.Location = a;

                    tempo = a;
                    a = c;
                    c = tempo;
                }
                if (panel4.Location.X == 81 && panel4.Location.Y == 257)
                {
                    panel1.Location = d;
                    panel4.Location = a;

                    tempo = a;
                    a = d;
                    d = tempo;
                }
            }

            if (panel1.Location.X > 362 && panel1.Location.Y > 0 && panel1.Location.X < 742 && panel1.Location.Y < 219)
            {
                if (panel2.Location.X == 423 && panel2.Location.Y == 42)
                {
                    panel1.Location = b;
                    panel2.Location = a;

                    tempo = a;
                    a = b;
                    b = tempo;
                }
                if (panel3.Location.X == 423 && panel3.Location.Y == 42)
                {
                    panel1.Location = c;
                    panel3.Location = a;

                    tempo = a;
                    a = c;
                    c = tempo;
                }
                if (panel4.Location.X == 423 && panel4.Location.Y == 42)
                {
                    panel1.Location = d;
                    panel4.Location = a;

                    tempo = a;
                    a = d;
                    d = tempo;
                }

            }

            if (panel1.Location.X > 362 && panel1.Location.Y > 219 && panel1.Location.X < 742 && panel1.Location.Y < 461)
            {
                if (panel2.Location.X == 423 && panel2.Location.Y == 257)
                {
                    panel1.Location = b;
                    panel2.Location = a;

                    tempo = a;
                    a = b;
                    b = tempo;
                }
                if (panel3.Location.X == 423 && panel3.Location.Y == 257)
                {
                    panel1.Location = c;
                    panel3.Location = a;

                    tempo = a;
                    a = c;
                    c = tempo;
                }
                if (panel4.Location.X == 423 && panel4.Location.Y == 257)
                {
                    panel1.Location = d;
                    panel4.Location = a;

                    tempo = a;
                    a = d;
                    d = tempo;
                }
            }

            if (panel1.Location.X > 0 && panel1.Location.Y > 0 && panel1.Location.X < 362 && panel1.Location.Y < 219)
            {

                if (panel2.Location.X == 81 && panel2.Location.Y == 42)
                {
                    panel1.Location = b;
                    panel2.Location = a;

                    tempo = a;
                    a = b;
                    b = tempo;
                }
                if (panel3.Location.X == 81 && panel3.Location.Y == 42)
                {
                    panel1.Location = c;
                    panel3.Location = a;

                    tempo = a;
                    a = c;
                    c = tempo;
                }
                if (panel4.Location.X == 81 && panel4.Location.Y == 42)
                {
                    panel1.Location = d;
                    panel4.Location = a;

                    tempo = a;
                    a = d;
                    d = tempo;
                }


            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 1)
            {
                panel1.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 2;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            if (panel2.Location.X > 0 && panel2.Location.Y > 219 && panel2.Location.X < 362 && panel2.Location.Y < 461)
            {
                if (panel1.Location.X == 81 && panel1.Location.Y == 257)
                {
                    panel1.Location = b;
                    panel2.Location = a;

                    tempo = a;
                    a = b;
                    b = tempo;
                }
                if (panel3.Location.X == 81 && panel3.Location.Y == 257)
                {
                    panel2.Location = c;
                    panel3.Location = b;

                    tempo = b;
                    b = c;
                    c = tempo;
                }
                if (panel4.Location.X == 81 && panel4.Location.Y == 257)
                {
                    panel2.Location = d;
                    panel4.Location = b;

                    tempo = b;
                    b = d;
                    d = tempo;
                }
            }

            if (panel2.Location.X > 362 && panel2.Location.Y > 0 && panel2.Location.X < 742 && panel2.Location.Y < 219)
            {
                if (panel1.Location.X == 423 && panel1.Location.Y == 42)
                {
                    panel1.Location = b;
                    panel2.Location = a;

                    tempo = a;
                    a = b;
                    b = tempo;
                }
                if (panel3.Location.X == 423 && panel3.Location.Y == 42)
                {
                    panel2.Location = c;
                    panel3.Location = b;

                    tempo = b;
                    b = c;
                    c = tempo;
                }
                if (panel4.Location.X == 423 && panel4.Location.Y == 42)
                {
                    panel2.Location = d;
                    panel4.Location = b;

                    tempo = b;
                    b = d;
                    d = tempo;
                }

            }

            if (panel2.Location.X > 362 && panel2.Location.Y > 219 && panel2.Location.X < 742 && panel2.Location.Y < 461)
            {
                if (panel1.Location.X == 423 && panel1.Location.Y == 257)
                {
                    panel1.Location = b;
                    panel2.Location = a;

                    tempo = a;
                    a = b;
                    b = tempo;
                }
                if (panel3.Location.X == 423 && panel3.Location.Y == 257)
                {
                    panel2.Location = c;
                    panel3.Location = b;

                    tempo = b;
                    b = c;
                    c = tempo;
                }
                if (panel4.Location.X == 423 && panel4.Location.Y == 257)
                {
                    panel2.Location = d;
                    panel4.Location = b;

                    tempo = b;
                    b = d;
                    d = tempo;
                }
            }

            if (panel2.Location.X > 0 && panel2.Location.Y > 0 && panel2.Location.X < 362 && panel2.Location.Y < 219)
            {

                if (panel1.Location.X == 81 && panel1.Location.Y == 42)
                {
                    panel1.Location = b;
                    panel2.Location = a;

                    tempo = a;
                    a = b;
                    b = tempo;
                }
                if (panel3.Location.X == 81 && panel3.Location.Y == 42)
                {
                    panel2.Location = c;
                    panel3.Location = b;

                    tempo = b;
                    b = c;
                    c = tempo;
                }
                if (panel4.Location.X == 81 && panel4.Location.Y == 42)
                {
                    panel2.Location = d;
                    panel4.Location = b;

                    tempo = b;
                    b = d;
                    d = tempo;
                }

            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 2)
            {
                panel2.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 3;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            if (panel3.Location.X > 0 && panel3.Location.Y > 219 && panel3.Location.X < 362 && panel3.Location.Y < 461)
            {
                if (panel1.Location.X == 81 && panel1.Location.Y == 257)
                {
                    panel1.Location = c;
                    panel3.Location = a;

                    tempo = a;
                    a = c;
                    c = tempo;
                }
                if (panel2.Location.X == 81 && panel2.Location.Y == 257)
                {
                    panel2.Location = c;
                    panel3.Location = b;

                    tempo = b;
                    b = c;
                    c = tempo;
                }
                if (panel4.Location.X == 81 && panel4.Location.Y == 257)
                {
                    panel3.Location = d;
                    panel4.Location = c;

                    tempo = c;
                    c = d;
                    d = tempo;
                }
            }

            if (panel3.Location.X > 362 && panel3.Location.Y > 0 && panel3.Location.X < 742 && panel3.Location.Y < 219)
            {
                if (panel1.Location.X == 423 && panel1.Location.Y == 42)
                {
                    panel3.Location = a;
                    panel1.Location = c;

                    tempo = c;
                    c = a;
                    a = tempo;
                }
                if (panel2.Location.X == 423 && panel2.Location.Y == 42)
                {
                    panel2.Location = c;
                    panel3.Location = b;

                    tempo = b;
                    b = c;
                    c = tempo;
                }
                if (panel4.Location.X == 423 && panel4.Location.Y == 42)
                {
                    panel3.Location = d;
                    panel4.Location = c;

                    tempo = c;
                    c = d;
                    d = tempo;
                }

            }

            if (panel3.Location.X > 362 && panel3.Location.Y > 219 && panel3.Location.X < 742 && panel3.Location.Y < 461)
            {
                if (panel1.Location.X == 423 && panel1.Location.Y == 257)
                {
                    panel3.Location = a;
                    panel1.Location = c;

                    tempo = c;
                    c = a;
                    a = tempo;
                }
                if (panel2.Location.X == 423 && panel2.Location.Y == 257)
                {
                    panel2.Location = c;
                    panel3.Location = b;

                    tempo = b;
                    b = c;
                    c = tempo;
                }
                if (panel4.Location.X == 423 && panel4.Location.Y == 257)
                {
                    panel3.Location = d;
                    panel4.Location = c;

                    tempo = c;
                    c = d;
                    d = tempo;
                }
            }

            if (panel3.Location.X > 0 && panel3.Location.Y > 0 && panel3.Location.X < 362 && panel3.Location.Y < 219)
            {

                if (panel1.Location.X == 81 && panel1.Location.Y == 42)
                {
                    panel3.Location = a;
                    panel1.Location = c;

                    tempo = c;
                    c = a;
                    a = tempo;
                }
                if (panel2.Location.X == 81 && panel2.Location.Y == 42)
                {
                    panel2.Location = c;
                    panel3.Location = b;

                    tempo = b;
                    b = c;
                    c = tempo;
                }
                if (panel4.Location.X == 81 && panel4.Location.Y == 42)
                {
                    panel3.Location = d;
                    panel4.Location = c;

                    tempo = c;
                    c = d;
                    d = tempo;
                }

            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 3)
            {
                panel3.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 4;
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            if (panel4.Location.X > 0 && panel4.Location.Y > 219 && panel4.Location.X < 362 && panel4.Location.Y < 461)
            {
                if (panel1.Location.X == 81 && panel1.Location.Y == 257)
                {
                    panel1.Location = d;
                    panel4.Location = a;

                    tempo = a;
                    a = d;
                    d = tempo;
                }
                if (panel2.Location.X == 81 && panel2.Location.Y == 257)
                {
                    panel2.Location = d;
                    panel4.Location = b;

                    tempo = b;
                    b = d;
                    d = tempo;
                }
                if (panel3.Location.X == 81 && panel3.Location.Y == 257)
                {
                    panel3.Location = d;
                    panel4.Location = c;

                    tempo = c;
                    c = d;
                    d = tempo;
                }
            }

            if (panel4.Location.X > 362 && panel4.Location.Y > 0 && panel4.Location.X < 742 && panel4.Location.Y < 219)
            {
                if (panel1.Location.X == 423 && panel1.Location.Y == 42)
                {
                    panel1.Location = d;
                    panel4.Location = a;

                    tempo = a;
                    a = d;
                    d = tempo;
                }
                if (panel2.Location.X == 423 && panel2.Location.Y == 42)
                {
                    panel2.Location = d;
                    panel4.Location = b;

                    tempo = b;
                    b = d;
                    d = tempo;
                }
                if (panel3.Location.X == 423 && panel3.Location.Y == 42)
                {
                    panel3.Location = d;
                    panel4.Location = c;

                    tempo = c;
                    c = d;
                    d = tempo;
                }

            }

            if (panel4.Location.X > 362 && panel4.Location.Y > 219 && panel4.Location.X < 742 && panel4.Location.Y < 461)
            {
                if (panel1.Location.X == 423 && panel1.Location.Y == 257)
                {
                    panel1.Location = d;
                    panel4.Location = a;

                    tempo = a;
                    a = d;
                    d = tempo;
                }
                if (panel2.Location.X == 423 && panel2.Location.Y == 257)
                {
                    panel2.Location = d;
                    panel4.Location = b;

                    tempo = b;
                    b = d;
                    d = tempo;
                }
                if (panel3.Location.X == 423 && panel3.Location.Y == 257)
                {
                    panel3.Location = d;
                    panel4.Location = c;

                    tempo = c;
                    c = d;
                    d = tempo;
                }
            }

            if (panel4.Location.X > 0 && panel4.Location.Y > 0 && panel4.Location.X < 362 && panel4.Location.Y < 219)
            {

                if (panel1.Location.X == 81 && panel1.Location.Y == 42)
                {
                    panel1.Location = d;
                    panel4.Location = a;

                    tempo = a;
                    a = d;
                    d = tempo;
                }
                if (panel2.Location.X == 81 && panel2.Location.Y == 42)
                {
                    panel2.Location = d;
                    panel4.Location = b;

                    tempo = b;
                    b = d;
                    d = tempo;
                }
                if (panel3.Location.X == 81 && panel3.Location.Y == 42)
                {
                    panel3.Location = d;
                    panel4.Location = c;

                    tempo = c;
                    c = d;
                    d = tempo;
                }

            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 4)
            {
                panel4.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void Panel_Swap_Load(object sender, EventArgs e)
        {
            label13.Text = s[0].name;
            label14.Text = s[0].id;
            label15.Text = s[0].discipline;

            label16.Text = s[1].name;
            label17.Text = s[1].id;
            label18.Text = s[1].discipline;

            label19.Text = s[2].name;
            label20.Text = s[2].id;
            label21.Text = s[2].discipline;

            label22.Text = s[3].name;
            label23.Text = s[3].id;
            label24.Text = s[3].discipline;
        }
    }
}
