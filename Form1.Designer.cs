
namespace GmapGenerator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblPrefix = new Label();
            txtPrefix = new TextBox();
            lblWidth = new Label();
            txtWidth = new TextBox();
            lblHeight = new Label();
            txtHeight = new TextBox();
            lblCenterX = new Label();
            txtCenterX = new TextBox();
            lblCenterY = new Label();
            txtCenterY = new TextBox();
            chkAddLinks = new CheckBox();
            btnGenerate = new Button();
            lblOutput = new Label();
            lblCredits = new Label();
            SuspendLayout();
            // 
            // lblPrefix
            // 
            lblPrefix.AutoSize = true;
            lblPrefix.ForeColor = Color.White;
            lblPrefix.Location = new Point(95, 22);
            lblPrefix.Margin = new Padding(4, 0, 4, 0);
            lblPrefix.Name = "lblPrefix";
            lblPrefix.Size = new Size(59, 25);
            lblPrefix.TabIndex = 0;
            lblPrefix.Text = "Prefix:";
            // 
            // txtPrefix
            // 
            txtPrefix.BackColor = Color.FromArgb(50, 50, 50);
            txtPrefix.ForeColor = Color.White;
            txtPrefix.Location = new Point(192, 19);
            txtPrefix.Margin = new Padding(4, 5, 4, 5);
            txtPrefix.Name = "txtPrefix";
            txtPrefix.Size = new Size(137, 31);
            txtPrefix.TabIndex = 1;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.ForeColor = Color.White;
            lblWidth.Location = new Point(95, 72);
            lblWidth.Margin = new Padding(4, 0, 4, 0);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(64, 25);
            lblWidth.TabIndex = 2;
            lblWidth.Text = "Width:";
            // 
            // txtWidth
            // 
            txtWidth.BackColor = Color.FromArgb(50, 50, 50);
            txtWidth.ForeColor = Color.White;
            txtWidth.Location = new Point(192, 69);
            txtWidth.Margin = new Padding(4, 5, 4, 5);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(137, 31);
            txtWidth.TabIndex = 3;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.ForeColor = Color.White;
            lblHeight.Location = new Point(95, 122);
            lblHeight.Margin = new Padding(4, 0, 4, 0);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(69, 25);
            lblHeight.TabIndex = 4;
            lblHeight.Text = "Height:";
            // 
            // txtHeight
            // 
            txtHeight.BackColor = Color.FromArgb(50, 50, 50);
            txtHeight.ForeColor = Color.White;
            txtHeight.Location = new Point(192, 122);
            txtHeight.Margin = new Padding(4, 5, 4, 5);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(137, 31);
            txtHeight.TabIndex = 5;
            // 
            // lblCenterX
            // 
            lblCenterX.AutoSize = true;
            lblCenterX.ForeColor = Color.White;
            lblCenterX.Location = new Point(95, 172);
            lblCenterX.Margin = new Padding(4, 0, 4, 0);
            lblCenterX.Name = "lblCenterX";
            lblCenterX.Size = new Size(83, 25);
            lblCenterX.TabIndex = 6;
            lblCenterX.Text = "Center X:";
            // 
            // txtCenterX
            // 
            txtCenterX.BackColor = Color.FromArgb(50, 50, 50);
            txtCenterX.ForeColor = Color.White;
            txtCenterX.Location = new Point(192, 167);
            txtCenterX.Margin = new Padding(4, 5, 4, 5);
            txtCenterX.Name = "txtCenterX";
            txtCenterX.Size = new Size(137, 31);
            txtCenterX.TabIndex = 7;
            // 
            // lblCenterY
            // 
            lblCenterY.AutoSize = true;
            lblCenterY.ForeColor = Color.White;
            lblCenterY.Location = new Point(95, 222);
            lblCenterY.Margin = new Padding(4, 0, 4, 0);
            lblCenterY.Name = "lblCenterY";
            lblCenterY.Size = new Size(82, 25);
            lblCenterY.TabIndex = 8;
            lblCenterY.Text = "Center Y:";
            // 
            // txtCenterY
            // 
            txtCenterY.BackColor = Color.FromArgb(50, 50, 50);
            txtCenterY.ForeColor = Color.White;
            txtCenterY.Location = new Point(192, 217);
            txtCenterY.Margin = new Padding(4, 5, 4, 5);
            txtCenterY.Name = "txtCenterY";
            txtCenterY.Size = new Size(137, 31);
            txtCenterY.TabIndex = 9;
            // 
            // chkAddLinks
            // 
            chkAddLinks.AutoSize = true;
            chkAddLinks.ForeColor = Color.White;
            chkAddLinks.Location = new Point(133, 271);
            chkAddLinks.Margin = new Padding(4, 5, 4, 5);
            chkAddLinks.Name = "chkAddLinks";
            chkAddLinks.Size = new Size(152, 29);
            chkAddLinks.TabIndex = 10;
            chkAddLinks.Text = "Add level links";
            chkAddLinks.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(70, 70, 70);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(152, 355);
            btnGenerate.Margin = new Padding(4, 5, 4, 5);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(107, 38);
            btnGenerate.TabIndex = 11;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblOutput
            // 
            lblOutput.ForeColor = Color.White;
            lblOutput.Location = new Point(27, 305);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(373, 37);
            lblOutput.TabIndex = 12;
            lblOutput.Text = "Click 'Generate' to create your Gmap!";
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCredits
            // 
            lblCredits.AutoSize = true;
            lblCredits.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Italic);
            lblCredits.ForeColor = Color.White;
            lblCredits.Location = new Point(28, 409);
            lblCredits.Margin = new Padding(4, 0, 4, 0);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(364, 25);
            lblCredits.TabIndex = 13;
            lblCredits.Text = "Concept by Crow, updated by Denveous";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(423, 443);
            Controls.Add(lblCredits);
            Controls.Add(lblOutput);
            Controls.Add(btnGenerate);
            Controls.Add(chkAddLinks);
            Controls.Add(txtCenterY);
            Controls.Add(lblCenterY);
            Controls.Add(txtCenterX);
            Controls.Add(lblCenterX);
            Controls.Add(txtHeight);
            Controls.Add(lblHeight);
            Controls.Add(txtWidth);
            Controls.Add(lblWidth);
            Controls.Add(txtPrefix);
            Controls.Add(lblPrefix);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Gmap Generator";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblCenterX;
        private System.Windows.Forms.TextBox txtCenterX;
        private System.Windows.Forms.Label lblCenterY;
        private System.Windows.Forms.TextBox txtCenterY;
        private System.Windows.Forms.CheckBox chkAddLinks;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblCredits;
    }
}
