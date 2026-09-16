using Assginment_11._3.Models;

namespace Assginment_11._3
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            dataGridViewGenre = new DataGridView();
            genreIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            genreBindingSource = new BindingSource(components);
            dataGridViewMovies = new DataGridView();
            movieIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            moviesBindingSource = new BindingSource(components);
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonSave = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moviesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGenre
            // 
            dataGridViewGenre.AutoGenerateColumns = false;
            dataGridViewGenre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenre.Columns.AddRange(new DataGridViewColumn[] { genreIdDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1 });
            dataGridViewGenre.DataSource = genreBindingSource;
            dataGridViewGenre.Location = new Point(42, 31);
            dataGridViewGenre.Name = "dataGridViewGenre";
            dataGridViewGenre.RowHeadersWidth = 62;
            dataGridViewGenre.Size = new Size(503, 225);
            dataGridViewGenre.TabIndex = 0;
            dataGridViewGenre.SelectionChanged += dataGridViewGenre_SelectionChanged;
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            genreIdDataGridViewTextBoxColumn.DataPropertyName = "GenreId";
            genreIdDataGridViewTextBoxColumn.HeaderText = "GenreId";
            genreIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            genreIdDataGridViewTextBoxColumn.ReadOnly = true;
            genreIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "GenreName";
            dataGridViewTextBoxColumn1.HeaderText = "GenreName";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // genreBindingSource
            // 
            genreBindingSource.DataSource = typeof(Genre);
            // 
            // dataGridViewMovies
            // 
            dataGridViewMovies.AutoGenerateColumns = false;
            dataGridViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovies.Columns.AddRange(new DataGridViewColumn[] { movieIdDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn });
            dataGridViewMovies.DataSource = moviesBindingSource;
            dataGridViewMovies.Location = new Point(751, 31);
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.RowHeadersWidth = 62;
            dataGridViewMovies.Size = new Size(613, 225);
            dataGridViewMovies.TabIndex = 1;
            // 
            // movieIdDataGridViewTextBoxColumn
            // 
            movieIdDataGridViewTextBoxColumn.DataPropertyName = "MovieId";
            movieIdDataGridViewTextBoxColumn.HeaderText = "MovieId";
            movieIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            movieIdDataGridViewTextBoxColumn.Name = "movieIdDataGridViewTextBoxColumn";
            movieIdDataGridViewTextBoxColumn.ReadOnly = true;
            movieIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Year";
            yearDataGridViewTextBoxColumn.MinimumWidth = 8;
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            yearDataGridViewTextBoxColumn.Width = 150;
            // 
            // moviesBindingSource
            // 
            moviesBindingSource.DataMember = "Movies";
            moviesBindingSource.DataSource = genreBindingSource;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(79, 324);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(386, 324);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(112, 34);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(691, 324);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1049, 324);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1682, 450);
            Controls.Add(button4);
            Controls.Add(buttonSave);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewMovies);
            Controls.Add(dataGridViewGenre);
            Name = "MainForm";
            Text = "Movies Catalog";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenre).EndInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)moviesBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn genreNameDataGridViewTextBoxColumn;
        private DataGridView dataGridViewGenre;
        private DataGridView dataGridViewMovies;
        private BindingSource genreBindingSource;
        private BindingSource moviesBindingSource;
        private DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn movieIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonSave;
        private Button button4;
    }
}
