#nullable enable

namespace MrPaint
{
    public partial class FormPaint : Form
    {
        private Editor.ITool ActiveTool { get; set; }
        private StateChangedObserver StateObserver { get; }
        internal Bitmap? Bmp { get; set; }

        public FormPaint()
        {
            InitializeComponent();
            ActiveTool = Editor.Pencil.Instance;
            StateObserver = new StateChangedObserver(this);
        }

        private void FormPaint_Load(object sender, EventArgs e)
        {
            Editor.History.Instance.Subscribe(StateObserver);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Editor.History.Instance.Clear();
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            ActiveTool = Editor.Pencil.Instance;
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            ActiveTool = Editor.Rectangle.Instance;
        }

        private void btnBucket_Click(object sender, EventArgs e)
        {
            ActiveTool = Editor.Bucket.Instance;
        }

        private void btnPrimaryColor_Click(object sender, EventArgs e)
        {
            using var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Editor.Params.Instance.PrimaryColor = colorDialog.Color;
                btnPrimaryColor.BackColor = colorDialog.Color;
            }
        }

        private void btnSecondaryColor_Click(object sender, EventArgs e)
        {
            using var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Editor.Params.Instance.SecondaryColor = colorDialog.Color;
                btnSecondaryColor.BackColor = colorDialog.Color;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Editor.Params.Instance.ShouldUseSecondaryColor = e.Button == MouseButtons.Right;
            ActiveTool.MouseDown(Bmp!, e);
            pictureBox.Invalidate();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            ActiveTool.MouseMove(Bmp!, e);
            pictureBox.Invalidate();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            ActiveTool.MouseUp(Bmp!, e);
            pictureBox.Invalidate();
            Editor.History.Instance.AddState(new Editor.State(ActiveTool.Name, Bmp!));
        }

        private void pictureBox_SizeChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    // resize the bitmap mantaining its contents
            //    Bitmap newBmp = new(Bmp!, pictureBox.Width, pictureBox.Height);
            //    pictureBox.Image = newBmp;
            //    Bmp?.Dispose();
            //    Bmp = newBmp;
            //}
            //catch { }
        }

        private void menuItemUndo_Click(object sender, EventArgs e)
        {
            if (Editor.History.Instance.CanUndo)
                Editor.History.Instance.Undo();
        }

        private void menuItemRedo_Click(object sender, EventArgs e)
        {
            if (Editor.History.Instance.CanRedo)
                Editor.History.Instance.Redo();
        }
    }
}
