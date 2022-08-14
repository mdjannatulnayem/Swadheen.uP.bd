
namespace Minimalistic_ALU
{
    partial class OutputWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputWindow));
            this._rone = new System.Windows.Forms.Button();
            this._cout = new System.Windows.Forms.Button();
            this._rnot = new System.Windows.Forms.Button();
            this.label_Co = new System.Windows.Forms.Label();
            this.label_r0 = new System.Windows.Forms.Label();
            this.label_r1 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _rone
            // 
            this._rone.Enabled = false;
            this._rone.Font = new System.Drawing.Font("Bahnschrift", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._rone.Location = new System.Drawing.Point(141, 99);
            this._rone.Name = "_rone";
            this._rone.Size = new System.Drawing.Size(102, 150);
            this._rone.TabIndex = 15;
            this._rone.Text = "0";
            this._rone.UseVisualStyleBackColor = true;
            // 
            // _cout
            // 
            this._cout.Enabled = false;
            this._cout.Font = new System.Drawing.Font("Bahnschrift", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cout.Location = new System.Drawing.Point(40, 99);
            this._cout.Name = "_cout";
            this._cout.Size = new System.Drawing.Size(102, 150);
            this._cout.TabIndex = 16;
            this._cout.Text = "0";
            this._cout.UseVisualStyleBackColor = true;
            // 
            // _rnot
            // 
            this._rnot.Enabled = false;
            this._rnot.Font = new System.Drawing.Font("Bahnschrift", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._rnot.Location = new System.Drawing.Point(243, 99);
            this._rnot.Name = "_rnot";
            this._rnot.Size = new System.Drawing.Size(102, 150);
            this._rnot.TabIndex = 17;
            this._rnot.Text = "0";
            this._rnot.UseVisualStyleBackColor = true;
            // 
            // label_Co
            // 
            this.label_Co.AutoSize = true;
            this.label_Co.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Co.Location = new System.Drawing.Point(52, 77);
            this.label_Co.Name = "label_Co";
            this.label_Co.Size = new System.Drawing.Size(83, 19);
            this.label_Co.TabIndex = 18;
            this.label_Co.Text = "Carry (Co)";
            // 
            // label_r0
            // 
            this.label_r0.AutoSize = true;
            this.label_r0.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_r0.Location = new System.Drawing.Point(252, 77);
            this.label_r0.Name = "label_r0";
            this.label_r0.Size = new System.Drawing.Size(28, 19);
            this.label_r0.TabIndex = 19;
            this.label_r0.Text = "R0";
            // 
            // label_r1
            // 
            this.label_r1.AutoSize = true;
            this.label_r1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_r1.Location = new System.Drawing.Point(151, 77);
            this.label_r1.Name = "label_r1";
            this.label_r1.Size = new System.Drawing.Size(24, 19);
            this.label_r1.TabIndex = 20;
            this.label_r1.Text = "R1";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_result.Location = new System.Drawing.Point(125, 27);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(146, 29);
            this.label_result.TabIndex = 21;
            this.label_result.Text = ">> Results <<";
            // 
            // OutputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_r1);
            this.Controls.Add(this.label_r0);
            this.Controls.Add(this.label_Co);
            this.Controls.Add(this._rnot);
            this.Controls.Add(this._cout);
            this.Controls.Add(this._rone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OutputWindow";
            this.Text = "Output window - Minimalistic ALU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _rone;
        private System.Windows.Forms.Button _cout;
        private System.Windows.Forms.Button _rnot;
        private System.Windows.Forms.Label label_Co;
        private System.Windows.Forms.Label label_r0;
        private System.Windows.Forms.Label label_r1;
        private System.Windows.Forms.Label label_result;
    }
}