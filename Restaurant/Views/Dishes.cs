using System.Windows.Forms;

namespace Restaurant
{
    public partial class btnDishes : Form
    {
        public btnDishes(object Source)
        {
            InitializeComponent();
            dgDishes.DataSource = Source;
        }
    }
}
