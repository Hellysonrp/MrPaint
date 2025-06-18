namespace MrPaint
{
    internal class StateChangedObserver(FormPaint frm) : IObserver<Editor.State?>
    {
        public void OnCompleted()
        {
            
        }

        public void OnError(Exception error)
        {
            MessageBox.Show(frm, error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void OnNext(Editor.State? state)
        {
            frm.Bmp?.Dispose();
            frm.Bmp = state?.Value != null ? new Bitmap(state.Value) : new Bitmap(frm.pictureBox.Width, frm.pictureBox.Height);
            frm.pictureBox.Image = frm.Bmp;
            frm.menuItemUndo.Enabled = Editor.History.Instance.CanUndo;
            frm.menuItemRedo.Enabled = Editor.History.Instance.CanRedo;
        }
    }
}
