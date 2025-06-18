namespace MrPaint
{
    partial class FormPaint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            editarToolStripMenuItem = new ToolStripMenuItem();
            menuItemUndo = new ToolStripMenuItem();
            menuItemRedo = new ToolStripMenuItem();
            groupBoxImage = new GroupBox();
            pictureBox = new PictureBox();
            btnClear = new Button();
            btnPencil = new Button();
            btnRect = new Button();
            btnBucket = new Button();
            panel1 = new Panel();
            btnSecondaryColor = new Button();
            btnPrimaryColor = new Button();
            panel2 = new Panel();
            stateBindingSource = new BindingSource(components);
            menuStrip.SuspendLayout();
            groupBoxImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stateBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.Control;
            menuStrip.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1085, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuItemUndo, menuItemRedo });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // menuItemUndo
            // 
            menuItemUndo.Image = Properties.Resources.Undo;
            menuItemUndo.Name = "menuItemUndo";
            menuItemUndo.ShortcutKeys = Keys.Control | Keys.Z;
            menuItemUndo.Size = new Size(210, 22);
            menuItemUndo.Text = "Desfazer (Ctrl + Z)";
            menuItemUndo.Click += menuItemUndo_Click;
            // 
            // menuItemRedo
            // 
            menuItemRedo.Image = Properties.Resources.Redo;
            menuItemRedo.Name = "menuItemRedo";
            menuItemRedo.ShortcutKeys = Keys.Control | Keys.Y;
            menuItemRedo.Size = new Size(210, 22);
            menuItemRedo.Text = "Refazer (Ctrl + Y)";
            menuItemRedo.Click += menuItemRedo_Click;
            // 
            // groupBoxImage
            // 
            groupBoxImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxImage.Controls.Add(pictureBox);
            groupBoxImage.Location = new Point(34, 23);
            groupBoxImage.Name = "groupBoxImage";
            groupBoxImage.Size = new Size(1049, 643);
            groupBoxImage.TabIndex = 2;
            groupBoxImage.TabStop = false;
            groupBoxImage.Text = "Imagem";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(6, 16);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1034, 621);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.SizeChanged += pictureBox_SizeChanged;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = Properties.Resources.Eraser;
            btnClear.BackgroundImageLayout = ImageLayout.Center;
            btnClear.Enabled = false;
            btnClear.Location = new Point(6, 610);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(23, 23);
            btnClear.TabIndex = 2;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Visible = false;
            // 
            // btnPencil
            // 
            btnPencil.BackgroundImage = Properties.Resources.Edit;
            btnPencil.BackgroundImageLayout = ImageLayout.Center;
            btnPencil.Location = new Point(6, 4);
            btnPencil.Name = "btnPencil";
            btnPencil.Size = new Size(23, 23);
            btnPencil.TabIndex = 3;
            btnPencil.UseVisualStyleBackColor = true;
            btnPencil.Click += btnPencil_Click;
            // 
            // btnRect
            // 
            btnRect.BackgroundImage = Properties.Resources.Shape;
            btnRect.BackgroundImageLayout = ImageLayout.Center;
            btnRect.Location = new Point(6, 33);
            btnRect.Name = "btnRect";
            btnRect.Size = new Size(23, 23);
            btnRect.TabIndex = 4;
            btnRect.UseVisualStyleBackColor = true;
            btnRect.Click += btnRect_Click;
            // 
            // btnBucket
            // 
            btnBucket.BackgroundImage = Properties.Resources.Fill;
            btnBucket.BackgroundImageLayout = ImageLayout.Center;
            btnBucket.Location = new Point(6, 62);
            btnBucket.Name = "btnBucket";
            btnBucket.Size = new Size(23, 23);
            btnBucket.TabIndex = 5;
            btnBucket.UseVisualStyleBackColor = true;
            btnBucket.Click += btnBucket_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnSecondaryColor);
            panel1.Controls.Add(btnPrimaryColor);
            panel1.Location = new Point(3, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(29, 55);
            panel1.TabIndex = 6;
            // 
            // btnSecondaryColor
            // 
            btnSecondaryColor.BackColor = Color.White;
            btnSecondaryColor.Location = new Point(3, 29);
            btnSecondaryColor.Name = "btnSecondaryColor";
            btnSecondaryColor.Size = new Size(23, 23);
            btnSecondaryColor.TabIndex = 8;
            btnSecondaryColor.UseVisualStyleBackColor = false;
            btnSecondaryColor.Click += btnSecondaryColor_Click;
            // 
            // btnPrimaryColor
            // 
            btnPrimaryColor.BackColor = Color.Black;
            btnPrimaryColor.Location = new Point(3, 3);
            btnPrimaryColor.Name = "btnPrimaryColor";
            btnPrimaryColor.Size = new Size(23, 23);
            btnPrimaryColor.TabIndex = 7;
            btnPrimaryColor.UseVisualStyleBackColor = false;
            btnPrimaryColor.Click += btnPrimaryColor_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btnBucket);
            panel2.Controls.Add(btnRect);
            panel2.Controls.Add(btnPencil);
            panel2.Controls.Add(btnClear);
            panel2.Location = new Point(0, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(34, 637);
            panel2.TabIndex = 7;
            // 
            // stateBindingSource
            // 
            stateBindingSource.DataSource = typeof(Editor.State);
            // 
            // FormPaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 668);
            Controls.Add(panel2);
            Controls.Add(groupBoxImage);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormPaint";
            Text = "MrPaint";
            Load += FormPaint_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            groupBoxImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stateBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem editarToolStripMenuItem;
        private GroupBox groupBoxImage;
        private Button btnClear;
        private Button btnPencil;
        private Button btnRect;
        private Button btnBucket;
        private Panel panel1;
        private Button btnSecondaryColor;
        private Button btnPrimaryColor;
        private Panel panel2;
        private BindingSource stateBindingSource;
        internal ToolStripMenuItem menuItemUndo;
        internal ToolStripMenuItem menuItemRedo;
        internal PictureBox pictureBox;
    }
}
