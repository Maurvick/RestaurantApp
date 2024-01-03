using System.Windows.Forms;

namespace Restaurant
{
    public partial class Display : Form
    {
        public Display(object Source)
        {
            InitializeComponent();
            dgDishes.DataSource = Source;
        }
    }
}
