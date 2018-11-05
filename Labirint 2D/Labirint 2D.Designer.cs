namespace Labirint_2D
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.button_start = new System.Windows.Forms.Button();
            this.butten_exit = new System.Windows.Forms.Button();
            this.box_sound = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(383, 341);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(108, 29);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start game";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // butten_exit
            // 
            this.butten_exit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butten_exit.Location = new System.Drawing.Point(12, 68);
            this.butten_exit.Name = "butten_exit";
            this.butten_exit.Size = new System.Drawing.Size(108, 29);
            this.butten_exit.TabIndex = 1;
            this.butten_exit.Text = "Exit";
            this.butten_exit.UseVisualStyleBackColor = true;
            this.butten_exit.Click += new System.EventHandler(this.butten_exit_Click);
            // 
            // box_sound
            // 
            this.box_sound.AutoSize = true;
            this.box_sound.BackColor = System.Drawing.Color.Transparent;
            this.box_sound.Checked = true;
            this.box_sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_sound.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_sound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.box_sound.Location = new System.Drawing.Point(12, 341);
            this.box_sound.Name = "box_sound";
            this.box_sound.Size = new System.Drawing.Size(79, 17);
            this.box_sound.TabIndex = 2;
            this.box_sound.Text = "Sound off";
            this.box_sound.UseVisualStyleBackColor = false;
            this.box_sound.CheckedChanged += new System.EventHandler(this.box_sound_CheckedChanged);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirint_2D.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(532, 410);
            this.Controls.Add(this.box_sound);
            this.Controls.Add(this.butten_exit);
            this.Controls.Add(this.button_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Labirint 2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button butten_exit;
        private System.Windows.Forms.CheckBox box_sound;
    }
}

