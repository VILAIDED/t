
namespace Calculator
{
    partial class DoHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DoHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "DoHoa";
            this.Text = "DoHoa";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DoHoa_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DoHoa_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DoHoa_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}