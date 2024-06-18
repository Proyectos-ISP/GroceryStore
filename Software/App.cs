namespace Software
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            MainMenu mainMenu = new MainMenu();
            mainMenu.TopLevel = false;
            infoPanel.Controls.Add(mainMenu);
            mainMenu.Show();
        }

        bool isListCreated = false;
        bool isHomeCreated = false;
        bool isAddProductCreated = false;

        private void btnList_Click(object sender, EventArgs e)
        {
            // Close any existing form in the panel
            CloseCurrentForm();

            if (!isListCreated)
            {
                btnHome.BackColor = Color.Empty;
                btnList.BackColor = Color.LightGray;

                ListProducts Frm = new ListProducts();
                Frm.TopLevel = false;
                infoPanel.Controls.Add(Frm);
                Frm.Show();

                isListCreated = true;
                isHomeCreated = false; // Reset MainMenu flag
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Close any existing form in the panel
            CloseCurrentForm();

            if (!isHomeCreated)
            {
                btnHome.BackColor = Color.LightGray;
                btnList.BackColor = Color.Empty;

                MainMenu Frm = new MainMenu();
                Frm.TopLevel = false;
                infoPanel.Controls.Add(Frm);
                Frm.Show();

                isHomeCreated = true;
                isListCreated = false; // Reset ListProducts flag
            }
        }

        public void CloseCurrentForm()
        {
            if (infoPanel.Controls.Count > 0)
            {
                // Get the currently displayed form
                Form? currentForm = infoPanel.Controls[0] as Form;
                if (currentForm != null)
                {
                    currentForm.Close(); // Close the form
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Close any existing form in the panel
            CloseCurrentForm();

            if (!isAddProductCreated)
            {
                btnHome.BackColor = Color.Empty;
                btnList.BackColor = Color.Empty;
                btnAddProduct.BackColor = Color.LightGray;

                addEdit Frm = new addEdit(null);
                Frm.TopLevel = false;
                infoPanel.Controls.Add(Frm);
                Frm.Show();

                isAddProductCreated = true;
                isListCreated = false; // Reset ListProducts flag
                isHomeCreated = false;
            }

        }
    }
}
