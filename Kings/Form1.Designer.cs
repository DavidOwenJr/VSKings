namespace Kings
{
    
    partial class Kings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kings));
            this.shuffle_deck = new System.Windows.Forms.Button();
            this.curr_card = new System.Windows.Forms.PictureBox();
            this.next_card = new System.Windows.Forms.Button();
            this.prev_card = new System.Windows.Forms.Button();
            this.curr_pos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Rule_Box = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.curr_card)).BeginInit();
            this.SuspendLayout();
            // 
            // shuffle_deck
            // 
            this.shuffle_deck.Location = new System.Drawing.Point(12, 120);
            this.shuffle_deck.Name = "shuffle_deck";
            this.shuffle_deck.Size = new System.Drawing.Size(75, 23);
            this.shuffle_deck.TabIndex = 0;
            this.shuffle_deck.Text = "Shuffle";
            this.shuffle_deck.UseVisualStyleBackColor = true;
            this.shuffle_deck.Click += new System.EventHandler(this.shuffle_deck_Click);
            // 
            // curr_card
            // 
            this.curr_card.Image = global::Kings.Properties.Resources.game_start;
            this.curr_card.Location = new System.Drawing.Point(94, 12);
            this.curr_card.Name = "curr_card";
            this.curr_card.Size = new System.Drawing.Size(168, 270);
            this.curr_card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.curr_card.TabIndex = 1;
            this.curr_card.TabStop = false;
            // 
            // next_card
            // 
            this.next_card.Location = new System.Drawing.Point(13, 149);
            this.next_card.Name = "next_card";
            this.next_card.Size = new System.Drawing.Size(75, 23);
            this.next_card.TabIndex = 2;
            this.next_card.Text = "Next Card";
            this.next_card.UseVisualStyleBackColor = true;
            this.next_card.Click += new System.EventHandler(this.next_card_Click);
            // 
            // prev_card
            // 
            this.prev_card.Enabled = false;
            this.prev_card.Location = new System.Drawing.Point(13, 178);
            this.prev_card.Name = "prev_card";
            this.prev_card.Size = new System.Drawing.Size(75, 23);
            this.prev_card.TabIndex = 3;
            this.prev_card.Text = "Previous";
            this.prev_card.UseVisualStyleBackColor = true;
            this.prev_card.Click += new System.EventHandler(this.prev_card_Click);
            // 
            // curr_pos
            // 
            this.curr_pos.AutoSize = true;
            this.curr_pos.Location = new System.Drawing.Point(10, 291);
            this.curr_pos.Name = "curr_pos";
            this.curr_pos.Size = new System.Drawing.Size(13, 13);
            this.curr_pos.TabIndex = 4;
            this.curr_pos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "LET\'S GET BOMBED!";
            // 
            // Rule_Box
            // 
            this.Rule_Box.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rule_Box.Location = new System.Drawing.Point(269, 12);
            this.Rule_Box.Name = "Rule_Box";
            this.Rule_Box.ReadOnly = true;
            this.Rule_Box.Size = new System.Drawing.Size(287, 292);
            this.Rule_Box.TabIndex = 12;
            this.Rule_Box.Text = "";
            // 
            // Kings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 319);
            this.Controls.Add(this.Rule_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.curr_pos);
            this.Controls.Add(this.prev_card);
            this.Controls.Add(this.next_card);
            this.Controls.Add(this.curr_card);
            this.Controls.Add(this.shuffle_deck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kings";
            this.Text = "Drink Like Kings!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.curr_card)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shuffle_deck;
        private System.Windows.Forms.PictureBox curr_card;
        private System.Windows.Forms.Button next_card;
        private System.Windows.Forms.Button prev_card;
        private System.Windows.Forms.Label curr_pos;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox Rule_Box;
    }
}

