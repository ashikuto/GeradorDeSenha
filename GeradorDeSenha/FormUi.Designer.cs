namespace GeradorDeSenha
{
    partial class FormUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUi));
            btnExit = new Button();
            btnStart = new Button();
            txtPasswordLength = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem1 = new ToolStripMenuItem();
            sumárioToolStripMenuItem = new ToolStripMenuItem();
            índiceToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            sobreToolStripMenuItem1 = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblLastPassword = new Label();
            btnCopy = new Button();
            btnClear = new Button();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.Name = "btnExit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnStart
            // 
            resources.ApplyResources(btnStart, "btnStart");
            btnStart.BackgroundImage = Properties.Resources._10071291;
            btnStart.Cursor = Cursors.Hand;
            btnStart.Name = "btnStart";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtPasswordLength
            // 
            txtPasswordLength.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtPasswordLength, "txtPasswordLength");
            txtPasswordLength.Name = "txtPasswordLength";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, ajudaToolStripMenuItem1 });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator, salvarToolStripMenuItem, toolStripSeparator1, toolStripSeparator2, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            resources.ApplyResources(arquivoToolStripMenuItem, "arquivoToolStripMenuItem");
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(toolStripSeparator, "toolStripSeparator");
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Image = Properties.Resources._10070942;
            resources.ApplyResources(salvarToolStripMenuItem, "salvarToolStripMenuItem");
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            resources.ApplyResources(sairToolStripMenuItem, "sairToolStripMenuItem");
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem1
            // 
            ajudaToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { sumárioToolStripMenuItem, índiceToolStripMenuItem, toolStripSeparator5, sobreToolStripMenuItem1 });
            ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            resources.ApplyResources(ajudaToolStripMenuItem1, "ajudaToolStripMenuItem1");
            // 
            // sumárioToolStripMenuItem
            // 
            sumárioToolStripMenuItem.Image = Properties.Resources._10070959;
            sumárioToolStripMenuItem.Name = "sumárioToolStripMenuItem";
            resources.ApplyResources(sumárioToolStripMenuItem, "sumárioToolStripMenuItem");
            sumárioToolStripMenuItem.Click += sumárioToolStripMenuItem_Click;
            // 
            // índiceToolStripMenuItem
            // 
            índiceToolStripMenuItem.Image = Properties.Resources.agile;
            índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            resources.ApplyResources(índiceToolStripMenuItem, "índiceToolStripMenuItem");
            índiceToolStripMenuItem.Click += índiceToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(toolStripSeparator5, "toolStripSeparator5");
            // 
            // sobreToolStripMenuItem1
            // 
            sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            resources.ApplyResources(sobreToolStripMenuItem1, "sobreToolStripMenuItem1");
            sobreToolStripMenuItem1.Click += sobreToolStripMenuItem1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnCopy);
            groupBox1.Controls.Add(btnClear);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblLastPassword);
            groupBox2.Cursor = Cursors.No;
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // lblLastPassword
            // 
            lblLastPassword.AutoEllipsis = true;
            resources.ApplyResources(lblLastPassword, "lblLastPassword");
            lblLastPassword.BackColor = SystemColors.Window;
            lblLastPassword.ForeColor = SystemColors.Desktop;
            lblLastPassword.Name = "lblLastPassword";
            // 
            // btnCopy
            // 
            btnCopy.Cursor = Cursors.Hand;
            resources.ApplyResources(btnCopy, "btnCopy");
            btnCopy.Name = "btnCopy";
            btnCopy.TabStop = false;
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            resources.ApplyResources(btnClear, "btnClear");
            btnClear.Name = "btnClear";
            btnClear.TabStop = false;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // metroLabel1
            // 
            resources.ApplyResources(metroLabel1, "metroLabel1");
            metroLabel1.Name = "metroLabel1";
            // 
            // FormUi
            // 
            AcceptButton = btnStart;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(255, 255, 255);
            BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            CancelButton = btnExit;
            ControlBox = false;
            Controls.Add(metroLabel1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtPasswordLength);
            Controls.Add(btnStart);
            Controls.Add(btnExit);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormUi";
            Resizable = false;
            ShowIcon = false;
            Style = MetroFramework.MetroColorStyle.Purple;
            Theme = MetroFramework.MetroThemeStyle.Default;
            TransparencyKey = Color.Empty;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnStart;
        private TextBox txtPasswordLength;
        private Label label1;
        private MenuStrip menuStrip1;
        private GroupBox groupBox1;
        private Label lblLastPassword;
        private Button btnClear;
        private Button btnCopy;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem1;
        private ToolStripMenuItem sumárioToolStripMenuItem;
        private ToolStripMenuItem índiceToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem sobreToolStripMenuItem1;
        private GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}