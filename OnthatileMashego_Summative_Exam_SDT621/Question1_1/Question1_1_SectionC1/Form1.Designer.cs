namespace Question1_1_SectionC1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ── lblOutput ──────────────────────────────────────────
            this.lblOutput.AutoSize = false;
            this.lblOutput.Location = new System.Drawing.Point(12, 15);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(360, 24);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "";
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 9.5f,
                                           System.Drawing.FontStyle.Bold);
            this.lblOutput.ForeColor = System.Drawing.Color.DarkGreen;

            // ── Mobile Code label + textbox ────────────────────────
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(12, 55);
            this.lblCode.Name = "lblCode";
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Mobile Code";

            this.txtCode.Location = new System.Drawing.Point(110, 52);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 23);
            this.txtCode.TabIndex = 2;

            // ── Make label + textbox ───────────────────────────────
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(12, 92);
            this.lblMake.Name = "lblMake";
            this.lblMake.TabIndex = 3;
            this.lblMake.Text = "Make";

            this.txtMake.Location = new System.Drawing.Point(110, 89);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(200, 23);
            this.txtMake.TabIndex = 4;

            // ── Quantity label + textbox ───────────────────────────
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 129);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";

            this.txtQuantity.Location = new System.Drawing.Point(110, 126);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 23);
            this.txtQuantity.TabIndex = 6;

            // ── Buttons ────────────────────────────────────────────
            this.btnAdd.Location = new System.Drawing.Point(12, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnDelete.Location = new System.Drawing.Point(115, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnFind.Location = new System.Drawing.Point(218, 170);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(90, 30);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);

            // ── Form ───────────────────────────────────────────────
            this.ClientSize = new System.Drawing.Size(400, 225);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblOutput,
                this.lblCode,   this.txtCode,
                this.lblMake,   this.txtMake,
                this.lblQuantity, this.txtQuantity,
                this.btnAdd,    this.btnDelete,    this.btnFind
            });
            this.Name = "Form1";
            this.Text = "Mobile Stock Capture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ── Control declarations ───────────────────────────────────
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
    }
}