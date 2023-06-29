using System.Net;
using System.Security.Policy;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        class User
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }
            [JsonPropertyName("first_name")]
            public string FirstName { get; set; }
            [JsonPropertyName("last_name")]
            public string LastName { get; set; }
            [JsonPropertyName("email")]
            public string Email { get; set; }
            [JsonPropertyName("avatar")]
            public string Avatar { get; set; }
        }

        class UserPagination
        {
            [JsonPropertyName("page")]
            public int Page { get; set; }
            [JsonPropertyName("total")]
            public int Total { get; set; }
            [JsonPropertyName("per_page")]
            public int PerPage { get; set; }
            [JsonPropertyName("total_pages")]
            public int TotalPages { get; set; }
            [JsonPropertyName("data")]
            public List<User> Data { get; set; }
        }

        private string GetHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response. 
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server. 
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access. 
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. 
            string responseFromServer = reader.ReadToEnd();
            // Close the response. 
            response.Close();
            return responseFromServer;
        }
        private void displayData(UserPagination data)
        {
            int y = 10; // Vị trí ban đầu của control
            int labelWidth = 200;
            int labelHeight = 20;
            int avatarSize = 100;
            int spacing = 10; // Khoảng cách giữa các control
            foreach (var user in data.Data)
            {
                string email = user.Email;
                string firstName = user.FirstName;
                string lastName = user.LastName;
                string avatarUrl = user.Avatar;

                // Tạo vách ngăn
                Panel dividerPanel = new Panel();
                dividerPanel.BackColor = Color.Black;
                dividerPanel.Size = new Size(panel1.ClientSize.Width, 1);
                dividerPanel.Location = new Point(0, y);

                // Tạo control hiển thị thông tin người dùng
                Label nameLabel = new Label();
                nameLabel.Text = $"{firstName} {lastName}";
                nameLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
                nameLabel.Size = new Size(labelWidth, labelHeight);
                nameLabel.Location = new Point(spacing, y + spacing);

                Label emailLabel = new Label();
                emailLabel.Text = email;
                emailLabel.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
                emailLabel.Size = new Size(labelWidth, labelHeight);
                emailLabel.Location = new Point(spacing, y + spacing + labelHeight);

                PictureBox avatarPictureBox = new PictureBox();
                avatarPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                avatarPictureBox.Size = new Size(avatarSize, avatarSize);
                avatarPictureBox.Location = new Point(panel1.ClientSize.Width - avatarSize - spacing, y + spacing);


                // Tải ảnh đại diện từ URL
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(avatarUrl);
                    using (var stream = new MemoryStream(imageData))
                    {
                        // Hiển thị ảnh đại diện lên PictureBox
                        avatarPictureBox.Image = Image.FromStream(stream);
                    }
                }

                // Thêm control vào panel
                panel1.Controls.Add(dividerPanel);
                panel1.Controls.Add(nameLabel);
                panel1.Controls.Add(emailLabel);
                panel1.Controls.Add(avatarPictureBox);
                // Cập nhật vị trí cho các control tiếp theo
                y += avatarSize + 2 * spacing;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var url = "https://reqres.in/api/users?page=1";
            var res = GetHTML(url);

            var data = JsonSerializer.Deserialize<UserPagination>(res);
            displayData(data);
            
        }
    }
}