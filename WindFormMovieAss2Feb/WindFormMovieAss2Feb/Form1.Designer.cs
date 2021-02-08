
namespace WindFormMovieAss2Feb
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbMovieDetails = new System.Windows.Forms.TabPage();
            this.tbShowMovie = new System.Windows.Forms.TabPage();
            this.tbUpdateMovie = new System.Windows.Forms.TabPage();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.lblTicketsSold = new System.Windows.Forms.Label();
            this.btnShowMovie = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowAllMovies = new System.Windows.Forms.Button();
            this.lblUMovieId = new System.Windows.Forms.Label();
            this.txtUMovieId = new System.Windows.Forms.TextBox();
            this.lblUMovieName = new System.Windows.Forms.Label();
            this.lblUActor = new System.Windows.Forms.Label();
            this.lblUTickets = new System.Windows.Forms.Label();
            this.txtUMovieName = new System.Windows.Forms.TextBox();
            this.txtUActor = new System.Windows.Forms.TextBox();
            this.txtUTickets = new System.Windows.Forms.TextBox();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btShowOnlyMovie = new System.Windows.Forms.Button();
            this.lblMovieNameOnly = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbMovieDetails.SuspendLayout();
            this.tbShowMovie.SuspendLayout();
            this.tbUpdateMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbMovieDetails);
            this.tabControl1.Controls.Add(this.tbShowMovie);
            this.tabControl1.Controls.Add(this.tbUpdateMovie);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tbMovieDetails
            // 
            this.tbMovieDetails.Controls.Add(this.lblMovieNameOnly);
            this.tbMovieDetails.Controls.Add(this.btShowOnlyMovie);
            this.tbMovieDetails.Controls.Add(this.btnShowMovie);
            this.tbMovieDetails.Controls.Add(this.lblTicketsSold);
            this.tbMovieDetails.Controls.Add(this.lblActor);
            this.tbMovieDetails.Controls.Add(this.lblMovieName);
            this.tbMovieDetails.Controls.Add(this.txtMovieId);
            this.tbMovieDetails.Controls.Add(this.lblMovieId);
            this.tbMovieDetails.Location = new System.Drawing.Point(4, 25);
            this.tbMovieDetails.Name = "tbMovieDetails";
            this.tbMovieDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbMovieDetails.Size = new System.Drawing.Size(510, 393);
            this.tbMovieDetails.TabIndex = 0;
            this.tbMovieDetails.Text = "Movie Details";
            this.tbMovieDetails.UseVisualStyleBackColor = true;
            this.tbMovieDetails.Click += new System.EventHandler(this.tbMovieDetails_Click);
            // 
            // tbShowMovie
            // 
            this.tbShowMovie.Controls.Add(this.btnShowAllMovies);
            this.tbShowMovie.Controls.Add(this.dataGridView1);
            this.tbShowMovie.Location = new System.Drawing.Point(4, 25);
            this.tbShowMovie.Name = "tbShowMovie";
            this.tbShowMovie.Padding = new System.Windows.Forms.Padding(3);
            this.tbShowMovie.Size = new System.Drawing.Size(510, 393);
            this.tbShowMovie.TabIndex = 1;
            this.tbShowMovie.Text = "Show Movies";
            this.tbShowMovie.UseVisualStyleBackColor = true;
            this.tbShowMovie.Click += new System.EventHandler(this.tbShowMovie_Click);
            // 
            // tbUpdateMovie
            // 
            this.tbUpdateMovie.Controls.Add(this.btnUpdateMovie);
            this.tbUpdateMovie.Controls.Add(this.txtUTickets);
            this.tbUpdateMovie.Controls.Add(this.txtUActor);
            this.tbUpdateMovie.Controls.Add(this.txtUMovieName);
            this.tbUpdateMovie.Controls.Add(this.lblUTickets);
            this.tbUpdateMovie.Controls.Add(this.lblUActor);
            this.tbUpdateMovie.Controls.Add(this.lblUMovieName);
            this.tbUpdateMovie.Controls.Add(this.txtUMovieId);
            this.tbUpdateMovie.Controls.Add(this.lblUMovieId);
            this.tbUpdateMovie.Location = new System.Drawing.Point(4, 25);
            this.tbUpdateMovie.Name = "tbUpdateMovie";
            this.tbUpdateMovie.Size = new System.Drawing.Size(510, 393);
            this.tbUpdateMovie.TabIndex = 2;
            this.tbUpdateMovie.Text = "Upadate Movie";
            this.tbUpdateMovie.UseVisualStyleBackColor = true;
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Location = new System.Drawing.Point(38, 43);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(100, 17);
            this.lblMovieId.TabIndex = 0;
            this.lblMovieId.Text = "Enter Movie ID";
            this.lblMovieId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMovieId
            // 
            this.txtMovieId.Location = new System.Drawing.Point(166, 38);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(100, 22);
            this.txtMovieId.TabIndex = 1;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(55, 93);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(0, 17);
            this.lblMovieName.TabIndex = 2;
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Location = new System.Drawing.Point(55, 145);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(0, 17);
            this.lblActor.TabIndex = 3;
            // 
            // lblTicketsSold
            // 
            this.lblTicketsSold.AutoSize = true;
            this.lblTicketsSold.Location = new System.Drawing.Point(55, 203);
            this.lblTicketsSold.Name = "lblTicketsSold";
            this.lblTicketsSold.Size = new System.Drawing.Size(0, 17);
            this.lblTicketsSold.TabIndex = 4;
            // 
            // btnShowMovie
            // 
            this.btnShowMovie.Location = new System.Drawing.Point(213, 66);
            this.btnShowMovie.Name = "btnShowMovie";
            this.btnShowMovie.Size = new System.Drawing.Size(117, 30);
            this.btnShowMovie.TabIndex = 5;
            this.btnShowMovie.Text = "Show Movie";
            this.btnShowMovie.UseVisualStyleBackColor = true;
            this.btnShowMovie.Click += new System.EventHandler(this.btnShowMovie_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(381, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnShowAllMovies
            // 
            this.btnShowAllMovies.Location = new System.Drawing.Point(49, 24);
            this.btnShowAllMovies.Name = "btnShowAllMovies";
            this.btnShowAllMovies.Size = new System.Drawing.Size(120, 28);
            this.btnShowAllMovies.TabIndex = 1;
            this.btnShowAllMovies.Text = "ShowAllMovies";
            this.btnShowAllMovies.UseVisualStyleBackColor = true;
            this.btnShowAllMovies.Click += new System.EventHandler(this.btnShowAllMovies_Click);
            // 
            // lblUMovieId
            // 
            this.lblUMovieId.AutoSize = true;
            this.lblUMovieId.Location = new System.Drawing.Point(85, 35);
            this.lblUMovieId.Name = "lblUMovieId";
            this.lblUMovieId.Size = new System.Drawing.Size(56, 17);
            this.lblUMovieId.TabIndex = 0;
            this.lblUMovieId.Text = "MovieId";
            // 
            // txtUMovieId
            // 
            this.txtUMovieId.Location = new System.Drawing.Point(199, 29);
            this.txtUMovieId.Name = "txtUMovieId";
            this.txtUMovieId.Size = new System.Drawing.Size(100, 22);
            this.txtUMovieId.TabIndex = 1;
            // 
            // lblUMovieName
            // 
            this.lblUMovieName.AutoSize = true;
            this.lblUMovieName.Location = new System.Drawing.Point(85, 92);
            this.lblUMovieName.Name = "lblUMovieName";
            this.lblUMovieName.Size = new System.Drawing.Size(82, 17);
            this.lblUMovieName.TabIndex = 2;
            this.lblUMovieName.Text = "MovieName";
            // 
            // lblUActor
            // 
            this.lblUActor.AutoSize = true;
            this.lblUActor.Location = new System.Drawing.Point(85, 157);
            this.lblUActor.Name = "lblUActor";
            this.lblUActor.Size = new System.Drawing.Size(41, 17);
            this.lblUActor.TabIndex = 3;
            this.lblUActor.Text = "Actor";
            // 
            // lblUTickets
            // 
            this.lblUTickets.AutoSize = true;
            this.lblUTickets.Location = new System.Drawing.Point(85, 229);
            this.lblUTickets.Name = "lblUTickets";
            this.lblUTickets.Size = new System.Drawing.Size(53, 17);
            this.lblUTickets.TabIndex = 4;
            this.lblUTickets.Text = "Tickets";
            // 
            // txtUMovieName
            // 
            this.txtUMovieName.Location = new System.Drawing.Point(199, 89);
            this.txtUMovieName.Name = "txtUMovieName";
            this.txtUMovieName.Size = new System.Drawing.Size(100, 22);
            this.txtUMovieName.TabIndex = 5;
            // 
            // txtUActor
            // 
            this.txtUActor.Location = new System.Drawing.Point(198, 151);
            this.txtUActor.Name = "txtUActor";
            this.txtUActor.Size = new System.Drawing.Size(100, 22);
            this.txtUActor.TabIndex = 6;
            // 
            // txtUTickets
            // 
            this.txtUTickets.Location = new System.Drawing.Point(198, 226);
            this.txtUTickets.Name = "txtUTickets";
            this.txtUTickets.Size = new System.Drawing.Size(100, 22);
            this.txtUTickets.TabIndex = 7;
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(126, 276);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(141, 38);
            this.btnUpdateMovie.TabIndex = 8;
            this.btnUpdateMovie.Text = "Update";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btShowOnlyMovie
            // 
            this.btShowOnlyMovie.Location = new System.Drawing.Point(61, 72);
            this.btShowOnlyMovie.Name = "btShowOnlyMovie";
            this.btShowOnlyMovie.Size = new System.Drawing.Size(140, 24);
            this.btShowOnlyMovie.TabIndex = 6;
            this.btShowOnlyMovie.Text = "ShowMovieName";
            this.btShowOnlyMovie.UseVisualStyleBackColor = true;
            this.btShowOnlyMovie.Click += new System.EventHandler(this.btShowOnlyMovie_Click);
            // 
            // lblMovieNameOnly
            // 
            this.lblMovieNameOnly.AutoSize = true;
            this.lblMovieNameOnly.Location = new System.Drawing.Point(279, 125);
            this.lblMovieNameOnly.Name = "lblMovieNameOnly";
            this.lblMovieNameOnly.Size = new System.Drawing.Size(0, 17);
            this.lblMovieNameOnly.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tbMovieDetails.ResumeLayout(false);
            this.tbMovieDetails.PerformLayout();
            this.tbShowMovie.ResumeLayout(false);
            this.tbUpdateMovie.ResumeLayout(false);
            this.tbUpdateMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbMovieDetails;
        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.TabPage tbShowMovie;
        private System.Windows.Forms.TabPage tbUpdateMovie;
        private System.Windows.Forms.Label lblTicketsSold;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.Button btnShowMovie;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowAllMovies;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.TextBox txtUTickets;
        private System.Windows.Forms.TextBox txtUActor;
        private System.Windows.Forms.TextBox txtUMovieName;
        private System.Windows.Forms.Label lblUTickets;
        private System.Windows.Forms.Label lblUActor;
        private System.Windows.Forms.Label lblUMovieName;
        private System.Windows.Forms.TextBox txtUMovieId;
        private System.Windows.Forms.Label lblUMovieId;
        private System.Windows.Forms.Button btShowOnlyMovie;
        private System.Windows.Forms.Label lblMovieNameOnly;
    }
}

