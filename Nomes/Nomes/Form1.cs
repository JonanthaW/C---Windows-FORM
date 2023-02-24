namespace Nomes {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txtName.Text) && !lstNames.Items.Contains(txtName.Text)) {
                lstNames.Items.Add(txtName.Text);
                txtName.Text = null; // Clear the text
            }
        }
    }
}