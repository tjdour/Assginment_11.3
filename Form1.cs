using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Assginment_11._3.Models;

namespace Assginment_11._3
{
    public partial class MainForm : Form
    {
        private MoviesContext? dbContext;
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new MoviesContext();

            // Uncomment the line below to start fresh with a new database.
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Genres.Load();

            this.genreBindingSource.DataSource = dbContext.Genres.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void dataGridViewGenre_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var Genre = (Genre)this.dataGridViewGenre.CurrentRow.DataBoundItem;

                if (Genre != null)
                {
                    this.dbContext.Entry(Genre).Collection(e => e.Movies).Load();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewGenre.Refresh();
            this.dataGridViewMovies.Refresh();
        }
    }
}
