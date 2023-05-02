using System.Drawing;
using System.Windows.Forms;

namespace MyCalc.Properties
{
    public partial class Tools : Form
    {
        private MainForm _parent = null;
        public Tools(MainForm parent)
        {
            _parent = parent;
            InitializeComponent();
            Blue.Scroll += TrackBarColor_Scroll;
            Green.Scroll += TrackBarColor_Scroll;
            Red.Scroll += TrackBarColor_Scroll;
        }

        private void TrackBarColor_Scroll(object sender, System.EventArgs e)
        {
            Color currentColor = Color.FromArgb(Red.Value, Green.Value, Blue.Value);
            _parent.ChangeBackgroundColor(currentColor);
        }

        private void Tools_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}