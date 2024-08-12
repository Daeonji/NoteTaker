namespace NoteTaker
{
    partial class NoteTaker
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prevNotes = new System.Windows.Forms.DataGridView();
            this.loadBttn = new System.Windows.Forms.Button();
            this.delBttn = new System.Windows.Forms.Button();
            this.newBttn = new System.Windows.Forms.Button();
            this.saveBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prevNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(368, 25);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(420, 20);
            this.titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(368, 69);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(420, 376);
            this.noteBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(368, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note:";
            // 
            // prevNotes
            // 
            this.prevNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prevNotes.BackgroundColor = System.Drawing.Color.White;
            this.prevNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prevNotes.Location = new System.Drawing.Point(2, 9);
            this.prevNotes.Name = "prevNotes";
            this.prevNotes.Size = new System.Drawing.Size(348, 340);
            this.prevNotes.TabIndex = 4;
            this.prevNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prevNotes_CellContentClick);
            this.prevNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prevNotes_CellDoubleClick);
            // 
            // loadBttn
            // 
            this.loadBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBttn.Location = new System.Drawing.Point(2, 355);
            this.loadBttn.Name = "loadBttn";
            this.loadBttn.Size = new System.Drawing.Size(171, 42);
            this.loadBttn.TabIndex = 5;
            this.loadBttn.Text = "Load";
            this.loadBttn.UseVisualStyleBackColor = true;
            this.loadBttn.Click += new System.EventHandler(this.loadBttn_Click);
            // 
            // delBttn
            // 
            this.delBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBttn.Location = new System.Drawing.Point(179, 355);
            this.delBttn.Name = "delBttn";
            this.delBttn.Size = new System.Drawing.Size(171, 42);
            this.delBttn.TabIndex = 6;
            this.delBttn.Text = "Delete";
            this.delBttn.UseVisualStyleBackColor = true;
            this.delBttn.Click += new System.EventHandler(this.delBttn_Click);
            // 
            // newBttn
            // 
            this.newBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBttn.Location = new System.Drawing.Point(2, 403);
            this.newBttn.Name = "newBttn";
            this.newBttn.Size = new System.Drawing.Size(171, 42);
            this.newBttn.TabIndex = 7;
            this.newBttn.Text = "New";
            this.newBttn.UseVisualStyleBackColor = true;
            this.newBttn.Click += new System.EventHandler(this.newBttn_Click);
            // 
            // saveBttn
            // 
            this.saveBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBttn.Location = new System.Drawing.Point(179, 403);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(171, 42);
            this.saveBttn.TabIndex = 8;
            this.saveBttn.Text = "Save";
            this.saveBttn.UseVisualStyleBackColor = true;
            this.saveBttn.Click += new System.EventHandler(this.saveBttn_Click);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBttn);
            this.Controls.Add(this.newBttn);
            this.Controls.Add(this.delBttn);
            this.Controls.Add(this.loadBttn);
            this.Controls.Add(this.prevNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.titleBox);
            this.Name = "NoteTaker";
            this.Text = "NoteTaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prevNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView prevNotes;
        private System.Windows.Forms.Button loadBttn;
        private System.Windows.Forms.Button delBttn;
        private System.Windows.Forms.Button newBttn;
        private System.Windows.Forms.Button saveBttn;
    }
}

