using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Repositories;

namespace WindowsFormsApp1
{
    public partial class CategoryCardControl : UserControl
    {
        public event EventHandler CardClicked;
        public event EventHandler EditRequested;
        public event EventHandler DeleteRequested;
        public event EventHandler AddNoteRequested;
        public event EventHandler ViewNotesRequested;

        private int _categoryId;
        private ICategoryRepository categoryRepository;
        private Category category;

        public CategoryCardControl()
        {
            InitializeComponent();
            SetupEventHandlers();
        }

       

        public CategoryCardControl(ICategoryRepository categoryRepository, Category category)
        {
            InitializeComponent(); // Très important !
            SetupEventHandlers();  // Pour gérer les clics et menu
            this.categoryRepository = categoryRepository;
            this.category = category;

            // Initialisation visuelle
            _categoryId = category.Id;
            CategoryName = category.Name;
            lblDate.Text = $"Créé le {category.CreatedAt:dd/MM/yyyy à HH:mm}";
            panelMain.BackgroundColor = ColorTranslator.FromHtml(category.ColorHex); // si tu stockes une couleur hex
            SetCategoryIcon(null); // ou image spécifique si tu en as



        }

        private void SetupEventHandlers()
        {
            panelMain.Click += (s, e) => CardClicked?.Invoke(this, e);
            lblCategoryName.Click += (s, e) => CardClicked?.Invoke(this, e);
            lblDate.Click += (s, e) => CardClicked?.Invoke(this, e);
            picIcon.Click += (s, e) => CardClicked?.Invoke(this, e);
            btnMenu.Click += BtnMenu_Click;
        }

        public void InitializeCard(int categoryId, string categoryName, Color bgColor, DateTime createdAt, Image categoryImage = null)
        {
            _categoryId = categoryId;
            panelMain.BackgroundColor = bgColor;
            CategoryName = categoryName;
            lblDate.Text = $" {createdAt:dd/MM/yyyy à HH:mm}";
            SetCategoryIcon(categoryImage);
        }

        public int CategoryId => _categoryId;

        public string CategoryName
        {
            get => lblCategoryName.Text.Trim();
            set => lblCategoryName.Text = $"   {value}";
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            var contextMenu = new ContextMenuStrip();

            

            var addNoteItem = new ToolStripMenuItem("Ajouter une note");
            addNoteItem.Click += (s, args) => AddNoteRequested?.Invoke(this, EventArgs.Empty);

            
            var deleteItem = new ToolStripMenuItem("Supprimer");
            deleteItem.Click += (s, args) => ConfirmAndDelete();

            contextMenu.Items.Add(addNoteItem);
            contextMenu.Items.Add(new ToolStripSeparator());
            contextMenu.Items.Add(deleteItem);

            contextMenu.Show(btnMenu, new Point(0, btnMenu.Height));
        }

        private void ConfirmAndDelete()
        {
           
                DeleteRequested?.Invoke(this, EventArgs.Empty);
            
        }

        private void SetCategoryIcon(Image image)
        {
            if (image != null)
            {
                picIcon.Image = ResizeImage(image, 32, 32);
                picIcon.Visible = true;
            }
            else
            {
                picIcon.Image = null;
                picIcon.Visible = false;
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            var destImage = new Bitmap(width, height);
            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return destImage;
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {

        }
    }
}