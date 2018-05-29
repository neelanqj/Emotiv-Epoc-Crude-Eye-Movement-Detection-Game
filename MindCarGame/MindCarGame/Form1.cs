using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindCarGame
{
    public partial class Form1 : Form
    {
        DatabaseConnector _dbConnector;

        int posOwl;
        public Form1()
        {
            _dbConnector = new DatabaseConnector(@"Data Source=localhost;User ID=Tester;Password=test;Integrated Security=False");
            
            InitializeComponent();
            posOwl = picOwl.Top - 10;
            this.KeyPress += new KeyPressEventHandler(MoveObject);
        }

        public void MoveObject(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                // e.Handled = true;
                picOwl.Top -= 10;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string move;
            int posOwl = picOwl.Top - 10;
            move = _dbConnector.ExecuteSqlCommandForSingleValue("InterdimensionalSinkhole", "SELECT TOP 1 data FROM InterdimensionalSinkhole.dbo.EpocHeadsetDataStream WITH(NOLOCK) ORDER BY createdate desc");
            
            if (move == "left" && picOwl.Left < 746)
            {
                picOwl.Left= picOwl.Left+10;
            }
            else if (move == "right" && picOwl.Left > 0)
            {
                picOwl.Left = picOwl.Left - 10;
            }

            if (move == "blink" && posOwl * 3 == picOwl.Top)
            {
                picOwl.Top = picOwl.Top - 10;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
