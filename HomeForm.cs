using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepScreenAwake
{
    public partial class HomeForm : Form
    {
        private bool buttonClicked = false;
        public bool ButtonClicked
        {
            get
            {
                return buttonClicked;
            }
            set
            {
                buttonClicked = value;
                if (buttonClicked)
                {
                    toggle_button.Text = "End";
                }
                else
                {
                    toggle_button.Text = "Start";
                }
            }
        }

        public HomeForm()
        {
            InitializeComponent();
            toggle_button.Text = "Start";
        }

        private void toggle_button_Click(object sender, EventArgs e)
        {
            ButtonClicked = !ButtonClicked;
            _ = DancingCursorLogicAsync();
        }

        private async Task DancingCursorLogicAsync()
        {
            try
            {
                do
                {
                    if (buttonClicked)
                    {
                        MoveCursor(Cursor.Position.X - 5, Cursor.Position.Y - 5);
                        await Task.Delay(2000);
                    }

                    if (buttonClicked)
                    {
                        MoveCursor(Cursor.Position.X + 5, Cursor.Position.Y + 5);
                        await Task.Delay(2000);
                    }

                } while (buttonClicked);
            }
            finally
            {
            }
        }

        private void MoveCursor(int x, int y)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(x, y);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

    }
}
