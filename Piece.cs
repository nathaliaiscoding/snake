using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public class Piece : Label
    {
        public Piece(int x, int y)
        {
            Location = new Point(x, y);
            Size = new Size(20, 20);
            Color _color = ColorTranslator.FromHtml("#0B0803");
            BackColor = _color;
            Enabled = false;
        }
    }
}
