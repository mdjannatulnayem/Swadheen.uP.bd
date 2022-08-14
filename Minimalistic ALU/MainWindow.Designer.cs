
namespace Minimalistic_ALU
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.bg = new System.Windows.Forms.PictureBox();
            this.exec = new System.Windows.Forms.Button();
            this.cmp_a1 = new System.Windows.Forms.Button();
            this.cmp_a0 = new System.Windows.Forms.Button();
            this.cmp_b1 = new System.Windows.Forms.Button();
            this.cmp_b0 = new System.Windows.Forms.Button();
            this._bone = new System.Windows.Forms.Button();
            this._bnot = new System.Windows.Forms.Button();
            this._anot = new System.Windows.Forms.Button();
            this._aone = new System.Windows.Forms.Button();
            this.____opcode = new System.Windows.Forms.ComboBox();
            this.opp_l = new System.Windows.Forms.Label();
            this._port = new System.Windows.Forms.TextBox();
            this.port_l = new System.Windows.Forms.Label();
            this.conn = new System.Windows.Forms.Button();
            this.connStatus = new System.Windows.Forms.Label();
            this.___h1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ASL = new System.Windows.Forms.Label();
            this.@__yr = new System.Windows.Forms.Label();
            this._event = new System.Windows.Forms.Label();
            this.showResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bg)).BeginInit();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg.Image = ((System.Drawing.Image)(resources.GetObject("bg.Image")));
            this.bg.Location = new System.Drawing.Point(0, 0);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(798, 494);
            this.bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg.TabIndex = 0;
            this.bg.TabStop = false;
            // 
            // exec
            // 
            this.exec.BackColor = System.Drawing.Color.DodgerBlue;
            this.exec.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exec.ForeColor = System.Drawing.Color.White;
            this.exec.Location = new System.Drawing.Point(300, 350);
            this.exec.Name = "exec";
            this.exec.Size = new System.Drawing.Size(200, 50);
            this.exec.TabIndex = 1;
            this.exec.Text = "Execute";
            this.exec.UseVisualStyleBackColor = false;
            this.exec.Click += new System.EventHandler(this.exec_Click);
            // 
            // cmp_a1
            // 
            this.cmp_a1.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmp_a1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmp_a1.ForeColor = System.Drawing.Color.White;
            this.cmp_a1.Location = new System.Drawing.Point(122, 215);
            this.cmp_a1.Name = "cmp_a1";
            this.cmp_a1.Size = new System.Drawing.Size(102, 23);
            this.cmp_a1.TabIndex = 7;
            this.cmp_a1.Text = "^";
            this.cmp_a1.UseVisualStyleBackColor = false;
            this.cmp_a1.Click += new System.EventHandler(this.cmp_a1_Click);
            // 
            // cmp_a0
            // 
            this.cmp_a0.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmp_a0.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmp_a0.ForeColor = System.Drawing.Color.White;
            this.cmp_a0.Location = new System.Drawing.Point(224, 215);
            this.cmp_a0.Name = "cmp_a0";
            this.cmp_a0.Size = new System.Drawing.Size(102, 23);
            this.cmp_a0.TabIndex = 9;
            this.cmp_a0.Text = "^";
            this.cmp_a0.UseVisualStyleBackColor = false;
            this.cmp_a0.Click += new System.EventHandler(this.cmp_a0_Click);
            // 
            // cmp_b1
            // 
            this.cmp_b1.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmp_b1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmp_b1.ForeColor = System.Drawing.Color.White;
            this.cmp_b1.Location = new System.Drawing.Point(474, 215);
            this.cmp_b1.Name = "cmp_b1";
            this.cmp_b1.Size = new System.Drawing.Size(102, 23);
            this.cmp_b1.TabIndex = 11;
            this.cmp_b1.Text = "^";
            this.cmp_b1.UseVisualStyleBackColor = false;
            this.cmp_b1.Click += new System.EventHandler(this.cmp_b1_Click);
            // 
            // cmp_b0
            // 
            this.cmp_b0.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmp_b0.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmp_b0.ForeColor = System.Drawing.Color.White;
            this.cmp_b0.Location = new System.Drawing.Point(576, 215);
            this.cmp_b0.Name = "cmp_b0";
            this.cmp_b0.Size = new System.Drawing.Size(102, 23);
            this.cmp_b0.TabIndex = 13;
            this.cmp_b0.Text = "^";
            this.cmp_b0.UseVisualStyleBackColor = false;
            this.cmp_b0.Click += new System.EventHandler(this.cmp_b0_Click);
            // 
            // _bone
            // 
            this._bone.Enabled = false;
            this._bone.Font = new System.Drawing.Font("Bahnschrift", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._bone.Location = new System.Drawing.Point(474, 62);
            this._bone.Name = "_bone";
            this._bone.Size = new System.Drawing.Size(102, 150);
            this._bone.TabIndex = 14;
            this._bone.Text = "0";
            this._bone.UseVisualStyleBackColor = true;
            // 
            // _bnot
            // 
            this._bnot.Enabled = false;
            this._bnot.Font = new System.Drawing.Font("Bahnschrift", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._bnot.Location = new System.Drawing.Point(576, 62);
            this._bnot.Name = "_bnot";
            this._bnot.Size = new System.Drawing.Size(102, 150);
            this._bnot.TabIndex = 15;
            this._bnot.Text = "0";
            this._bnot.UseVisualStyleBackColor = true;
            // 
            // _anot
            // 
            this._anot.Enabled = false;
            this._anot.Font = new System.Drawing.Font("Bahnschrift", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._anot.Location = new System.Drawing.Point(224, 62);
            this._anot.Name = "_anot";
            this._anot.Size = new System.Drawing.Size(102, 150);
            this._anot.TabIndex = 16;
            this._anot.Text = "0";
            this._anot.UseVisualStyleBackColor = true;
            // 
            // _aone
            // 
            this._aone.Enabled = false;
            this._aone.Font = new System.Drawing.Font("Bahnschrift", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._aone.Location = new System.Drawing.Point(122, 62);
            this._aone.Name = "_aone";
            this._aone.Size = new System.Drawing.Size(102, 150);
            this._aone.TabIndex = 17;
            this._aone.Text = "0";
            this._aone.UseVisualStyleBackColor = true;
            // 
            // ____opcode
            // 
            this.____opcode.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.____opcode.FormattingEnabled = true;
            this.____opcode.Items.AddRange(new object[] {
            "NOT",
            "OR",
            "AND",
            "ADD",
            "SUB"});
            this.____opcode.Location = new System.Drawing.Point(353, 125);
            this.____opcode.Name = "____opcode";
            this.____opcode.Size = new System.Drawing.Size(100, 22);
            this.____opcode.TabIndex = 18;
            // 
            // opp_l
            // 
            this.opp_l.AutoSize = true;
            this.opp_l.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opp_l.Location = new System.Drawing.Point(350, 101);
            this.opp_l.Name = "opp_l";
            this.opp_l.Size = new System.Drawing.Size(105, 19);
            this.opp_l.TabIndex = 19;
            this.opp_l.Text = "Operation ???";
            // 
            // _port
            // 
            this._port.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._port.Location = new System.Drawing.Point(355, 252);
            this._port.Name = "_port";
            this._port.Size = new System.Drawing.Size(100, 22);
            this._port.TabIndex = 20;
            // 
            // port_l
            // 
            this.port_l.AutoSize = true;
            this.port_l.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.port_l.Location = new System.Drawing.Point(355, 230);
            this.port_l.Name = "port_l";
            this.port_l.Size = new System.Drawing.Size(100, 19);
            this.port_l.TabIndex = 21;
            this.port_l.Text = "COM port ???";
            // 
            // conn
            // 
            this.conn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conn.Location = new System.Drawing.Point(365, 280);
            this.conn.Name = "conn";
            this.conn.Size = new System.Drawing.Size(80, 30);
            this.conn.TabIndex = 22;
            this.conn.Text = "Connect";
            this.conn.UseVisualStyleBackColor = true;
            this.conn.Click += new System.EventHandler(this.conn_Click);
            // 
            // connStatus
            // 
            this.connStatus.AutoSize = true;
            this.connStatus.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connStatus.ForeColor = System.Drawing.Color.Red;
            this.connStatus.Location = new System.Drawing.Point(350, 313);
            this.connStatus.Name = "connStatus";
            this.connStatus.Size = new System.Drawing.Size(111, 19);
            this.connStatus.TabIndex = 23;
            this.connStatus.Text = "Disconnected!";
            // 
            // ___h1
            // 
            this.___h1.AutoSize = true;
            this.___h1.BackColor = System.Drawing.Color.White;
            this.___h1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.___h1.ForeColor = System.Drawing.Color.Black;
            this.___h1.Location = new System.Drawing.Point(277, 9);
            this.___h1.Name = "___h1";
            this.___h1.Size = new System.Drawing.Size(256, 39);
            this.___h1.TabIndex = 24;
            this.___h1.Text = "Minimalistic ALU";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ASL
            // 
            this.ASL.AutoSize = true;
            this.ASL.BackColor = System.Drawing.Color.White;
            this.ASL.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ASL.Location = new System.Drawing.Point(711, 434);
            this.ASL.Name = "ASL";
            this.ASL.Size = new System.Drawing.Size(75, 39);
            this.ASL.TabIndex = 27;
            this.ASL.Text = "ASL";
            // 
            // __yr
            // 
            this.@__yr.AutoSize = true;
            this.@__yr.BackColor = System.Drawing.Color.White;
            this.@__yr.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.@__yr.Location = new System.Drawing.Point(12, 446);
            this.@__yr.Name = "__yr";
            this.@__yr.Size = new System.Drawing.Size(86, 39);
            this.@__yr.TabIndex = 26;
            this.@__yr.Text = "2022";
            // 
            // _event
            // 
            this._event.AutoSize = true;
            this._event.BackColor = System.Drawing.Color.White;
            this._event.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._event.Location = new System.Drawing.Point(16, 425);
            this._event.Name = "_event";
            this._event.Size = new System.Drawing.Size(77, 19);
            this._event.TabIndex = 25;
            this._event.Text = "BRAINIAC";
            // 
            // showResult
            // 
            this.showResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.showResult.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showResult.ForeColor = System.Drawing.Color.White;
            this.showResult.Location = new System.Drawing.Point(300, 406);
            this.showResult.Name = "showResult";
            this.showResult.Size = new System.Drawing.Size(200, 50);
            this.showResult.TabIndex = 28;
            this.showResult.Text = "Show result";
            this.showResult.UseVisualStyleBackColor = false;
            this.showResult.Click += new System.EventHandler(this.showResult_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 494);
            this.Controls.Add(this.showResult);
            this.Controls.Add(this.ASL);
            this.Controls.Add(this.@__yr);
            this.Controls.Add(this._event);
            this.Controls.Add(this.___h1);
            this.Controls.Add(this.connStatus);
            this.Controls.Add(this.conn);
            this.Controls.Add(this.port_l);
            this.Controls.Add(this._port);
            this.Controls.Add(this.opp_l);
            this.Controls.Add(this.____opcode);
            this.Controls.Add(this._aone);
            this.Controls.Add(this._anot);
            this.Controls.Add(this._bnot);
            this.Controls.Add(this._bone);
            this.Controls.Add(this.cmp_b0);
            this.Controls.Add(this.cmp_b1);
            this.Controls.Add(this.cmp_a0);
            this.Controls.Add(this.cmp_a1);
            this.Controls.Add(this.exec);
            this.Controls.Add(this.bg);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command panel - Minimalistic ALU ~ version 1.0.0";
            ((System.ComponentModel.ISupportInitialize)(this.bg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg;
        private System.Windows.Forms.Button exec;
        private System.Windows.Forms.Button cmp_a1;
        private System.Windows.Forms.Button cmp_a0;
        private System.Windows.Forms.Button cmp_b1;
        private System.Windows.Forms.Button cmp_b0;
        private System.Windows.Forms.Button _bone;
        private System.Windows.Forms.Button _bnot;
        private System.Windows.Forms.Button _anot;
        private System.Windows.Forms.Button _aone;
        private System.Windows.Forms.ComboBox ____opcode;
        private System.Windows.Forms.Label opp_l;
        private System.Windows.Forms.TextBox _port;
        private System.Windows.Forms.Label port_l;
        private System.Windows.Forms.Button conn;
        private System.Windows.Forms.Label connStatus;
        private System.Windows.Forms.Label ___h1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label ASL;
        private System.Windows.Forms.Label __yr;
        private System.Windows.Forms.Label _event;
        private System.Windows.Forms.Button showResult;
    }
}

